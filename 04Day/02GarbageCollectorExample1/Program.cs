using System;
using System.Collections.Generic;
using System.Threading;

namespace _02GarbageCollectorExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            var o = new MyObject();

            Console.WriteLine($"Aging of 'o': {GC.GetGeneration(o)}");
            GC.Collect();

            Console.WriteLine($"Aging: {GC.GetGeneration(o)}");
            GC.Collect();

            Console.WriteLine($"Aging: {GC.GetGeneration(o)}");
            GC.Collect();

            Console.WriteLine($"Aging: {GC.GetGeneration(o)}");
            GC.Collect();

            Console.WriteLine($"Aging: {GC.GetGeneration(o)}");
            GC.Collect();

            Console.WriteLine($"Aging: {GC.GetGeneration(o)}");
            GC.Collect();

            var content = new List<string>();

            for (int i = 0; i < 600; i++)
            {
                Thread.Sleep(20);
                content.Add(new string('C', 6000));
                Console.WriteLine($"Aging of 'content': {GC.GetGeneration(content)}");
            }

            Console.ReadLine();
        }
    }
}
