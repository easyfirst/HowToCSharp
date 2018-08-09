using System;
using System.Collections.Generic;
using System.Linq;

namespace _01AreaOfThePlanes
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(side: 4);

            Console.WriteLine($"Area of the square: {square.Area()}");

            var circle = new Circle(radius: 5);
            Console.WriteLine($"Area of the circle: {circle.Area()}");

            var triangle = new Triangle(trianglebase: 6, height: 4);
            Console.WriteLine($"Area of the triangle: {triangle.Area()}");

            //Sum area:
            var areasum = square.Area();

            areasum = areasum + circle.Area();

            areasum += triangle.Area();
            Console.WriteLine($"The total area: {areasum}");


            // With interface
            var planes = new List<Plane>();

            planes.Add(square);
            planes.Add(circle);
            planes.Add(triangle);

            //var sum = 0;
            //foreach (var plane in planes)
            //{
            //    sum += plane.Area();
            //}
            //Console.WriteLine($"The total area: {sum}");

            //With Linq
            //var sum = planes.Sum(x => x.Area());
            //Console.WriteLine($"The total area: {sum}");

            // or

            Console.WriteLine($"The total area: {planes.Sum(x => x.Area())}");

            Console.ReadLine();
        }
    }
}
