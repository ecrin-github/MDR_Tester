namespace MDR_Tester;

public class TestStudyReporter
{
    private readonly ILoggingHelper _loggingHelper;
    private readonly TestReportHelper _repHelper;

    public TestStudyReporter(Source source, ILoggingHelper loggingHelper)
    {
        _loggingHelper = loggingHelper;        
        _repHelper = new TestReportHelper(source, loggingHelper);

    }
   
    public List<string>? FetchObjectOIDs(string sd_id)
    {
        return _repHelper.FetchObjectOIDs(sd_id);
    }
    
    public void compare_table_studies(string sd_id, int fb_level)
    {
        string where_clause = $" where sd_sid ='{sd_id}'";
        TableResults tr = new TableResults("Study Details", "studies", fb_level);
        tr = _repHelper.CompareField(tr, "display_title", "string", where_clause, true);
        tr = _repHelper.CompareField(tr, "title_lang_code", "string", where_clause);
        tr = _repHelper.CompareField(tr, "brief_description", "string", where_clause, true);
        tr = _repHelper.CompareField(tr, "data_sharing_statement", "string", where_clause, true);
        tr = _repHelper.CompareField(tr, "study_start_year", "int", where_clause);
        tr = _repHelper.CompareField(tr, "study_start_month", "int", where_clause);
        tr = _repHelper.CompareField(tr, "study_type_id", "int", where_clause);
        tr = _repHelper.CompareField(tr, "study_status_id", "int", where_clause);
        tr = _repHelper.CompareField(tr, "study_enrolment", "string", where_clause);
        tr = _repHelper.CompareField(tr, "study_gender_elig_id", "int",where_clause);
        tr = _repHelper.CompareField(tr, "min_age", "int", where_clause);
        tr = _repHelper.CompareField(tr, "min_age_units_id", "int", where_clause);
        tr = _repHelper.CompareField(tr, "max_age", "int", where_clause);
        tr = _repHelper.CompareField(tr, "max_age_units_id", "int", where_clause);
        tr = _repHelper.CompareField(tr, "iec_level", "int", where_clause);
        _repHelper.write_results(tr);
    }

        
    public void compare_table_study_identifiers(string sd_id, int fb_level)
    {
        TableResults tr = new TableResults("Study Identifiers", "study_identifiers", fb_level);
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_sid ='{sd_id}'");
        List<string>? id_values = _repHelper.FetchStudyIdValues(sd_id);
        if (id_values?.Any() == true)
        {
            foreach (string id_value in id_values)
            {
                string where_clause = $" where sd_sid ='{sd_id}' and identifier_value ='{id_value}'";
                tr = _repHelper.CompareField(tr, "identifier_value", "string", where_clause);
                tr = _repHelper.CompareField(tr, "identifier_type_id", "int", where_clause);
                tr = _repHelper.CompareField(tr, "source_id", "int", where_clause);
                tr = _repHelper.CompareField(tr, "source", "string", where_clause);
                tr = _repHelper.CompareField(tr, "source_ror_id", "string", where_clause);
                tr = _repHelper.CompareField(tr, "identifier_date", "string", where_clause);
                tr = _repHelper.CompareField(tr, "identifier_date", "string", where_clause);
            }
        }
        _repHelper.write_results(tr);
    }
   

