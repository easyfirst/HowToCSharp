namespace _01IEnumerableT
{
    /// <summary>
    /// It's a class containing simple data.
    /// 
    /// for example a folder, Calendar item, etc.
    /// </summary>
    public class Data
    {
        public int Number { get; set; }
        public string Text { get; set; }

        public Data(int number, string text)
        {
            Number = number;
            Text = text;
        }
    }
}