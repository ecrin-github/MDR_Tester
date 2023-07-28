namespace MDR_Tester;

public class TestObjectReporter
{
    private readonly TestReportHelper _repHelper;

    public TestObjectReporter(Source source, ILoggingHelper loggingHelper, int fbLevel)
    {
        _repHelper = new TestReportHelper(source, loggingHelper, fbLevel);
    }
    
    public int compare_table_data_objects(string sd_id)
    {
        //_loggingHelper.LogTableHeader("Data Objects");
        TableResults tr = new TableResults("Data Object details", "data_objects", "object", false)
        {
            data_present = true, num_exp_recs = -1, num_act_recs = -1
        };
        RecordResults rr = new RecordResults(tr, sd_id, "string");
        rr = _repHelper.CompareField(rr, "sd_sid", "string");
        rr = _repHelper.CompareField(rr, "title", "string", true);
        rr = _repHelper.CompareField(rr, "version", "string");
        rr = _repHelper.CompareField(rr, "display_title", "string", true);
        rr = _repHelper.CompareField(rr, "doi", "string");
        rr = _repHelper.CompareField(rr, "doi_status_id", "int");
        rr = _repHelper.CompareField(rr, "publication_year", "int");
        rr = _repHelper.CompareField(rr, "object_class_id", "int");
        rr = _repHelper.CompareField(rr, "object_type_id", "int");
        rr = _repHelper.CompareField(rr, "managing_org_id", "int");
        rr = _repHelper.CompareField(rr, "managing_org", "string");
        rr = _repHelper.CompareField(rr, "lang_code", "string");
        rr = _repHelper.CompareField(rr, "access_type_id", "int");
        rr = _repHelper.CompareField(rr, "access_details", "string", true);
        rr = _repHelper.CompareField(rr, "access_details_url", "string");
        rr = _repHelper.CompareField(rr, "eosc_category", "int"); 
        rr = _repHelper.CompareField(rr, "add_study_contribs", "bool");
        rr = _repHelper.CompareField(rr, "add_study_topics", "bool");
        tr.record_results.Add(rr);
        tr.num_issues += rr.num_issues;
        _repHelper.write_results(tr);
        return tr.num_issues;
    }
    
    public int compare_table_object_instances(string sd_id)
    {
        TableResults tr = new TableResults("Object Instances", "object_instances", "object", false);
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_oid ='{sd_id}'");
        List<string>? instance_values = _repHelper.FetchObjectInstanceValues(sd_id);
        if (instance_values?.Any() == true)
        {
            foreach (string id_value in instance_values)
            {
                RecordResults rr = new RecordResults(tr, sd_id, "Instance", "url", "string", id_value);
                rr = _repHelper.CompareField(rr, "system_id", "int");
                rr = _repHelper.CompareField(rr, "system", "string");
                rr = _repHelper.CompareField(rr, "url_accessible", "bool");
                rr = _repHelper.CompareField(rr, "resource_type_id", "int");
                rr = _repHelper.CompareField(rr, "resource_size", "string");
                rr = _repHelper.CompareField(rr, "resource_size_units", "string");
                rr = _repHelper.CompareField(rr, "resource_comments", "string");
                tr.record_results.Add(rr);
                tr.num_issues += rr.num_issues;
            }
        }
        _repHelper.write_results(tr);
        return tr.num_issues;
    }
    
