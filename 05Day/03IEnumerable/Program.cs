using System;
using System.Collections.Generic;

namespace _03IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            var myEnumerable = new MyEnumerable();

            foreach (var item in myEnumerable)
            {
                Console.WriteLine(item);
            }

            //                    MoveNext(position: 0, moveNext: True)
            //                    Current(position: 0, current: 1 kg steak)
            //1 kg steak
            //                    MoveNext(position: 1, moveNext: True)
            //                    Current(position: 1, current: salt)
            //salt
            //                    MoveNext(position: 2, moveNext: True)
            //                    Current(position: 2, current: 1 kg potato)
            //1 kg potato
            //                    MoveNext(position: 3, moveNext: True)
            //                    Current(position: 3, current: 1 kg flour)
            //1 kg flour
            //                    MoveNext(position: 4, moveNext: False)

            Console.WriteLine();
            Console.WriteLine();

            // the builder create a code like this:

            var enumerator = myEnumerable.GetEnumerator();
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                //This is the variable of cycle
                Console.WriteLine(current);
            }

            //Attention, we have to handle with the changes of items in the cycle in the implementation !!!
            //example: implementation of a List

            //this is the easier solution: if the list changes, it throws an exception.
            //this is the toughest solution: our class cares about whether the internal state changes,
            //then the running cycle do not run in a bad state
            var shoppingList = new List<string>() { "1 kg steak", "salt", "1 kg potato", "1 kg flour" };
            foreach (var item in shoppingList)
            {   //we delete the items, the List changes ==>  it causes a foul (Exception)
                //System.InvalidOperationException: 'Collection was modified; enumeration operation may not execute.'
                shoppingList.Remove(item);
            }

            Console.ReadLine();
        }
    }
}
