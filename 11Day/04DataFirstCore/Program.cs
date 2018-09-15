using _04DataFirstCore.Models;
using System;
using System.Linq;

namespace _04DataFirstCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new CodeFirstDBContext();

            Console.WriteLine($"The number of teachers: {db.Teachers.Count()}, The number of subjects: {db.Subjects.Count()}");

            Console.ReadLine();
        }
    }
}
