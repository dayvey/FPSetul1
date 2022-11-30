using System;
using System.Security.Cryptography;

namespace _18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("n=");
            n=Convert.ToInt32(Console.ReadLine());
            Console.Write("n=");

            int nr = 0;
            int d = 2;
            int c2 = 0;

            while (n>1)
            {
                int c = 0;
                int d2 = d;
                for (int i = 2; i <= d2 / 2 && c == 0; i++)
                    if (d2 % i == 0)
                        c = 1;
                if (c==0)
                {
                    if (c2 != 0)
                    {
                        if (nr!=0)
                            Console.Write("x");
                    }
                    else c2 = 1;
                    nr = 0;
                    while (n % d == 0)
                    {
                        n /= d;
                        nr++;
                    }
                    if (nr != 0)
                    {
                        Console.Write("{0}^{1}", d, nr);
                    }
                }
                d++;
            }
        }
    }
}