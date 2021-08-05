using System;

namespace PrimeFactor
{
    class Prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("prime factor of number is");

            while (num % 2 == 0)
            {
                Console.WriteLine(2 + " ");
                num /= 2;
            }
            for (int i = 3; i < Math.Sqrt(num); i += 2)
            {
                while (num % i == 0)
                {
                    Console.WriteLine(i + " ");
                    num /= i;

                }

            }
            if (num > 2)
                Console.WriteLine(num);

        }
    }
}
