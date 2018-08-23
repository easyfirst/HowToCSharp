using System;
using System.Collections.Generic;

namespace _02IEnumerable
{
    class Program
    {
        /// <summary>
        /// the assigned with 'static' property
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            foreach (var item in ShoppingList())
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

            //InstanceFunction();
        }

        private static IEnumerable<string> ShoppingList()
        {
            yield return "1 kg steak";
            yield return "salt";
            yield return "1 kg potato";
            yield return "1 kg flour";

            // Static function ables to call from static function.
            //ShoppingList();
            //Main(new string[] { });

            //It is not able to call Instance function from static function.
            //InstanceFunction();
        }

        public void InstanceFunction()
        {
            //Instance function can be invoked from Instance function, because it is internal of this class.
            InstanceFunction();

            // Static function can be invoked, because there is only 1 instance.
            ShoppingList();
            Main(new string[] { });
        }
    }
}
