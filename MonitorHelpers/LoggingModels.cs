﻿using Dapper.Contrib.Extensions;
namespace MDR_Tester;



[Table("sf.source_parameters")]
public class Source
{
    public int id { get; }
    public string? source_type { get; }
    public int? preference_rating { get; }
    public string? database_name { get; }
    public string? repo_name { get; }
    public string? db_conn { get; set; }
    public bool? uses_who_harvest { get; }
    public int? harvest_chunk { get; }
    public string? local_folder { get; }
    public bool? local_files_grouped { get; }
    public int? grouping_range_by_id { get; }
    public string? local_file_prefix { get; }
    public bool? has_study_tables { get; }
    public bool? has_study_topics { get; }
    public bool? has_study_conditions { get; }
    public bool? has_study_features { get; }
    public bool? has_study_iec{ get; }
    public bool? has_study_people{ get; }
    public bool? has_study_organisations{ get; }
    public bool? has_study_references { get; }
    public bool? has_study_relationships { get; }
    public bool? has_study_countries { get; }
    public bool? has_study_locations { get; }
    public bool? has_study_links { get; }
    public bool? has_study_ipd_available { get; }
    public string? study_iec_storage_type { get; }
    public bool? has_object_datasets { get; }
    public bool? has_object_instances { get; }
    public bool? has_object_dates { get; }
    public bool? has_object_descriptions { get; }
    public bool? has_object_identifiers { get; }
    public bool? has_object_people { get; }
    public bool? has_object_organisations { get; }
    public bool? has_object_topics { get; }
    public bool? has_object_comments { get; }
    public bool? has_object_db_links { get; }
    public bool? has_object_publication_types{ get; }
    public bool? has_journal_details { get; }
    public bool? has_object_rights { get; }
    public bool? has_object_relationships { get; }
    
    
}

[Table("sf.source_parameters")]
public class SourceX
{
    public int id { get; }
    public string? source_type { get; }
    public int? preference_rating { get; }
    public string? database_name { get; }
    public string? repo_name { get; }
    public string? db_conn { get; set; }
    public bool? uses_who_harvest { get; }
    public int? harvest_chunk { get; }
    public string? local_folder { get; }
    public bool? local_files_grouped { get; }
    public int? grouping_range_by_id { get; }
    public string? local_file_prefix { get; }
    public bool? has_study_tables { get; }
    public bool? has_study_topics { get; }
    public bool? has_study_conditions { get; }
    public bool? has_study_features { get; }
    public bool? has_study_iec{ get; }
    public string? study_iec_storage_type { get; }
    public bool? has_study_organisations { get; }
    public bool? has_study_people { get; }
    public bool? has_study_references { get; }
    public bool? has_study_relationships { get; }
    public bool? has_study_links { get; }
    public bool? has_study_countries { get; }
    public bool? has_study_locations { get; }
    public bool? has_study_ipd_available { get; }
    public bool? has_object_datasets { get; }
    public bool? has_object_dates { get; }
    public bool? has_object_relationships { get; }
    public bool? has_object_rights { get; }
    public bool? has_object_pubmed_set { get; }
    public bool? has_object_doi_set { get; }
}


[Table("sf.import_events")]
public class ImportEvent
{
    [ExplicitKey]
    public int? id { get; set; }
    public int? source_id { get; set; }
    public DateTime? time_started { get; set; }
    public DateTime? time_ended { get; set; }
    public bool? tables_rebuilt { get; set; }
    public int? num_sd_studies { get; set; }
    public int? num_matched_studies { get; set; } = 0;
    public int? num_sd_objects { get; set; }
    public int? num_matched_objects { get; set; } = 0;
    public string? comments { get; set; }

    public ImportEvent(int? _id, int? _source_id, bool? _tables_rebuilt)
    {
        id = _id;
        source_id = _source_id;
        time_started = DateTime.Now;
        tables_rebuilt = _tables_rebuilt;
    }
}


[Table("sf.source_data_studies")]
public class StudyFileRecord
{
    public int? id { get; set; }
    public int? source_id { get; set; }
    public string? sd_id { get; set; }
    public string? remote_url { get; set; }
    public DateTime? last_revised { get; set; }
    public bool? assume_complete { get; set; }
    public int? download_status { get; set; }
    public string? local_path { get; set; }
    public int? last_saf_id { get; set; }
    public DateTime? last_downloaded { get; set; }
    public int? last_harvest_id { get; set; }
    public DateTime? last_harvested { get; set; }
    public int? last_import_id { get; set; }
    public DateTime? last_imported { get; set; }

    // constructor when a revision date can be expected (not always there)
    public StudyFileRecord(int? _source_id, string? _sd_id, string? _remote_url, int? _last_saf_id,
                                          DateTime? _last_revised, string? _local_path)
    {
        source_id = _source_id;
        sd_id = _sd_id;
        remote_url = _remote_url;
        last_saf_id = _last_saf_id;
        last_revised = _last_revised;
        download_status = 2;
        last_downloaded = DateTime.Now;
        local_path = _local_path;
    }

    // constructor when an 'assumed complete' judgement can be expected (not always there)
    public StudyFileRecord(int? _source_id, string? _sd_id, string? _remote_url, int? _last_saf_id,
                                          bool? _assume_complete, string? _local_path)
    {
        source_id = _source_id;
        sd_id = _sd_id;
        remote_url = _remote_url;
        last_saf_id = _last_saf_id;
        assume_complete = _assume_complete;
        download_status = 2;
        last_downloaded = DateTime.Now;
        local_path = _local_path;
    }


    public StudyFileRecord()
    { }

}


[Table("sf.source_data_objects")]
public class ObjectFileRecord
{
    public int? id { get; set; }
    public int? source_id { get; set; }
    public string? sd_id { get; set; }
    public string? remote_url { get; set; }
    public DateTime? last_revised { get; set; }
    public bool? assume_complete { get; set; }
    public int? download_status { get; set; }
    public string? local_path { get; set; }
    public int? last_saf_id { get; set; }
    public DateTime? last_downloaded { get; set; }
    public int? last_harvest_id { get; set; }
    public DateTime? last_harvested { get; set; }
    public int? last_import_id { get; set; }
    public DateTime? last_imported { get; set; }

    // constructor when a revision data can be expected (not always there)
    public ObjectFileRecord(int? _source_id, string? _sd_id, string? _remote_url, int? _last_saf_id,
                                          DateTime? _last_revised, string? _local_path)
    {
        source_id = _source_id;
        sd_id = _sd_id;
        remote_url = _remote_url;
        last_saf_id = _last_saf_id;
        last_revised = _last_revised;
        download_status = 2;
        last_downloaded = DateTime.Now;
        local_path = _local_path;
    }

    // constructor when an 'assumed complete' judgement can be expected (not always there)
    public ObjectFileRecord(int? _source_id, string? _sd_id, string? _remote_url, int? _last_saf_id,
                                          bool? _assume_complete, string? _local_path)
    {
        source_id = _source_id;
        sd_id = _sd_id;
        remote_url = _remote_url;
        last_saf_id = _last_saf_id;
        assume_complete = _assume_complete;
        download_status = 2;
        last_downloaded = DateTime.Now;
        local_path = _local_path;
    }

    public ObjectFileRecord()
    { }

}

public class att_stat
{
    public int? status { get; set; }
    public int? num { get; set; }
}
