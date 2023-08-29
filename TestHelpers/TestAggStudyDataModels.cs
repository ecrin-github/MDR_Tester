namespace MDR_Tester;

public class FullAggStudy
{
    public AggStudy? study { get; set; }
    public List<AggStudyIdentifier>? identifiers { get; set; }
    public List<AggStudyTitle>? titles { get; set; }
    public List<AggStudyPerson>? people { get; set; }
    public List<AggStudyOrganisation>? organisations { get; set; }
    public List<AggStudyTopic>? topics { get; set; }
    public List<AggStudyFeature>? features { get; set; }
    public List<AggStudyCondition>? conditions { get; set; }
    public List<AggStudyIEC>? iec { get; set; }
    public List<AggStudyRelationship>? relationships { get; set; }
    public List<AggStudyLocation>? sites { get; set; }
    public List<AggStudyCountry>? countries { get; set; }
    public List<AggStudyDataObject>? data_objects { get; set; }

    public FullAggStudy()
    {}
        
    public FullAggStudy(AggStudy study, List<AggStudyIdentifier> identifiers, List<AggStudyTitle> titles, 
                              List<AggStudyPerson> people, List<AggStudyOrganisation> organisations, 
                              List<AggStudyTopic> topics, 
                              List<AggStudyFeature> features, List<AggStudyCondition> conditions, 
                              List<AggStudyIEC> iec, List<AggStudyRelationship> relationships, 
                              List<AggStudyLocation> sites, List<AggStudyCountry> countries, 
                              List<AggStudyDataObject> dataObjects)
    {
        this.study = study;
        this.identifiers = identifiers;
        this.titles = titles;
        this.people = people;
        this.organisations = organisations;
        this.topics = topics;
        this.features = features;
        this.conditions = conditions;
        this.iec = iec;
        this.relationships = relationships;
        this.sites = sites;
        this.countries = countries;
        data_objects = dataObjects;
    }
}

public class AggStudy
{
    public int sid { get; set; }
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
     
