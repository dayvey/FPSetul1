using System;

namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("a=");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("b=");
            b = Convert.ToInt32(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("a={0} si b={1}", a, b);
        }
    }
}