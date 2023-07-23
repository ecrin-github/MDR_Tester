using Dapper;
using Npgsql;

namespace MDR_Tester;

public class ObjectTableBuilders
{ 
    private readonly string _db_conn;

    public ObjectTableBuilders(string db_conn)
    {
        _db_conn = db_conn;
    }


    public void Execute_SQL(string sql_string)
    {
        using var conn = new NpgsqlConnection(_db_conn);
        conn.Execute(sql_string);
    }


    public void create_table_data_objects()
    {
        string sql_string = @"DROP TABLE IF EXISTS te.data_objects;
        CREATE TABLE te.data_objects(
            id                     INT             GENERATED ALWAYS AS IDENTITY PRIMARY KEY
          , sd_oid                 VARCHAR         NOT NULL
          , sd_sid                 VARCHAR         NULL
          , title                  VARCHAR         NULL
          , version                VARCHAR         NULL
          , display_title          VARCHAR         NULL
          , doi                    VARCHAR         NULL 
          , doi_status_id          INT             NULL
          , publication_year       INT             NULL
          , object_class_id        INT             NULL
          , object_type_id         INT             NULL
          , managing_org_id        INT             NULL
          , managing_org           VARCHAR         NULL
          , managing_org_ror_id    VARCHAR         NULL
          , lang_code              VARCHAR         NULL
          , access_type_id         INT             NULL
          , access_details         VARCHAR         NULL
          , access_details_url     VARCHAR         NULL
          , eosc_category          INT             NULL
          , add_study_contribs     BOOLEAN         NULL
          , add_study_topics       BOOLEAN         NULL
        );    
        CREATE INDEX data_objects_oid ON te.data_objects(sd_oid);
        CREATE INDEX data_objects_sid ON te.data_objects(sd_sid);";

        Execute_SQL(sql_string);
    }


    public void create_table_object_datasets()
    {
        string sql_string = @"DROP TABLE IF EXISTS te.object_datasets;
        CREATE TABLE te.object_datasets(
            id                     INT             GENERATED ALWAYS AS IDENTITY PRIMARY KEY
          , sd_oid                 VARCHAR         NULL
          , record_keys_type_id    INT             NULL 
          , record_keys_details    VARCHAR         NULL    
          , deident_type_id        INT             NULL  
          , deident_direct 	       BOOLEAN         NULL   
          , deident_hipaa 	       BOOLEAN         NULL   
          , deident_dates 	       BOOLEAN         NULL   
          , deident_nonarr 	       BOOLEAN         NULL   
          , deident_kanon	       BOOLEAN         NULL   
          , deident_details        VARCHAR         NULL    
          , consent_type_id        INT             NULL  
          , consent_noncommercial  BOOLEAN         NULL
          , consent_geog_restrict  BOOLEAN         NULL
          , consent_research_type  BOOLEAN         NULL
          , consent_genetic_only   BOOLEAN         NULL
          , consent_no_methods     BOOLEAN         NULL
          , consent_details        VARCHAR         NULL 
        );

        CREATE INDEX object_datasets_oid ON te.object_datasets(sd_oid);";

        Execute_SQL(sql_string);
    }


    public void create_table_object_dates()
    {
        string sql_string = @"DROP TABLE IF EXISTS te.object_dates;
        CREATE TABLE te.object_dates(
            id                     INT             GENERATED ALWAYS AS IDENTITY PRIMARY KEY
          , sd_oid                 VARCHAR        NULL
          , date_type_id           INT             NULL
          , date_is_range          BOOLEAN         NULL default false
          , date_as_string         VARCHAR         NULL
          , start_year             INT             NULL
          , start_month            INT             NULL
          , start_day              INT             NULL
          , end_year               INT             NULL
          , end_month              INT             NULL
          , end_day                INT             NULL
          , details                VARCHAR         NULL
        );
        CREATE INDEX object_dates_oid ON te.object_dates(sd_oid);";

        Execute_SQL(sql_string);
    }


