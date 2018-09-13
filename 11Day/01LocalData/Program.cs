using System;
using System.IO;

namespace _01LocalData
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path is a static class that helps you in paths.

            // you should normally abstain from the absolute paths, instead you should use a relative path.

            // for example: relativ path
            var path = "MyOneDirectory";

            //and absolute path
            Console.WriteLine($"This is a relativ path: {path}\n");
            Console.WriteLine($" and this is the absolute path of the path above: {Path.GetFullPath(path)}");

            Console.ReadLine();
        }
    }
}
