namespace MDR_Tester;

public class FullAggDataObject
{
    public AggDataObject? data_object { get; set; }
    public AggObjectDataset? object_dataset  { get; set; }
    
    public List<AggObjectInstance>? object_instances { get; set; }    
    public List<AggObjectTitle>? object_titles { get; set; }    
    public List<AggObjectDate>? object_dates { get; set; }

    public List<AggObjectIdentifier>? object_identifiers { get; set; }
    public List<AggObjectTopic>? object_topics { get; set; }
    public List<AggObjectDescription>? object_descriptions { get; set; }
    public List<AggObjectOrganisation>? object_organisations { get; set; }
    public List<AggObjectPerson>? object_people { get; set; }
    
    public FullAggDataObject()
    { }
    
    public FullAggDataObject(AggDataObject? dataObject, AggObjectDataset? _object_dataset,
                          List<AggObjectInstance>? objectInstances, List<AggObjectTitle>? objectTitles, 
                          List<AggObjectDate>? objectDates, 
                          List<AggObjectIdentifier>? objectIdentifiers, List<AggObjectTopic>? objectTopics, 
                          List<AggObjectDescription>? objectDescriptions, 
                          List<AggObjectOrganisation>? objectOrganisations, 
                          List<AggObjectPerson>? objectPeople)
    {
        data_object = dataObject;
        object_dataset = _object_dataset;
        object_instances = objectInstances;        
        object_titles = objectTitles;
        object_dates = objectDates;   
        
        object_identifiers = objectIdentifiers;
        object_topics = objectTopics;
        object_descriptions = objectDescriptions;
        object_organisations = objectOrganisations;
        object_people = objectPeople;
    }
}


public class AggStudyDataObject
{
    public AggDataObject? data_object { get; set; }
    public AggObjectDataset? dataset_details  { get; set; }
    public List<AggObjectInstance>? object_instances { get; set; }    
    public List<AggObjectTitle>? object_titles { get; set; }
    public List<AggObjectDate>? object_dates { get; set; }

    public AggStudyDataObject()
    { }
        
    public AggStudyDataObject(AggDataObject? dataObject, AggObjectDataset? _object_dataset, 
          List<AggObjectTitle>? objectTitles, List<AggObjectInstance>? objectInstances, 
                          List<AggObjectDate>? objectDates)
    {
        data_object = dataObject;
        dataset_details = _object_dataset;
        object_titles = objectTitles;       
        object_instances = objectInstances;        
        object_dates = objectDates;
    }
}


public class AggDataObject
{
    public int oid { get; set; }
    public int? sid { get; set; }
    public string? title { get; set; }
    public string? version { get; set; }
    public string? display_title { get; set; }
    public string? doi { get; set; }
    public int? doi_status_id { get; set; }
    public int? publication_year { get; set; }
    public int? object_class_id { get; set; }
    public int? object_type_id { get; set; }
    public int? managing_org_id { get; set; }
    public string? managing_org { get; set; }
    public string? managing_org_ror_id { get; set; }
    public string? lang_code { get; set; }
    public int? access_type_id { get; set; }
    public string? access_details { get; set; }
    public string? access_details_url { get; set; }
    public int? eosc_category { get; set; }
    public bool? add_study_contribs { get; set; }
    public bool? add_study_topics { get; set; }
    
    public AggDataObject(int _oid, int? _sid, string? _title, 
                        string? _version, string? _display_title, 
                        string? _doi, int? _doi_status_id,
                        int? _publication_year, int? _object_class_id,
                        int? _object_type_id, int? _managing_org_id, string? _managing_org, 
                        string? _managing_org_ror_id, string? _lang_code,
                        int? _access_type_id, string? _access_details,
                        string? _access_details_url, 
                        int? _eosc_category, bool _add_study_contribs, bool _add_study_topics)
    {
        oid = _oid;
        sid = _sid;
        title = _title;
        version = _version;
        display_title = _display_title;
        doi = _doi;
        doi_status_id = _doi_status_id;
        publication_year = _publication_year;
        object_class_id = _object_class_id;
        object_type_id = _object_type_id;
        managing_org_id = _managing_org_id;
        managing_org = _managing_org;
        managing_org_ror_id = _managing_org_ror_id;
        lang_code = _lang_code;
        access_type_id = _access_type_id;
        access_details = _access_details;
        access_details_url = _access_details_url;
        eosc_category = _eosc_category;
        add_study_contribs = _add_study_contribs;
        add_study_topics = _add_study_topics;
    }
}

