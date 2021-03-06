﻿using System;
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

        private int data;
        public int Data        // Implementing of IMessage
        {
            get { return data; }
            set
            {
                if (data == value) { return; } // If it has not changed then "do not panic"
 
                data = value;
                //todo: notify the curious participants (Observer)
                SendMessage();
            }
        }

        // If you want to share more information with your listeners, you will need to add this to the interface and it will be ready.
        public string Text { get; set; }   // Implementing of IMessage


        public void Start()
        {
            Console.WriteLine("LongRunningProcess: 0%");

            Data = 0;
            Console.WriteLine();

            Thread.Sleep(1000);
            Console.WriteLine("LongRunningProcess: 25%");
            Data = 25;
            Console.WriteLine();

            Thread.Sleep(1000);
            Console.WriteLine("LongRunningProcess: 50%");
            Data = 50;
            Console.WriteLine();

            Thread.Sleep(1000);
            Console.WriteLine("LongRunningProcess: 75%");
            Data = 75;
            Console.WriteLine();

            Thread.Sleep(1000);
            Console.WriteLine("LongRunningProcess: 100%");
            Data = 100;
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