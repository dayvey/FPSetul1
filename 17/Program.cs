using System;

namespace _17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, m;

            Console.Write("n=");
            n=int.Parse(Console.ReadLine());

            Console.Write("m=");
            m = int.Parse(Console.ReadLine());

            int x = n, y = m;

            while (x != y)
            {
                if (x < y)
                    y -= x;
                else x -= y;
            }
            Console.WriteLine("Cel mai mare divizor comun al lui {0} si {1} este {2}", n, m, x);

            int a = n; int b = m; y = m; x = n; 

            while (x!=y)
            {
                if (x < y)
                    x = x + a;
                else y = y + b;
            }
            Console.WriteLine("Cel mai mic multiplu comun al lui {0} si {1} este {2}", n, m, x);
        }
    }
}