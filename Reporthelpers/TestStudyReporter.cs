namespace MDR_Tester;

public class TestStudyReporter
{
    private readonly TestReportHelper _repHelper;

    public TestStudyReporter(Source source, ILoggingHelper loggingHelper, int fbLevel)
    {
        _repHelper = new TestReportHelper(source, loggingHelper, fbLevel);
    }
   
    public List<string>? FetchObjectOIDs(string sd_id)
    {
        return _repHelper.FetchObjectOIDs(sd_id);
    }

    public int compare_table_studies(string sd_id)
    {
        TableResults tr = new TableResults("Study Details", "studies", "study", false)
        {
            data_present = true, num_exp_recs = -1, num_act_recs = -1
        };
        RecordResults rr = new RecordResults(tr, sd_id, "string");
        rr = _repHelper.CompareField(rr, "display_title", "string",  true);
        rr = _repHelper.CompareField(rr, "title_lang_code", "string");
        rr = _repHelper.CompareField(rr, "brief_description", "string",  true);
        rr = _repHelper.CompareField(rr, "data_sharing_statement", "string",  true);
        rr = _repHelper.CompareField(rr, "study_start_year", "int");
        rr = _repHelper.CompareField(rr, "study_start_month", "int");
        rr = _repHelper.CompareField(rr, "study_type_id", "int");
        rr = _repHelper.CompareField(rr, "study_status_id", "int");
        rr = _repHelper.CompareField(rr, "study_enrolment", "string");
        rr = _repHelper.CompareField(rr, "study_gender_elig_id", "int");
        rr = _repHelper.CompareField(rr, "min_age", "int");
        rr = _repHelper.CompareField(rr, "min_age_units_id", "int");
        rr = _repHelper.CompareField(rr, "max_age", "int");
        rr = _repHelper.CompareField(rr, "max_age_units_id", "int");
        rr = _repHelper.CompareField(rr, "iec_level", "int");
        tr.record_results.Add(rr);
        tr.num_issues += rr.num_issues;
        _repHelper.write_results(tr);
        return tr.num_issues;
    }

        
    public int compare_table_study_identifiers(string sd_id)
    {
        TableResults tr = new TableResults("Study Identifiers", "study_identifiers", "study", false);  
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_sid ='{sd_id}'");
        List<string>? id_values = _repHelper.FetchStudyIdValues(sd_id);
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
                rr = _repHelper.CompareField(rr,"identifier_link", "string");
                tr.record_results.Add(rr);
                tr.num_issues += rr.num_issues;
            }
        }
        _repHelper.write_results(tr);
        return tr.num_issues;
    }
   

    public int compare_table_study_titles(string sd_id)
    {
        TableResults tr = new TableResults("Study Titles", "study_titles", "study", false); 
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_sid ='{sd_id}'");
        List<string>? title_values = _repHelper.FetchStudyTitleValues(sd_id);
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
    
    
    public int compare_table_study_topics(string sd_id)
    {
        TableResults tr = new TableResults("Study Topics", "study_topics", "study", false); 
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_sid ='{sd_id}'");
        if (tr.data_present)
        {
            List<string>? topic_values = _repHelper.FetchStudyTopics(sd_id);
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
    
    public int compare_table_study_conditions(string sd_id)
    {
        TableResults tr = new TableResults("Study Conditions", "study_conditions", "study", false); 
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_sid ='{sd_id}'");
        if (tr.data_present)
        {
            List<string>? condition_values = _repHelper.FetchStudyConditions(sd_id);
            if (condition_values?.Any() == true)
            {
                foreach (string id_value in condition_values)
                {
                    RecordResults rr = new RecordResults(tr, sd_id, "Condition", "original_value", "string", id_value);
                    rr = _repHelper.CompareField(rr, "original_ct_type_id", "int");
                    rr = _repHelper.CompareField(rr, "original_ct_code", "string");
                    rr = _repHelper.CompareField(rr, "icd_code", "string");
                    rr = _repHelper.CompareField(rr, "icd_name", "string");
                    tr.record_results.Add(rr);
                    tr.num_issues += rr.num_issues;
                }
            }
        }
        _repHelper.write_results(tr);
        return tr.num_issues;
    }
    
    public int compare_table_study_features(string sd_id)
    {
        TableResults tr = new TableResults("Study Features", "study_features", "study", false); 
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_sid ='{sd_id}'");
        if (tr.data_present)
        {
            List<string>? feature_values = _repHelper.FetchStudyFeatures(sd_id);
            if (feature_values?.Any() == true)
            {
                foreach (string id_value in feature_values)
                {
                    RecordResults rr = new RecordResults(tr, sd_id, "Feature Value", "feature_value_id", "int", id_value);
                    rr = _repHelper.CompareField(rr, "feature_type_id", "int");
                    tr.record_results.Add(rr);
                    tr.num_issues += rr.num_issues;
                }
            }
        } 
        _repHelper.write_results(tr);
        return tr.num_issues;
    }
    
    public int compare_table_study_people(string sd_id)
    {
        TableResults tr = new TableResults("Study People", "study_people", "study", false); 
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_sid ='{sd_id}'");
        if (tr.data_present)
        {
            List<string>? people_values = _repHelper.FetchStudyPeopleValues(sd_id);
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
    
    public int compare_table_study_organisations(string sd_id)
    {
        TableResults tr = new TableResults("Study Organisations", "study_organisations", "study", false); 
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_sid ='{sd_id}'");
        if (tr.data_present)
        {
            List<string>? org_values = _repHelper.FetchStudyOrgValues(sd_id);
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
    
    public int compare_table_study_references(string sd_id)
    {
        TableResults tr = new TableResults("Study References", "study_references", "study", true); 
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_sid ='{sd_id}'");
        if (tr.data_present)
        {
            List<CitationData>? ref_values = _repHelper.FetchStudyReferences(sd_id);
            if (ref_values?.Any() == true)
            {
                foreach (CitationData id_values in ref_values)
                {
                    RecordResults rr = new RecordResults(tr, sd_id, "PMID / Citation", "pmid", "string", 
                        id_values.pmid, "citation", "string", id_values.citation);
                    rr = _repHelper.CompareField(rr, "doi", "string");
                    rr = _repHelper.CompareField(rr, "type_id", "int");
                    rr = _repHelper.CompareField(rr, "comments", "string");
                    tr.record_results.Add(rr);
                    tr.num_issues += rr.num_issues;
                }
            }
        }
        _repHelper.write_results(tr);
        return tr.num_issues;
    }
    
    public int compare_table_study_relationships(string sd_id)
    {
        TableResults tr = new TableResults("Study Relationships", "study_relationships", "study", false); 
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_sid ='{sd_id}'");
        if (tr.data_present)
        {
            List<string>? rel_values = _repHelper.FetchStudyRelationships(sd_id);
            if (rel_values?.Any() == true)
            {
                foreach (string id_value in rel_values)
                {
                    RecordResults rr = new RecordResults(tr, sd_id, "Target Study", "target_sd_sid", "string", id_value);
                    rr = _repHelper.CompareField(rr, "relationship_type_id", "int");
                    tr.record_results.Add(rr);
                    tr.num_issues += rr.num_issues;
                }
            }
            
        }
        _repHelper.write_results(tr);
        return tr.num_issues;
    }
    
    public int compare_table_study_links(string sd_id)
    {
        TableResults tr = new TableResults("Study Links", "study_links", "study", false); 
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_sid ='{sd_id}'");
        if (tr.data_present)
        {
            List<string>? condition_values = _repHelper.FetchStudyLinks(sd_id);
            if (condition_values?.Any() == true)
            {
                foreach (string id_value in condition_values)
                {
                    RecordResults rr = new RecordResults(tr, sd_id, "Link Label", "link_label", "string", id_value);
                    rr = _repHelper.CompareField(rr, "link_url", "string");
                    tr.record_results.Add(rr);
                    tr.num_issues += rr.num_issues;
                }
            }
            
        }
        _repHelper.write_results(tr);
        return tr.num_issues;
    }
    
    public int compare_table_study_countries(string sd_id)
    {
        TableResults tr = new TableResults("Study Countries", "study_countries", "study", false); 
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_sid ='{sd_id}'");
        if (tr.data_present)
        {
            List<string>? country_values = _repHelper.FetchStudyCountries(sd_id);
            if (country_values?.Any() == true)
            {
                foreach (string id_value in country_values)
                {
                    RecordResults rr = new RecordResults(tr, sd_id, "Country", "country_name", "string", id_value);
                    rr = _repHelper.CompareField(rr, "country_id", "int");
                    rr = _repHelper.CompareField(rr, "status_id", "int");
                    tr.record_results.Add(rr);
                    tr.num_issues += rr.num_issues;
                }
            }
            
        }
        _repHelper.write_results(tr);
        return tr.num_issues;
    }
    
    public int compare_table_study_locations(string sd_id)
    {
        TableResults tr = new TableResults("Study Locations", "study_locations", "study", true); 
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_sid ='{sd_id}'");
        if (tr.data_present)
        {
            List<string>? loc_values = _repHelper.FetchStudyLocations(sd_id);
            if (loc_values?.Any() == true)
            {
                foreach (string id_value in loc_values)
                {
                    RecordResults rr = new RecordResults(tr, sd_id, "Facility", "facility", "string", id_value);
                    rr = _repHelper.CompareField(rr, "facility_org_id", "int");
                    rr = _repHelper.CompareField(rr, "facility_ror_id", "string");
                    rr = _repHelper.CompareField(rr, "city_id", "int");
                    rr = _repHelper.CompareField(rr, "city_name", "string");
                    rr = _repHelper.CompareField(rr, "country_id", "int");
                    rr = _repHelper.CompareField(rr, "country_name", "string");
                    rr = _repHelper.CompareField(rr, "status_id", "int");
                    tr.record_results.Add(rr);
                    tr.num_issues += rr.num_issues;
                }
            }
            
        }
        _repHelper.write_results(tr);
        return tr.num_issues;
    }
    
    public int compare_table_ipd_available(string sd_id)
    {
        TableResults tr = new TableResults("Study IPD Available", "study_ipd_available", "study", false); 
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_sid ='{sd_id}'");
        if (tr.data_present)
        {
            List<string>? ipd_values = _repHelper.FetchStudyIPDAvailable(sd_id);
            if (ipd_values?.Any() == true)
            {
                foreach (string id_value in ipd_values)
                {
                    RecordResults rr = new RecordResults(tr, sd_id, "IPD ID", "ipd_id", "string", id_value);
                    rr = _repHelper.CompareField(rr, "ipd_type", "string");
                    rr = _repHelper.CompareField(rr, "ipd_url", "string");
                    rr = _repHelper.CompareField(rr, "ipd_comment", "string");
                    tr.record_results.Add(rr);
                    tr.num_issues += rr.num_issues;
                }
            }
            
        }
        _repHelper.write_results(tr);
        return tr.num_issues;
    }
    
    public int compare_table_study_iec(string sd_id)
    {
        TableResults tr = new TableResults("Study IEC", "study_iec", "study", false); 
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_sid ='{sd_id}'");
        if (tr.data_present)
        {
            List<string>? iec_values = _repHelper.FetchStudyIEC(sd_id, "study_iec");
            if (iec_values?.Any() == true)
            {
                iec_values = iec_values.OrderBy(int.Parse).ToList();
                foreach (string id_value in iec_values)
                {
                    RecordResults rr = new RecordResults(tr, sd_id, "Seq Num", "seq_num", "int", id_value);
                    rr = _repHelper.CompareField(rr, "iec_type_id", "int");
                    rr = _repHelper.CompareField(rr, "split_type", "string");
                    rr = _repHelper.CompareField(rr, "leader", "string");
                    rr = _repHelper.CompareField(rr, "indent_level", "int");
                    rr = _repHelper.CompareField(rr, "sequence_string", "string");
                    rr = _repHelper.CompareField(rr, "iec_text", "string", true);
                    tr.record_results.Add(rr);
                    tr.num_issues += rr.num_issues;
                }
            }
            
        }
        _repHelper.write_results(tr);
        return tr.num_issues;
    }
    
    public int compare_table_study_iec_by_year_groups(string sd_id)
    {
        int? start_year = _repHelper.GetStudyStartYear(sd_id);
        string table_name = start_year switch
        {
            null or <= 2012 => "study_iec_upto12",
            >= 2013 and <= 2019 => "study_iec_13to19",
            _ => "study_iec_20on"
        };
        
        TableResults tr = new TableResults("Study IEC", table_name, "study", false); 
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_sid ='{sd_id}'");
        if (tr.data_present)
        {
            List<string>? iec_values = _repHelper.FetchStudyIEC(sd_id, table_name);
            if (iec_values?.Any() == true)
            {
                iec_values = iec_values.OrderBy(int.Parse).ToList();
                foreach (string id_value in iec_values)
                {
                    RecordResults rr = new RecordResults(tr, sd_id, "Seq Num", "seq_num",  "int", id_value);
                    rr = _repHelper.CompareField(rr, "iec_type_id", "int");
                    rr = _repHelper.CompareField(rr, "split_type", "string");
                    rr = _repHelper.CompareField(rr, "leader", "string");
                    rr = _repHelper.CompareField(rr, "indent_level", "int");
                    rr = _repHelper.CompareField(rr, "sequence_string", "string");
                    rr = _repHelper.CompareField(rr, "iec_text", "string", true);
                    tr.record_results.Add(rr);
                    tr.num_issues += rr.num_issues;
                }
            }
            
        }
        _repHelper.write_results(tr);
        return tr.num_issues;
    }
    
    public int compare_table_study_iec_by_years(string sd_id)
    {
        int? start_year = _repHelper.GetStudyStartYear(sd_id);
        string table_name = start_year switch
        {
            < 2006 => "study_iec_pre06",
            >= 2006 and <= 2008 => "study_iec_0608",
            2009 or 2010 => "study_iec_0910",
            2011 or 2012 => "study_iec_1112",
            2013 or 2014 => "study_iec_1314",
            >= 2015 and <= 2030 => $"study_iec_{start_year - 2000}",
            null => "study_iec_null",
            _ => "study_iec_null"
        };
        
        TableResults tr = new TableResults("Study IEC", table_name, "study", false); 
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_sid ='{sd_id}'");
        if (tr.data_present)
        {
            List<string>? iec_values = _repHelper.FetchStudyIEC(sd_id, table_name);
            if (iec_values?.Any() == true)
            {
                iec_values = iec_values.OrderBy(int.Parse).ToList();
                foreach (string id_value in iec_values)
                {
                    RecordResults rr = new RecordResults(tr, sd_id, "Seq Num", "seq_num", "int", id_value);
                    rr = _repHelper.CompareField(rr, "iec_type_id", "int");
                    rr = _repHelper.CompareField(rr, "split_type", "string");
                    rr = _repHelper.CompareField(rr, "leader", "string");
                    rr = _repHelper.CompareField(rr, "indent_level", "int");
                    rr = _repHelper.CompareField(rr, "sequence_string", "string");
                    rr = _repHelper.CompareField(rr, "iec_text", "string", true);
                    tr.record_results.Add(rr);
                    tr.num_issues += rr.num_issues;
                }
            }
        }
        _repHelper.write_results(tr);
        return tr.num_issues;
    }

    public int compare_table_study_data_objects(string sd_id)
    {
        TableResults tr = new TableResults("Study Data Object Numbers", "data_objects", "study", false); 
        tr = _repHelper.CompareAttNumbers(tr, $" where sd_sid ='{sd_id}'");
        _repHelper.write_results(tr);
        return tr.num_issues;
    }

}