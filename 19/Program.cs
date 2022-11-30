using System;

namespace _19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, m;

            Console.Write("n=");
            n=Convert.ToInt32(Console.ReadLine());

            m = n;

            int x=0, y=-1;

            x = m % 10;
            m /= 10;

            bool c = true;

            while (m>0 && c==true)
            {
                if (m % 10 != x && m % 10 != y)
                {
                    if (y == -1)
                        y = m % 10;
                    else c = false;
                }
                m /= 10;
            }

            if (c == true) Console.WriteLine("Numarul {0} este formata din 2 cifre care se pot repeta, care sunt {1} si {2}.", n, x, y);
            else Console.WriteLine("Numarul {0} nu este formata numai din 2 cifre care se pot repeta.", n);
        }
    }
}