using System;

namespace compare_two_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int strg1 = 50;
            int strg2 = 100;
            int strg3 = 150;

            int var1 = (strg1.CompareTo( strg2  ));
            Console.WriteLine("strg1 && strng2" comparison : +var1);

            int var2 = (strg2.CompareTo((strg3));
            Console.WriteLine("strg2 && strg3" Comparison : +var2);

            int var3 = (strg3.compareTo("compareTo method example"));
            Console.WriteLine("strg2 && string argument comparison: " + var3);


         }
    }
}
