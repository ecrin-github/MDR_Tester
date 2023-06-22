using Dapper;
using Npgsql;

namespace MDR_Tester;

public class TestDataLayer
{
    private readonly ILoggingHelper _loggingHelper;
    private readonly Source _source;
    private readonly string _connString;
    
    public TestDataLayer(Source source, ILoggingHelper loggingHelper)
    {
        _loggingHelper = loggingHelper;
        _source = source;
        _connString = source.db_conn!;
    }

    public IEnumerable<string>? ObtainTestSIDs(string sourceType)
    {
        string sqlString = sourceType == "study" ? "Select sd_sid" : "Select sd_oid";
        sqlString += " from mn.source_data where for_testing = true;";
        using NpgsqlConnection conn = new(_connString);
        return conn.Query<string>(sqlString);
    }
    
    public bool LoadData(int source_id, string sd_sid)
    {
        // get data using source_id to identify source class,
        // sd_sid to identify specific data 

        TestData_Base tdb = source_id
            switch
            {
                100116 => new TestData_100116(),
                100118 => new TestData_100118(),
                100120 => new TestData_100120(),
                100123 => new TestData_100123(),
                100126 => new TestData_100126(),
                100124 => new TestData_100124(),
                100132 => new TestData_100132(),
                101900 => new TestData_101900(),
                101901 => new TestData_101901(),
                _ => null
            };
        
        switch (source_id)
        {
            case 100116:
            {
                tdb = new TestData_100116();
                break;
            }
        }

        case 100118: tdb = new TestData_100118();
            case 100120: tdb = new TestData_100120();
            case 100123: tdb = new TestData_100123();
            case 100126: tdb = new TestData_100126();
            case 100124: tdb = new TestData_100124();
            case 100132: tdb = new TestData_100132();
            case 101900: tdb = new TestData_101900();
            case 101901: tdb = new TestData_101901();
        }
            
        
        // load the study data into the database
        FullStudy fs = new (sd_sid);
        
        if (fs is null)
        {
            return false;
        }
        
        Study s = fs.study!;
        
        string sqlString = $@"Insert into te.studies (sd_sid, display_title, title_lang_code
                            , brief_description, data_sharing_statement, study_start_year
                            , study_start_month, study_type_id, study_status_id, study_enrolment
                            , study_gender_elig_id, min_age, min_age_units_id, max_age
                            , max_age_units_id, iec_level)
                            values ({s.sd_sid}, {s.display_title}, {s.title_lang_code}
                            , {s.brief_description}, {s.data_sharing_statement}, {s.study_start_year}
                            , {s.study_start_month}, {s.study_type_id}, {s.study_status_id}
                            , {s.study_enrolment}, {s.study_gender_elig_id}, {s.min_age}
                            , {s.min_age_units_id}, {s.max_age}, {s.max_age_units_id}, {s.iec_level})";
        
        return true;
    }
    
    
    
    
}