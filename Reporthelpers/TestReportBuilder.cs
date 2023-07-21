namespace MDR_Tester;

public class TestReportBuilder
{
    private readonly Source _source;
    private readonly ILoggingHelper _loggingHelper;
    private readonly TestStudyReporter _studyReporter;
    private readonly TestObjectReporter _objectReporter;

    
    public TestReportBuilder(Source source, ILoggingHelper loggingHelper)
    {
        _source = source;
        _loggingHelper = loggingHelper;        
        
        _studyReporter = new TestStudyReporter(source, loggingHelper);
        _objectReporter = new TestObjectReporter(source, loggingHelper);
    }

    
    public void CompareData(string sd_id, int ff)    // ff = feedback level
    {
        
        _loggingHelper.LogSDIDHeader(sd_id);
        if (_source.has_study_tables is true)
        {
            // these common to all study databases

            _studyReporter.compare_table_studies(sd_id, ff);
            _studyReporter.compare_table_study_identifiers(sd_id, ff);
            _studyReporter.compare_table_study_titles(sd_id, ff);

            // these are database dependent
            if (_source.has_study_topics is true) _studyReporter.compare_table_study_topics(sd_id, ff);
            if (_source.has_study_conditions is true) _studyReporter.compare_table_study_conditions(sd_id, ff);
            if (_source.has_study_features is true) _studyReporter.compare_table_study_features(sd_id, ff);
            if (_source.has_study_people is true) _studyReporter.compare_table_study_people(sd_id, ff);
            if (_source.has_study_organisations is true) _studyReporter.compare_table_study_organisations(sd_id, ff);
            if (_source.has_study_references is true) _studyReporter.compare_table_study_references(sd_id, ff);
            if (_source.has_study_relationships is true) _studyReporter.compare_table_study_relationships(sd_id, ff);
            if (_source.has_study_links is true) _studyReporter.compare_table_study_links(sd_id, ff);
            if (_source.has_study_countries is true) _studyReporter.compare_table_study_countries(sd_id, ff);
            if (_source.has_study_locations is true) _studyReporter.compare_table_study_locations(sd_id, ff);
            if (_source.has_study_ipd_available is true) _studyReporter.compare_table_ipd_available(sd_id, ff);
            if (_source.has_study_iec is true)
            {
                if (_source.study_iec_storage_type == "Single Table")
                {
                    _studyReporter.compare_table_study_iec(sd_id, ff);
                }
                if (_source.study_iec_storage_type == "By Year Groupings")
                {
                    _studyReporter.compare_table_study_iec_by_year_groups(sd_id, ff);
                }
                if (_source.study_iec_storage_type == "By Years")
                {
                    _studyReporter.compare_table_study_iec_by_years(sd_id, ff);
                }
            }
            
            // object tables 
            
            _studyReporter.compare_table_study_data_objects(sd_id, ff);
            List<string>? oids = _studyReporter.FetchObjectOIDs(sd_id);
            if (oids?.Any() == true)
            {
                foreach (string oid in oids)
                {
                    _loggingHelper.LogSDIDHeader(oid);
                    _objectReporter.compare_table_data_objects(oid, ff);
                    _objectReporter.compare_table_object_instances(oid, ff);
                    _objectReporter.compare_table_object_titles(oid, ff);
                    if (_source.has_object_datasets is true) _objectReporter.compare_table_object_datasets(oid, ff);
                    if (_source.has_object_dates is true) _objectReporter.compare_table_object_dates(oid, ff);
                }
            }
        }
        else 
        {
            // PubMed only at the moment

            _objectReporter.compare_table_data_objects(sd_id, ff);
            _objectReporter.compare_table_object_instances(sd_id, ff);
            _objectReporter.compare_table_object_titles(sd_id, ff);

            // these are database dependent		

            if (_source.has_object_datasets is true) _objectReporter.compare_table_object_datasets(sd_id, ff);
            if (_source.has_object_dates is true) _objectReporter.compare_table_object_dates(sd_id, ff);
            if (_source.has_object_relationships is true) _objectReporter.compare_table_object_relationships(sd_id, ff);
            if (_source.has_object_rights is true) _objectReporter.compare_table_object_rights(sd_id, ff);
            if (_source.has_object_pubmed_set is true)
            {
                _objectReporter.compare_table_object_people(sd_id, ff);
                _objectReporter.compare_table_object_organisations(sd_id, ff);
                _objectReporter.compare_table_object_topics(sd_id, ff);
                _objectReporter.compare_table_object_comments(sd_id, ff);
                _objectReporter.compare_table_object_descriptions(sd_id, ff);
                _objectReporter.compare_table_object_identifiers(sd_id, ff);
                _objectReporter.compare_table_object_db_links(sd_id, ff);
                _objectReporter.compare_table_object_publication_types(sd_id, ff);
                _objectReporter.compare_table_journal_details(sd_id, ff);
            }
        }
    }
}