namespace MDR_Tester;


public class TableResults
{
    public string header { get; set; }
    public string table_name { get; set; }
    public string table_type { get; set; }    
    public bool data_present { get; set; }
    public bool rec_num_mismatch_allowed { get; set; }
    public int num_exp_recs { get; set; }
    public int num_act_recs { get; set; }
    public int num_issues { get; set; }

    public List<RecordResults> record_results{ get; set; }
    
    public TableResults(string _header, string _table_name, string _table_type, bool _rec_num_mismatch_allowed)
    {
        header = _header;
        table_name = _table_name;
        table_type = _table_type;
        rec_num_mismatch_allowed = _rec_num_mismatch_allowed;
        num_issues = 0;
        record_results = new List<RecordResults>();
    }
}

public class RecordResults
{
    public string table_name { get; set; }
    public string table_id_type { get; set; }
    public string record_id { get; set; }
    public string? key_field { get; set; }
    public string? key_field_type { get; set; }
    public string? key_field_value { get; set; }
    public string? key_field2 { get; set; }
    public string? key_field2_type { get; set; }
    public string? key_field2_value { get; set; }
    public string? key_field_header { get; set; }
    public string where_clause { get; set; }
    public int num_issues { get; set; }
    public List<FieldResult> fields{ get; set; }
    
    // used for the studies and data object tables
    
    public RecordResults(TableResults tr, string _record_id, string _key_field_type)
    {
        table_name = tr.table_name;
        table_id_type = tr.table_type == "study" ? "sd_sid" : "sd_oid";
        record_id = _record_id;
        key_field_type = _key_field_type;
        where_clause = _key_field_type == "string"
            ? $" where {table_id_type} = '{record_id}'"
            : $" where {table_id_type} = {record_id}";
        num_issues = 0;
        fields = new List<FieldResult>();
    }
    
    // used for most other tables, that require an additional key field
    
    public RecordResults(TableResults tr, string _record_id, string _key_field_header, 
        string _key_field, string _key_field_type, string? _key_field_value)
    {
        table_name = tr.table_name;
        table_id_type = tr.table_type == "study" ? "sd_sid" : "sd_oid";
        record_id = _record_id;
        key_field_header = _key_field_header;        
        key_field = _key_field;
        key_field_type = _key_field_type;
        key_field_value = _key_field_value;
        where_clause = _key_field_type == "string"
            ? $" where {table_id_type} ='{record_id}' and {key_field} = '{key_field_value}'"
            : $" where {table_id_type} ='{record_id}' and {key_field} = {key_field_value}";
        num_issues = 0; 
        fields = new List<FieldResult>();
    }
    
    // used for a few tables, that require an second key field
    // types are either two strings or a string followed by an int
    
    public RecordResults(TableResults tr, string _record_id, string _key_field_header, 
        string _key_field, string _key_field_type, string? _key_field_value, 
        string _key_field2, string _key_field2_type, string? _key_field2_value)
    {
        table_name = tr.table_name;
        table_id_type = tr.table_type == "study" ? "sd_sid" : "sd_oid";
        record_id = _record_id;
        key_field_header = _key_field_header;        
        key_field = _key_field;
        key_field_type = _key_field_type;
        key_field_value = _key_field_value;
        key_field2 = _key_field2;
        key_field2_type = _key_field2_type;
        key_field2_value = _key_field2_value;
        where_clause = (_key_field_type == "string" && _key_field2_type == "string")
            ? $" where {table_id_type} ='{record_id}' and {key_field} = '{key_field_value}' and {key_field2} = '{key_field2_value}'"
            : $" where {table_id_type} ='{record_id}' and {key_field} = '{key_field_value}' and {key_field2} = {key_field2_value}";
        num_issues = 0;
        fields = new List<FieldResult>();
    }
}


public class FieldResult
{
    public string field_name { get; set; }
    public int res { get; set; }        // 0 = no issue, 1 = a mismatch
    public string exp_value { get; set; }
    public string act_value { get; set; }
    public bool use_new_line { get; set; }

    public FieldResult(string fieldName, int _res, string fieldE, string fieldA, bool _use_new_line)
    {
        field_name = fieldName;
        res = _res;
        exp_value = fieldE;
        act_value = fieldA;
        use_new_line = _use_new_line;
    }
    
}


public class ObjectDateDets
{
    public string? date_as_string { get; set; }
    public string? date_type_id { get; set; }
}

public class CitationData
{
    public string? pmid { get; set; }
    public string? citation { get; set; }
}

public class IPDData
{
    public string? ipd_id { get; set; }
    public string? ipd_type { get; set; }
}