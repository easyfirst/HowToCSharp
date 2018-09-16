using System;
using System.Threading;
using System.Threading.Tasks;

namespace _02Tasks
{
    class Program
    {
        // To test this functions You have to run this code with Ctrl + F5 !!!

        static void Main(string[] args)
        {
            // Focusing to the statuses of task
            //Test1();

            // Catching exceptions
            //Test2();

            // Task cancel
            Test3();

            Console.ReadLine();
        }

        private static void Test3()
        {
            var cts = new CancellationTokenSource(); //1. this is a radio station that the task will take while driving

            Action todo = () =>
            {
                for (int i = 0; i < 10; i++)
                {
                    if (cts.Token.IsCancellationRequested)
                    { // 3.a if we have issued the cancel, then we can validate or clean it here, see. IDisposable
                        Console.WriteLine($"{i}: We got Cancel");
                    }

                    cts.Token.ThrowIfCancellationRequested(); //3.b with this will leave the task running

                    Console.WriteLine($"i: {i}");
                    Thread.Sleep(100);
                }
            };
            
            var task = new Task(todo, cts.Token); //2. we transfer the radio station to the task so that we can stop it later

            task.Start();
            Thread.Sleep(200);

            Console.WriteLine("We stop the task");

            cts.Cancel(); // we shut down the task with this command

            try
            {
                task.Wait(); //4. you have to wait for the end of the task
            }
            catch (AggregateException ex)
            {
                //5. have to deal with the cancelt!
                foreach (var e in ex.InnerExceptions)
                {
                    Console.WriteLine($"Exception {e.Message}");
                    if (e is TaskCanceledException)
                    {
                        Console.WriteLine("Cancel has occurred");
                    }
                }
            }
        }

        private static void Test2()
        {
            Action todo = () =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"i: {i}");
                    Thread.Sleep(100);
                }
                throw new StackOverflowException();
            };

            var task = new Task(todo);
            task.Start();


            //To get the exception, we have to wait for the task !!!
            try
            {
                task.Wait();
            }
            catch (AggregateException ex)
            {
                // The Flatten() extends the complicated exception tree
                Console.WriteLine("The Flatten() extends the complicated exception tree:");
                Console.WriteLine(ex.Flatten().Message);
                Console.WriteLine();

                //or 

                Console.WriteLine(" ... or we can write the InnerExceptions with foreach:");
                foreach (var e in ex.InnerExceptions)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private static void Test1()
        {
            Action todo = () =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"i: {i}");
                    Thread.Sleep(300);
                }
            };

            //var task = new Task(todo2);

            var task = new Task(todo);

            Console.WriteLine($"Status: {task.Status}");
            task.Start(); // Starting the task

            Console.WriteLine($"Status: {task.Status}");
            Thread.Sleep(100); // waiting a bit

            Console.WriteLine($"Status: {task.Status}");
            task.Wait(); // waiting till the end of task

            Console.WriteLine($"Status: {task.Status}");

            //Status: Created
            //Status: WaitingToRun
            //i: 0
            //Status: Running
            //i: 1
            //i: 2
            //i: 3
            //i: 4
            //i: 5
            //i: 6
            //i: 7
            //i: 8
            //i: 9
            //Status: RanToCompletion
        }

        /// <summary>
        /// Instead of action you can declare a function definition like this
        /// </summary>
        static public void todo2()
        { }

    }
}
