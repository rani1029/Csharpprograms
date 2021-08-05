using System;

namespace VowelConso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the alphabet to check");
            char alpha = char.Parse(Console.ReadLine());
            switch (alpha)
            {
                case 'a':
                    Console.WriteLine("alphabet is vowel");
                    break;
                case 'A':
                    Console.WriteLine("alphabet is vowel");
                    break;
                case 'e':
                    Console.WriteLine("alphabet is vowel");
                    break;
                case 'E':
                    Console.WriteLine("alphabet is vowel");
                    break;
                case 'i':
                    Console.WriteLine("alphabet is vowel");
                    break;
                case 'I':
                    Console.WriteLine("alphabet is vowel");
                    break;
                case 'o':
                    Console.WriteLine("alphabet is vowel");
                    break;
                case 'O':
                    Console.WriteLine("alphabet is vowel");
                    break;
                case 'u':
                    Console.WriteLine("alphabet is vowel");
                    break;
                case 'U':
                    Console.WriteLine("alphabet is vowel");
                    break;

                default:
                    Console.WriteLine("alphabet is consonent");
                    break;


            }
        }
    }
}
