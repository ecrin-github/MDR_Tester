using Dapper;
using Npgsql;

namespace MDR_Tester;

public class AggStudyTableBuilders
{
    private readonly string _db_conn;
    private readonly string _iec_conn;

    public AggStudyTableBuilders(string db_conn, string iec_conn)
    {
        _db_conn = db_conn;
        _iec_conn = iec_conn;
    }

    public void Execute_SQL(string sql_string)
    {
        using var conn = new NpgsqlConnection(_db_conn);
        conn.Execute(sql_string);
    }

    public void Execute_IEC_SQL(string sql_string)
    {
        using var conn = new NpgsqlConnection(_iec_conn);
        conn.Execute(sql_string);
    }

    public void EnsureTEschemas()
    {
        string sql_string = "CREATE SCHEMA IF NOT EXISTS te";
        Execute_SQL(sql_string);
        Execute_IEC_SQL(sql_string);

    }

    public void create_table_studies()
    {
        string sql_string = @"DROP TABLE IF EXISTS te.studies;
        CREATE TABLE te.studies(
            id                     INT             GENERATED ALWAYS AS IDENTITY PRIMARY KEY
          , sid                    INT             NOT NULL
          , display_title          VARCHAR         NULL
          , title_lang_code        VARCHAR         NULL default 'en'
          , brief_description      VARCHAR         NULL
          , data_sharing_statement VARCHAR         NULL
          , study_start_year       INT             NULL
          , study_start_month      INT             NULL
          , study_type_id          INT             NULL
          , study_status_id        INT             NULL
          , study_enrolment        VARCHAR         NULL
          , study_gender_elig_id   INT             NULL
          , min_age                INT             NULL
          , min_age_units_id       INT             NULL
          , max_age                INT             NULL
          , max_age_units_id       INT             NULL
          , iec_level              INT             NULL
        );
        CREATE INDEX studies_sid ON te.studies(sd_sid);";

        Execute_SQL(sql_string);
    }


    public void create_table_study_identifiers()
    {
        string sql_string = @"DROP TABLE IF EXISTS te.study_identifiers;
        CREATE TABLE te.study_identifiers(
            id                     INT             GENERATED ALWAYS AS IDENTITY PRIMARY KEY
          , sid                    INT             NOT NULL
          , identifier_value       VARCHAR         NULL
          , identifier_type_id     INT             NULL
          , source_id              INT             NULL
          , source                 VARCHAR         NULL
          , source_ror_id          VARCHAR         NULL
          , identifier_date        VARCHAR         NULL
          , identifier_link        VARCHAR         NULL
                                  
        );
        CREATE INDEX study_identifiers_sid ON te.study_identifiers(sd_sid);";

        Execute_SQL(sql_string);
    }

    public void create_table_study_relationships()
    {
        string sql_string = @"DROP TABLE IF EXISTS te.study_relationships;
        CREATE TABLE te.study_relationships(
            id                     INT             GENERATED ALWAYS AS IDENTITY PRIMARY KEY
          , sid                    INT             NOT NULL
          , relationship_type_id   INT             NULL
          , target_sid             INT             NULL
        );
        CREATE INDEX study_relationships_sid ON te.study_relationships(sd_sid);
        CREATE INDEX study_relationships_target_sid ON te.study_relationships(target_sd_sid);";

        Execute_SQL(sql_string);
    }


    public void create_table_study_references()
    {
        string sql_string = @"DROP TABLE IF EXISTS te.study_references;
        CREATE TABLE te.study_references(
            id                     INT             GENERATED ALWAYS AS IDENTITY PRIMARY KEY
          , sid                    INT             NOT NULL
          , pmid                   VARCHAR         NULL
          , citation               VARCHAR         NULL
          , doi                    VARCHAR         NULL	
          , type_id                INT             NULL
          , comments               VARCHAR         NULL
        );
        CREATE INDEX study_references_sid ON te.study_references(sd_sid);";

        Execute_SQL(sql_string);
    }


    public void create_table_study_titles()
    {
        string sql_string = @"DROP TABLE IF EXISTS te.study_titles;
        CREATE TABLE te.study_titles(
            id                     INT             GENERATED ALWAYS AS IDENTITY PRIMARY KEY
          , sid                    INT             NOT NULL
          , title_type_id          INT             NULL
          , title_text             VARCHAR         NULL
          , lang_code              VARCHAR         NOT NULL default 'en'
          , lang_usage_id          INT             NOT NULL default 11
          , is_default             BOOLEAN         NULL
          , comments               VARCHAR         NULL
        );
        CREATE INDEX study_titles_sid ON te.study_titles(sd_sid);";

        Execute_SQL(sql_string);
    }


