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

            process.DataChanged += log.Message;
            process.DataChanged += ui.Message;

            /// Problems:
            /// 
            /// 1. I can initialize the call list from the outside
            /// process.ObserversCallList = null;
            ///  
            /// The builder already does not allow this by event:
            /// process.DataChanged = null;
            /// 
            /// 2. I can call the call list from outside
            /// process.ObserversCallList(new LongRunningProcess());
            /// 
            /// The builder already does not allow this by event:
            /// process.DataChanged(new LongRunningProcess(), "I cheated");


            process.Start();

            process.DataChanged -= log.Message;
            process.DataChanged -= ui.Message;

            Console.WriteLine("The process is done.");

            Console.ReadLine();
        }
    }
}
