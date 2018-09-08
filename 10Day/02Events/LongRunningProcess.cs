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
        // Defining the event
        // at the same time
        // 1. type definition and
        // 2. declaration of the  call list variable
        //
        // This defines a special delegate:
        // a.) only defines a void type function
        // b.) can't call the call list from outside
        // c.) can't initialize the call list from the outside

        // The function has two parameters in each case:
        // if the definition is EventHandler <T> then:
        // object sender,
        // and
        // T e
        // The first is mandatory, the second is designated by the generic parameter.

        // If I do not want to highlight a parameter then it is an empty definition,
        // public event EventHandler<EventArgs> DataChanged;

        // otherwise you have to define Dto, which is derived from EventArgs
        public event EventHandler<EventDto> DataChanged;

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
        /// We enclose the calling event list into a private function.
        /// </summary>
        /// <param name="data"></param>
        private void OnDataChanged(int data)
        {
            var callList = DataChanged;
            if (callList != null)
            {
                // If there is no priority parameter, we call this in this way:
                //callList(this, EventArgs.Empty);

                callList(this, new EventDto(data));
            }

            //faster solution:
            //ObserversCallList?.Invoke(this);
        }

        /// <summary>
        /// It will notify all observers.
        /// </summary>
        private void SendMessage()
        {
            OnDataChanged(Data);
        }
    }
}