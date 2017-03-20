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
            Logger _logger = new Logger();
            Exception ex = new Exception();
            _logger.Log(LogLevel.Fatal, typeof(Program).ToString(), ex, 5);
            _logger.Log(LogLevel.Error, typeof(Program).ToString(), ex, 10);
            _logger.Log(LogLevel.Warn, typeof(Program).ToString(), ex, 20);
            _logger.Log(LogLevel.Info, typeof(Program).ToString(), ex, 25);
            _logger.Log(LogLevel.Debug, typeof(Program).ToString(), ex, 30);
            _logger.Log(LogLevel.Trace, typeof(Program).ToString(), ex, 35);


            Console.ReadLine();
        }

    }
}
