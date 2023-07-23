
namespace MDR_Tester;

public interface ILoggingHelper
{
   
    void LogLine(string message, string identifier = "");    
    void LogBlank();   
    void LogHeader(string header_text);
    void LogTableHeader(string header_text);
    void LogSDIDHeader(string type, string sdid, int fbLevel);
    void LogStudyHeader(Options opts, string dbLine);   
    
    void LogError(string message);
    void LogCodeError(string header, string errorMessage, string? stackTrace);
    void LogParseError(string header, string errorNum, string errorType);   
    
    void LogCommandLineParameters(Options opts);
    
    void OpenLogFile(string database_name);
    void OpenNoSourceLogFile();    

    void CloseLog();   
    
}

