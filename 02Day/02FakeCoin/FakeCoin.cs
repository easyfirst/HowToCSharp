namespace _02FakeCoin
{
    public class FakeCoin : Coin
    {
        public FakeCoin()
        {
            System.Console.WriteLine("Constructor of FakeCoin.");
        }

        //We override (fake) the function with "override" keyword.
        public override int Collect()
        {
            System.Console.WriteLine("FakeCoin.Collect()");

            return 0;
        }
    }
}