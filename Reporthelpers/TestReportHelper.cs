using Dapper;
using Npgsql;

namespace MDR_Tester;

public class TestReportHelper
{
    private readonly ILoggingHelper _loggingHelper;
    private readonly string _connString;

    public TestReportHelper(Source source, ILoggingHelper loggingHelper)
    {
        _loggingHelper = loggingHelper;
        _connString = source.db_conn!;
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
            tr.num_issues++;
        }

        //bool res = expNum == actNum;
        //string feedback = expNum == actNum ? $" PASS ({expNum})" : $" FAIL (e: {expNum}, a: {actNum}) !!!!!!!!!";
        //string res_string = $"Table: {tr.table_name}; Record number check: {feedback}";
        return tr;
    }

    
    public TableResults CompareField(TableResults tr, string fieldName, string fieldType, 
             string where_clause, bool use_new_line = false)
    {
        using NpgsqlConnection conn = new(_connString);    
        string exp_sql_string = $"select {fieldName} from te.{tr.table_name} " + where_clause;
        string act_sql_string = $"select {fieldName} from ad.{tr.table_name} " + where_clause;
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
        //string feedback;
        if (expVal == "null" && actVal == "null")
        {
            res = 0;
            //feedback = " PASS (both NULL)";
        }
        else
        {
            //string possNL = use_new_line ? "\n" : "";
            if (expVal == actVal)
            {
                res = 0;
                //feedback = $" PASS (both: {possNL}{expVal})";
            }
            else
            {
                res = 1;
                //feedback = $" FAIL (e: {possNL}{expVal} : a: {possNL}{actVal})";
            }
        }
        //string resString = $"{fieldName} => Result: {feedback}";
        //_loggingHelper.LogLine(resString);
        tr.fields.Add(new FieldResult(fieldName, res, expVal, actVal, use_new_line));
        
        return tr;
    }
    
    public void write_results(TableResults tr)
    {
        // table header etc. depending on fb level
        if (tr.data_present)
        {
            if (tr.num_issues == 0)
            {
                _loggingHelper.LogLine("no issues");
            }
            
        }
        else
        {
            // table etc. depending on fb level
            _loggingHelper.LogLine("No data present");
        }
        
        /*
        if (issues == 0)
        {
            _loggingHelper.LogLine("No issues found!");
        }
        else
        {
            string issue_string = issues == 1 ? "issue" : "issues";
            _loggingHelper.LogLine($"{issues} {issue_string} found");
        }
        */
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
    
    
}