﻿using System;

namespace _01AreaOfThePlanes
{
    public class Circle :Plane
    {
        private int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return (2 * radius * Math.PI);
        }
    }
}