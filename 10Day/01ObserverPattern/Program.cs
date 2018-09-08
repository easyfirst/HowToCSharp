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
            var process = new LongRunningProcess();

            process.Subscribe(log);
            process.Subscribe(ui);

            process.Start();

            process.Unsubscribe(log);
            process.Unsubscribe(ui);

            Console.WriteLine("The process is done.");

            Console.ReadLine();
        }
    }
}
