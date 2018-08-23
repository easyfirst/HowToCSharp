using System;

namespace _01IDisposable
{
    class Program
    {
        static void Main(string[] args)
        {
            ////we're going to make a self-cleaning class
            //var cleaner = new ItselfCleaner();

            //try //attempts to execute the code block
            //{
            //    //we do our job
            //}
            //finally //after the above runs, whether it is an error or not, this code block will run in any case
            //{
            //    //the "Dispose()" function of the IDisposable interface is used
            //    ((IDisposable)takarito).Dispose();
            //}


            //so you do not always have to write that many codes,
            //so using this kind of 'syntactic sugar' the builder generates the same thing
            using (var cleaner = new ItselfCleaner())
            { //this code block has a protected use

            }
    }
    }
}
