using System;

namespace _01AreaOfThePlanes
{
    public class Triangle :Plane
    {
        private int trianglebase;
        private int height;

        public Triangle(int trianglebase, int height)
        {
            this.trianglebase = trianglebase;
            this.height = height;
            this.Name = "triangle";
        }

        public override double Area()
        {
            return (trianglebase * height) / 2;
        }
    }
}