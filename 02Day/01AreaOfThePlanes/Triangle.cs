using System;

namespace _01AreaOfThePlanes
{
    public class Triangle :IPlane
    {
        private int trianglebase;
        private int height;

        public Triangle(int trianglebase, int height)
        {
            this.trianglebase = trianglebase;
            this.height = height;
        }

        public double Area()
        {
            return (trianglebase * height) / 2;
        }
    }
}