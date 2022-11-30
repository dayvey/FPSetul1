namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            float a, b;

            Console.Write("a=");
            a=float.Parse(Console.ReadLine());

            Console.Write("b=");
            b = float.Parse(Console.ReadLine());

            b = -b;
            b /= a;

            Console.WriteLine("x={0}", b);
        }
    }
}