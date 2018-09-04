using System;

namespace _09DelegateDef
{
    class Program
    {
        /// <summary>
        /// 1. step: We define 
        ///   the return value of the function, 
        ///   the name, for reference 
        ///   his signature (name and parameters).
        ///   
        ///   type definition: describe what kind of function we thought.
        /// </summary>
        /// <param name="msg"></param>
        delegate void DelegateDef(string msg);

        /// <summary>
        /// This is a function that matches the description of delegate.
        /// 
        /// It's static, because we'll call it from Main, which is static,
        /// which has nothing to do with the delegate topic.
        /// </summary>
        /// <param name="txt"></param>
        static void Hi(string txt)
        {
            Console.WriteLine($"Hi, it's jolly good You to come: {txt}");
        }


        /// <summary>
        /// This is an other function that matches the description of delegate.
        /// 
        /// It's static, because we'll call it from Main, which is static,
        /// which has nothing to do with the delegate topic.
        /// </summary>
        /// <param name="str"></param>
        static void By(string str)
        {
            Console.WriteLine($"Hi, it's a pity you're already going: {str}");
        }

        static void Main(string[] args)
        {


            DelegateDef a;
            DelegateDef b;
            DelegateDef c;
            DelegateDef d;

            //I'm making a call list, 
            //which contains a reference
            a = Hi;

            //I'm making an other call list, 
            //which contains a reference
            b = By;

            //I can put these call lists together
            c = a + b;

            //I can distinguish these call lists
            d = c - a;


            /// This is the 3. step: we are colling the call list:
            /// 
            Console.WriteLine("Calling [a] list");
            a("a");
            Console.WriteLine("Calling az [b] list");
            b("b");
            Console.WriteLine("Calling az [c] list");
            c("c");
            Console.WriteLine("Calling az [d] list");
            d("d");

            Console.ReadLine();

            /// Result:
            /// 
            //Calling [a] list
            //Hi, it's jolly good You to come: a

            //Calling [b] list
            //Hi, it's a pity you're already going: b

            //Calling [c] list
            //Hi, it's jolly good You to come: c
            //Hi, it's a pity you're already going: c

            // Calling[d] list
            //Hi, it's a pity you're already going: d
        }
    }
}