    public AggStudy(int _sid, string? displayTitle, 
        string? titleLangCode, string? briefDescription, string? dataSharingStatement, 
        int? studyStartYear, int? studyStartMonth, int? studyTypeId, int? studyStatusId, 
        string? studyEnrolment, int? studyGenderEligId, int? minAge, 
        int? minAgeUnitsId, int? maxAge, int? maxAgeUnitsId, int? iecLevel)
    {
        sid =_sid;
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


public class AggStudyTitle
{
    public int sid { get; set; }
    public int? title_type_id { get; set; }
    public string? title_text { get; set; }
    public string? lang_code { get; set; } 
    public int? lang_usage_id  { get; set; }
    public bool? is_default { get; set; }
    public string? comments { get; set; }

    public AggStudyTitle(int _sid, string? _title_text, int? _title_type_id, 
                      string? _lang_code, int? _lang_usage_id, bool? _is_default, string? _comments)
    {
        sid =_sid;
        title_text = _title_text;
        title_type_id = _title_type_id;
        lang_code = _lang_code;
        lang_usage_id = _lang_usage_id;
        is_default = _is_default;
        comments = _comments;
    }
}


public class AggStudyPerson
{
    public int sid { get; set; }
    public int? contrib_type_id { get; set; }
    public string? person_given_name { get; set; }
    public string? person_family_name { get; set; }
    public string? person_full_name { get; set; }
    public string? orcid_id { get; set; }
    public string? person_affiliation { get; set; }
    public int? organisation_id { get; set; }
    public string? organisation_name { get; set; }
    public string? organisation_ror_id { get; set; }

    public AggStudyPerson(int _sid, int? _contrib_type_id, 
                            string? _person_given_name, string? _person_family_name,
                            string? _person_full_name, string? _orcid_id, 
                            string? _person_affiliation, int? _organisation_id, 
                            string? _organisation_name, string? _organisation_ror_id)
    {
        sid =_sid;
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
    
    public AggStudyPerson(int _sid, int? _contrib_type_id, 
        string? _person_full_name, 
        string? _person_affiliation, int? _organisation_id, 
        string? _organisation_name, string? _organisation_ror_id)
    {
        sid =_sid;
        contrib_type_id = _contrib_type_id;
        person_full_name = _person_full_name;
        person_affiliation = _person_affiliation;
        organisation_id = _organisation_id;
        organisation_name = _organisation_name;
        organisation_ror_id = _organisation_ror_id;
    }
}
    

public class AggStudyOrganisation
{
    public int sid { get; set; }
    public int? contrib_type_id { get; set; }
    public int? organisation_id { get; set; }
    public string? organisation_name { get; set; }
    public string? organisation_ror_id { get; set; }
    
    public AggStudyOrganisation(int _sid, int? _contrib_type_id, 
                            int? _organisation_id, string? _organisation_name, 
                            string? _organisation_ror_id)
    {
        sid =_sid;
        contrib_type_id = _contrib_type_id;
        organisation_id = _organisation_id;
        organisation_name = _organisation_name;
        organisation_ror_id = _organisation_ror_id;
    }
}

public class AggStudyRelationship
{
    public int sid { get; set; }
    public int? relationship_type_id { get; set; }
    public int? target_sid { get; set; }

    public AggStudyRelationship(int _sid, int? _relationship_type_id, 
                             int? _target_sid)
    {
        sid =_sid;
        relationship_type_id = _relationship_type_id;
        target_sid = _target_sid;
    }
}


public class AggStudyIdentifier
{
    public int sid { get; set; }
    public int? identifier_type_id { get; set; }
    public string? identifier_value { get; set; }
    public int? source_id { get; set; }
    public string? source { get; set; }
    public string? source_ror_id { get; set; }
    public string? identifier_date { get; set; }
    public string? identifier_link { get; set; }

    public AggStudyIdentifier(int _sid, string? _identifier_value,
        int? _identifier_type_id, int? _source_id, string? _source, string? _source_ror_id,
        string? _identifier_date, string? _identifier_link)
    {
        sid =_sid;
        identifier_value = _identifier_value;
        identifier_type_id = _identifier_type_id;
        source_id = _source_id;
        source = _source;
        source_ror_id = _source_ror_id;
        identifier_date = _identifier_date;
        identifier_link = _identifier_link;
    }
}


public class AggStudyTopic
{
    public int sid { get; set; }
    public int? topic_type_id { get; set; }
    public string? original_value { get; set; }    
    public int? original_ct_type_id { get; set; }
    public string? original_ct_code { get; set; }    
    public string? mesh_code { get; set; }
    public string? mesh_value { get; set; }

    public AggStudyTopic(int _sid, int? _topic_type_id, string? _original_value,
                      int? _original_ct_type_id, string? _original_ct_code, 
                      string? _mesh_code, string? _mesh_value)
    {
        sid =_sid;
        topic_type_id = _topic_type_id;
        original_value = _original_value;       
        original_ct_type_id = _original_ct_type_id;
        original_ct_code = _original_ct_code;
        mesh_code = _mesh_code;
        mesh_value = _mesh_value;
    }
}

public class AggStudyCondition
{
    public int sid { get; set; }
    public string? original_value { get; set; }
    public int? original_ct_type_id { get; set; }
    public string? original_ct_code { get; set; }
    public string? icd_code { get; set; }
    public string? icd_name { get; set; }

    public AggStudyCondition(int _sid, string? _original_value, int? _original_ct_type_id, 
        string? _original_ct_code, string? _icd_code, string? _icd_name)
    {
        sid =_sid;
        original_value = _original_value;
        original_ct_type_id = _original_ct_type_id;
        original_ct_code = _original_ct_code;
        icd_code = _icd_code;
        icd_name = _icd_name;
    }
    
    public AggStudyCondition(int _sid, string? _original_value)
    {
        sid =_sid;
        original_value = _original_value;
        original_ct_type_id = null;
        original_ct_code = null;
        icd_code = null;
        icd_name = null;
    }
}


public class AggStudyFeature
{
    public int sid { get; set; }
    public int? feature_type_id { get; set; }
    public int? feature_value_id { get; set; }

    public AggStudyFeature(int _sid, int? _feature_type_id, int? _feature_value_id)
    {
        sid =_sid;
        feature_type_id = _feature_type_id;
        feature_value_id = _feature_value_id;
    }
}

  
public class AggStudyLocation
{
    public int sid { get; set; }
    public int? facility_org_id { get; set; }
    public string? facility { get; set; }
    public string? facility_ror_id { get; set; }
    public int? city_id { get; set; }
    public string? city_name { get; set; }
    public int? country_id { get; set; }
    public string? country_name { get; set; }
    public int? status_id { get; set; }

    public AggStudyLocation(int _sid, int? _facility_org_id, string? _facility, 
                         string? _facility_ror_id, int? _city_id, string? _city_name,
                         int? _country_id, string? _country_name, int? _status_id)
    {
        sid =_sid;
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


public class AggStudyCountry
{
    public int sid { get; set; }
    public int? country_id { get; set; }
    public string? country_name { get; set; }
    public int? status_id { get; set; }

    public AggStudyCountry(int _sid, int? _country_id, string? _country_name,
                         int? _status_id)
    {
        sid =_sid;
        country_id = _country_id;
        country_name = _country_name;
        status_id = _status_id;
    }
}


public class AggStudyIEC
{
    public int sid { get; set; }
    public int? seq_num { get; set; }    
    public int? iec_type_id { get; set; }
    public string? split_type { get; set; }
    public string? leader { get; set; }
    public int? indent_level { get; set; }
    public string? sequence_string { get; set; }    
    public string? iec_text { get; set; }

    public AggStudyIEC(int _sid, int? _seq_num, int? _iec_type_id, 
                    string? _split_type, string? _leader, 
                    int? _indent_level, string? _sequence_string, string? _iec_text)
    {
        sid =_sid;
        seq_num = _seq_num;
        iec_type_id = _iec_type_id;
        split_type = _split_type;       
        leader = _leader;
        indent_level = _indent_level;
        sequence_string = _sequence_string;
        iec_text = _iec_text;
    }
}



    

