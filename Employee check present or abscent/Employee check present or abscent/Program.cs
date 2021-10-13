using System;

namespace Employee_check_present_or_abscent
{
    class Program
    {
        static void Main(string[] args)
        {
            int isFullTime = 1;
            Random random = new Random();

            int empCheck = random.Next(0, 2);
            if (empCheck == isFullTime)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is abscent");
            }
        }
    }
}
