using System;

namespace _07Serilog
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            while (!Console.KeyAvailable) //It is running till a key is press down.
            {
                //We select a level randomly for logging.
                var level = r.Next(100);
                //We simulate working of a program.
                //We would like more logs of low level. The worse the entry is, the less it will be
                if (level < 50)
                { //The lowest level, but most frequent messages (Debug)
                }
                if (level >= 50 && level < 70)
                { //Info
                }
                if (level >= 70 && level < 85)
                { //Warning
                }
                if (level >= 85 && level < 95)
                { //Error
                }
                if (level >= 95)
                { //Fatal
                }
                Thread.Sleep(200);
            }
        }
    }
}
