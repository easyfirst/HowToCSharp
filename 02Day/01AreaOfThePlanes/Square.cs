using System;

namespace _01AreaOfThePlanes
{
    public class Square :Plane
    {
        private int side;

        public Square(int side)
        {
            this.side = side;
        }

        public override double Area()
        {
            return side * side;
        }
    }
}