    public void create_table_object_instances()
    {
        string sql_string = @"DROP TABLE IF EXISTS te.object_instances;
        CREATE TABLE te.object_instances(
            id                     INT             GENERATED ALWAYS AS IDENTITY PRIMARY KEY
          , sd_oid                 VARCHAR         NULL
          , system_id              INT             NULL
          , system                 VARCHAR         NULL
          , url                    VARCHAR         NULL
          , url_accessible         BOOLEAN         NULL
          , resource_type_id       INT             NULL
          , resource_size          VARCHAR         NULL
          , resource_size_units    VARCHAR         NULL
          , resource_comments      VARCHAR         NULL
        );
        CREATE INDEX object_instances_oid ON te.object_instances(sd_oid);";

        Execute_SQL(sql_string);
    }


    public void create_table_object_titles()
    {
        string sql_string = @"DROP TABLE IF EXISTS te.object_titles;
        CREATE TABLE te.object_titles(
            id                     INT             GENERATED ALWAYS AS IDENTITY PRIMARY KEY
          , sd_oid                 VARCHAR        NULL
          , title_type_id          INT             NULL
          , title_text             VARCHAR         NULL
          , lang_code              VARCHAR         NOT NULL
          , lang_usage_id          INT             NOT NULL default 11
          , is_default             BOOLEAN         NULL
          , comments               VARCHAR         NULL
        );
        CREATE INDEX object_titles_oid ON te.object_titles(sd_oid);";

        Execute_SQL(sql_string);
    }


    public void create_table_object_people()
    {
        string sql_string = @"DROP TABLE IF EXISTS te.object_people;
        CREATE TABLE te.object_people(
            id                     INT             GENERATED ALWAYS AS IDENTITY PRIMARY KEY
          , sd_oid                 VARCHAR        NULL
          , contrib_type_id        INT             NULL
          , person_given_name      VARCHAR         NULL
          , person_family_name     VARCHAR         NULL
          , person_full_name       VARCHAR         NULL
          , orcid_id               VARCHAR         NULL
          , person_affiliation     VARCHAR         NULL
          , organisation_id        INT             NULL
          , organisation_name      VARCHAR         NULL
          , organisation_ror_id    VARCHAR         NULL
        );
        CREATE INDEX object_people_oid ON te.object_people(sd_oid);";

        Execute_SQL(sql_string);
    }

    
    public void create_table_object_organisations()
    {
        string sql_string = @"DROP TABLE IF EXISTS te.object_organisations;
        CREATE TABLE te.object_organisations(
            id                     INT             GENERATED ALWAYS AS IDENTITY PRIMARY KEY
          , sd_oid                 VARCHAR        NULL
          , contrib_type_id        INT             NULL
          , organisation_id        INT             NULL
          , organisation_name      VARCHAR         NULL
          , organisation_ror_id    VARCHAR         NULL
        );
        CREATE INDEX object_organisations_oid ON te.object_organisations(sd_oid);";

        Execute_SQL(sql_string);
    }
    

    public void create_table_object_topics()
    {
        string sql_string = @"DROP TABLE IF EXISTS te.object_topics;
        CREATE TABLE te.object_topics(
            id                     INT             GENERATED ALWAYS AS IDENTITY PRIMARY KEY
          , sd_oid                 VARCHAR        NULL
          , topic_type_id          INT             NULL
          , original_value         VARCHAR         NULL         
          , original_ct_type_id    INT             NULL
          , original_ct_code       VARCHAR         NULL
          , mesh_code              VARCHAR         NULL
          , mesh_value             VARCHAR         NULL
        );
        CREATE INDEX object_topics_oid ON te.object_topics(sd_oid);";

        Execute_SQL(sql_string);
    }


    public void create_table_object_comments()
    {
        string sql_string = @"DROP TABLE IF EXISTS te.object_comments;
        CREATE TABLE te.object_comments(
            id                     INT             GENERATED ALWAYS AS IDENTITY PRIMARY KEY
          , sd_oid                 VARCHAR         NULL
          , ref_type               VARCHAR         NULL 
          , ref_source             VARCHAR         NULL 
          , pmid                   VARCHAR         NULL 
          , pmid_version           VARCHAR         NULL 
          , notes                  VARCHAR         NULL 
        );
        CREATE INDEX object_comments_oid ON te.object_comments(sd_oid);";

        Execute_SQL(sql_string); 
    }


