using System;

namespace ElapsedCut
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime (2019,12,13,8,10,55);
            Console.WriteLine(date.DateEnlapsed());

            string text = "Hello my friend, i'm felling good";
            Console.WriteLine(text.Cut(10));
        }
    }
}
