using Dapper;
using Npgsql;

namespace MDR_Tester;

public class TestReportHelper
{
    private readonly ILoggingHelper _loggingHelper;
    private readonly string _connString;
    private readonly int _fbLevel;

    public TestReportHelper(Source source, ILoggingHelper loggingHelper, int fbLevel)
    {
        _loggingHelper = loggingHelper;
        _connString = source.db_conn!;
        _fbLevel = fbLevel;
    }

    public TableResults CompareAttNumbers(TableResults tr, string where_clause)
    {
        using NpgsqlConnection conn = new(_connString);        
        
        string exp_sql_string = $"select count(*) from te.{tr.table_name} " + where_clause;
        tr.num_exp_recs = conn.ExecuteScalar<int>(exp_sql_string);
        
        string act_sql_string = $"select count(*) from ad.{tr.table_name} " + where_clause;
        tr.num_act_recs = conn.ExecuteScalar<int>(act_sql_string);

        if (tr.num_exp_recs > 0 || tr.num_act_recs > 0)
        {
            tr.data_present = true;
        }
        if (tr.num_exp_recs != tr.num_act_recs)
        {
            if (!tr.rec_num_mismatch_allowed)   // in some cases mismatch OK
            {
                tr.num_issues++;
            }
        }
        return tr;
    }

    
    public RecordResults CompareField(RecordResults rr, string fieldName, string fieldType, 
             bool use_new_line = false)
    {
        using NpgsqlConnection conn = new(_connString);   
        string exp_sql_string = $"select {fieldName} from te.{rr.table_name} {rr.where_clause}";
        string act_sql_string = $"select {fieldName} from ad.{rr.table_name} {rr.where_clause}";
        string expVal = "", actVal = "";
        switch (fieldType)
        {
            case "string":
            {
                expVal = conn.QueryFirstOrDefault<string?>(exp_sql_string) ?? "null";
                actVal  = conn.QueryFirstOrDefault<string?>(act_sql_string) ?? "null";
                break;
            }
            case "int":
            {
                expVal = conn.QueryFirstOrDefault<int?>(exp_sql_string)?.ToString() ?? "null";
                actVal  = conn.QueryFirstOrDefault<int?>(act_sql_string)?.ToString() ?? "null";
                break;
            }
            case "bool":
            {
                expVal = conn.QueryFirstOrDefault<bool?>(exp_sql_string)?.ToString() ?? "null";
                actVal  = conn.QueryFirstOrDefault<bool?>(act_sql_string)?.ToString() ?? "null";
                break;
            }
        }

        int res; 
        if (expVal == "null" && actVal == "null")
        {
            res = 0;
        }
        else
        {
            res = expVal == actVal ? 0 : 1;
        }
        rr.fields.Add(new FieldResult(fieldName, res, expVal, actVal, use_new_line));
        rr.num_issues += res;
        return rr;
    }
    
    
    public void write_results(TableResults tr)
    {
        bool rec_num_equal = tr.num_exp_recs == tr.num_act_recs;

        if (_fbLevel == 0)
        {
            // write out all comparisons for each field, for each record, in each table
            // Start with the attribute count (number oof issues not relevant to the feedback
            // format but no data is presented as such
            
            _loggingHelper.LogTableHeader(tr.header);
            if (tr.num_issues > 0)
            {
                string add_s = tr.num_issues > 1 ? "s" : "";
                _loggingHelper.LogLine($"!!!!! {tr.num_issues} issue{add_s} found !!!!!"); 
            }
            
            if (!tr.data_present)
            {
                _loggingHelper.LogLine("No data present"); 
            }
            else
            {
                if (tr.num_exp_recs != -1)    // -1 indicates single study or data object record
                {
                    if (rec_num_equal)
                    {
                        _loggingHelper.LogLine($"Record number check: PASS ({tr.num_exp_recs} expected and found)");
                    }
                    else
                    {
                        if (tr.rec_num_mismatch_allowed) // in some cases mismatch OK
                        {
                            string check_fb = $"({tr.num_exp_recs} expected, {tr.num_act_recs} found)\n";
                            check_fb += "but expected may be a deliberate subset of actual, and no error is implied.";
                            _loggingHelper.LogLine("Record number check: " + check_fb);
                        }
                        else
                        {
                            _loggingHelper.LogLine($"Record number check: FAIL ({tr.num_exp_recs} expected, {tr.num_act_recs} found) !!!!!");
                        }
                    }
                }

                if (tr.record_results.Any())
                {
                    foreach (RecordResults rr in tr.record_results)
                    {
                        if (rr.key_field is not null)    // null if a whole study or data object record
                        {
                            _loggingHelper.LogLine($"{rr.key_field_header} : {rr.key_field_value}");
                        }

                        if (rr.fields.Any())
                        {
                            foreach (FieldResult ff in rr.fields)
                            {
                                if (ff is { exp_value: "null", act_value: "null" })
                                {
                                    _loggingHelper.LogLine(
                                        $"{ff.field_name}: PASS - both NULL");
                                }
                                else
                                {
                                    if (ff.exp_value == ff.act_value)
                                    {
                                        _loggingHelper.LogLine(
                                            $"{ff.field_name}: PASS: both are: {ff.exp_value}");
                                    }
                                    else
                                    {
                                        _loggingHelper.LogBlank();
                                        _loggingHelper.LogLine($"{ff.field_name}: FAIL: !!!!!");
                                        _loggingHelper.LogLine($"e: {ff.exp_value} ");
                                        _loggingHelper.LogLine($"a: {ff.act_value}");
                                        _loggingHelper.LogBlank();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        if (_fbLevel == 1)
        {
            // write out all issues for each record in each table
            // If there are no issues for a particular record report that on a single line
            
            _loggingHelper.LogTableHeader(tr.header);
            if (tr.num_issues > 0)
            {
                string add_s = tr.num_issues > 1 ? "s" : "";
                _loggingHelper.LogLine($"!!!!! {tr.num_issues} issue{add_s} found !!!!!"); 
            }
            
            if (!tr.data_present)
            {
                _loggingHelper.LogLine("No data present");
            }
            else
            {
                if (tr.num_exp_recs != -1)    // -1 indicates single study or data object record
                {
                    if (rec_num_equal)
                    {
                        _loggingHelper.LogLine($"Record number check: PASS ({tr.num_exp_recs} expected and found)");
                    }
                    else
                    {
                        if (tr.rec_num_mismatch_allowed) // in some cases mismatch OK
                        {
                            string check_fb = $"({tr.num_exp_recs} expected, {tr.num_act_recs} found)\n";
                            check_fb += "but expected may be a deliberate subset of actual, and no error is implied.";
                            _loggingHelper.LogLine("Record number check: " + check_fb);
                        }
                        else
                        {
                            _loggingHelper.LogLine($"Record number check: FAIL ({tr.num_exp_recs} expected, {tr.num_act_recs} found) !!!!!");
                        }
                    }
                }

                if (tr.record_results.Any())
                {
                    foreach (RecordResults rr in tr.record_results)
                    {
                        if (rr.key_field is not null) // null if a whole study or data object record
                        {
                            _loggingHelper.LogLine($"{rr.key_field_header} : {rr.key_field_value}");
                        }

                        if (rr.num_issues > 0)
                        { 
                            string add_s = rr.num_issues > 1 ? "s" : "";
                            _loggingHelper.LogLine($"{rr.num_issues} issue{add_s} found:");
                            
                            if (rr.fields.Any())
                            {
                                foreach (FieldResult ff in rr.fields)
                                {
                                    if (ff.res == 1)
                                    {
                                        _loggingHelper.LogBlank();
                                        string possNL = ff.use_new_line ? "\n" : "";
                                        string feedback = $"{ff.field_name}: FAIL: ";
                                        feedback += $"{possNL}e: {ff.exp_value} {possNL}a: {ff.act_value}";
                                        _loggingHelper.LogLine(feedback);
                                        _loggingHelper.LogBlank();
                                    } 
                                }
                            }
                        }
                        else
                        {
                            _loggingHelper.LogLine("No issues");
                        }
                    }
                }
            }
        }
  
        
        if (_fbLevel == 2)
        {
            // no data or no issues reported on a single line
            
            if (tr.num_exp_recs != -1) // -1 indicates single study or data object record
            {
                _loggingHelper.LogBlank();
            }

            if (!tr.data_present)
            {
                string fb = tr.header + ": No data";
                _loggingHelper.LogLine(fb); 
            }
            else
            {
                if (tr.num_issues == 0)
                {
                    _loggingHelper.LogLine(tr.header + ": No issues found");
                }
                else
                {
                    string add_s = tr.num_issues > 1 ? "s" : "";
                    _loggingHelper.LogLine(tr.header + $": !!!!! {tr.num_issues} issue{add_s} found !!!!!");
                }
                
                if (!rec_num_equal)
                {
                    if (tr.rec_num_mismatch_allowed) // in some cases mismatch OK
                    {
                        string check_fb = $"({tr.num_exp_recs} expected, {tr.num_act_recs} found)\n";
                        check_fb += "but expected may be a deliberate subset of actual, and no error is implied.";
                        _loggingHelper.LogLine("Record number check: " + check_fb);
                    }
                    else
                    {
                        _loggingHelper.LogLine($"Record number check: FAIL ({tr.num_exp_recs} expected, {tr.num_act_recs} found) !!!!!");
                    }
                }

                if (tr.record_results.Any())
                {
                    foreach (RecordResults rr in tr.record_results)
                    {
                        if (rr.key_field is not null) // null if a whole study or data object record
                        {
                            string record_header = $"{rr.key_field_header} : {rr.key_field_value}";
                            if (rr.num_issues > 0)
                            {
                                string add_s = rr.num_issues > 1 ? "s" : "";
                                _loggingHelper.LogLine($"{record_header}: {rr.num_issues} issue{add_s} found:");
                            }
                            else
                            {
                                _loggingHelper.LogLine(record_header + ": No issues");
                            }
                        }
                        
                        if (rr.num_issues > 0)
                        {
                            if (rr.fields.Any())
                            {
                                foreach (FieldResult ff in rr.fields)
                                {
                                    if (ff.res == 1)
                                    {
                                        string possNL = ff.use_new_line ? "\n" : "";
                                        string feedback = $"{ff.field_name}: FAIL: {possNL}e: {ff.exp_value} {possNL}a: {ff.act_value}";
                                        _loggingHelper.LogLine(feedback);
                                        _loggingHelper.LogBlank();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        if (_fbLevel == 3)
        {
            // Exception reporting only. Tables and records that are fine are ignored.

            if (tr.num_issues > 0)
            {
                string add_s = tr.num_issues > 1 ? "s" : "";
                _loggingHelper.LogLine(tr.header + $": !!!!! {tr.num_issues} issue{add_s} found !!!!!");
            }

            if (!rec_num_equal)
            {
                if (!tr.rec_num_mismatch_allowed) // in some cases mismatch OK
                {
                    _loggingHelper.LogLine(
                        $"Record number check: FAIL ({tr.num_exp_recs} expected, {tr.num_act_recs} found) !!!!!");
                }
            }

            if (tr.record_results.Any())
            {
                foreach (RecordResults rr in tr.record_results)
                {
                    if (rr.num_issues > 0)
                    {
                        if (rr.key_field is not null) // null if a whole study or data object record
                        {
                            string record_header = $"{rr.key_field_header} : {rr.key_field_value}";
                            string add_s = rr.num_issues > 1 ? "s" : "";
                            _loggingHelper.LogLine($"{record_header}: {rr.num_issues} issue{add_s} found:");
                        }

                        foreach (FieldResult ff in rr.fields.Where(ff => ff.res == 1))
                        {
                            string possNL = ff.use_new_line ? "\n" : "";
                            string feedback = $"{ff.field_name}: FAIL: {possNL}e: {ff.exp_value} {possNL}a: {ff.act_value}";
                            _loggingHelper.LogLine(feedback);
                            _loggingHelper.LogBlank();
                        }
                    }
                }
            }
        }
    }

    
    public int? GetStudyStartYear(string sd_id)
    {
        using NpgsqlConnection conn = new(_connString);    
        string sql_string = $"select study_start_year from te.studies where sd_sid = '{sd_id}'";
        return conn.QuerySingle<int?>(sql_string);
    }
    
    public List<string>? FetchObjectOIDs(string sd_id)
    {
        using NpgsqlConnection conn = new(_connString);    
        string sql_string = $"select sd_oid from te.data_objects where sd_sid = '{sd_id}'";
        return conn.Query<string>(sql_string)?.ToList() ;
    }
    
    public List<string>? FetchStudyIdValues(string sd_id)
    {
        using NpgsqlConnection conn = new(_connString);
        string sql_string = @$"select identifier_value from te.study_identifiers where sd_sid = '{sd_id}'
               union
               select identifier_value from ad.study_identifiers where sd_sid = '{sd_id}'";
        return conn.Query<string>(sql_string)?.ToList() ;
    }
    
    public List<string>? FetchStudyTitleValues(string sd_id)
    {
        using NpgsqlConnection conn = new(_connString);
        string sql_string = @$"select title_text from te.study_titles where sd_sid = '{sd_id}'
               union
               select title_text from ad.study_titles where sd_sid = '{sd_id}'";
        return conn.Query<string>(sql_string)?.ToList() ;
    }
    
    public List<string>? FetchStudyPeopleValues(string sd_id)
    {
        using NpgsqlConnection conn = new(_connString);
        string sql_string = @$"select person_full_name from te.study_people where sd_sid = '{sd_id}'
               union
               select person_full_name from ad.study_people where sd_sid = '{sd_id}'";
        return conn.Query<string>(sql_string)?.ToList() ;
    }
    
    public List<string>? FetchStudyOrgValues(string sd_id)
    {
        using NpgsqlConnection conn = new(_connString);
        string sql_string = @$"select organisation_name from te.study_organisations where sd_sid = '{sd_id}'
               union
               select organisation_name from ad.study_organisations where sd_sid = '{sd_id}'";
        return conn.Query<string>(sql_string)?.ToList() ;
    }
    
    public List<string>? FetchStudyTopics(string sd_id)
    {
        using NpgsqlConnection conn = new(_connString);
        string sql_string = @$"select original_value from te.study_topics where sd_sid = '{sd_id}'
               union
               select original_value from ad.study_topics where sd_sid = '{sd_id}'";
        return conn.Query<string>(sql_string)?.ToList() ;
    }

    public List<string>? FetchStudyConditions(string sd_id)
    {
        using NpgsqlConnection conn = new(_connString);
        string sql_string = @$"select original_value from te.study_conditions where sd_sid = '{sd_id}'
               union
               select original_value from ad.study_conditions where sd_sid = '{sd_id}'";
        return conn.Query<string>(sql_string)?.ToList() ;
    }

    public List<string>? FetchStudyFeatures(string sd_id)
    {
        using NpgsqlConnection conn = new(_connString);
        string sql_string = @$"select feature_value_id::varchar from te.study_features where sd_sid = '{sd_id}'
               union
               select feature_value_id::varchar from ad.study_features where sd_sid = '{sd_id}'";
        return conn.Query<string>(sql_string)?.ToList() ;
    }
    
    public List<string>? FetchStudyReferences(string sd_id)
    {
        using NpgsqlConnection conn = new(_connString);
        // expected references tested only, as often only a subset 'expected'
        string sql_string = @$"select citation from te.study_references where sd_sid = '{sd_id}'";
        return conn.Query<string>(sql_string)?.ToList() ;
    }

    
    public List<string>? FetchStudyRelationships(string sd_id)
    {
        using NpgsqlConnection conn = new(_connString);
        string sql_string = @$"select target_sd_sid from te.study_relationships where sd_sid = '{sd_id}'
               union
               select target_sd_sid from ad.study_relationships where sd_sid = '{sd_id}'";
        return conn.Query<string>(sql_string)?.ToList() ;
    }
    
    
    public List<string>? FetchStudyLinks(string sd_id)
    {
        using NpgsqlConnection conn = new(_connString);
        string sql_string = @$"select link_label from te.study_links where sd_sid = '{sd_id}'
               union
               select link_label from ad.study_links where sd_sid = '{sd_id}'";
        return conn.Query<string>(sql_string)?.ToList() ;
    }
    
    
    public List<string>? FetchStudyCountries(string sd_id)
    {
        using NpgsqlConnection conn = new(_connString);
        string sql_string = @$"select country_name from te.study_countries where sd_sid = '{sd_id}'
               union
               select country_name from ad.study_countries where sd_sid = '{sd_id}'";
        return conn.Query<string>(sql_string)?.ToList() ;
    }
    
    
    public List<string>? FetchStudyLocations(string sd_id)
    {
        using NpgsqlConnection conn = new(_connString);
        // expected locations tested only, as often only a subset 'expected'
        string sql_string = @$"select facility from te.study_locations where sd_sid = '{sd_id}'";
        return conn.Query<string>(sql_string)?.ToList() ;
    }
    
    
    public List<string>? FetchStudyIPDAvailable(string sd_id)
    {
        using NpgsqlConnection conn = new(_connString);
        string sql_string = @$"select ipd_id from te.study_ipd_available where sd_sid = '{sd_id}'
               union
               select ipd_id from ad.study_ipd_available where sd_sid = '{sd_id}'";
        return conn.Query<string>(sql_string)?.ToList() ;
    }
    
    
    public List<string>? FetchStudyIEC(string sd_id, string table_name)
    {
        using NpgsqlConnection conn = new(_connString);
        string sql_string = @$"select seq_num::varchar from te.{table_name} where sd_sid = '{sd_id}'
               union
               select seq_num::varchar from ad.{table_name} where sd_sid = '{sd_id}'
               order by seq_num";
        return conn.Query<string>(sql_string)?.ToList() ;
    }
    
    
    
    
    public List<string>? FetchObjectInstanceValues(string sd_id)
    {
        using NpgsqlConnection conn = new(_connString);
        string sql_string = @$"select url from te.object_instances where sd_oid = '{sd_id}'
               union
               select url from ad.object_instances where sd_oid = '{sd_id}'";
        return conn.Query<string>(sql_string)?.ToList() ;
    }
    
    public List<string>? FetchObjectTitleValues(string sd_id)
    {
        using NpgsqlConnection conn = new(_connString);
        string sql_string = @$"select title_text from te.object_titles where sd_oid = '{sd_id}'
               union
               select title_text from ad.object_titles where sd_oid = '{sd_id}'";
        return conn.Query<string>(sql_string)?.ToList() ;
    }
    
    public List<string>? FetchObjectDateValues(string sd_id)
    {
        using NpgsqlConnection conn = new(_connString);
        string sql_string = @$"select date_as_string from te.object_dates where sd_oid = '{sd_id}'
               union
               select date_as_string from ad.object_dates where sd_oid = '{sd_id}'";
        return conn.Query<string>(sql_string)?.ToList() ;
    }
    
    public List<string>? FetchObjectPeopleValues(string sd_id)
    {
        using NpgsqlConnection conn = new(_connString);
        string sql_string = @$"select person_full_name from te.object_people where sd_oid = '{sd_id}'
               union
               select person_full_name from ad.object_people where sd_oid = '{sd_id}'";
        return conn.Query<string>(sql_string)?.ToList() ;
    }
    
    public List<string>? FetchObjectOrgValues(string sd_id)
    {
        using NpgsqlConnection conn = new(_connString);
        string sql_string = @$"select organisation_name from te.object_organisations where sd_oid = '{sd_id}'
               union
               select organisation_name from ad.object_organisations where sd_oid = '{sd_id}'";
        return conn.Query<string>(sql_string)?.ToList() ;
    }
    
    public List<string>? FetchObjectTopicValues(string sd_id)
    {
        using NpgsqlConnection conn = new(_connString);
        string sql_string = @$"select original_value from te.object_topics where sd_oid = '{sd_id}'
               union
               select original_value from ad.object_topics where sd_oid = '{sd_id}'";
        return conn.Query<string>(sql_string)?.ToList() ;
    }
    
    public List<string>? FetchObjectCommentsValues(string sd_id)
    {
        using NpgsqlConnection conn = new(_connString);
        string sql_string = @$"select pmid from te.object_comments where sd_oid = '{sd_id}'
               union
               select pmid from ad.object_comments where sd_oid = '{sd_id}'";
        return conn.Query<string>(sql_string)?.ToList() ;
    }
    
    public List<string>? FetchObjectDescriptionsValues(string sd_id)
    {
        using NpgsqlConnection conn = new(_connString);
        string sql_string = @$"select description_text from te.object_descriptions where sd_oid = '{sd_id}'
               union
               select description_text from ad.object_descriptions where sd_oid = '{sd_id}'";
        return conn.Query<string>(sql_string)?.ToList() ;
    }
    
    public List<string>? FetchObjectIdValues(string sd_id)
    {
        using NpgsqlConnection conn = new(_connString);
        string sql_string = @$"select identifier_value from te.object_identifiers where sd_oid = '{sd_id}'
               union
               select identifier_value from ad.object_identifiers where sd_oid = '{sd_id}'";
        return conn.Query<string>(sql_string)?.ToList() ;
    }
    
    public List<string>? FetchObjectDBLinkValues(string sd_id)
    {
        using NpgsqlConnection conn = new(_connString);
        string sql_string = @$"select id_in_db from te.object_db_links where sd_oid = '{sd_id}'
               union
               select id_in_db from ad.object_db_links where sd_oid = '{sd_id}'";
        return conn.Query<string>(sql_string)?.ToList() ;
    }
    
    public List<string>? FetchObjectPubTypeValues(string sd_id)
    {
        using NpgsqlConnection conn = new(_connString);
        string sql_string = @$"select type_name from te.object_pub_types where sd_oid = '{sd_id}'
               union
               select type_name from ad.object_pub_types where sd_oid = '{sd_id}'";
        return conn.Query<string>(sql_string)?.ToList() ;
    }
    
    public List<string>? FetchObjectRelationshipValues(string sd_id)
    {
        using NpgsqlConnection conn = new(_connString);
        string sql_string = @$"select target_sd_oid from te.object_relationships where sd_oid = '{sd_id}'
               union
               select target_sd_oid from ad.object_relationships where sd_oid = '{sd_id}'";
        return conn.Query<string>(sql_string)?.ToList() ;
    }
    
    public List<string>? FetchObjectRightsValues(string sd_id)
    {
        using NpgsqlConnection conn = new(_connString);
        string sql_string = @$"select rights_name from te.object_rights where sd_oid = '{sd_id}'
               union
               select rights_name from ad.object_rights where sd_oid = '{sd_id}'";
        return conn.Query<string>(sql_string)?.ToList() ;
    }
    
}