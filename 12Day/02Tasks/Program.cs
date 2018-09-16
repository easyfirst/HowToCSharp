using System;
using System.Threading;
using System.Threading.Tasks;

namespace _02Tasks
{
    class Program
    {
        static void Main(string[] args)
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

            Console.ReadLine();

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
