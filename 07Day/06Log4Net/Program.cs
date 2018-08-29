using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _06Log4Net
{
    class Program
    {
        //Through this property, works all the logging of that class go through this property
        //http://logging.apache.org/log4net/release/faq.html#static-class-name
        // The name of logger indicate the class which is logged.
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger("_06Log4Net.Program"));
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            // Loading configuration from "app.config".
            log4net.Config.XmlConfigurator.Configure();

            var r = new Random();
            while (!Console.KeyAvailable) //It is running till a key is press down.
            {
                //We select a level randomly for logging.
                var level = r.Next(100);
                //We simulate working of a program.
                //We would like more logs of low level. The worse the entry is, the less it will be
                if (level < 50)
                { //The lowest level, but most frequent messages (Debug)
                    log.Debug($"Debug message: {level}");
                }
                if (level >= 50 && level < 70)
                { //Info
                    log.Info($"Info message: {level}");
                }
                if (level >= 70 && level < 85)
                { //Warning
                    log.Warn($"Warning message: {level}");
                }
                if (level >= 85 && level < 95)
                { //Error
                    log.Error($"Error message: {level}");
                }
                if (level >= 95)
                { //Fatal
                    log.Fatal($"Fatal error message: {level}");
                }
                Thread.Sleep(200);
            }
        }
    }
}
