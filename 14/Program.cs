using System;

namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, m=0;

            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            int l = n;

            while (n>0)
            {
                m = m * 10 + n % 10;
                n /= 10;
            }

            if (l == m)
                Console.WriteLine("{0} este palindrom!", l);
            else Console.WriteLine("{0} nu este palindrom!", l);
        }
    }
}