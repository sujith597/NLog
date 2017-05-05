using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using NLog.Config;
using NLog.Internal;
using NLog.Layouts;
using NLog.Targets;

namespace NLogConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger _logger = new Logger(typeof(Program).ToString());
            Exception ex = new InvalidDataException();
            _logger.Log(NLog.LogLevel.Fatal, typeof(Program).ToString(), ex, 5);
            _logger.Log(NLog.LogLevel.Error, typeof(Program).ToString(), ex, 10);
            _logger.Log(NLog.LogLevel.Warn, typeof(Program).ToString(), ex, 20);
            _logger.Log(NLog.LogLevel.Info, typeof(Program).ToString(), ex, 25);
            _logger.Log(NLog.LogLevel.Debug, typeof(Program).ToString(), ex, 30);
           
            Exception ex1 = new InvalidDataException();
          //LogInfo(LogLevel.Fatal, "New241 This is Test", typeof(Program).ToString(), ex1);
            Console.WriteLine("Operation COmpleted");
            Console.ReadKey();
        }
        //private static void LogInfo(LogLevel logLevel, string message, string callingAssembly, Exception ex = null, KeyValuePair<string, string>[] parameters = null)
        //{
        //    var config = new LoggingConfiguration();
        //    var envName = "Local";
        //    var loggerName = callingAssembly;

        //    if (!String.IsNullOrEmpty(callingAssembly)) callingAssembly = callingAssembly.ToLower();
        //    if (!String.IsNullOrEmpty(envName)) loggerName = $"{callingAssembly}-{envName}".ToLower();
        //    if (ex != null) message = $"{message} {ex.ToString()}";
        //    loggerName = loggerName.ToLower();

        //    using (var fluentdTarget = new Fluentd())
        //    {
        //        fluentdTarget.Host = "";
        //        fluentdTarget.Port = 24224;
        //        fluentdTarget.Layout = Layout.FromString("${message}");
        //        fluentdTarget.Tag = callingAssembly;
        //        fluentdTarget.EmitStackTraceWhenAvailable = true;
        //        config.AddTarget("fluentd", fluentdTarget);
        //        config.LoggingRules.Add(new LoggingRule(loggerName, LogLevel.Fatal, fluentdTarget));

        //        var entry = new LogEventInfo()
        //        {
        //            TimeStamp = DateTime.UtcNow,
        //            Level = logLevel,
        //            Message = message,
        //            LoggerName = loggerName,
        //            Exception = ex == null ? null : ex
        //        };

        //        if (parameters != null)
        //        {
        //            foreach (var par in parameters)
        //            {
        //                fluentdTarget.Layout = fluentdTarget.Layout + "${event-properties:item=" + par.Key + "}";
        //                entry.Properties[par.Key] = par.Value;
        //            }
        //        }

        //        var loggerFactory = new LogFactory(config);
        //        var logger = loggerFactory.GetLogger(loggerName);

        //        logger.Log(entry);

        //    }
        //}

    }
}