    public void compare_table_study_titles(string sd_id, int fb_level)
    {
        TableResults tr = new TableResults("Study Titles", "study_titles", fb_level);
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_sid ='{sd_id}'");
        List<string>? title_values = _repHelper.FetchStudyTitleValues(sd_id);
        if (title_values?.Any() == true)
        {
            foreach (string id_value in title_values)
            {
                //_loggingHelper.LogFieldHeader("title: " + id_value);
                string where_clause = $" where sd_sid ='{sd_id}' and title_text ='{id_value}'";
                tr = _repHelper.CompareField(tr, "title_type_id", "int", where_clause);
                tr = _repHelper.CompareField(tr, "lang_code", "string", where_clause);
                tr = _repHelper.CompareField(tr, "lang_usage_id", "int", where_clause);
                tr = _repHelper.CompareField(tr, "is_default", "bool", where_clause);
                tr = _repHelper.CompareField(tr, "comments", "string", where_clause);
            }
        }
        _repHelper.write_results(tr);
    }
    
    
    public void compare_table_study_topics(string sd_id, int fb_level)
    {
        TableResults tr = new TableResults("Study Topics", "study_topics", fb_level);
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_sid ='{sd_id}'");
        if (tr.data_present)
        {
            List<string>? topic_values = _repHelper.FetchStudyTopics(sd_id);
            if (topic_values?.Any() == true)
            {
                foreach (string id_value in topic_values)
                {
                    //_loggingHelper.LogFieldHeader("topic: " + id_value);
                    string where_clause = $" where sd_sid ='{sd_id}' and original_value ='{id_value}'";
                    tr = _repHelper.CompareField(tr, "topic_type_id", "int", where_clause);
                    tr = _repHelper.CompareField(tr, "original_ct_type_id", "int", where_clause);
                    tr = _repHelper.CompareField(tr, "original_ct_code", "string", where_clause);
                    tr = _repHelper.CompareField(tr, "mesh_code", "string", where_clause);
                    tr = _repHelper.CompareField(tr, "mesh_value", "string", where_clause);
                }
            }
        }
        _repHelper.write_results(tr);
    }
    
    public void compare_table_study_conditions(string sd_id, int fb_level)
    {
        TableResults tr = new TableResults("Study Conditions", "study_conditions", fb_level);
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_sid ='{sd_id}'");
        if (tr.data_present)
        {
            List<string>? condition_values = _repHelper.FetchStudyConditions(sd_id);
            if (condition_values?.Any() == true)
            {
                foreach (string id_value in condition_values)
                {
                    _loggingHelper.LogFieldHeader("condition: " + id_value);
                    string where_clause = $" where sd_sid ='{sd_id}' and original_value ='{id_value}'";
                    tr = _repHelper.CompareField(tr, "original_ct_type_id", "int", where_clause);
                    tr = _repHelper.CompareField(tr, "original_ct_code", "string", where_clause);
                    tr = _repHelper.CompareField(tr, "icd_code", "string", where_clause);
                    tr = _repHelper.CompareField(tr, "icd_name", "string", where_clause);
                }
            }
            _repHelper.write_results(tr);
        }
    }
    
    public void compare_table_study_features(string sd_id, int fb_level)
    {
        TableResults tr = new TableResults("Study Features", "study_features", fb_level);
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_sid ='{sd_id}'");
        if (tr.data_present)
        {
            List<string>? feature_values = _repHelper.FetchStudyFeatures(sd_id);
            if (feature_values?.Any() == true)
            {
                foreach (string id_value in feature_values)
                {
                    _loggingHelper.LogFieldHeader("feature value: " + id_value);
                    string where_clause = $" where sd_sid ='{sd_id}' and feature_value_id = {id_value}";
                    tr = _repHelper.CompareField(tr, "feature_type_id", "int", where_clause);
                }
            }
            _repHelper.write_results(tr);
        }
    }
    
    public void compare_table_study_people(string sd_id, int fb_level)
    {
        TableResults tr = new TableResults("Study People", "study_people", fb_level);
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_sid ='{sd_id}'");
        if (tr.data_present)
        {
            List<string>? people_values = _repHelper.FetchStudyPeopleValues(sd_id);
            if (people_values?.Any() == true)
            {
                foreach (string id_value in people_values)
                {
                    _loggingHelper.LogFieldHeader("person: " + id_value);
                    string where_clause = $" where sd_sid ='{sd_id}' and person_full_name ='{id_value}'";
                    tr = _repHelper.CompareField(tr, "contrib_type_id", "int", where_clause);
                    tr = _repHelper.CompareField(tr, "person_given_name", "string", where_clause);
                    tr = _repHelper.CompareField(tr, "person_family_name", "string", where_clause);
                    tr = _repHelper.CompareField(tr, "orcid_id", "string", where_clause);
                    tr = _repHelper.CompareField(tr, "person_affiliation", "string", where_clause);
                    tr = _repHelper.CompareField(tr, "organisation_id", "int", where_clause);
                    tr = _repHelper.CompareField(tr, "organisation_name", "string", where_clause);
                    tr = _repHelper.CompareField(tr, "organisation_ror_id", "string", where_clause);
                }
            }
            _repHelper.write_results(tr);
        }
    }
    
