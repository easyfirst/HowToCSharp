using System;
using System.Collections.Generic;
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
        private readonly List<IMessage> observers = new List<IMessage>();

        

        public void Start()
        {
            Console.WriteLine("LongRunningProcess: 0%");

            //todo: notify the curious participants (Observer)
            SendMessage(0);
            Console.WriteLine();

            Thread.Sleep(1000);
            Console.WriteLine("LongRunningProcess: 25%");
            SendMessage(25);
            Console.WriteLine();

            Thread.Sleep(1000);
            Console.WriteLine("LongRunningProcess: 50%");
            SendMessage(50);
            Console.WriteLine();

            Thread.Sleep(1000);
            Console.WriteLine("LongRunningProcess: 75%");
            SendMessage(75);
            Console.WriteLine();

            Thread.Sleep(1000);
            Console.WriteLine("LongRunningProcess: 100%");
            SendMessage(100);
            Console.WriteLine();
        }

        /// <summary>
        /// Subscribing to the list of observers.
        /// </summary>
        /// <param name="observer">Subscribe class</param>
        public void Subscribe(IMessage observer)
        {
            observers.Add(observer);
        }

        /// <summary>
        /// Unsubscribing to the list of observers.
        /// </summary>
        /// <param name="observer">Unsubscribe class</param>
        public void Unsubscribe(IMessage observer)
        {
            observers.Remove(observer);
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