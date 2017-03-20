using NLog;
using System;

namespace NLogConsole
{
    public class Logger
    {
        public void Log(LogLevel logStatus, string callingAssembly, Exception ex, int propertyId)
        {
            LogInfo(logStatus, callingAssembly, ex, propertyId);
        }
        private static void LogInfo(LogLevel logLevel, string callingAssembly, Exception ex, int propertyId)
        {
            String EnviromentDetails = "Client ID : " + propertyId +
                                       "|| Class : " + callingAssembly.ToString() +
                                       " || Follwed By Environment Details";
            var entry = new LogEventInfo()
            {
                TimeStamp = DateTime.UtcNow,
                Level = logLevel,
                Message = EnviromentDetails,
                LoggerName = "",
                Exception = ex == null ? null : ex
            };

            var logger = LogManager.GetCurrentClassLogger();
            logger.Log(entry);
        }
    }
}