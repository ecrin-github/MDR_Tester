﻿namespace MDR_Tester;

public class FullStudy
{
    public Study? study { get; set; }
    public List<StudyIdentifier>? identifiers { get; set; }
    public List<StudyTitle>? titles { get; set; }
    public List<StudyPerson>? people { get; set; }
    public List<StudyOrganisation>? organisations { get; set; }
    public List<StudyReference>? references { get; set; }
    public List<StudyTopic>? topics { get; set; }
    public List<StudyFeature>? features { get; set; }
    public List<StudyCondition>? conditions { get; set; }
    public List<StudyIEC>? iec { get; set; }
    public List<StudyRelationship>? relationships { get; set; }
    public List<StudyLocation>? sites { get; set; }
    public List<StudyCountry>? countries { get; set; }
    public List<StudyLink>? studylinks { get; set; }
    public List<AvailableIPD>? ipd_info { get; set; }
    public List<StudyDataObject>? data_objects { get; set; }

    public FullStudy()
    {}
        
    public FullStudy(Study study, List<StudyIdentifier> identifiers, List<StudyTitle> titles, 
                              List<StudyPerson> people, List<StudyOrganisation> organisations, 
                              List<StudyReference> references, List<StudyTopic> topics, 
                              List<StudyFeature> features, List<StudyCondition> conditions, 
                              List<StudyIEC> iec, List<StudyRelationship> relationships, 
                              List<StudyLocation> sites, List<StudyCountry> countries, 
                              List<StudyLink> studylinks, List<AvailableIPD> ipdInfo, 
                              List<StudyDataObject> dataObjects)
    {
        this.study = study;
        this.identifiers = identifiers;
        this.titles = titles;
        this.people = people;
        this.organisations = organisations;
        this.references = references;
        this.topics = topics;
        this.features = features;
        this.conditions = conditions;
        this.iec = iec;
        this.relationships = relationships;
        this.sites = sites;
        this.countries = countries;
        this.studylinks = studylinks;
        ipd_info = ipdInfo;
        data_objects = dataObjects;
    }
}

public class Study
{
    public string? sd_sid { get; set; }
    public string? display_title { get; set; }
    public string? title_lang_code { get; set; }
    public string? brief_description  { get; set; }
    public string? data_sharing_statement { get; set; }
    public int? study_start_year { get; set; }
    public int? study_start_month { get; set; }
    public int? study_type_id { get; set; }
    public int? study_status_id { get; set; }
    public string? study_enrolment { get; set; }
    public int? study_gender_elig_id { get; set; }
    public int? min_age { get; set; }
    public int? min_age_units_id { get; set; }
    public int? max_age { get; set; }
    public int? max_age_units_id { get; set; }
    public int? iec_level { get; set; }
     
    public Study(string? sdSid, string? displayTitle, 
        string? titleLangCode, string? briefDescription, string? dataSharingStatement, 
        int? studyStartYear, int? studyStartMonth, int? studyTypeId, int? studyStatusId, 
        string? studyEnrolment, int? studyGenderEligId, int? minAge, 
        int? minAgeUnitsId, int? maxAge, int? maxAgeUnitsId, int? iecLevel)
    {
        sd_sid = sdSid;
        display_title = displayTitle;
        title_lang_code = titleLangCode;
        brief_description = briefDescription;
        data_sharing_statement = dataSharingStatement;
        study_start_year = studyStartYear;
        study_start_month = studyStartMonth;
        study_type_id = studyTypeId;
        study_status_id = studyStatusId;
        study_enrolment = studyEnrolment;
        study_gender_elig_id = studyGenderEligId;
        min_age = minAge;
        min_age_units_id = minAgeUnitsId;
        max_age = maxAge;
        max_age_units_id = maxAgeUnitsId;
        iec_level = iecLevel;
    }
}


public class StudyTitle
{
    public string? sd_sid { get; set; }
    public int? title_type_id { get; set; }
    public string? title_text { get; set; }
    public string? lang_code { get; set; } 
    public int? lang_usage_id  { get; set; }
    public bool? is_default { get; set; }
    public string? comments { get; set; }

    public StudyTitle(string? _sd_sid, string? _title_text, int? _title_type_id, 
                      string? _lang_code, int? _lang_usage_id, bool? _is_default, string? _comments)
    {
        sd_sid = _sd_sid;
        title_text = _title_text;
        title_type_id = _title_type_id;
        lang_code = _lang_code;
        lang_usage_id = _lang_usage_id;
        is_default = _is_default;
        comments = _comments;
    }
}


public class StudyPerson
{
    public string? sd_sid { get; set; }
    public int? contrib_type_id { get; set; }
    public string? person_given_name { get; set; }
    public string? person_family_name { get; set; }
    public string? person_full_name { get; set; }
    public string? orcid_id { get; set; }
    public string? person_affiliation { get; set; }
    public int? organisation_id { get; set; }
    public string? organisation_name { get; set; }
    public string? organisation_ror_id { get; set; }

