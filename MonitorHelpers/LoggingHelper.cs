using Microsoft.Extensions.Configuration;

namespace MDR_Tester;

public class LoggingHelper : ILoggingHelper
{
    private readonly string? _logfileStartOfPath;
    private readonly string? _summaryLogfileStartOfPath;  
    private string _logfilePath = "";
    private string _summaryLogfilePath = "";
    private StreamWriter? _sw;

    public LoggingHelper()
    {
        IConfigurationRoot settings = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

        _logfileStartOfPath = settings["logFilePath"] ?? "";
        _summaryLogfileStartOfPath = settings["summaryFilePath"] ?? "";
    }

    public string LogFilePath => _logfilePath;

    
    public void OpenLogFile(string databaseName)
    {
        string dtString = DateTime.Now.ToString("s", System.Globalization.CultureInfo.InvariantCulture)
            .Replace(":", "").Replace("T", " ");

        string logFolderPath = Path.Combine(_logfileStartOfPath!, databaseName);
        if (!Directory.Exists(logFolderPath))
        {
            Directory.CreateDirectory(logFolderPath);
        }
        
        string logFileName = "TS " + databaseName + " " + dtString + ".log";
        _logfilePath = Path.Combine(logFolderPath, logFileName);
        _summaryLogfilePath = Path.Combine(_summaryLogfileStartOfPath!, logFileName);
        _sw = new StreamWriter(_logfilePath, true, System.Text.Encoding.UTF8);
    }
    

    public void OpenNoSourceLogFile()
    {
        string dtString = DateTime.Now.ToString("s", System.Globalization.CultureInfo.InvariantCulture)
            .Replace(":", "").Replace("T", " ");
        
        string logFileName = "IM Source not set " + dtString + ".log";
        _logfilePath = Path.Combine(_logfileStartOfPath!, logFileName);
        _summaryLogfilePath = Path.Combine(_summaryLogfileStartOfPath!, logFileName);
        _sw = new StreamWriter(_logfilePath, true, System.Text.Encoding.UTF8);
    }

    public void LogLine(string message, string identifier = "")
    {
        string dtPrefix = DateTime.Now.ToShortDateString() + " : " + DateTime.Now.ToShortTimeString() + " :   ";
        string feedback = dtPrefix + message + identifier;
        Transmit(feedback);
    }
    
    public void LogHeader(string message)
    {
        string dtPrefix = DateTime.Now.ToShortDateString() + " : " + DateTime.Now.ToShortTimeString() + " :   ";
        Transmit("");
        Transmit(dtPrefix + "**** " + message.ToUpper() + " ****");
        Transmit("");
    }

    public void LogSDIDHeader(string sdid)
    {
        string dtPrefix = DateTime.Now.ToShortDateString() + " : " + DateTime.Now.ToShortTimeString() + " :   ";
        Transmit("");        
        Transmit(dtPrefix + "------------------------------");
        Transmit(dtPrefix + "ID: " + sdid);
        Transmit(dtPrefix + "------------------------------");
        Transmit("");
    }
    
    
    public void LogTableHeader(string message)
    {
        string dtPrefix = DateTime.Now.ToShortDateString() + " : " + DateTime.Now.ToShortTimeString() + " :   ";
        string header = dtPrefix + "**** " + message.ToUpper() + " TABLE" + " ****";
        Transmit("");
        Transmit(header);
    }
    
    
    public void LogFieldHeader(string message)
    {
        string dtPrefix = DateTime.Now.ToShortDateString() + " : " + DateTime.Now.ToShortTimeString() + " :   ";
        string header = dtPrefix + "**** " + message + " ****";
        Transmit(header);
    }
    
    
    public void LogStudyHeader(Options opts, string dbLine)
    {
        string dtPrefix = DateTime.Now.ToShortDateString() + " : " + DateTime.Now.ToShortTimeString() + " :   ";
        string dividerLine = new string('=', 70);
        Transmit("");
        Transmit(dividerLine);
        Transmit(dtPrefix + dbLine);
        Transmit(dividerLine);
        Transmit("");
    }


    public void LogError(string message)
    {
        string dtPrefix = DateTime.Now.ToShortDateString() + " : " + DateTime.Now.ToShortTimeString() + " :   ";
        string errorMessage = dtPrefix + "***ERROR*** " + message;
        Transmit("");
        Transmit("+++++++++++++++++++++++++++++++++++++++");
        Transmit(errorMessage);
        Transmit("+++++++++++++++++++++++++++++++++++++++");
        Transmit("");
    }


    public void LogCodeError(string header, string errorMessage, string? stackTrace)
    {
        string dtPrefix = DateTime.Now.ToShortDateString() + " : " + DateTime.Now.ToShortTimeString() + " :   ";
        string headerMessage = dtPrefix + "***ERROR*** " + header + "\n";
        Transmit("");
        Transmit("+++++++++++++++++++++++++++++++++++++++");
        Transmit(headerMessage);
        Transmit(errorMessage + "\n");
        Transmit(stackTrace ?? "");
        Transmit("+++++++++++++++++++++++++++++++++++++++");
        Transmit("");
    }


    public void LogParseError(string header, string errorNum, string errorType)
    {
        string dtPrefix = DateTime.Now.ToShortDateString() + " : " + DateTime.Now.ToShortTimeString() + " :   ";
        string errorMessage = dtPrefix + "***ERROR*** " + "Error " + errorNum + ": " + header + " " + errorType;
        Transmit(errorMessage);
    }
            

    public void LogCommandLineParameters(Options opts)
    {
        int[]? sourceIds = opts.SourceIds?.ToArray();
        if (sourceIds?.Length > 0)
        {
            if (sourceIds.Length == 1)
            {
                LogLine("Source_id is " + sourceIds[0]);
            }
            else
            {
                LogLine("Source_ids are " + string.Join(",", sourceIds));
            }
        }
        LogLine("");
    }


    public void CloseLog()
    {
        if (_sw is not null)
        {
            LogHeader("Closing Log");
            _sw.Flush();
            _sw.Close();
        }
        
        // Write out the summary file.
        
        var swSummary = new StreamWriter(_summaryLogfilePath, true, System.Text.Encoding.UTF8);
        
        swSummary.Flush();
        swSummary.Close();
    }
    
    private void Transmit(string message)
    {
        _sw!.WriteLine(message);
        Console.WriteLine(message);
    }
    
}