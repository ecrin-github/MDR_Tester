namespace MDR_Tester;

public class Tester
{
    private readonly ILoggingHelper _loggingHelper;
    private readonly IMonDataLayer _monDataLayer;

    public Tester(IMonDataLayer monDataLayer, ILoggingHelper loggingHelper)
    {
        _monDataLayer = monDataLayer;
        _loggingHelper = loggingHelper;
    }
    
    public void Run(Options opts)
    {
        try
        {
            // Simply test the selected study data for each listed source.

            foreach (int sourceId in opts.SourceIds!)
            {
                // Obtain source details, augment with connection string for this database
                // Open up the logging file for this source and then call the main 
                // test routine. After initial checks source is guaranteed to be non-null.
                    
                Source source = _monDataLayer.FetchSourceParameters(sourceId)!;
                string dbName = source.database_name!;
                source.db_conn = _monDataLayer.GetConnectionString(dbName) ;
                
                _loggingHelper.OpenLogFile(source.database_name!);
                _loggingHelper.LogHeader("STARTING TEST");
                _loggingHelper.LogCommandLineParameters(opts);
                _loggingHelper.LogStudyHeader(opts, "For source: " + source.id + ": " + dbName);
                
                int FbLevel = (int)opts.FeedbackLevel!;  // default ensures an integer
                RunTest(source, FbLevel);
                
                _loggingHelper.CloseLog();
            }
        }

        catch (Exception e)
        {
            _loggingHelper.LogHeader("UNHANDLED EXCEPTION");
            _loggingHelper.LogCodeError("Importer application aborted", e.Message, e.StackTrace);
            _loggingHelper.CloseLog();
        }
    }

    private void RunTest(Source source, int FbLevel)
    {
        // Recreate the TE (test expected) tables.
        // Then obtain a list of the studies or objects marked as for testing
        // If there are any, go through them and load the corresponding data set
        // If there is no corresponding data log that fact
        
        _loggingHelper.LogLine("Setup Test Expected (TE) Tables");
        ExpectedBuilder eb = new ExpectedBuilder(source, _loggingHelper);
        eb.BuildExpectedTables();
        
        TestDataLayer testdl = new TestDataLayer(source, _loggingHelper);
        List<string>? test_sids = testdl.ObtainTestSIDs(source.source_type!)?.ToList();
        if (test_sids is not null)
        {
            bool data_loaded = false;
            _loggingHelper.LogHeader("Loading data");
            foreach (string s in test_sids)
            {
                data_loaded = testdl.LoadData(source.source_type!, source.id, s, FbLevel);
                if (!data_loaded)
                {
                    _loggingHelper.LogLine($"!!! No source data found for {s} !!!");
                }

                if (FbLevel < 2)
                {
                    _loggingHelper.LogLine("");
                }
            } 

            // Then compare loaded 'expected' data with the actual data in the ad tables.
            
            if (data_loaded)
            {
                TestReportBuilder repBuilder = new TestReportBuilder(source, _loggingHelper, FbLevel);
                _loggingHelper.LogHeader("Comparing data");
                foreach (string s in test_sids)
                {
                    repBuilder.CompareData(s);
                }
            }
        }
    } 
}

