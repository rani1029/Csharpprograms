using System;

namespace PowerOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of power of two");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(" table is ");
            for (int i = 1; i <= n; i++)
            {
                double p = Math.Pow(2, i);
                Console.WriteLine(p);
            }

        }
    }
}
