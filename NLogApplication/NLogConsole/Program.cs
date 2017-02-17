using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace NLogConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger log = LogManager.GetCurrentClassLogger();
            log.Trace("This is a Trace message");
            log.Debug("This is a debug message");
            log.Info("This is information message");
            log.Warn("This is warning message");
            log.Error("This is error");
            log.Fatal("This is fater error message");

            Console.ReadLine();
        }

    }
}
