using System;
using System.Collections.Generic;

namespace _10DelegateExample
{

    class Program
    {
        static string CharToRemove = "m";

        static void Main(string[] args)
        {
            var lines = new List<string>();
            lines.Add("First item.");
            lines.Add("Second item.");
            lines.Add("Thirth item.");
            lines.Add("Forth item.");
            lines.Add("Fifth item.");
            lines.Add("Sixth item.");

            var store = new DataStore(lines);


            store.ProcessData(RemoveT);
            store.ProcessData(RemoveF);

            /// The call list is not "just "definition of function but "environment "as well.
            /// I can refer to a local variable and it is going with the call list.
            store.ProcessData(RemoveChar);


            /// The call list is called up one after the other
            /// and with the same parameter variables.
            /// So the variable passed in the ref is also the same, that's why I can do more than one operation.


            /// I can handle previous operations as well,
            /// so put the calls to a list and pass the list.
            DataStore.FuncDef processList = null;

            store.ProcessData(processList);

            // for example:
            //processList = RemoveT;

            // for example:
            //processList = processList + RemoveF + RemoveChar;

            // or :

            processList = delegate { };     // I define a blank call list, it works without any type.

            processList += RemoveT;
            processList += RemoveF;

            // the call list is taking the reference with.
            processList += RemoveChar;
            //store.ProcessData(processList);



            // if it changes, it will affect its functioning.
            CharToRemove = "h";


            // if you want to send a local variable to the function,
            // then you can use it instead of a separate function definition, using an anonymous delegate:
            processList += delegate (ref string toModify)
            {
                var toReplace = "d";
                toModify = toModify.Replace(toReplace, "");
            };

            // The function defined within the code block has access to the variables within the code block (for example: toReplace).
            var toReplaceVar = "o";
            processList += delegate (ref string toModify)
            {
                toModify = toModify.Replace(toReplaceVar, "");
            };
            store.ProcessData(processList);


            store.Print();

            Console.ReadLine();
        }

        private static void RemoveF(ref string text)
        {
            text = text.Replace("f", "");
        }

        private static void RemoveT(ref string text)
        {
            text = text.Replace("t", "");
        }

        private static void RemoveChar(ref string text)
        {
            /// I can also use a parameter from the outside at the delegate: what the definition can look ,
            /// and it is going with the call list.
            text = text.Replace(CharToRemove, "");
        }

    }
}