    public void compare_table_study_organisations(string sd_id, int fb_level)
    {
        TableResults tr = new TableResults("Study Organisations", "study_organisations", fb_level);
        //_loggingHelper.LogTableHeader("Study organisations");
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_sid ='{sd_id}'");
        if (tr.data_present)
        {
            List<string>? org_values = _repHelper.FetchStudyOrgValues(sd_id);
            if (org_values?.Any() == true)
            {
                foreach (string id_value in org_values)
                {
                    _loggingHelper.LogFieldHeader("organisation: " + id_value);
                    string where_clause = $" where sd_sid ='{sd_id}' and organisation_name ='{id_value}'";
                    tr = _repHelper.CompareField(tr, "contrib_type_id", "int", where_clause);
                    tr = _repHelper.CompareField(tr, "organisation_id", "int", where_clause);
                    tr = _repHelper.CompareField(tr, "organisation_ror_id", "string", where_clause);
                }
            }
            _repHelper.write_results(tr);
        }
    }
    
    public void compare_table_study_references(string sd_id, int fb_level)
    {
        TableResults tr = new TableResults("Study References", "study_references", fb_level);
        //_loggingHelper.LogTableHeader("Study references");
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_sid ='{sd_id}'");
        if (tr.data_present)
        {
            //_loggingHelper.LogLine($"Expected references ({s.num_exp}) may be a subset of actual references({s.num_act})");
            List<string>? ref_values = _repHelper.FetchStudyReferences(sd_id);
            if (ref_values?.Any() == true)
            {
                foreach (string id_value in ref_values)
                {
                    _loggingHelper.LogFieldHeader("citation: " + id_value);
                    string where_clause = $" where sd_sid ='{sd_id}' and citation ='{id_value}'";
                    tr = _repHelper.CompareField(tr, "pmid", "string", where_clause);
                    tr = _repHelper.CompareField(tr, "doi", "string", where_clause);
                    tr = _repHelper.CompareField(tr, "type_id", "int", where_clause);
                    tr = _repHelper.CompareField(tr, "comments", "string", where_clause);
                }
            }
            _repHelper.write_results(tr);
        }
    }
    
    public void compare_table_study_relationships(string sd_id, int fb_level)
    {
        TableResults tr = new TableResults("Study Relationships", "study_relationships", fb_level);
        //_loggingHelper.LogTableHeader("Study relationships");
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_sid ='{sd_id}'");
        if (tr.data_present)
        {
            //_loggingHelper.LogLine(s.res_string);
            List<string>? rel_values = _repHelper.FetchStudyRelationships(sd_id);
            if (rel_values?.Any() == true)
            {
                foreach (string id_value in rel_values)
                {
                    _loggingHelper.LogFieldHeader("target_sd_sid: " + id_value);
                    string where_clause = $" where sd_sid ='{sd_id}' and target_sd_sid ='{id_value}'";
                    tr = _repHelper.CompareField(tr, "relationship_type_id", "int", where_clause);
                }
            }
            _repHelper.write_results(tr);
        }
    }
    
    public void compare_table_study_links(string sd_id, int fb_level)
    {
        TableResults tr = new TableResults("Study Links", "study_links", fb_level);
        //_loggingHelper.LogTableHeader("Study links");
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_sid ='{sd_id}'");
        if (tr.data_present)
        {
            //_loggingHelper.LogLine(s.res_string);
            List<string>? condition_values = _repHelper.FetchStudyLinks(sd_id);
            if (condition_values?.Any() == true)
            {
                foreach (string id_value in condition_values)
                {
                    _loggingHelper.LogFieldHeader("link_label: " + id_value);
                    string where_clause = $" where sd_sid ='{sd_id}' and link_label ='{id_value}'";
                    tr = _repHelper.CompareField(tr, "link_url", "string", where_clause);
                }
            }
            _repHelper.write_results(tr);
        }
    }
    
