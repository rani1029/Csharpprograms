using System;

namespace Fibonacci
{
    class fab
    {
        int n = 10;
        int n1 = 0;
        int n2 = 1;
        static void Main(string[] args)
        {

            int n = 10;
            int n1 = 0;
            int n2 = 1;
            Console.Write(n1 + " " + n2 + " ");
            for (int i = 2; i <= n - 1; i++)
            {
                int n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
                //Console.Write(i);
                Console.Write(n3 + " ");
            }

        }
    }
}
