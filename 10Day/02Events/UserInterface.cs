using System;

namespace _01ObserverPattern
{
    public class UserInterface
    {
        public void Message(object sender, EventDto e)
        {
            // If the detailed data are needed, it has to use data converting.
            var data = (LongRunningProcess)sender;

            // but if only highlighted detailed data are needed, it is enough using parameter "e".
            Console.WriteLine($"UserInterface: {e.Data}");
        }
    }
}