    public int compare_table_object_titles(string sd_id)
    {
        TableResults tr = new TableResults("Object Titles", "object_titles", "object", false);
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_oid ='{sd_id}'");
        List<string>? title_values = _repHelper.FetchObjectTitleValues(sd_id);
        if (title_values?.Any() == true)
        {
            foreach (string id_value in title_values)
            {
                RecordResults rr = new RecordResults(tr, sd_id, "Title", "title_text", "string", id_value);
                rr = _repHelper.CompareField(rr, "title_type_id", "int");
                rr = _repHelper.CompareField(rr, "lang_code", "string");
                rr = _repHelper.CompareField(rr, "lang_usage_id", "int");
                rr = _repHelper.CompareField(rr, "is_default", "bool");
                rr = _repHelper.CompareField(rr, "comments", "string");
                tr.record_results.Add(rr);
                tr.num_issues += rr.num_issues;
            }
        }
        _repHelper.write_results(tr);
        return tr.num_issues;
    }
    
    
    public int compare_table_object_datasets(string sd_id)
    {
        TableResults tr = new TableResults("Object Datasets", "object_datasets", "object", false);
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_oid ='{sd_id}'");
        if (tr.data_present)
        { 
            // only one possible dataset record per object 

            RecordResults rr = new RecordResults(tr, sd_id, "string");
            rr = _repHelper.CompareField(rr, "record_keys_type_id", "int");
            rr = _repHelper.CompareField(rr, "record_keys_details", "string");
            rr = _repHelper.CompareField(rr, "deident_type_id", "int");    
            rr = _repHelper.CompareField(rr, "deident_direct", "bool");    
            rr = _repHelper.CompareField(rr, "deident_hipaa", "bool");   
            rr = _repHelper.CompareField(rr, "deident_dates", "bool");   
            rr = _repHelper.CompareField(rr, "deident_nonarr", "bool");   
            rr = _repHelper.CompareField(rr, "deident_kanon", "bool");   
            rr = _repHelper.CompareField(rr, "deident_details", "string");            
            rr = _repHelper.CompareField(rr, "consent_type_id", "int");   
            rr = _repHelper.CompareField(rr, "consent_noncommercial", "bool");    
            rr = _repHelper.CompareField(rr, "consent_geog_restrict", "bool");   
            rr = _repHelper.CompareField(rr, "consent_research_type", "bool");   
            rr = _repHelper.CompareField(rr, "consent_genetic_only", "bool");   
            rr = _repHelper.CompareField(rr, "consent_no_methods", "bool");   
            rr = _repHelper.CompareField(rr, "consent_details", "string");

            tr.record_results.Add(rr);
            tr.num_issues += rr.num_issues;
        }
        _repHelper.write_results(tr);
        return tr.num_issues;
    }

    public int compare_table_object_dates(string sd_id)
    {
        TableResults tr = new TableResults("Object Dates", "object_dates", "object", false);
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_oid ='{sd_id}'");
        if (tr.data_present)
        {
            List<ObjectDateDets>? date_values = _repHelper.FetchObjectDateValues(sd_id);
            if (date_values?.Any() == true)
            {
                foreach (ObjectDateDets date_dets in date_values)
                {
                    RecordResults rr = new RecordResults(tr, sd_id, "Date", "date_as_string", "string",
                        date_dets.date_as_string, "date_type_id", "int", date_dets.date_type_id);
                    rr = _repHelper.CompareField(rr, "date_is_range", "bool");
                    rr = _repHelper.CompareField(rr, "start_year", "int");
                    rr = _repHelper.CompareField(rr, "start_month", "int");
                    rr = _repHelper.CompareField(rr, "start_day", "int");
                    rr = _repHelper.CompareField(rr, "end_year", "int");
                    rr = _repHelper.CompareField(rr, "end_month", "int");
                    rr = _repHelper.CompareField(rr, "end_day", "int");
                    rr = _repHelper.CompareField(rr, "details", "string");
                    tr.record_results.Add(rr);
                    tr.num_issues += rr.num_issues;

                }
            }
        }
        _repHelper.write_results(tr);
        return tr.num_issues;
    }
    
    
    public int compare_table_object_people(string sd_id)
    {
        TableResults tr = new TableResults("Object People", "object_people", "object", false);
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_oid ='{sd_id}'");
        if (tr.data_present)
        {
            List<string>? people_values = _repHelper.FetchObjectPeopleValues(sd_id);
            if (people_values?.Any() == true)
            {
                foreach (string id_value in people_values)
                {
                    RecordResults rr = new RecordResults(tr, sd_id, "Person", "person_full_name", "string", id_value);
                    rr = _repHelper.CompareField(rr, "contrib_type_id", "int");
                    rr = _repHelper.CompareField(rr, "person_given_name", "string");
                    rr = _repHelper.CompareField(rr, "person_family_name", "string");
                    rr = _repHelper.CompareField(rr, "orcid_id", "string");
                    rr = _repHelper.CompareField(rr, "person_affiliation", "string");
                    rr = _repHelper.CompareField(rr, "organisation_id", "int");
                    rr = _repHelper.CompareField(rr, "organisation_name", "string");
                    rr = _repHelper.CompareField(rr, "organisation_ror_id", "string");
                    tr.record_results.Add(rr);
                    tr.num_issues += rr.num_issues;
                }
            }
        }
        _repHelper.write_results(tr);
        return tr.num_issues;
    }

