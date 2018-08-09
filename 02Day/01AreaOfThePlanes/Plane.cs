using System;

namespace _01AreaOfThePlanes
{
    // Only in abstract class can contains abstract function.
    // So this class must be abstract.
    public abstract class Plane : IPlane
    {
        // Abstract class can contain non abstract properties too.
        public string Name { get; set; }

        /// <summary>
        /// Show the plane.
        /// </summary>
        public void Show()
        {
            //todo: Show the plane
        }

        /// <summary>
        /// Hide the plane.
        /// </summary>
        public void Hide()
        {
            //todo: Hide the plane
        }

        // The abstract function means that there is no implementation of the function.
        // Because there is no implementation of the function it must be implemented during deriving from a class.
        // Conclusion: the "abstract" keyword actually means the "virtual"
        //Abstract function can be only in abstract class.
        public abstract double Area(); 
    }
}