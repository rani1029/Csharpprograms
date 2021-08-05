using System;

namespace SwapTwoNum
{
    class Program
    {

        static void Main(string[] args)
        {
            int c;
            Console.WriteLine("enter first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            int b = int.Parse(Console.ReadLine());
            c = a;
            a = b;
            b = c;
            Console.WriteLine("no after swapping:" + a);
            Console.WriteLine("no after swapping:" + b);




        }
    }
}
