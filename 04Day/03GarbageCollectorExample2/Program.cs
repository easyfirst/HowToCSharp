using System;
using System.Drawing;

namespace _03GarbageCollectorExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (!Console.KeyAvailable)
            {
                //This code burdens the memory.
                //var bitmap = new Bitmap(2048, 2048);

                //If we pay attention to cleaning with help of finalizer we have no memory and processor problem.
                using (var bitmap = new Bitmap(1280, 1024)) { }

            }
        }
    }
}
