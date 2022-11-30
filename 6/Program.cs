using System;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;

            Console.Write("a=");
            a = float.Parse(Console.ReadLine());

            Console.Write("b=");
            b = float.Parse(Console.ReadLine());
            
            Console.Write("c=");
            c = float.Parse(Console.ReadLine());

            if (a < b + c && b < a + c && c < a + b)
                Console.WriteLine("{0}, {1} si {2} pot fi laturile unui triunghi!", a, b, c);
            else Console.WriteLine("{0}, {1} si {2} nu pot fi laturile unui triunghi!", a, b, c);
        }
    }
}