    public void compare_table_study_countries(string sd_id, int fb_level)
    {
        TableResults tr = new TableResults("Study Countries", "study_countries", fb_level);
        //_loggingHelper.LogTableHeader("Study countries");
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_sid ='{sd_id}'");
        if (tr.data_present)
        {
            //_loggingHelper.LogLine(s.res_string);
            List<string>? country_values = _repHelper.FetchStudyCountries(sd_id);
            if (country_values?.Any() == true)
            {
                foreach (string id_value in country_values)
                {
                    _loggingHelper.LogFieldHeader("country name: " + id_value);
                    string where_clause = $" where sd_sid ='{sd_id}' and country_name ='{id_value}'";
                    tr = _repHelper.CompareField(tr, "country_id", "int", where_clause);
                    tr = _repHelper.CompareField(tr, "status_id", "int", where_clause);
                }
            }
            _repHelper.write_results(tr);
        }
    }
    
    public void compare_table_study_locations(string sd_id, int fb_level)
    {
        TableResults tr = new TableResults("Study Locations", "study_locations", fb_level);
        //_loggingHelper.LogTableHeader("Study locations");
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_sid ='{sd_id}'");
        if (tr.data_present)
        {
            //_loggingHelper.LogLine($"Expected locations ({s.num_exp}) often a subset of actual locations({s.num_act})");
            List<string>? loc_values = _repHelper.FetchStudyLocations(sd_id);
            if (loc_values?.Any() == true)
            {
                foreach (string id_value in loc_values)
                {
                    _loggingHelper.LogFieldHeader("facility: " + id_value);
                    string where_clause = $" where sd_sid ='{sd_id}' and facility ='{id_value}'";
                    tr = _repHelper.CompareField(tr, "facility_org_id", "int", where_clause);
                    tr = _repHelper.CompareField(tr, "facility_ror_id", "string", where_clause);
                    tr = _repHelper.CompareField(tr, "city_id", "int", where_clause);
                    tr = _repHelper.CompareField(tr, "city_name", "string", where_clause);
                    tr = _repHelper.CompareField(tr, "country_id", "int", where_clause);
                    tr = _repHelper.CompareField(tr, "country_name", "string", where_clause);
                    tr = _repHelper.CompareField(tr, "status_id", "int", where_clause);
                }
            }
            _repHelper.write_results(tr);
        }
    }
    
    public void compare_table_ipd_available(string sd_id, int fb_level)
    {
        TableResults tr = new TableResults("Study IPD Available", "study_ipd_available", fb_level);
        //_loggingHelper.LogTableHeader("Study ipd available");
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_sid ='{sd_id}'");
        if (tr.data_present)
        {
            //_loggingHelper.LogLine(s.res_string);
            List<string>? ipd_values = _repHelper.FetchStudyIPDAvailable(sd_id);
            if (ipd_values?.Any() == true)
            {
                foreach (string id_value in ipd_values)
                {
                    _loggingHelper.LogFieldHeader("ipd_id: " + id_value);
                    string where_clause = $" where sd_sid ='{sd_id}' and ipd_id ='{id_value}'";
                    tr = _repHelper.CompareField(tr, "ipd_type", "string", where_clause);
                    tr = _repHelper.CompareField(tr, "ipd_url", "string", where_clause);
                    tr = _repHelper.CompareField(tr, "ipd_comment", "string", where_clause);
                }
            }
            _repHelper.write_results(tr);
        }
    }
    
    public void compare_table_study_iec(string sd_id, int fb_level)
    {
        TableResults tr = new TableResults("Study IEC", "study_iec", fb_level);
        //_loggingHelper.LogTableHeader("Study IEC");
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_sid ='{sd_id}'");
        if (tr.data_present)
        {
            //_loggingHelper.LogLine(s.res_string);
            List<string>? iec_values = _repHelper.FetchStudyIEC(sd_id, "study_iec");
            if (iec_values?.Any() == true)
            {
                foreach (string id_value in iec_values)
                {
                    _loggingHelper.LogFieldHeader("seq num: " + id_value);
                    string where_clause = $" where sd_sid ='{sd_id}' and seq_num = {id_value}";
                    tr = _repHelper.CompareField(tr, "iec_type_id", "int", where_clause);
                    tr = _repHelper.CompareField(tr, "split_type", "string", where_clause);
                    tr = _repHelper.CompareField(tr, "leader", "string", where_clause);
                    tr = _repHelper.CompareField(tr, "indent_level", "int", where_clause);
                    tr = _repHelper.CompareField(tr, "sequence_string", "string", where_clause);
                    tr = _repHelper.CompareField(tr, "iec_text", "string", where_clause);
                }
            }
            _repHelper.write_results(tr);
        }
    }
    
