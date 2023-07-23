namespace MDR_Tester;

public class TestReportBuilder
{
    private readonly Source _source;
    private readonly ILoggingHelper _loggingHelper;
    private readonly TestStudyReporter _studyReporter;
    private readonly TestObjectReporter _objectReporter;
    private readonly int _fbLevel;

    
    public TestReportBuilder(Source source, ILoggingHelper loggingHelper, int fbLevel)
    {
        _source = source;
        _loggingHelper = loggingHelper;
        _fbLevel = fbLevel;
        _studyReporter = new TestStudyReporter(source, loggingHelper, fbLevel);
        _objectReporter = new TestObjectReporter(source, loggingHelper, fbLevel);
    }

    
    public void CompareData(string sd_id)   
    {
        if (_source.has_study_tables is true)
        {
            _loggingHelper.LogSDIDHeader("Study", sd_id, _fbLevel);
            int total_issues = 0;
            
            // these common to all study databases

            total_issues += _studyReporter.compare_table_studies(sd_id);
            total_issues += _studyReporter.compare_table_study_identifiers(sd_id);
            total_issues += _studyReporter.compare_table_study_titles(sd_id);

            // these are database dependent
            if (_source.has_study_topics is true) total_issues += _studyReporter.compare_table_study_topics(sd_id);
            if (_source.has_study_conditions is true) total_issues += _studyReporter.compare_table_study_conditions(sd_id);
            if (_source.has_study_features is true) total_issues += _studyReporter.compare_table_study_features(sd_id);
            if (_source.has_study_people is true) total_issues += _studyReporter.compare_table_study_people(sd_id);
            if (_source.has_study_organisations is true) total_issues += _studyReporter.compare_table_study_organisations(sd_id);
            if (_source.has_study_references is true) total_issues += _studyReporter.compare_table_study_references(sd_id);
            if (_source.has_study_relationships is true) total_issues += _studyReporter.compare_table_study_relationships(sd_id);
            if (_source.has_study_links is true) total_issues += _studyReporter.compare_table_study_links(sd_id);
            if (_source.has_study_countries is true) total_issues += _studyReporter.compare_table_study_countries(sd_id);
            if (_source.has_study_locations is true) total_issues += _studyReporter.compare_table_study_locations(sd_id);
            if (_source.has_study_ipd_available is true) total_issues += _studyReporter.compare_table_ipd_available(sd_id);
            if (_source.has_study_iec is true)
            {
                if (_source.study_iec_storage_type == "Single Table")
                {
                    total_issues += _studyReporter.compare_table_study_iec(sd_id);
                }
                if (_source.study_iec_storage_type == "By Year Groupings")
                {
                    total_issues += _studyReporter.compare_table_study_iec_by_year_groups(sd_id);
                }
                if (_source.study_iec_storage_type == "By Years")
                {
                    total_issues += _studyReporter.compare_table_study_iec_by_years(sd_id);
                }
            }
            
            // object tables 
            
            total_issues += _studyReporter.compare_table_study_data_objects(sd_id);
            List<string>? oids = _studyReporter.FetchObjectOIDs(sd_id);
            if (oids?.Any() == true)
            {
                foreach (string oid in oids)
                {
                    _loggingHelper.LogSDIDHeader("Study data object", oid, _fbLevel);
                    total_issues += _objectReporter.compare_table_data_objects(oid);
                    total_issues += _objectReporter.compare_table_object_instances(oid);
                    total_issues += _objectReporter.compare_table_object_titles(oid);
                    if (_source.has_object_datasets is true) total_issues += _objectReporter.compare_table_object_datasets(oid);
                    if (_source.has_object_dates is true) total_issues += _objectReporter.compare_table_object_dates(oid);
                }
            }
            
            // finally
            
            _loggingHelper.LogBlank();
            _loggingHelper.LogLine($"Expected and Actual data compared for study {sd_id}");
            string add_s = total_issues != 1 ? "s" : "";
            _loggingHelper.LogLine($"{total_issues} issue{add_s} found in total");
            _loggingHelper.LogBlank();
        }
        else 
        {
            // PubMed only at the moment
            
            _loggingHelper.LogSDIDHeader("Data object", sd_id, _fbLevel);
            int total_issues = 0;

            total_issues += _objectReporter.compare_table_data_objects(sd_id);
            total_issues += _objectReporter.compare_table_object_instances(sd_id);
            total_issues += _objectReporter.compare_table_object_titles(sd_id);

            // these are database dependent		

            if (_source.has_object_datasets is true) total_issues += _objectReporter.compare_table_object_datasets(sd_id);
            if (_source.has_object_dates is true) total_issues += _objectReporter.compare_table_object_dates(sd_id);
            if (_source.has_object_relationships is true) total_issues += _objectReporter.compare_table_object_relationships(sd_id);
            if (_source.has_object_rights is true) total_issues += _objectReporter.compare_table_object_rights(sd_id);
            if (_source.has_object_pubmed_set is true)
            {
                total_issues += _objectReporter.compare_table_object_people(sd_id);
                total_issues += _objectReporter.compare_table_object_organisations(sd_id);
                total_issues += _objectReporter.compare_table_object_topics(sd_id);
                total_issues += _objectReporter.compare_table_object_comments(sd_id);
                total_issues += _objectReporter.compare_table_object_descriptions(sd_id);
                total_issues += _objectReporter.compare_table_object_identifiers(sd_id);
                total_issues += _objectReporter.compare_table_object_db_links(sd_id);
                total_issues += _objectReporter.compare_table_object_publication_types(sd_id);
                total_issues += _objectReporter.compare_table_journal_details(sd_id);
            }
            
            // finally
            
            _loggingHelper.LogBlank();
            _loggingHelper.LogLine($"Expected and Actual data compared for data object {sd_id}");
            string add_s = total_issues != 1 ? "s" : "";
            _loggingHelper.LogLine($"{total_issues} issue{add_s} found in total");
            _loggingHelper.LogBlank();
        }
    }
}