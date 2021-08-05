using System;

namespace ReverseNum
{
    class Reverse
    {
        static void Main(string[] args)
        {
            int Rev = 0;
            int rem = 0;
            Console.WriteLine("enter the number to reverse");
            int num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                rem = num % 10;
                Rev = Rev * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine("number after reverse is :" + Rev);




        }
    }
}
