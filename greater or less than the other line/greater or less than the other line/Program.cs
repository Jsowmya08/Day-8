using System;

namespace greater_or_less_than_the_other_line
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = 30;

            Console.WriteLine(a.CompareTo(b));

            Console.WriteLine(b.CompareTo(c));

            Console.WriteLine(c.CompareTo(a));

        }
    }
}
