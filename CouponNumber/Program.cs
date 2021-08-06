using System;

namespace CouponNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int ranNum = 0;
            int Flag = 0;
            Console.WriteLine("enter the coupon num");
            int cnum = int.Parse(Console.ReadLine());
            // Random ran = new Random();
            while (ranNum != cnum)
            {
                Random ran = new Random();
                ranNum = ran.Next(0, 100);
                Console.WriteLine(ranNum);
                Flag++;
            }
            Console.WriteLine("no of times random no generated is " + Flag);



        }
    }
}
