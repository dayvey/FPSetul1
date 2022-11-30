using System;

namespace _16
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int a, b, c, d, e;

            int x = 0;

            Console.Write("a=");
            a = int.Parse(Console.ReadLine());

            Console.Write("b=");
            b = int.Parse(Console.ReadLine());

            Console.Write("c=");
            c = int.Parse(Console.ReadLine());

            Console.Write("d=");
            d = int.Parse(Console.ReadLine());

            Console.Write("e=");
            e = int.Parse(Console.ReadLine());

            if (a > b)
            {
                x = a;
                a = b;
                b = x;
            }
            if (a > c)
            {
                x = a;
                a = c;
                c = x;
            }
            if (a > d)
            {
                x = a;
                a = d;
                d = x;
            }
            if (a > e)
            {
                x = a;
                a = e;
                e = x;
            }
            if (b > c)
            {
                x = b;
                b = c;
                c = x;
            }
            if (b > d)
            {
                x = b;
                b = d;
                d = x;
            }
            if (b > e)
            {
                x = b;
                b = e;
                e = x;
            }
            if (c > d)
            {
                x = c;
                c = d;
                d = x;
            }
            if (c > e)
            {
                x = c;
                c = e;
                e = x;
            }
            if (d > e)
            {
                x = d;
                d = e;
                e = x;
            }

            Console.WriteLine("Cele 5 numere in ordine crescatoare sunt: {0}, {1}, {2}, {3}, {4}", a, b, c, d, e);
        }
    }
}