public class AggObjectDataset
{
    public int oid { get; set; }
    public int? record_keys_type_id { get; set; }
    public string? record_keys_details { get; set; }
    public int? deident_type_id { get; set; }
    public bool? deident_direct { get; set; }
    public bool? deident_hipaa { get; set; }
    public bool? deident_dates { get; set; }
    public bool? deident_nonarr { get; set; }
    public bool? deident_kanon { get; set; }
    public string? deident_details { get; set; }
    public int? consent_type_id { get; set; }
    public bool? consent_noncommercial { get; set; }
    public bool? consent_geog_restrict { get; set; }
    public bool? consent_research_type { get; set; }
    public bool? consent_genetic_only { get; set; }
    public bool? consent_no_methods { get; set; }
    public string? consent_details { get; set; }

    public AggObjectDataset(int _oid,
                        int? _record_keys_type_id, string? _record_keys_details,
                        int? _deident_type_id, 
                        bool? _deident_direct, bool? _deident_hipaa, bool? _deident_dates,
                        bool? _deident_nonarr, bool? _deident_kanon, string? _deident_details,
                        int? _consent_type_id, 
                        bool? _consent_noncommercial, bool? _consent_geog_restrict, bool? _consent_research_type,
                        bool? _consent_genetic_only, bool? _consent_no_methods,
                        string? _consent_details)
    {
        oid = _oid;
        record_keys_type_id = _record_keys_type_id;
        record_keys_details = _record_keys_details;
        deident_type_id = _deident_type_id;
        deident_direct = _deident_direct;
        deident_hipaa = _deident_hipaa;
        deident_dates = _deident_dates;
        deident_nonarr = _deident_nonarr;
        deident_kanon = _deident_kanon;
        deident_details = _deident_details;
        consent_type_id = _consent_type_id;
        consent_noncommercial = _consent_noncommercial;
        consent_geog_restrict = _consent_geog_restrict;
        consent_research_type = _consent_research_type;
        consent_genetic_only = _consent_genetic_only;
        consent_no_methods = _consent_no_methods;
        consent_details = _consent_details;
    }
}


public class AggObjectTitle
{
    public int oid { get; set; }
    public int? title_type_id { get; set; }
    public string? title_text { get; set; }
    public string? lang_code { get; set; }
    public int? lang_usage_id { get; set; }
    public bool? is_default { get; set; }
    public string? comments { get; set; }
    
    public AggObjectTitle(int _oid, string? _title_text, 
                            int? _title_type_id, string? _lang_code,
                            int? _lang_usage_id, bool? _is_default, string? _comments)
    {
        oid = _oid;
        title_text = _title_text;
        title_type_id = _title_type_id;
        lang_code = _lang_code;
        lang_usage_id = _lang_usage_id;
        is_default = _is_default;
        comments = _comments;
    }

}


public class AggObjectInstance
{
    public int oid { get; set; }
    public int? system_id { get; set; }
    public string? system { get; set; }
    public string? url { get; set; }
    public bool? url_accessible { get; set; }
    public int? resource_type_id { get; set; }
    public string? resource_size { get; set; }
    public string? resource_size_units { get; set; }
    public string? resource_comments { get; set; }

    public AggObjectInstance(int _oid, int? _system_id, string? _system, 
                string? _url, bool? _url_accessible,
                int? _resource_type_id, string? _resource_size, 
                string? _resource_size_units, string? _resource_comments)
    {
        oid = _oid;
        system_id = _system_id;
        system = _system;
        url = _url;
        url_accessible = _url_accessible;
        resource_type_id = _resource_type_id;
        resource_size = _resource_size;
        resource_size_units = _resource_size_units;
        resource_comments = _resource_comments;
    }

}


public class AggObjectDate
{
    public int oid { get; set; }
    public int? date_type_id { get; set; }
    public bool? date_is_range { get; set; }    
    public string? date_as_string { get; set; }
    public int? start_year { get; set; }
    public int? start_month { get; set; }
    public int? start_day { get; set; }
    public int? end_year { get; set; }
    public int? end_month { get; set; }
    public int? end_day { get; set; }
    public string? details { get; set; }

   
    public AggObjectDate(int _oid, int? _date_type_id,
                                bool? _date_is_range, string? _date_as_string, 
                                int? _start_year, int? _start_month, int? _start_day,
                                int? _end_year, int? _end_month, int? _end_day,
                                string? _details)
    {
        oid = _oid;
        date_type_id = _date_type_id;
        date_is_range = _date_is_range;        
        date_as_string = _date_as_string;
        start_year = _start_year;
        start_month = _start_month;
        start_day = _start_day;
        end_year = _end_year;
        end_month = _end_month;
        end_day = _end_day;
        details = _details;
    }
    
