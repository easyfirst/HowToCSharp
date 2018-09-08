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
         private readonly IMessage[] observers;

        public LongRunningProcess(params IMessage[] observers)
        {
            this.observers = observers ?? throw new ArgumentNullException(nameof(observers)) ;
        }

        public void Start()
        {
            Console.WriteLine("LongRunningProcess: 0%");

            //todo: notify the curious participants (Observer)
            SendMessage(0);
            Console.WriteLine();

            Thread.Sleep(1000);
            Console.WriteLine("LongRunningProcess: 25%");
            SendMessage(0);
            Console.WriteLine();

            Thread.Sleep(1000);
            Console.WriteLine("LongRunningProcess: 50%");
            SendMessage(0);
            Console.WriteLine();

            Thread.Sleep(1000);
            Console.WriteLine("LongRunningProcess: 75%");
            SendMessage(0);
            Console.WriteLine();

            Thread.Sleep(1000);
            Console.WriteLine("LongRunningProcess: 100%");
            SendMessage(0);
            Console.WriteLine();
        }

        /// <summary>
        /// It will notify all observers.
        /// </summary>
        /// <param name="data">The information what is needed to be sent</param>
        private void SendMessage(int data)
        {
            foreach (var observer in observers)
            {
                observer.Message(data);
            }
        }
    }
}