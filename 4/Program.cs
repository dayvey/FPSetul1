using System;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y;

            Console.Write("y=");
            y = Convert.ToInt32(Console.ReadLine());

            if (y % 4 == 0)
                if (y % 100 != 0 && y % 400 != 0)
                    Console.WriteLine("y este an bisect!");
                else if (y % 100 == 0 && y % 400 != 0)
                        Console.WriteLine("y nu este an bisect!");
                     else Console.WriteLine("y este an bisect!");
            else Console.WriteLine("y nu este an bisect!");

        }
    }
}