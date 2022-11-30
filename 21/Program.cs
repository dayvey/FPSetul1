using System;

namespace _21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            //int n=rnd.Next(1,1025);

            int x = 0;

            Console.WriteLine(n);

            while (x != n)
            {
                Console.Write("Numarul este mai mare sau egal decat ");
                x = Convert.ToInt32(Console.ReadLine());
                if (x < n) Console.WriteLine("Mai mare!");
                else if (x > n) Console.WriteLine("Mai mic!");
                     else Console.WriteLine("Felicitari! Ai ghicit numarul n!");
            }
        }
    }
}