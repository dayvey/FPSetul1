using System;

namespace _12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, a, b;

            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            Console.Write("a=");
            a = int.Parse(Console.ReadLine());

            Console.Write("b=");
            b = int.Parse(Console.ReadLine());

            int nr = 0;

            for (int i=a; i<=b; i++)
            {
                if (i%n==0)
                    nr++;
            }

            Console.WriteLine("Intre {0} si {1} sunt {2} numere divizibile cu {3}", a, b, nr, n);
        }
    }
}