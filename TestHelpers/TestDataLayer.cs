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

    private void ExecuteSQL(string sqlString)
    {
        try
        {
            using NpgsqlConnection conn = new(_connString);
            conn.Execute(sqlString);
        }
        catch (Exception e)
        {
            _loggingHelper.LogError($"{e.Message} with sql: {sqlString}");
        }
    }

    private string ToStringPar(string? ParValue)
    {
        return ParValue is null ? "null" : $"'{ParValue}'";
    }

    private string ToIntPar(int? ParValue)
    {
        return ParValue.HasValue ? ((int)ParValue).ToString() : "null";
    }

    private string ToBoolPar(bool? ParValue)
    {
        return ParValue.HasValue ? ((bool)ParValue).ToString() : "null";
    }

    public IEnumerable<string>? ObtainTestSIDs(string sourceType)
    {
        string sqlString = sourceType == "study" ? "Select sd_sid" : "Select sd_oid";
        sqlString += " from mn.source_data where for_testing = true;";
        using NpgsqlConnection conn = new(_connString);
        return conn.Query<string>(sqlString);
    }

    public bool LoadData(string source_type, int source_id, string sd_id)
    {
        // Get data using source_id to identify source class,
        // sd_sid to identify specific data 

        TestData_Base? tdb = source_id switch
        {
            100116 => new TestData_100116(),
            100118 => new TestData_100118(),
            100120 => new TestData_100120(),
            100123 => new TestData_100123(),
            100124 => new TestData_100124(),
            100126 => new TestData_100126(),
            100132 => new TestData_100132(),
            101900 => new TestData_101900(),
            101901 => new TestData_101901(),
            100135 => new TestData_100135(),
            _ => null
        };

        // Load the expected study data from the
        // manually curated data source pages.

        if (source_type == "study")
        {
            FullStudy? fs = tdb?.FetchStudyData(sd_id);
            if (fs is null)
            {
                return false;
            }

            // Store the study components.
            
            StoreStudyComponents(fs);
        }
        else
        {
            FullDataObject? fdo = tdb?.FetchObjectData(sd_id);
            if (fdo is null)
            {
                return false;
            }

            // Store the object components.
            
            StoreObjectComponents(fdo);
        }

        return true;
    }

    private void StoreStudyComponents(FullStudy fs)
    {
        Study s = fs.study!;
        string sid = ToStringPar(s.sd_sid);

        string i_title = ToStringPar(s.display_title);
        string i_lang_code = ToStringPar(s.title_lang_code);
        string i_description = ToStringPar(s.brief_description);
        string i_dss = ToStringPar(s.data_sharing_statement);
        string i_s_year = ToIntPar(s.study_start_year);
        string i_s_month = ToIntPar(s.study_start_month);
        string i_type_id = ToIntPar(s.study_type_id);
        string i_status_id = ToIntPar(s.study_status_id);
        string i_enrolment = ToStringPar(s.study_enrolment);
        string i_gender_id = ToIntPar(s.study_gender_elig_id);
        string i_min_age = ToIntPar(s.min_age);
        string i_min_age_uid = ToIntPar(s.min_age_units_id);
        string i_max_age = ToIntPar(s.max_age);
        string i_max_age_uid = ToIntPar(s.max_age_units_id);
        string i_iec_level = ToIntPar(s.iec_level);

        string sqlString = $@"Insert into te.studies (sd_sid, display_title, title_lang_code
                            , brief_description, data_sharing_statement, study_start_year
                            , study_start_month, study_type_id, study_status_id, study_enrolment
                            , study_gender_elig_id, min_age, min_age_units_id, max_age
                            , max_age_units_id, iec_level)
                            values ({sid}, {i_title}, {i_lang_code}
                            , {i_description}, {i_dss}, {i_s_year}, {i_s_month}
                            , {i_type_id}, {i_status_id}, {i_enrolment}, {i_gender_id} 
                            , {i_min_age}, {i_min_age_uid}, {i_max_age}, {i_max_age_uid}, {i_iec_level}) ";
        ExecuteSQL(sqlString);
        _loggingHelper.LogLine($"Study record for {sid} added to DB");


        if (fs.identifiers?.Any() == true)
        {
            int n = 0;
            foreach (StudyIdentifier si in fs.identifiers)
            {
                string i_ident_val = ToStringPar(si.identifier_value);
                string i_ident_type = ToIntPar(si.identifier_type_id);
                string i_source_id = ToIntPar(si.source_id);
                string i_source = ToStringPar(si.source);
                string i_source_ror = ToStringPar(si.source_ror_id);
                string i_ident_date = ToStringPar(si.identifier_date);
                string i_ident_link = ToStringPar(si.identifier_link);

                sqlString = $@"Insert into te.study_identifiers(sd_sid, identifier_value, identifier_type_id, 
                source_id, source, source_ror_id, identifier_date, identifier_link)
                values ({sid}, {i_ident_val}, {i_ident_type}, {i_source_id}, {i_source}, 
                {i_source_ror}, {i_ident_date}, {i_ident_link}) ";
                ExecuteSQL(sqlString);
                n++;
            }
            string recs = n == 1 ? "record" : "records";
            _loggingHelper.LogLine($"{n} Study identifier {recs} for {sid} added to DB");
        }

        if (fs.titles?.Any() == true)
        {
            int n = 0;
            foreach (StudyTitle st in fs.titles)
            {
                string i_title_type = ToIntPar(st.title_type_id);
                string i_title_text = ToStringPar(st.title_text);
                string i_title_lang = ToStringPar(st.lang_code);
                string i_title_lang_use = ToIntPar(st.lang_usage_id);
                string i_title_default = ToBoolPar(st.is_default);
                string i_title_comms = ToStringPar(st.comments);

                sqlString = $@"Insert into te.study_titles(sd_sid, title_type_id, title_text, 
                lang_code, lang_usage_id, is_default, comments)
                values ({sid}, {i_title_type}, {i_title_text}, {i_title_lang}, 
                {i_title_lang_use}, {i_title_default}, {i_title_comms}) ";
                ExecuteSQL(sqlString);
                n++;
            }
            string recs = n == 1 ? "record" : "records";
            _loggingHelper.LogLine($"{n} Study title {recs} for {sid} added to DB");
        }

        if (fs.people?.Any() == true)
        {
            int n = 0;
            foreach (StudyPerson sp in fs.people)
            {
                string i_p_contrib = ToIntPar(sp.contrib_type_id);
                string i_given = ToStringPar(sp.person_given_name);
                string i_family = ToStringPar(sp.person_family_name);
                string i_full = ToStringPar(sp.person_full_name);
                string i_orcid = ToStringPar(sp.orcid_id);
                string i_affil = ToStringPar(sp.person_affiliation);
                string i_p_org_id = ToIntPar(sp.organisation_id);
                string i_p_org = ToStringPar(sp.organisation_name);
                string i_p_org_ror = ToStringPar(sp.organisation_ror_id);

                sqlString = $@"Insert into te.study_people(sd_sid, contrib_type_id, 
                person_given_name, person_family_name, person_full_name, 
                orcid_id, person_affiliation, organisation_id, organisation_name, organisation_ror_id)
                values ({sid}, {i_p_contrib}, {i_given}, {i_family}, {i_full}, 
                {i_orcid}, {i_affil}, {i_p_org_id}, {i_p_org}, {i_p_org_ror}) ";
                ExecuteSQL(sqlString);
                n++;
            }
            string recs = n == 1 ? "record" : "records";
            _loggingHelper.LogLine($"{n} Study people {recs} for {sid} added to DB");
        }

        if (fs.organisations?.Any() == true)
        {
            int n = 0;
            foreach (StudyOrganisation sg in fs.organisations)
            {
                string i_g_contrib = ToIntPar(sg.contrib_type_id);
                string i_g_org_id = ToIntPar(sg.organisation_id);
                string i_g_org = ToStringPar(sg.organisation_name);
                string i_g_org_ror = ToStringPar(sg.organisation_ror_id);

                sqlString = $@"Insert into te.study_organisations(sd_sid, contrib_type_id,  
                organisation_id, organisation_name, organisation_ror_id)
                values ({sid}, {i_g_contrib}, {i_g_org_id}, {i_g_org}, {i_g_org_ror}) ";
                ExecuteSQL(sqlString);
                n++;
            }
            string recs = n == 1 ? "record" : "records";
            _loggingHelper.LogLine($"{n} Study organisation {recs} for {sid} added to DB");
        }

        if (fs.references?.Any() == true)
        {
            int n = 0;
            foreach (StudyReference sr in fs.references)
            {
                string i_pmid = ToStringPar(sr.pmid);
                string i_citation = ToStringPar(sr.citation);
                string i_doi = ToStringPar(sr.doi);
                string i_type = ToIntPar(sr.type_id);
                string i_ref_comms = ToStringPar(sr.comments);

                sqlString = $@"Insert into te.study_references(sd_sid, pmid, citation, 
                doi, type_id, comments)
                values ({sid}, {i_pmid}, {i_citation}, {i_doi}, {i_type}, {i_ref_comms}) ";
                ExecuteSQL(sqlString);
                n++;
            }
            string recs = n == 1 ? "record" : "records";
            _loggingHelper.LogLine($"{n} Study reference {recs} for {sid} added to DB");
        }

        if (fs.topics?.Any() == true)
        {
            int n = 0;
            foreach (StudyTopic st in fs.topics)
            {
                string i_topic_type = ToIntPar(st.topic_type_id);
                string i_topic_ov = ToStringPar(st.original_value);
                string i_ct_type = ToIntPar(st.original_ct_type_id);
                string i_ct_code = ToStringPar(st.original_ct_code);
                string i_mesh_code = ToStringPar(st.mesh_code);
                string i_mesh_value = ToStringPar(st.mesh_value);

                sqlString = $@"Insert into te.study_topics(sd_sid, topic_type_id, original_value, 
                original_ct_type_id, original_ct_code, mesh_code, mesh_value)
                values ({sid}, {i_topic_type}, {i_topic_ov}, 
                {i_ct_type}, {i_ct_code}, {i_mesh_code}, {i_mesh_value}) ";
                ExecuteSQL(sqlString);
                n++;
            }
            string recs = n == 1 ? "record" : "records";
            _loggingHelper.LogLine($"{n} Study topic {recs} for {sid} added to DB");
        }

        if (fs.features?.Any() == true)
        {
            int n = 0;
            foreach (StudyFeature sf in fs.features)
            {
                string i_ft_type = ToIntPar(sf.feature_type_id);
                string i_ft_value = ToIntPar(sf.feature_value_id);

                sqlString = $@"Insert into te.study_features(sd_sid, feature_type_id, feature_value_id)
                values ({sid}, {i_ft_type}, {i_ft_value}) ";
                ExecuteSQL(sqlString);
                n++;
            }
            string recs = n == 1 ? "record" : "records";
            _loggingHelper.LogLine($"{n} Study feature {recs} for {sid} added to DB");
        }

        if (fs.conditions?.Any() == true)
        {
            int n = 0;
            foreach (StudyCondition sc in fs.conditions)
            {

                string i_cond_ov = ToStringPar(sc.original_value);
                string i_ct_type = ToIntPar(sc.original_ct_type_id);
                string i_ct_code = ToStringPar(sc.original_ct_code);
                string i_icd_code = ToStringPar(sc.icd_code);
                string i_icd_value = ToStringPar(sc.icd_name);

                sqlString = $@"Insert into te.study_conditions(sd_sid, original_value, 
                original_ct_type_id, original_ct_code, icd_code, icd_name)
                values ({sid}, {i_cond_ov}, {i_ct_type}, {i_ct_code}, {i_icd_code}, {i_icd_value}) ";
                ExecuteSQL(sqlString);
                n++;
            }
            string recs = n == 1 ? "record" : "records";
            _loggingHelper.LogLine($"{n} Study condition {recs} for {sid} added to DB");
        }

        if (fs.iec?.Any() == true)
        {
            int n = 0;
            foreach (StudyIEC si in fs.iec)
            {
                string i_seq_num = ToIntPar(si.seq_num);
                string i_iec_type = ToIntPar(si.iec_type_id);
                string i_split_type = ToStringPar(si.split_type);
                string i_ldr = ToStringPar(si.leader);
                string i_indent = ToIntPar(si.indent_level);
                string i_seq_string = ToStringPar(si.sequence_string);
                string i_iec_text = ToStringPar(si.iec_text);

                sqlString = $@"Insert into te.study_iec(sd_sid, seq_num, iec_type_id, split_type, 
                leader, indent_level, sequence_string, iec_text)
                values ({sid}, {i_seq_num}, {i_iec_type}, {i_split_type}, 
                {i_ldr}, {i_indent}, {i_seq_string}, {i_iec_text}) ";
                ExecuteSQL(sqlString);
                n++;
            }
            string recs = n == 1 ? "record" : "records";
            _loggingHelper.LogLine($"{n} Study IEC {recs} for {sid} added to DB");
        }

        if (fs.relationships?.Any() == true)
        {
            int n = 0;
            foreach (StudyRelationship sr in fs.relationships)
            {
                string i_rel_type = ToIntPar(sr.relationship_type_id);
                string i_target_sid = ToStringPar(sr.target_sd_sid);

                sqlString = $@"Insert into te.study_relationships(sd_sid, relationship_type_id, 
                target_study_id) values ({sid}, {i_rel_type}, {i_target_sid}) ";
                ExecuteSQL(sqlString);
                n++;
            }
            string recs = n == 1 ? "record" : "records";
            _loggingHelper.LogLine($"{n} Study relationships {recs} for {sid} added to DB");
        }

        if (fs.sites?.Any() == true)
        {
            int n = 0;
            foreach (StudyLocation ss in fs.sites)
            {
                string i_fac_id = ToIntPar(ss.facility_org_id);
                string i_fac = ToStringPar(ss.facility);
                string i_fac_ror = ToStringPar(ss.facility_ror_id);
                string i_city_id = ToIntPar(ss.city_id);
                string i_city = ToStringPar(ss.city_name);
                string i_country_id = ToIntPar(ss.country_id);
                string i_country = ToStringPar(ss.country_name);
                string i_status = ToIntPar(ss.status_id);

                sqlString = $@"Insert into te.study_sites(sd_sid, facility_org_id, facility, facility_ror_id,
                city_id, city_name, country_id, country_name, status_id)
                values ({sid}, {i_fac_id}, {i_fac}, {i_fac_ror}, 
                {i_city_id}, {i_city}, {i_country_id}, {i_country}, {i_status}) ";
                ExecuteSQL(sqlString);
                n++;
            }
            string recs = n == 1 ? "record" : "records";
            _loggingHelper.LogLine($"{n} Study location {recs} for {sid} added to DB");
        }


        if (fs.countries?.Any() == true)
        {
            int n = 0;
            foreach (StudyCountry sc in fs.countries)
            {
                string i_country_id = ToIntPar(sc.country_id);
                string i_country = ToStringPar(sc.country_name);
                string i_status = ToIntPar(sc.status_id);

                sqlString = $@"Insert into te.study_countries(sd_sid, country_id, country_name, status_id)
                values ({sid}, {i_country_id}, {i_country}, {i_status}) ";
                ExecuteSQL(sqlString);
                n++;
            }
            string recs = n == 1 ? "record" : "records";
            _loggingHelper.LogLine($"{n} Study country {recs} for {sid} added to DB");
        }


        if (fs.studylinks?.Any() == true)
        {
            int n = 0;
            foreach (StudyLink sk in fs.studylinks)
            {
                string i_label = ToStringPar(sk.link_label);
                string i_url = ToStringPar(sk.link_url);

                sqlString = $@"Insert into te.study_links(sd_sid, link_label, link_url)
                values ({sid}, {i_label}, {i_url}) ";
                ExecuteSQL(sqlString);
                n++;
            }
            string recs = n == 1 ? "record" : "records";
            _loggingHelper.LogLine($"{n} Study link {recs} for {sid} added to DB");
        }


        if (fs.ipd_info?.Any() == true)
        {
            int n = 0;
            foreach (AvailableIPD sa in fs.ipd_info)
            {
                string i_ipd_id = ToStringPar(sa.ipd_id);
                string i_ipd_type = ToStringPar(sa.ipd_type);
                string i_ipd_url = ToStringPar(sa.ipd_url);
                string i_ipd_comms = ToStringPar(sa.ipd_comment);

                sqlString = $@"Insert into te.study_ipd(sd_sid, ipd_id, ipd_type, ipd_url, ipd_comment)
                values ({sid}, {i_ipd_id}, {i_ipd_type}, {i_ipd_url}, {i_ipd_comms}) ";
                ExecuteSQL(sqlString);
                n++;
            }
            string recs = n == 1 ? "record" : "records";
            _loggingHelper.LogLine($"{n} Study available ipd {recs} for {sid} added to DB");
        }

        // store the study data object components 

        if (fs.data_objects?.Any() == true)
        {
            int n = 0;
            foreach (StudyDataObject sob in fs.data_objects)
            {
                DataObject? dob = sob.data_object;
                ObjectDataset? ds = sob.dataset_details;
                List<ObjectInstance>? obi = sob.object_instances;
                List<ObjectTitle>? obt = sob.object_titles;
                List<ObjectDate>? obd = sob.object_dates;
                string oid = "";
                if (dob is not null)
                {
                    oid = ToStringPar(dob.sd_oid);
                    string i_sd_sid = ToStringPar(dob.sd_sid);
                    string i_ob_title = ToStringPar(dob.title);
                    string i_version = ToStringPar(dob.version);
                    string i_disp_title = ToStringPar(dob.display_title);
                    string i_doi = ToStringPar(dob.doi);
                    string i_doi_status = ToIntPar(dob.doi_status_id);
                    string i_pub_year = ToIntPar(dob.publication_year);
                    string i_ob_class_id = ToIntPar(dob.object_class_id);
                    string i_ob_type_id = ToIntPar(dob.object_type_id);
                    string i_man_org_id = ToIntPar(dob.managing_org_id);
                    string i_man_org = ToStringPar(dob.managing_org);
                    string i_man_org_ror = ToStringPar(dob.managing_org_ror_id);
                    string i_ob_lang_code = ToStringPar(dob.lang_code);
                    string i_access_type = ToIntPar(dob.access_type_id);
                    string i_access_dets = ToStringPar(dob.access_details);
                    string i_access_dets_url = ToStringPar(dob.access_details_url);
                    string i_eosc_cat = ToIntPar(dob.eosc_category);
                    string i_add_s_contribs = ToBoolPar(dob.add_study_contribs);
                    string i_add_s_topics = ToBoolPar(dob.add_study_topics);

                    sqlString = $@"Insert into te.data_objects(sd_oid, sd_sid, title, version, display_title, 
                    doi, doi_status_id, publication_year, object_class_id, object_type_id, 
                    managing_org_id, managing_org, managing_org_ror_id, lang_code, access_type_id, 
                    access_details, access_details_url, eosc_category, 
                    add_study_contribs, add_study_topics) 
                    values({oid}, {i_sd_sid}, {i_ob_title}, {i_version}, {i_disp_title}, 
                    {i_doi}, {i_doi_status}, {i_pub_year}, {i_ob_class_id},
                    {i_ob_type_id}, {i_man_org_id}, {i_man_org}, 
                    {i_man_org_ror}, {i_ob_lang_code}, {i_access_type}, {i_access_dets}, 
                    {i_access_dets_url}, {i_eosc_cat}, {i_add_s_contribs}, {i_add_s_topics} )";
                    ExecuteSQL(sqlString);
                    _loggingHelper.LogLine($"Data object record for {oid} added to DB");
                    n++;
                }

                if (ds is not null)
                {
                    string i_rk_type = ToIntPar(ds.record_keys_type_id);
                    string i_rk_dets = ToStringPar(ds.record_keys_details);
                    string i_di_type = ToIntPar(ds.deident_type_id);
                    string i_di_direct = ToBoolPar(ds.deident_direct);
                    string i_di_hipaa = ToBoolPar(ds.deident_hipaa);
                    string i_di_dates = ToBoolPar(ds.deident_dates);
                    string i_di_nonarr = ToBoolPar(ds.deident_nonarr);
                    string i_di_kanon = ToBoolPar(ds.deident_kanon);
                    string i_di_dets = ToStringPar(ds.deident_details);
                    string i_cn_type = ToIntPar(ds.consent_type_id);
                    string i_cn_noncom = ToBoolPar(ds.consent_noncommercial);
                    string i_cn_geog = ToBoolPar(ds.consent_geog_restrict);
                    string i_cn_res_type = ToBoolPar(ds.consent_research_type);
                    string i_cn_gen_only = ToBoolPar(ds.consent_genetic_only);
                    string i_cn_no_methods = ToBoolPar(ds.consent_no_methods);
                    string i_cn_dets = ToStringPar(ds.consent_details);

                    sqlString = $@"Insert into te.object_datasets(sd_oid, record_keys_type_id, 
                    record_keys_details, deident_type_id, deident_direct, deident_hipaa, 
                    deident_dates, deident_nonarr, deident_kanon, deident_details, consent_type_id,
                    consent_noncommercial, consent_geog_restrict, consent_research_type, 
                    consent_genetic_only, consent_no_methods, consent_details) 
                    values({oid}, {i_rk_type}, {i_rk_dets}, {i_di_type}, 
                    {i_di_direct}, {i_di_hipaa}, {i_di_dates}, {i_di_nonarr}, 
                    {i_di_kanon}, {i_di_dets}, {i_cn_type}, {i_cn_noncom}, 
                    {i_cn_geog}, {i_cn_res_type}, {i_cn_gen_only}, 
                    {i_cn_no_methods}, {i_cn_dets} )";
                    ExecuteSQL(sqlString);
                    _loggingHelper.LogLine($"Dataset record for {oid} added to DB");
                }

                if (obi?.Any() == true)
                {
                    int nn = 0;
                    foreach (ObjectInstance oi in obi)
                    {
                        string i_system_id = ToIntPar(oi.system_id);
                        string i_system = ToStringPar(oi.system);
                        string i_url = ToStringPar(oi.url);
                        string i_accessible = ToBoolPar(oi.url_accessible);
                        string i_res_type = ToIntPar(oi.resource_type_id);
                        string i_res_size = ToStringPar(oi.resource_size);
                        string i_res_units = ToStringPar(oi.resource_size_units);
                        string i_res_comms = ToStringPar(oi.resource_comments);

                        sqlString = $@"Insert into te.object_instances(sd_oid, system_id, system, 
                        url, url_accessible, resource_type_id, resource_size, 
                        resource_size_units, resource_comments )
                        values ({oid}, {i_system_id}, {i_system}, {i_url}, {i_accessible}, 
                        {i_res_type}, {i_res_size}, {i_res_units}, {i_res_comms}) ";
                        ExecuteSQL(sqlString);
                        nn++;
                    }
                    string nrecs = nn == 1 ? "record" : "records";
                    _loggingHelper.LogLine($"{nn} object instance {nrecs} for {oid} added to DB");
                }

                if (obt?.Any() == true)
                {
                    int nn = 0;
                    foreach (ObjectTitle ot in obt)
                    {
                        string i_tt_type = ToIntPar(ot.title_type_id);
                        string i_tt_text = ToStringPar(ot.title_text);
                        string i_tt_lang = ToStringPar(ot.lang_code);
                        string i_tt_lang_use = ToIntPar(ot.lang_usage_id);
                        string i_tt_default = ToBoolPar(ot.is_default);
                        string i_tt_comms = ToStringPar(ot.comments);

                        sqlString = $@"Insert into te.object_titles(sd_oid, title_type_id, title_text, 
                        lang_code, lang_usage_id, is_default, comments)
                        values ({oid}, {i_tt_type}, {i_tt_text}, {i_tt_lang}, 
                        {i_tt_lang_use}, {i_tt_default}, {i_tt_comms}) ";
                        ExecuteSQL(sqlString);
                        nn++;
                    }
                    string nrecs = nn == 1 ? "record" : "records";
                    _loggingHelper.LogLine($"{nn} object title {nrecs} for {oid} added to DB");
                }

                if (obd?.Any() == true)
                {
                    int nn = 0;
                    foreach (ObjectDate od in obd)
                    {
                        string i_dt_type = ToIntPar(od.date_type_id);
                        string i_is_range = ToBoolPar(od.date_is_range);
                        string i_dt_as_string = ToStringPar(od.date_as_string);
                        string i_sy = ToIntPar(od.start_year);
                        string i_sm = ToIntPar(od.start_month);
                        string i_sd = ToIntPar(od.start_day);
                        string i_ey = ToIntPar(od.end_year);
                        string i_em = ToIntPar(od.end_month);
                        string i_ed = ToIntPar(od.end_day);
                        string i_dt_dets = ToStringPar(od.details);

                        sqlString = $@"Insert into te.object_dates(sd_oid, date_type_id, date_is_range, 
                        date_as_string, start_year, start_month, start_day, end_year, end_month, end_day, details)
                        values ({oid}, {i_dt_type}, {i_is_range}, {i_dt_as_string}, 
                        {i_sy}, {i_sm}, {i_sd}, {i_ey}, {i_em}, {i_ed}, {i_dt_dets}) ";
                        ExecuteSQL(sqlString);
                        nn++;
                    }
                    string nrecs = nn == 1 ? "record" : "records";
                    _loggingHelper.LogLine($"{nn} object date {nrecs} for {oid} added to DB");
                }
            }
            string recs = n == 1 ? "record" : "records";
            _loggingHelper.LogLine($"{n} Data Object {recs} for {sid} added to DB");
        }
    }

    private void StoreObjectComponents(FullDataObject fdo)
    {
        
    }

}