    public StudyPerson(string? _sd_sid, int? _contrib_type_id, 
                            string? _person_given_name, string? _person_family_name,
                            string? _person_full_name, string? _orcid_id, 
                            string? _person_affiliation, int? _organisation_id, 
                            string? _organisation_name, string? _organisation_ror_id)
    {
        sd_sid = _sd_sid;
        contrib_type_id = _contrib_type_id;
        person_given_name = _person_given_name;
        person_family_name = _person_family_name;
        person_full_name = _person_full_name;
        orcid_id = _orcid_id;
        person_affiliation = _person_affiliation;
        organisation_id = _organisation_id;
        organisation_name = _organisation_name;
        organisation_ror_id = _organisation_ror_id;
    }
    
    public StudyPerson(string? _sd_sid, int? _contrib_type_id, 
        string? _person_full_name, 
        string? _person_affiliation, int? _organisation_id, 
        string? _organisation_name, string? _organisation_ror_id)
    {
        sd_sid = _sd_sid;
        contrib_type_id = _contrib_type_id;
        person_full_name = _person_full_name;
        person_affiliation = _person_affiliation;
        organisation_id = _organisation_id;
        organisation_name = _organisation_name;
        organisation_ror_id = _organisation_ror_id;
    }
}
    

public class StudyOrganisation
{
    public string? sd_sid { get; set; }
    public int? contrib_type_id { get; set; }
    public int? organisation_id { get; set; }
    public string? organisation_name { get; set; }
    public string? organisation_ror_id { get; set; }
    
    public StudyOrganisation(string?_sd_sid, int? _contrib_type_id, 
                            int? _organisation_id, string? _organisation_name, 
                            string? _organisation_ror_id)
    {
        sd_sid = _sd_sid;
        contrib_type_id = _contrib_type_id;
        organisation_id = _organisation_id;
        organisation_name = _organisation_name;
        organisation_ror_id = _organisation_ror_id;
    }
}

public class StudyRelationship
{
    public string? sd_sid { get; set; }
    public int? relationship_type_id { get; set; }
    public string? target_sd_sid { get; set; }

    public StudyRelationship(string _sd_sid, int? _relationship_type_id, 
                             string? _target_sd_sid)
    {
        sd_sid = _sd_sid;
        relationship_type_id = _relationship_type_id;
        target_sd_sid = _target_sd_sid;
    }
}

public class StudyReference
{
    public string? sd_sid { get; set; }
    public string? pmid { get; set; }    
    public string? citation { get; set; }   
    public string? doi { get; set; }
    public int? type_id { get; set; }
    public string? comments { get; set; }

    
    public StudyReference(string? _sd_sid, string? _citation, string? _pmid, 
                          string? _doi, int? _type_id, string? _comments)
    {
        sd_sid = _sd_sid;
        citation = _citation;        
        pmid = _pmid;
        doi = _doi;
        type_id = _type_id;
        comments = _comments;
    }
}


public class StudyIdentifier
{
    public string? sd_sid { get; set; }
    public int? identifier_type_id { get; set; }
    public string? identifier_value { get; set; }
    public int? source_id { get; set; }
    public string? source { get; set; }
    public string? source_ror_id { get; set; }
    public string? identifier_date { get; set; }
    public string? identifier_link { get; set; }

    public StudyIdentifier(string? _sd_sid, string? _identifier_value,
        int? _identifier_type_id, int? _source_id, string? _source, string? _source_ror_id,
        string? _identifier_date, string? _identifier_link)
    {
        sd_sid = _sd_sid;
        identifier_value = _identifier_value;
        identifier_type_id = _identifier_type_id;
        source_id = _source_id;
        source = _source;
        source_ror_id = _source_ror_id;
        identifier_date = _identifier_date;
        identifier_link = _identifier_link;
    }
}


public class StudyTopic
{
    public string? sd_sid { get; set; }
    public int? topic_type_id { get; set; }
    public string? original_value { get; set; }    
    public int? original_ct_type_id { get; set; }
    public string? original_ct_code { get; set; }    
    public string? mesh_code { get; set; }
    public string? mesh_value { get; set; }

    public StudyTopic(string? _sd_sid, int? _topic_type_id, string? _original_value,
                      int? _original_ct_type_id, string? _original_ct_code, 
                      string? _mesh_code, string? _mesh_value)
    {
        sd_sid = _sd_sid;
        topic_type_id = _topic_type_id;
        original_value = _original_value;       
        original_ct_type_id = _original_ct_type_id;
        original_ct_code = _original_ct_code;
        mesh_code = _mesh_code;
        mesh_value = _mesh_value;
    }
}

public class StudyCondition
{
    public string? sd_sid { get; set; }
    public string? original_value { get; set; }
    public int? original_ct_type_id { get; set; }
    public string? original_ct_code { get; set; }
    public string? icd_code { get; set; }
    public string? icd_name { get; set; }

