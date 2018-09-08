using System;
using System.Threading;

namespace _01ObserverPattern
{
    /// <summary>
    /// An example of a class performing a long process.
    /// This will notify the others if something happened.
    /// Observable / Observed Player (operator)
    /// </summary>
    public class LongRunningProcess
    {
        private IMessage log;
        private IMessage ui;

        public LongRunningProcess(IMessage log, IMessage ui)
        {
            this.log = log;
            this.ui = ui;
        }

        public void Start()
        {
            Console.WriteLine("LongRunningProcess: 0%");

            //todo: notify the curious participants (Observer)
            log.Message(0);
            ui.Message(0);
            Console.WriteLine();

            Thread.Sleep(1000);
            Console.WriteLine("LongRunningProcess: 25%");
            log.Message(25);
            ui.Message(25);
            Console.WriteLine();

            Thread.Sleep(1000);
            Console.WriteLine("LongRunningProcess: 50%");
            log.Message(50);
            ui.Message(50);
            Console.WriteLine();

            Thread.Sleep(1000);
            Console.WriteLine("LongRunningProcess: 75%");
            log.Message(75);
            ui.Message(75);
            Console.WriteLine();

            Thread.Sleep(1000);
            Console.WriteLine("LongRunningProcess: 100%");
            log.Message(100);
            ui.Message(100);
            Console.WriteLine();
        }
    }
}