using System;
using System.Threading;
using Serilog;

namespace _07Serilog
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Serilog Logger static property is reachable from every class.
            // The file location is: 07Serilog \ bin \ Debug \ netcoreapp2.1 \ serilog.log
            Serilog.Log.Logger = new Serilog.LoggerConfiguration()
                                            .WriteTo.Console()
                                            .WriteTo.File(".\\serilog.log")
                                            .CreateLogger();

            var r = new Random();
            while (!Console.KeyAvailable) //It is running till a key is press down.
            {
                //We select a level randomly for logging.
                var level = r.Next(100);
                //We simulate working of a program.
                //We would like more logs of low level. The worse the entry is, the less it will be
                if (level < 50)
                { //The lowest level, but most frequent messages (Debug)
                    Log.Logger.Debug($"Debug: {level}");
                }
                if (level >= 50 && level < 70)
                { //Info
                    Log.Logger.Information($"Information: {level}");
                }
                if (level >= 70 && level < 85)
                { //Warning
                    Log.Logger.Warning($"Warning: {level}");
                }
                if (level >= 85 && level < 95)
                { //Error
                    Log.Logger.Error($"Error: {level}");
                }
                if (level >= 95)
                { //Fatal
                    Log.Logger.Fatal($"Fatal: {level}");
                }
                Thread.Sleep(200);
            }
        }
    }
}
