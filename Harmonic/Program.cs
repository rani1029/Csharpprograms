using System;

namespace Harmonic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value N");
            int n = int.Parse(Console.ReadLine());
            float h = 0;
            for (int i = 1; i <= n; i++)
            {
                h += (float)1 / i;
            }
            Console.WriteLine("  Nth value of hatmonic number is " + " " + h);
        }

    }
}
