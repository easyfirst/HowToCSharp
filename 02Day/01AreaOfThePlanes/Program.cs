using System;

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

            Console.ReadLine();
        }
    }
}
