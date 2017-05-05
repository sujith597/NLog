using NLog;
using System;
using NLog.Config;
using NLog.Layouts;
using NLog.Targets;

namespace NLogConsole
{
    public class Logger
    {
        private string guid =Guid.NewGuid().ToString();
        public void Log(NLog.LogLevel logStatus, string callingAssembly, Exception ex, int propertyId)
        {
            LogInfo(logStatus, callingAssembly, ex, propertyId);
            

        }
        private NLog.Logger _logger;
        public Logger( string className)
        {
            _logger = LogManager.GetLogger(className);
        }

        internal void Log(object fatal, string v1, Exception ex, int v2)
        {
            throw new NotImplementedException();
        }

        public void LogInfo(NLog.LogLevel logLevel, string callingAssembly, Exception ex, int propertyId)
        {
            // Search with NLogConsole.Program
            String EnviromentDetails = "New240 Client ID : " + propertyId +
                                       "|| Class : " + callingAssembly.ToString() +
                                       " || Follwed By Environment Details";
            // var logfactory1 = new LogFactory();
            Console.WriteLine(guid);
            LogMessage logMessage = new LogMessage
            {
                RequestID = guid,
                Message = EnviromentDetails
            };
          
            var entry = new LogEventInfo()
                {
                    TimeStamp = DateTime.UtcNow,
                    Level = logLevel,
                    Message = EnviromentDetails,
                    LoggerName = "",
                    Exception = ex == null ? null : ex
                };
            foreach (var param in logMessage.GetType().GetProperties())
            {
                entry.Properties[param.Name] = param.GetValue(logMessage, null);
            }

            _logger.Log(typeof(Logger),entry);

        }
    }
}