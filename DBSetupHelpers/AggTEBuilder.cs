namespace MDR_Tester;

class AggExpectedBuilder
{
    private readonly ILoggingHelper _loggingHelper;
    private readonly AggStudyTableBuilders _studyBuilder;
    private readonly AggObjectTableBuilders _objectBuilder;

    public AggExpectedBuilder(IMonDataLayer monDataLayer, ILoggingHelper loggingHelper)
    {
        _loggingHelper = loggingHelper;        
        string mdr_conn = monDataLayer.GetConnectionString("mdr");
        string iec_conn = monDataLayer.GetConnectionString("iec");
        _studyBuilder = new AggStudyTableBuilders(mdr_conn, iec_conn);
        _objectBuilder = new AggObjectTableBuilders(mdr_conn);
    }

    public void BuildExpectedTables()
    {
        _studyBuilder.EnsureTEschemas();
        
        _studyBuilder.create_table_studies();
        _studyBuilder.create_table_study_identifiers();
        _studyBuilder.create_table_study_titles();
        _studyBuilder.create_table_study_topics();
        _studyBuilder.create_table_study_conditions();
        _studyBuilder.create_table_study_features();
        _studyBuilder.create_table_study_people();
        _studyBuilder.create_table_study_organisations();
        _studyBuilder.create_table_study_references();
        _studyBuilder.create_table_study_relationships();
        _studyBuilder.create_table_study_countries();
        _studyBuilder.create_table_study_locations();
        
        _studyBuilder.create_table_study_iec_by_years();
        
        _loggingHelper.LogLine("Rebuilt Expected study tables");

        // object tables 

        _objectBuilder.create_table_data_objects();
        _objectBuilder.create_table_object_instances();
        _objectBuilder.create_table_object_titles();
        
        _objectBuilder.create_table_object_datasets();
        _objectBuilder.create_table_object_dates();
        _objectBuilder.create_table_object_relationships();
        _objectBuilder.create_table_object_rights();
        _objectBuilder.create_table_object_people();
        _objectBuilder.create_table_object_organisations();
        _objectBuilder.create_table_object_topics();
        _objectBuilder.create_table_object_descriptions();
        _objectBuilder.create_table_object_identifiers();

        _loggingHelper.LogLine("Rebuilt Expected object tables");
    }
}