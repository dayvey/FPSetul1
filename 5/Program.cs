using System;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, k;

            Console.Write("n=");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("k=");
            k = Convert.ToInt32(Console.ReadLine());

            int l = k;
            int m = n;

            while (k > 1)
            {
                k--;
                n /= 10;
            }

            k = n % 10;

            Console.WriteLine("a {0}-a cifra din {1} de la dreapta la stanga este {2}", l, m, k);
        }
    }
}