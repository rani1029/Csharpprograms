using System;

namespace Largestnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first num");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second num");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the third num");
            int c = int.Parse(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine("largest num is" + a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("largest num is" + b);
            }
            else
                Console.WriteLine("largest num is  " + c);


        }
    }
}
