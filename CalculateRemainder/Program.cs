using System;

namespace CalculateRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the dividend");
            int dividend = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the divisor");
            int divisor = int.Parse(Console.ReadLine());
            int remainder = dividend % divisor;
            int quotient = dividend / divisor;

            Console.WriteLine("Quotient is " + quotient);
            Console.WriteLine("remainder is " + remainder);



            // Console.WriteLine("Hello World!");
        }
    }
}
