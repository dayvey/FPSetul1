using System;

namespace _9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("n=");
            n = Convert.ToInt32(Console.ReadLine());

            int c = 0;

            for (int i = 2; i <= n/2; i++)
            {
                if (n % i == 0)
                    Console.Write("{0} ", i);
            }
        }
    }
}