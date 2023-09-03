using Microsoft.Extensions.Configuration;
using Npgsql;
namespace MDR_Tester;

public class Credentials : ICredentials
{
    private readonly string? _host;
    public readonly string? _username; 
    public readonly string? _password; 
    private readonly int _port;

    public Credentials(IConfiguration settings)
    {
        _host = settings["host"];
        _username = settings["user"];
        _password = settings["password"];
        string? PortAsString = settings["port"];
        if (string.IsNullOrWhiteSpace(PortAsString))
        {
            _port = 5432;  // default
        }
        else
        {
            _port = int.TryParse(PortAsString, out int port_num) ? port_num : 5432;
        }
    }

    public string GetConnectionString(string database_name)
    {
        NpgsqlConnectionStringBuilder builder = new NpgsqlConnectionStringBuilder
        {
            Host = _host,
            Username = _username,
            Password = _password,
            Database = database_name,
            Port = _port,
            KeepAlive = 300,
            IncludeErrorDetail = true
        };
        return builder.ConnectionString;
    }
}

