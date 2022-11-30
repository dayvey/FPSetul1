using System;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("a=");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("b=");
            b = Convert.ToInt32(Console.ReadLine());

            c = a;
            a = b;
            b = c;

            Console.WriteLine("a={0} si b={1}", a, b);

        }
    }
}