    public void create_table_study_people()
    {
        string sql_string = @"DROP TABLE IF EXISTS te.study_people;
        CREATE TABLE te.study_people(
            id                     INT             GENERATED ALWAYS AS IDENTITY PRIMARY KEY
          , sid                    INT             NOT NULL
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
        CREATE INDEX study_people_sid ON te.study_people(sd_sid);";

        Execute_SQL(sql_string);
    }
    
    
    public void create_table_study_organisations()
    {
        string sql_string = @"DROP TABLE IF EXISTS te.study_organisations;
        CREATE TABLE te.study_organisations(
            id                     INT             GENERATED ALWAYS AS IDENTITY PRIMARY KEY
          , sid                    INT             NOT NULL
          , contrib_type_id        INT             NULL
          , organisation_id        INT             NULL
          , organisation_name      VARCHAR         NULL
          , organisation_ror_id    VARCHAR         NULL
        );
        CREATE INDEX study_organisations_sid ON te.study_organisations(sd_sid);";

        Execute_SQL(sql_string);
    }


    public void create_table_study_topics()
    {
        string sql_string = @"DROP TABLE IF EXISTS te.study_topics;
        CREATE TABLE te.study_topics(
            id                     INT             GENERATED ALWAYS AS IDENTITY PRIMARY KEY
          , sid                    INT             NOT NULL
          , topic_type_id          INT             NULL
          , original_value         VARCHAR         NULL       
          , original_ct_type_id    INT             NULL
          , original_ct_code       VARCHAR         NULL 
          , mesh_code              VARCHAR         NULL
          , mesh_value             VARCHAR         NULL
        );
        CREATE INDEX study_topics_sid ON te.study_topics(sd_sid);";

        Execute_SQL(sql_string);
    }

    public void create_table_study_conditions()
    {
        string sql_string = @"DROP TABLE IF EXISTS te.study_conditions;
        CREATE TABLE te.study_conditions(
            id                     INT             GENERATED ALWAYS AS IDENTITY PRIMARY KEY
          , sid                    INT             NOT NULL
          , original_value         VARCHAR         NULL
          , original_ct_type_id    INT             NULL
          , original_ct_code       VARCHAR         NULL                 
          , icd_code               VARCHAR         NULL
          , icd_name               VARCHAR         NULL
        );
        CREATE INDEX study_conditions_sid ON te.study_conditions(sd_sid);";

        Execute_SQL(sql_string);
    }

    public void create_table_study_features()
    {
        string sql_string = @"DROP TABLE IF EXISTS te.study_features;
        CREATE TABLE te.study_features(
            id                     INT             GENERATED ALWAYS AS IDENTITY PRIMARY KEY
          , sid                    INT             NOT NULL
          , feature_type_id        INT             NULL
          , feature_value_id       INT             NULL

        );
        CREATE INDEX study_features_sid ON te.study_features(sd_sid);";

        Execute_SQL(sql_string);
    }

    
    public void create_table_study_locations()
    {
        string sql_string = @"DROP TABLE IF EXISTS te.study_locations;
        CREATE TABLE te.study_locations(
            id                     INT             GENERATED ALWAYS AS IDENTITY PRIMARY KEY
          , sid                    INT             NOT NULL
          , facility_org_id        INT             NULL
          , facility               VARCHAR         NULL
          , facility_ror_id        VARCHAR         NULL
          , city_id                INT             NULL
          , city_name              VARCHAR         NULL
          , country_id             INT             NULL
          , country_name           VARCHAR         NULL
          , status_id              INT             NULL
        );
        CREATE INDEX study_locations_sid ON te.study_locations(sd_sid);";

        Execute_SQL(sql_string);
    }


    public void create_table_study_countries()
    {
        string sql_string = @"DROP TABLE IF EXISTS te.study_countries;
        CREATE TABLE te.study_countries(
            id                     INT             GENERATED ALWAYS AS IDENTITY PRIMARY KEY
          , sid                    INT             NOT NULL
          , country_id             INT             NULL
          , country_name           VARCHAR         NULL
          , status_id              INT             NULL
        );
        CREATE INDEX study_countries_sid ON te.study_countries(sd_sid);";

        Execute_SQL(sql_string);
    }

    
    private void create_iec_table(string table_name)
    {
        string sql_string = $@"DROP TABLE IF EXISTS te.{table_name};
        CREATE TABLE te.{table_name}(
            id                     INT             GENERATED ALWAYS AS IDENTITY PRIMARY KEY
          , sid                    INT             NOT NULL
          , seq_num                INT             NULL
          , iec_type_id            INT             NULL       
          , split_type             VARCHAR         NULL              
          , leader                 VARCHAR         NOT NULL
          , indent_level           INT             NULL
          , sequence_string        VARCHAR         NULL
          , iec_text               VARCHAR         NULL
          , iec_class_id           INT             NULL
          , iec_class              VARCHAR         NULL
          , iec_parsed_text        VARCHAR         NULL
        );
        CREATE INDEX {table_name}_sid ON te.{table_name}(sd_sid);";

        Execute_IEC_SQL(sql_string);     // Note different database for IEC test data
    }
    
    public void create_table_study_iec_by_years()
    {
        create_iec_table("study_iec_null");
        create_iec_table("study_iec_pre06");
        create_iec_table("study_iec_0608");
        create_iec_table("study_iec_0910");
        create_iec_table("study_iec_1112");
        create_iec_table("study_iec_1314");
        for (int i = 15; i <= 30; i++)
        {
            create_iec_table($"study_iec_{i}");
        }
    }
    
}