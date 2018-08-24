using System.Collections;
using System.Collections.Generic;

namespace _03IEnumerable
{
    public class MyEnumerable : IEnumerable
    {
        List<string> shoppingList = new List<string>() { "1 kg steak", "salt", "1 kg potato", "1 kg flour" };

        public MyEnumerable()
        {
        }

        public IEnumerator GetEnumerator()
        {
            return new MyEnumerator(shoppingList);
        }
    }
}