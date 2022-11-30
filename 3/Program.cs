using System;

namespace _3
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

            if (n % k == 0)
                Console.WriteLine("n se divide cu k!");
            else Console.WriteLine("n nu se divide cu k!");
        }
    }
}