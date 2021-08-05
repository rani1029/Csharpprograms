using System;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the year");
            int year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 == 0) || (year % 400 == 0))
            {
                Console.WriteLine("year is leap year");
            }
            else
                Console.WriteLine("year is not leap year");

        }
    }
}
