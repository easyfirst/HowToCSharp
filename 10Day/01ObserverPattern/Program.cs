using System;

namespace _01ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //The two application modules that require information
            //they are the observers: (Observers)

            //logging
            var log = new Logger();

            //and user interface
            var ui = new UserInterface();

            //the long-term process
            var process = new LongRunningProcess(log, ui);

            // So you can use the function, thanks for the keyword "params":
            //process = new LongRunningProcess();
            //process = new LongRunningProcess(log);
            //process = new LongRunningProcess(log, ui, log, log);



            process.Start();

            Console.WriteLine("The process is done.");

            Console.ReadLine();
        }
    }
}
