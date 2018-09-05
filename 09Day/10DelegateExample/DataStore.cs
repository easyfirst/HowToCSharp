using System;
using System.Collections.Generic;

namespace _10DelegateExample
{
    public class DataStore
    {
        private List<string> lines;

        /// <summary>
        /// Function definition to enable the modifying function (s) (strategies) to come in with the help of delegate
        /// </summary>
        /// <param name="text"></param>
        public delegate void FuncDef(ref string text);

        public DataStore(List<string> lines)
        {
            this.lines = lines;
        }

        public void Print()
        {
            foreach (var item in lines)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// The interface of the modifying
        /// during this "face" arrive the "list" of the changes
        /// </summary>
        /// <param name="processList">
        /// The delegate's call list, with each element pointing to such a function,
        /// which corresponds to the FuncDef definition.
        /// </param>
        public void ProcessData(FuncDef processList)
        {
            ///We have to use the 'for' cycle instead of the 'foreach' cycle,
            ///because inside the cycle of 'foreach' the item is not enable to modify.
            for (int i = 0; i < lines.Count; i++)
            {
                // We get the value fo the lines[i].
                var item = lines[i];

                // We send the item into the function.
                processList(ref item);

                // We write back the modified value of the item into the list.
                lines[i] = item;
            }
        }
    }
}