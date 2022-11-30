using System;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;

            Console.Write("a=");
            a=float.Parse(Console.ReadLine());

            Console.Write("b=");
            b = float.Parse(Console.ReadLine());

            Console.Write("c=");
            c = float.Parse(Console.ReadLine());

            float delta = (b * b) - (4 * a * c);

            if (delta > 0)
            {
                float x1, x2;
                x1 = ( (float)Math.Sqrt(delta) - b) / (2 * a);
                x2 = ( -(float)Math.Sqrt(delta) - b) / (2 * a);
                Console.WriteLine("x1={0}", x1);
                Console.WriteLine("x2={0}", x2);
            }
            else if(delta == 0)
            {
                float x;
                x = -b / (2 * a);
                Console.WriteLine("x={0}", x);
            }
            else
            {
                delta = -delta;
                delta=(float)Math.Sqrt(delta);

                Console.WriteLine("x1 = (-{0}+i*{1}) / 2*{2}", b, delta, a);
                Console.WriteLine("x2 = (-{0}-i*{1}) / 2*{2}", b, delta, a);
            }
        }
    }
}