    public StudyCondition(string? _sd_sid, string? _original_value, int? _original_ct_type_id, 
        string? _original_ct_code, string? _icd_code, string? _icd_name)
    {
        sd_sid = _sd_sid;
        original_value = _original_value;
        original_ct_type_id = _original_ct_type_id;
        original_ct_code = _original_ct_code;
        icd_code = _icd_code;
        icd_name = _icd_name;
    }
    
    public StudyCondition(string? _sd_sid, string? _original_value)
    {
        sd_sid = _sd_sid;
        original_value = _original_value;
        original_ct_type_id = null;
        original_ct_code = null;
        icd_code = null;
        icd_name = null;
    }
}


public class StudyFeature
{
    public string? sd_sid { get; set; }
    public int? feature_type_id { get; set; }
    public int? feature_value_id { get; set; }

    public StudyFeature(string? _sd_sid, int? _feature_type_id, int? _feature_value_id)
    {
        sd_sid = _sd_sid;
        feature_type_id = _feature_type_id;
        feature_value_id = _feature_value_id;
    }
}


public class StudyLink
{
    public string? sd_sid { get; set; }
    public string? link_label { get; set; }
    public string? link_url { get; set; }

    public StudyLink(string _sd_sid, string? _link_label, string? _link_url)
    {
        sd_sid = _sd_sid;
        link_label = _link_label;
        link_url = _link_url;
    }
}
  

public class StudyLocation
{
    public string? sd_sid { get; set; }
    public int? facility_org_id { get; set; }
    public string? facility { get; set; }
    public string? facility_ror_id { get; set; }
    public int? city_id { get; set; }
    public string? city_name { get; set; }
    public int? country_id { get; set; }
    public string? country_name { get; set; }
    public int? status_id { get; set; }

    public StudyLocation(string _sd_sid, int? _facility_org_id, string? _facility, 
                         string? _facility_ror_id, int? _city_id, string? _city_name,
                         int? _country_id, string? _country_name, int? _status_id)
    {
        sd_sid = _sd_sid;
        facility_org_id = _facility_org_id;
        facility = _facility;
        facility_ror_id = _facility_ror_id;
        city_id = _city_id;
        city_name = _city_name;
        country_id = _country_id;
        country_name = _country_name;
        status_id = _status_id;
    }
}


public class StudyCountry
{
    public string? sd_sid { get; set; }
    public int? country_id { get; set; }
    public string? country_name { get; set; }
    public int? status_id { get; set; }

    public StudyCountry(string _sd_sid, int? _country_id, string? _country_name,
                         int? _status_id)
    {
        sd_sid = _sd_sid;
        country_id = _country_id;
        country_name = _country_name;
        status_id = _status_id;
    }
}

public class AvailableIPD
{
    public string? sd_sid { get; set; }
    public string? ipd_id { get; set; }
    public string? ipd_type { get; set; }
    public string? ipd_url { get; set; }
    public string? ipd_comment { get; set; }

    public AvailableIPD(string _sd_sid, string? _ipd_id, string? _ipd_type,
                            string? _ipd_url, string? _ipd_comment)
    {
        sd_sid = _sd_sid;
        ipd_id = _ipd_id;
        ipd_type = _ipd_type;
        ipd_url = _ipd_url;
        ipd_comment = _ipd_comment;
    }
}


public class StudyIEC
{
    public string? sd_sid { get; set; }
    public int? seq_num { get; set; }    
    public int? iec_type_id { get; set; }
    public string? split_type { get; set; }
    public string? leader { get; set; }
    public int? indent_level { get; set; }
    public string? sequence_string { get; set; }    
    public string? iec_text { get; set; }

    public StudyIEC(string? _sd_sid, int? _seq_num, int? _iec_type_id, 
                    string? _split_type, string? _leader, 
                    int? _indent_level, string? _sequence_string, string? _iec_text)
    {
        sd_sid = _sd_sid;
        seq_num = _seq_num;
        iec_type_id = _iec_type_id;
        split_type = _split_type;       
        leader = _leader;
        indent_level = _indent_level;
        sequence_string = _sequence_string;
        iec_text = _iec_text;
    }
}


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
    public string key_field_type { get; set; }
    public string? key_field_value { get; set; }
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
    
    // used for all other tables, that require an additional key field
    
    public RecordResults(TableResults tr, string _record_id, string _key_field, string _key_field_header,
                         string _key_field_type, string _key_field_value)
    {
        table_name = tr.table_name;
        table_id_type = tr.table_type == "study" ? "sd_sid" : "sd_oid";
        record_id = _record_id;
        key_field = _key_field;
        key_field_header = _key_field_header;
        key_field_type = _key_field_type;
        key_field_value = _key_field_value;
        where_clause = _key_field_type == "string"
            ? $" where {table_id_type} ='{record_id}' and {key_field} = '{key_field_value}'"
            : $" where {table_id_type} ='{record_id}' and {key_field} = {key_field_value}";
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



    

