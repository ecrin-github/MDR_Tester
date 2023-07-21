namespace MDR_Tester;

public class TestObjectReporter
{
    private readonly ILoggingHelper _loggingHelper;
    private readonly TestReportHelper _repHelper;

    public TestObjectReporter(Source source, ILoggingHelper loggingHelper)
    {
        _loggingHelper = loggingHelper;        
        _repHelper = new TestReportHelper(source, loggingHelper);
    }
    
    public void compare_table_data_objects(string sd_id, int fb_level)
    {
        //_loggingHelper.LogTableHeader("Data Objects");
        TableResults tr = new TableResults("Data Objects", "data_objects", fb_level);
        string where_clause = $" where sd_oid ='{sd_id}'";
        tr = _repHelper.CompareField(tr, "sd_sid", "string", where_clause);
        tr = _repHelper.CompareField(tr, "title", "string", where_clause, true);
        tr = _repHelper.CompareField(tr, "version", "string", where_clause);
        tr = _repHelper.CompareField(tr, "display_title", "string", where_clause, true);
        tr = _repHelper.CompareField(tr, "doi", "string", where_clause);
        tr = _repHelper.CompareField(tr, "doi_status_id", "int", where_clause);
        tr = _repHelper.CompareField(tr, "publication_year", "int", where_clause);
        tr = _repHelper.CompareField(tr, "object_class_id", "int", where_clause);
        tr = _repHelper.CompareField(tr, "object_type_id", "int", where_clause);
        tr = _repHelper.CompareField(tr, "managing_org_id", "int", where_clause);
        tr = _repHelper.CompareField(tr, "managing_org", "string", where_clause);
        tr = _repHelper.CompareField(tr, "lang_code", "string", where_clause);
        tr = _repHelper.CompareField(tr, "access_type_id", "int", where_clause);
        tr = _repHelper.CompareField(tr, "access_details", "string", where_clause, true);
        tr = _repHelper.CompareField(tr, "access_details_url", "string", where_clause);
        tr = _repHelper.CompareField(tr, "eosc_category", "int", where_clause); 
        tr = _repHelper.CompareField(tr, "add_study_contribs", "bool", where_clause);
        tr = _repHelper.CompareField(tr, "add_study_topics", "bool", where_clause);
        _repHelper.write_results(tr);
    }
    
    public void compare_table_object_instances(string sd_id, int fb_level)
    {
        TableResults tr = new TableResults("Object Instances", "object_instances", fb_level);
        //_loggingHelper.LogTableHeader("object instances");
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_oid ='{sd_id}'");
        //_loggingHelper.LogLine(s.res_string);
        
        _repHelper.write_results(tr);
    }
    
    public void compare_table_object_titles(string sd_id, int fb_level)
    {
        TableResults tr = new TableResults("Object Titles", "object_titles", fb_level);
        //_loggingHelper.LogTableHeader("object titles");
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_oid ='{sd_id}'");
        //_loggingHelper.LogLine(s.res_string);
        
        _repHelper.write_results(tr);
    }
    
    
    public void compare_table_object_datasets(string sd_id, int fb_level)
    {
        TableResults tr = new TableResults("Object Datasets", "object_datasets", fb_level);
        //_loggingHelper.LogTableHeader("object datasets");
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_oid ='{sd_id}'");
        if (tr.data_present)
        { 

        }
        _repHelper.write_results(tr);
    }

    public void compare_table_object_dates(string sd_id, int fb_level)
    {
        TableResults tr = new TableResults("Object Dates", "object_dates", fb_level);
        //_loggingHelper.LogTableHeader("object dates");
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_oid ='{sd_id}'");
        if (tr.data_present)
        {

        }
        _repHelper.write_results(tr);
    }
    
    public void compare_table_object_relationships(string sd_id, int fb_level)
    {
        TableResults tr = new TableResults("Object Relationships", "object_relationships", fb_level);
        //_loggingHelper.LogTableHeader("object relationships");
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_oid ='{sd_id}'");
        if (tr.data_present)
        {

        }
        _repHelper.write_results(tr);
    }

    public void compare_table_object_rights(string sd_id, int fb_level)
    {
        TableResults tr = new TableResults("Object Rights", "object_rights", fb_level);
        //_loggingHelper.LogTableHeader("object rights");
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_oid ='{sd_id}'");
        if (tr.data_present)
        {

        }
        _repHelper.write_results(tr);
    }
    
    public void compare_table_object_people(string sd_id, int fb_level)
    {
        TableResults tr = new TableResults("Object People", "object_people", fb_level);
        //_loggingHelper.LogTableHeader("object people");
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_oid ='{sd_id}'");
        if (tr.data_present)
        {

        }
        _repHelper.write_results(tr);
    }

    public void compare_table_object_organisations(string sd_id, int fb_level)
    {
        TableResults tr = new TableResults("Object Organisations", "object_organisations", fb_level);
        //_loggingHelper.LogTableHeader("object organisations");
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_oid ='{sd_id}'");
        if (tr.data_present)
        {

        }
        _repHelper.write_results(tr);
    }
    
    public void compare_table_object_topics(string sd_id, int fb_level)
    {
        TableResults tr = new TableResults("Object Topics", "object_topics", fb_level);
        //_loggingHelper.LogTableHeader("object topics");
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_oid ='{sd_id}'");
        if (tr.data_present)
        {

        }
        _repHelper.write_results(tr);
    }

    public void compare_table_object_comments(string sd_id, int fb_level)
    {
        TableResults tr = new TableResults("Object Comments", "object_comments", fb_level);
        //_loggingHelper.LogTableHeader("object comments");
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_oid ='{sd_id}'");
        if (tr.data_present)
        {

        }
        _repHelper.write_results(tr);
    }
    
    public void compare_table_object_descriptions(string sd_id, int fb_level)
    {
        TableResults tr = new TableResults("Object Descriptions", "object_descriptions", fb_level);
        //_loggingHelper.LogTableHeader("object descriptions");
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_oid ='{sd_id}'");
        if (tr.data_present)
        {

        }
        _repHelper.write_results(tr);
    }

    public void compare_table_object_identifiers(string sd_id, int fb_level)
    {
        TableResults tr = new TableResults("Object Identifiers", "object_identifiers", fb_level);
        //_loggingHelper.LogTableHeader("object identifiers");
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_oid ='{sd_id}'");
        if (tr.data_present)
        {
            
        }
        _repHelper.write_results(tr);
    }
    
    public void compare_table_object_db_links(string sd_id, int fb_level)
    {
        TableResults tr = new TableResults("Object DB Links", "object_db_links", fb_level);
        //_loggingHelper.LogTableHeader("object links");
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_oid ='{sd_id}'");
        if (tr.data_present)
        {
            
        }
        _repHelper.write_results(tr);
    }

    public void compare_table_object_publication_types(string sd_id, int fb_level)
    {
        TableResults tr = new TableResults("Object Publication Types", "object_publication_types", fb_level);
        //_loggingHelper.LogTableHeader("object publication types");
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_oid ='{sd_id}'");
        if (tr.data_present)
        {

        }
        _repHelper.write_results(tr);
    }

    public void compare_table_journal_details(string sd_id, int fb_level)
    {
        TableResults tr = new TableResults("Journal Details", "journal_details", fb_level);
        //_loggingHelper.LogTableHeader("object journal details");
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_oid ='{sd_id}'");
        if (tr.data_present)
        {

        }
        _repHelper.write_results(tr);
    }
    
}