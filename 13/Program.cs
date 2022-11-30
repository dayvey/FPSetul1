using System;

namespace _13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y1, y2;

            Console.Write("y1=");
            y1=int.Parse(Console.ReadLine());

            Console.Write("y2=");
            y2 = int.Parse(Console.ReadLine());

            int c = 0;

            int x = y1;

            int nr = 0;

            while (x+4<=y2)
            {
                if (c == 0)
                {
                    if (x % 4 == 0)
                        if (x % 100 != 0 && x % 400 != 0)
                        {
                            c = 1;
                            nr++;
                        }
                        else if (x % 100 == 0 && x % 400 != 0)
                            c = 0;
                        else
                        {
                            c = 1;
                            nr++;
                        }
                    else c = 0;
                    x++;
                }
                else
                {
                    nr++;
                    x += 4;
                }
            }
            Console.WriteLine("Intre {0} si {1} sunt {2} ani bisecti", y1, y2, nr+1);
        }
    }
}