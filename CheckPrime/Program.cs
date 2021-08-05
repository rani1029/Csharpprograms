using System;

namespace CheckPrime
{
    class Prime
    {
        //int Flag=0;
        static void Main(string[] args)
        {
            int Flag = 0;
            Console.WriteLine("enter the number to check");
            int num = int.Parse(Console.ReadLine());
            for (int i = 2; i < num; i++)
            {


                if (num % i == 0)
                {
                    Console.WriteLine("it is not prime number");
                    Flag++;
                    break;
                }
            }

            if (Flag == 0)
            {
                Console.WriteLine("it is prime number");

            }
        }
    }
}
