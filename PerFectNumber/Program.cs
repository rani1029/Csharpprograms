using System;

namespace PerFectNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("enter the number to check");
            int num = int.Parse(Console.ReadLine());
            int m = num / 2;
            for (int i = 1; i <= m; i++)
            {
                int rem = num % i;
                if (rem == 0)
                {
                    Console.WriteLine(i);
                    sum = sum + i;
                }
                //else
                //  break;
            }
            if (sum == num)
            {
                Console.WriteLine("number is perfect number");
            }
            else
                Console.WriteLine("number is not perfect number");


        }
    }
}