    public int compare_table_object_organisations(string sd_id)
    {
        TableResults tr = new TableResults("Object Organisations", "object_organisations", "object", false);
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_oid ='{sd_id}'");
        if (tr.data_present)
        {
            List<string>? org_values = _repHelper.FetchObjectOrgValues(sd_id);
            if (org_values?.Any() == true)
            {
                foreach (string id_value in org_values)
                {
                    RecordResults rr = new RecordResults(tr, sd_id, "Organisation", "organisation_name", "string", id_value);
                    rr = _repHelper.CompareField(rr, "contrib_type_id", "int");
                    rr = _repHelper.CompareField(rr, "organisation_id", "int");
                    rr = _repHelper.CompareField(rr, "organisation_ror_id", "string");
                    tr.record_results.Add(rr);
                    tr.num_issues += rr.num_issues;
                }
            }
        }
        _repHelper.write_results(tr);
        return tr.num_issues;
    }
    
    public int compare_table_object_topics(string sd_id)
    {
        TableResults tr = new TableResults("Object Topics", "object_topics", "object", false);
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_oid ='{sd_id}'");
        if (tr.data_present)
        {
            List<string>? topic_values = _repHelper.FetchObjectTopicValues(sd_id);
            if (topic_values?.Any() == true)
            {
                foreach (string id_value in topic_values)
                {
                    RecordResults rr = new RecordResults(tr, sd_id, "Topic", "original_value", "string", id_value);
                    rr = _repHelper.CompareField(rr, "topic_type_id", "int");
                    rr = _repHelper.CompareField(rr, "original_ct_type_id", "int");
                    rr = _repHelper.CompareField(rr, "original_ct_code", "string");
                    rr = _repHelper.CompareField(rr, "mesh_code", "string");
                    rr = _repHelper.CompareField(rr, "mesh_value", "string");
                    tr.record_results.Add(rr);
                    tr.num_issues += rr.num_issues;
                }
            }
        }
        _repHelper.write_results(tr);
        return tr.num_issues;
    }

    public int compare_table_object_comments(string sd_id)
    {
        TableResults tr = new TableResults("Object Comments", "object_comments", "object", false);
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_oid ='{sd_id}'");
        if (tr.data_present)
        {
            List<string>? comments_values = _repHelper.FetchObjectCommentsValues(sd_id);
            if (comments_values?.Any() == true)
            {
                foreach (string id_value in comments_values)
                {
                    RecordResults rr = new RecordResults(tr, sd_id, "Comments", "pmid", "string", id_value);
                    rr = _repHelper.CompareField(rr, "ref_type", "string");
                    rr = _repHelper.CompareField(rr, "ref_source", "string");
                    rr = _repHelper.CompareField(rr, "pmid_version", "string");
                    rr = _repHelper.CompareField(rr, "notes", "string");
                    tr.record_results.Add(rr);
                    tr.num_issues += rr.num_issues;
                }
            }
        }
        _repHelper.write_results(tr);
        return tr.num_issues;
    }
    
    public int compare_table_object_descriptions(string sd_id)
    {
        TableResults tr = new TableResults("Object Descriptions", "object_descriptions", "object", false);
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_oid ='{sd_id}'");
        if (tr.data_present)
        {
            List<string>? description_values = _repHelper.FetchObjectDescriptionsValues(sd_id);
            if (description_values?.Any() == true)
            {
                foreach (string id_value in description_values)
                {
                    RecordResults rr = new RecordResults(tr, sd_id, "Description", "description_text", "string", id_value);
                    rr = _repHelper.CompareField(rr, "description_type_id", "int");
                    rr = _repHelper.CompareField(rr, "label", "int");
                    rr = _repHelper.CompareField(rr, "lang_code", "string");
                    tr.record_results.Add(rr);
                    tr.num_issues += rr.num_issues;
                }
            }
        }
        _repHelper.write_results(tr);
        return tr.num_issues;
    }

    public int compare_table_object_identifiers(string sd_id)
    {
        TableResults tr = new TableResults("Object Identifiers", "object_identifiers", "object", false);
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_oid ='{sd_id}'");
        if (tr.data_present)
        {
            List<string>? id_values = _repHelper.FetchObjectIdValues(sd_id);
            if (id_values?.Any() == true)
            {
                foreach (string id_value in id_values)
                {
                    RecordResults rr = new RecordResults(tr, sd_id, "Identifier", "identifier_value", "string", id_value);
                    rr = _repHelper.CompareField(rr,"identifier_type_id", "int");
                    rr = _repHelper.CompareField(rr,"source_id", "int");
                    rr = _repHelper.CompareField(rr,"source", "string");
                    rr = _repHelper.CompareField(rr,"source_ror_id", "string");
                    rr = _repHelper.CompareField(rr,"identifier_date", "string");
                    tr.record_results.Add(rr);
                    tr.num_issues += rr.num_issues;
                }
            }
        }
        _repHelper.write_results(tr);
        return tr.num_issues;
    }
    
