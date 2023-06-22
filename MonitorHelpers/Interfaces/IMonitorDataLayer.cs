namespace MDR_Tester;

public interface IMonDataLayer
{
    Credentials Credentials { get; }
    
    bool SourceIdPresent(int? source_id);
    string GetConnectionString(string database_name);
    Source? FetchSourceParameters(int? source_id);
    IEnumerable<int>? FetchTestDBList();


    //int GetNextImportEventId();
    //int StoreImportEvent(ImportEvent import);
}

