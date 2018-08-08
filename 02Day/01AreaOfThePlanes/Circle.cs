using System;

namespace _01AreaOfThePlanes
{
    public class Circle :IPlane
    {
        private int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public int Area()
        {
            return (int)(2 * radius * Math.PI);
        }
    }
}