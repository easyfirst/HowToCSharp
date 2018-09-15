using _03CodeFirstCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _03CodeFirstCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Server=.\\SQLEXPRESS;Database=CodeFirstDB;Trusted_Connection=True;";
            var optionsBuilder = new DbContextOptionsBuilder<CodeFirstContext>();

            optionsBuilder.UseSqlServer(connectionString);

            var db = new CodeFirstContext(optionsBuilder.Options);

            //todo: check if the database exists
            //todo: and if it does not exist, it must be created.
            db.Database.Migrate();

            if (db.Teachers.Count() == 0)
            { // check data
                Seed(db);
            }
            Console.WriteLine($"The number of teachers: {db.Teachers.Count()}, The number of subjects: {db.Subjects.Count()}");
            Console.ReadLine();
        }

        private static void Seed(CodeFirstContext db)
        {
            var subjects = new List<Subject>();
            subjects.Add(new Subject() { Name = "Mathematics" });
            subjects.Add(new Subject() { Name = "Physics" });
            db.Teachers.Add(new Teacher() { Name = "John Smith", Subject = subjects });
            db.SaveChanges();
        }
    }
}	