    public void create_table_object_descriptions()
    {
        string sql_string = @"DROP TABLE IF EXISTS te.object_descriptions;
        CREATE TABLE te.object_descriptions(
            id                     INT             GENERATED ALWAYS AS IDENTITY PRIMARY KEY
          , sd_oid                 VARCHAR         NULL
          , description_type_id    INT             NULL
          , label                  VARCHAR         NULL
          , description_text       VARCHAR         NULL
          , lang_code              VARCHAR         NULL
        );
        CREATE INDEX object_descriptions_oid ON te.object_descriptions(sd_oid);";

        Execute_SQL(sql_string);
    }

    public void create_table_object_identifiers()
    {
        string sql_string = @"DROP TABLE IF EXISTS te.object_identifiers;
            CREATE TABLE te.object_identifiers(
            id                     INT             GENERATED ALWAYS AS IDENTITY PRIMARY KEY
          , sd_oid                 VARCHAR         NULL
          , identifier_value       VARCHAR         NULL
          , identifier_type_id     INT             NULL
          , source_id              INT             NULL
          , source                 VARCHAR         NULL
          , source_ror_id          VARCHAR         NULL
          , identifier_date        VARCHAR         NULL
        );
        CREATE INDEX object_identifiers_oid ON te.object_identifiers(sd_oid);";

        Execute_SQL(sql_string);
    }


    public void create_table_object_db_links()
    {
        string sql_string = @"DROP TABLE IF EXISTS te.object_db_links;
        CREATE TABLE te.object_db_links(
            id                     INT             GENERATED ALWAYS AS IDENTITY PRIMARY KEY
          , sd_oid                 VARCHAR         NULL
          , db_sequence            INT             NULL
          , db_name                VARCHAR         NULL
          , id_in_db               VARCHAR         NULL
        );
        CREATE INDEX object_db_links_oid ON te.object_db_links(sd_oid);";

        Execute_SQL(sql_string);
    }


    public void create_table_object_publication_types()
    {
        string sql_string = @"DROP TABLE IF EXISTS te.object_publication_types;
        CREATE TABLE te.object_publication_types(
            id                     INT             GENERATED ALWAYS AS IDENTITY PRIMARY KEY
          , sd_oid                 VARCHAR        NULL
          , type_name              VARCHAR         NULL
        );
        CREATE INDEX object_publication_types_oid ON te.object_publication_types(sd_oid);";

        Execute_SQL(sql_string);
    }


    public void create_table_object_rights()
    {
        string sql_string = @"DROP TABLE IF EXISTS te.object_rights;
        CREATE TABLE te.object_rights(
            id                     INT             GENERATED ALWAYS AS IDENTITY PRIMARY KEY
          , sd_oid                 VARCHAR         NULL
          , rights_name            VARCHAR         NULL
          , rights_uri             VARCHAR         NULL
          , comments               VARCHAR         NULL
        );
        CREATE INDEX object_rights_oid ON te.object_rights(sd_oid);";

        Execute_SQL(sql_string);
    }


    public void create_table_object_relationships()
    {
        string sql_string = @"DROP TABLE IF EXISTS te.object_relationships;
        CREATE TABLE te.object_relationships(
            id                     INT             GENERATED ALWAYS AS IDENTITY PRIMARY KEY
          , sd_oid                 VARCHAR         NULL
          , relationship_type_id   INT             NULL
          , target_sd_oid          VARCHAR         NULL
        );
        CREATE INDEX object_relationships_oid ON te.object_relationships(sd_oid);
        CREATE INDEX object_relationships_target_oid ON te.object_relationships(target_sd_oid);";
        Execute_SQL(sql_string);
    }
    
    
    public void create_table_journal_details()
    {
        string sql_string = @"DROP TABLE IF EXISTS te.journal_details;
        CREATE TABLE te.journal_details(
            id                     INT             GENERATED ALWAYS AS IDENTITY PRIMARY KEY
          , sd_oid                 VARCHAR         NOT NULL
          , journal_title          VARCHAR         NULL
          , pissn                  VARCHAR         NULL
          , eissn                  VARCHAR         NULL
          , journal_nlm_id         VARCHAR         NULL
          , journal_iso_abbrev     VARCHAR         NULL
          , publisher_id           INT             NULL
          , publisher              VARCHAR         NULL
        );
        CREATE INDEX journal_details_oid ON te.journal_details(sd_oid);";

        Execute_SQL(sql_string);
    }
}