    public AggObjectDate(int _oid, int? _date_type_id, string? _date_as_string, 
        int? _start_year, int? _start_month, int? _start_day)
    {
        oid = _oid;
        date_type_id = _date_type_id;
        date_is_range = false;    
        date_as_string = _date_as_string;
        start_year = _start_year;
        start_month = _start_month;
        start_day = _start_day;
        end_year = null;
        end_month = null;
        end_day = null;
        details = null;
    }
    
}


/****************************************************************
// Objects below currently used only for PubMed entries
// (Description may be used in the future for linked samples)
*****************************************************************/


public class AggObjectDescription
{
    public int oid { get; init; }
    public int? description_type_id { get; init; }
    public string? label { get; set; }
    public string? description_text { get; init; }
    public string? lang_code { get; init; }

    public AggObjectDescription(int _oid, int? descriptionTypeId, string? label, 
                             string? descriptionText, string? langCode)
    {
        oid = _oid;
        description_type_id = descriptionTypeId;
        this.label = label;
        description_text = descriptionText;
        lang_code = langCode;
    }
}


public class AggObjectTopic
{
    public int oid { get; set; }
    public int? topic_type_id { get; set; }
    public string? original_value { get; set; }
    public int? original_ct_type_id { get; set; }
    public string? original_ct_code { get; set; }
    public string? mesh_code { get; set; }
    public string? mesh_value { get; set; }

    public AggObjectTopic(int _oid, int? _topic_type_id, string? _original_value,
                       int? _original_ct_type_id, string? _original_ct_code, 
                       string? _mesh_code, string? _mesh_value)
    {
        oid = _oid;
        topic_type_id = _topic_type_id;
        original_value = _original_value;        
        original_ct_type_id = _original_ct_type_id;
        original_ct_code = _original_ct_code;        
        mesh_code = _mesh_code;
        mesh_value = _mesh_value;
    }
}

  
public class AggObjectPerson
{
    public int oid { get; set; }
    public int? contrib_type_id { get; set; }
    public string? person_given_name { get; set; }
    public string? person_family_name { get; set; }
    public string? person_full_name { get; set; }
    public string? orcid_id { get; set; }
    public string? person_affiliation { get; set; }
    public int? organisation_id { get; set; }
    public string? organisation_name { get; set; }
    public string? organisation_ror_id { get; set; }
    
    public AggObjectPerson(int _oid, int? _contrib_type_id, string? _person_given_name, 
                        string? _person_family_name, string? _person_full_name,
                        string? _orcid_id, string? _person_affiliation, int? _organisation_id, 
                        string? _organisation_name, string? _organisation_ror_id)
    {
        oid = _oid;
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

}

public class AggObjectOrganisation
{
    public int oid { get; set; }
    public int? contrib_type_id { get; set; }
    public int? organisation_id { get; set; }
    public string? organisation_name { get; set; }
    public string? organisation_ror_id { get; set; }
    
    public AggObjectOrganisation(int _oid, int? _contrib_type_id,
           int? _organisation_id, string? _organisation_name, string? _organisation_ror_id)
    {
        oid = _oid;
        contrib_type_id = _contrib_type_id;
        organisation_id = _organisation_id;
        organisation_name = _organisation_name;
        organisation_ror_id = _organisation_ror_id;    
    }
}


public class AggObjectIdentifier
{
    public int oid { get; set; }
    public string? identifier_value { get; set; }    
    public int? identifier_type_id { get; set; }
    public int? source_id { get; set; }
    public string? source { get; set; }
    public string? source_ror_id { get; set; }
    public string? identifier_date { get; set; }

    public AggObjectIdentifier(int _oid, string? _id_value, int? _type_id, 
                  int? _source_id, string? _source, string? _source_ror_id, string? _identifier_date)
    {
        oid = _oid;
        identifier_value = _id_value;        
        identifier_type_id = _type_id;
        source_id = _source_id;
        source = _source;
        source_ror_id = _source_ror_id;
        identifier_date = _identifier_date;
    }
}








    

