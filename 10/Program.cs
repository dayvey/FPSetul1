using System;

namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, c=0;

            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n/2 && c==0; i++)
            {
                if (n % i == 0)
                    c = 1;
            }

            if (c == 0)
                Console.WriteLine("{0} este prim", n);
            else Console.WriteLine("{0} nu este prim", n);
        }
    }
}