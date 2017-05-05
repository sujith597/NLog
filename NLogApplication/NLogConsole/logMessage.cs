using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogConsole
{
    public class LogMessage
    {
        public string ClientID { get; set; }
        public string PropertyID { get; set; }
        public string UserID { get; set; }
        public string SessionID { get; set; }
        public string RequestID { get; set; }
        public string CorrelationID { get; set; }
        public string API { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
        public string Data { get; set; }
        public string ClassName { get; set; }
        public string Timestamp { get; set; }
        public string Environment { get; set; }
        public string StackTrace { get; set; }
        public LogLevel LogLevel { get; set; }
        public string Application { get; set; }
        public string IPAddress { get; set; }
        public string MachineName { get; set; }
        KeyValuePair<string, string>[] parameters = null;

    }
    public enum LogLevel
    {
        Debug,
        Error,
        Fatal,
        Info,
        Off,
        Warn
    }
}
