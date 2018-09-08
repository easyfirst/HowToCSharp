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

        // You can send a comma-separated list of arguments of the specified type.
        // A params parameter accepts zero or more arguments.
        public LongRunningProcess(params IMessage[] observers)
        {
            // ?? operator: Null coalescing. For example: x ?? y  Evaluates to y if x is null, to x otherwise
            // The ?? operator is called the null-coalescing operator and is used to define
            // a default value for a nullable value types as well as reference types.
            //
            // It returns the left-hand operand if it is not null; otherwise it returns the right operand.
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