    public void compare_table_study_iec_by_year_groups(string sd_id, int fb_level)
    {
        int? start_year = _repHelper.GetStudyStartYear(sd_id);
        string table_name = start_year switch
        {
            null or <= 2012 => "study_iec_upto12",
            >= 2013 and <= 2019 => "study_iec_13to19",
            _ => "study_iec_20on"
        };
        
        TableResults tr = new TableResults("Study IEC", table_name, fb_level);
        //_loggingHelper.LogTableHeader("Study IEC");
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_sid ='{sd_id}'");
        if (tr.data_present)
        {
            //_loggingHelper.LogLine(s.res_string);
            List<string>? iec_values = _repHelper.FetchStudyIEC(sd_id, table_name);
            if (iec_values?.Any() == true)
            {
                foreach (string id_value in iec_values)
                {
                    _loggingHelper.LogFieldHeader("seq num: " + id_value);
                    string where_clause = $" where sd_sid ='{sd_id}' and seq_num = {id_value}";
                    tr = _repHelper.CompareField(tr, "iec_type_id", "int", where_clause);
                    tr = _repHelper.CompareField(tr, "split_type", "string", where_clause);
                    tr = _repHelper.CompareField(tr, "leader", "string", where_clause);
                    tr = _repHelper.CompareField(tr, "indent_level", "int", where_clause);
                    tr = _repHelper.CompareField(tr, "sequence_string", "string", where_clause);
                    tr = _repHelper.CompareField(tr, "iec_text", "string", where_clause);
                }
            }
            _repHelper.write_results(tr);
        }
    }
    
    public void compare_table_study_iec_by_years(string sd_id, int fb_level)
    {
        int? start_year = _repHelper.GetStudyStartYear(sd_id);
        string table_name = start_year switch
        {
            <= 2006 => "study_iec_pre06",
            null => "study_iec_null",
            _ => start_year switch
            {
                >= 2015 and <= 2030 => $"study_iec_{start_year - 2000}",
                2009 or 2010 => "study_iec_0910",
                2011 or 2012 => "study_iec_1112",
                2013 or 2014 => "study_iec_1314",
                >= 2006 and <= 2008 => "study_iec_0608",
                _ => "study_iec_null"
            }
        };
        
        TableResults tr = new TableResults("Study IEC", table_name, fb_level);
        //_loggingHelper.LogTableHeader("Study IEC");
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_sid ='{sd_id}'");
        if (tr.data_present)
        {
            //_loggingHelper.LogLine(s.res_string);
            List<string>? iec_values = _repHelper.FetchStudyIEC(sd_id, table_name);
            if (iec_values?.Any() == true)
            {
                foreach (string id_value in iec_values)
                {
                    _loggingHelper.LogFieldHeader("seq num: " + id_value);
                    string where_clause = $" where sd_sid ='{sd_id}' and seq_num = {id_value}";
                    tr = _repHelper.CompareField(tr, "iec_type_id", "int", where_clause);
                    tr = _repHelper.CompareField(tr, "split_type", "string", where_clause);
                    tr = _repHelper.CompareField(tr, "leader", "string", where_clause);
                    tr = _repHelper.CompareField(tr, "indent_level", "int", where_clause);
                    tr = _repHelper.CompareField(tr, "sequence_string", "string", where_clause);
                    tr = _repHelper.CompareField(tr, "iec_text", "string", where_clause);
                }
            }
            _repHelper.write_results(tr);
        }
    }

    public void compare_table_study_data_objects(string sd_id, int fb_level)
    {
        TableResults tr = new TableResults("Study Data Objects", "data_objects", fb_level);
        //_loggingHelper.LogTableHeader("Study data objects");
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_sid ='{sd_id}'");
        //_loggingHelper.LogLine(s.res_string);
        _repHelper.write_results(tr);
    }

}