    public int compare_table_object_db_links(string sd_id)
    {
        TableResults tr = new TableResults("Object DB Links", "object_db_links", "object", false);
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_oid ='{sd_id}'");
        if (tr.data_present)
        {
            List<string>? dblink_values = _repHelper.FetchObjectDBLinkValues(sd_id);
            if (dblink_values?.Any() == true)
            {
                foreach (string id_value in dblink_values)
                {
                    RecordResults rr = new RecordResults(tr, sd_id, "DB ID", "id_in_db", "string", id_value);
                    rr = _repHelper.CompareField(rr, "db_sequence", "int");
                    rr = _repHelper.CompareField(rr, "db_name", "string");
                    tr.record_results.Add(rr);
                    tr.num_issues += rr.num_issues;
                }
            }
        }
        _repHelper.write_results(tr);
        return tr.num_issues;
    }

    public int compare_table_object_publication_types(string sd_id)
    {
        TableResults tr = new TableResults("Object Publication Types", "object_publication_types", "object", false);
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_oid ='{sd_id}'");
        if (tr.data_present)
        {
            List<string>? pubtype_values = _repHelper.FetchObjectPubTypeValues(sd_id);
            if (pubtype_values?.Any() == true)
            {
                foreach (string id_value in pubtype_values)
                {
                    RecordResults rr = new RecordResults(tr, sd_id, "Type", "type_name", "string", id_value);
                    rr = _repHelper.CompareField(rr, "type_name", "string");
                    tr.record_results.Add(rr);
                    tr.num_issues += rr.num_issues;
                }
            }
        }
        _repHelper.write_results(tr);
        return tr.num_issues;
    }

    public int compare_table_journal_details(string sd_id)
    {
        TableResults tr = new TableResults("Journal Details", "journal_details", "object", false);
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_oid ='{sd_id}'");
        if (tr.data_present)
        {
            // only one possible journal details record per object 

            RecordResults rr = new RecordResults(tr, sd_id, "string");
            rr = _repHelper.CompareField(rr, "journal_title", "string");
            rr = _repHelper.CompareField(rr, "pissn", "string");
            rr = _repHelper.CompareField(rr, "eissn", "string");
            rr = _repHelper.CompareField(rr, "journal_nlm_id", "string");
            rr = _repHelper.CompareField(rr, "journal_iso_abbrev", "string");
            rr = _repHelper.CompareField(rr, "publisher_id", "int");
            rr = _repHelper.CompareField(rr, "publisher", "string");
            tr.record_results.Add(rr);
            tr.num_issues += rr.num_issues;
        }
        _repHelper.write_results(tr);
        return tr.num_issues;
    }
    
    
    public int compare_table_object_relationships(string sd_id)
    {
        TableResults tr = new TableResults("Object Relationships", "object_relationships", "object", false);
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_oid ='{sd_id}'");
        if (tr.data_present)
        {
            List<string>? rels_values = _repHelper.FetchObjectRelationshipValues(sd_id);
            if (rels_values?.Any() == true)
            {
                foreach (string id_value in rels_values)
                {
                    RecordResults rr = new RecordResults(tr, sd_id, "target_sd_oid", "Target sd_oid", "string", id_value);
                    rr = _repHelper.CompareField(rr, "relationship_type_id", "int");
                    tr.record_results.Add(rr);
                    tr.num_issues += rr.num_issues;
                }
            }
        }
        _repHelper.write_results(tr);
        return tr.num_issues;
    }

    public int compare_table_object_rights(string sd_id)
    {
        TableResults tr = new TableResults("Object Rights", "object_rights", "object", false);
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_oid ='{sd_id}'");
        if (tr.data_present)
        {
            List<string>? rights_values = _repHelper.FetchObjectRightsValues(sd_id);
            if (rights_values?.Any() == true)
            {
                foreach (string id_value in rights_values)
                {
                    RecordResults rr = new RecordResults(tr, sd_id, "rights_name", "Right", "string", id_value);
                    rr = _repHelper.CompareField(rr, "rights_uri", "string");
                    rr = _repHelper.CompareField(rr, "comments", "string");
                    tr.record_results.Add(rr);
                    tr.num_issues += rr.num_issues;
                }
            }
        }
        _repHelper.write_results(tr);
        return tr.num_issues;
    }
    
}