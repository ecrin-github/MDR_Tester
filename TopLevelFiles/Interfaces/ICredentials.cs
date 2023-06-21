
namespace MDR_Tester;

public interface ICredentials
{
    string? Password { get; set; }
    string? Username { get; set; }
    string GetConnectionString(string databaseName);
}

