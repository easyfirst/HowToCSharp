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
    public class LongRunningProcess : IMessage
    {
        private readonly List<INotifiable> observers = new List<INotifiable>();

        public int Data { get; set; }   // Implementing of IMessage

        // If you want to share more information with your listeners, you will need to add this to the interface and it will be ready.
        public string Text { get; set; }   // Implementing of IMessage


        public void Start()
        {
            Console.WriteLine("LongRunningProcess: 0%");

            //todo: notify the curious participants (Observer)
            Data = 0;
            SendMessage();
            Console.WriteLine();

            Thread.Sleep(1000);
            Console.WriteLine("LongRunningProcess: 25%");
            Data = 25;
            SendMessage();
            Console.WriteLine();

            Thread.Sleep(1000);
            Console.WriteLine("LongRunningProcess: 50%");
            Data = 50;
            SendMessage();
            Console.WriteLine();

            Thread.Sleep(1000);
            Console.WriteLine("LongRunningProcess: 75%");
            Data = 75;
            SendMessage();
            Console.WriteLine();

            Thread.Sleep(1000);
            Console.WriteLine("LongRunningProcess: 100%");
            Data = 100;
            SendMessage();
            Console.WriteLine();
        }

        /// <summary>
        /// Subscribing to the list of observers.
        /// </summary>
        /// <param name="observer">Subscribe class</param>
        public void Subscribe(INotifiable observer)
        {
            observers.Add(observer);
        }

        /// <summary>
        /// Unsubscribing to the list of observers.
        /// </summary>
        /// <param name="observer">Unsubscribe class</param>
        public void Unsubscribe(INotifiable observer)
        {
            observers.Remove(observer);
        }

        /// <summary>
        /// It will notify all observers.
        /// </summary>
        private void SendMessage()
        {
            foreach (var observer in observers)
            {
                observer.Message(this);
            }
        }
    }
}