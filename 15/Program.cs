using System;

namespace _15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("a=");
            a=int.Parse(Console.ReadLine());

            Console.Write("b=");
            b = int.Parse(Console.ReadLine());

            Console.Write("c=");
            c = int.Parse(Console.ReadLine());

            if (a > c)
            {
                a += c;
                c = a - c;
                a = a - c;
            }
            if (a > b)
            {
                a += b;
                b = a - b;
                a = a - b;
            }
            if (b > c)
            {
                b += c;
                c = b - c;
                b = b - c;
            }

            Console.WriteLine("Cele trei numere in ordine crescatoare: {0} {1} {2}", a, b, c);
        }
    }
}