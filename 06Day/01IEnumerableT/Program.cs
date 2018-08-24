using System;

namespace _01IEnumerableT
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Data(number: 1, text: "beef");

            var datasets = new CyclableData<Data>();  //It has two important roles: contains data and makes them cyclable (crawlable).

            datasets.Add(data);
            datasets.Add(new Data(number: 2, text: "salt"));
            datasets.Add(new Data(number: 3, text: "potato"));
            datasets.Add(new Data(number: 4, text: "red pepper"));

            Console.ReadLine();
        }
    }
}
