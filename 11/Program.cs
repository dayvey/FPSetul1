using System;

namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, m = 0;

            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            int l = n;

            while (n>0)
            {
                m = m * 10 + n % 10;
                n /= 10;
            }

            Console.WriteLine("{0} cu cifrele in ordine inversa: {1}", l, m);
        }
    }
}