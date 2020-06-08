using System;

namespace Laba2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = -3, y = 0;
            Console.WriteLine("\n*****************************************\n");
            Console.WriteLine("\tX\t\t\tY\n");
            Console.WriteLine("*****************************************\n");
            while (x <= 3)
            {
                y = (2 + Math.Pow(x, 3)) / (x + Math.Sqrt(13 * Math.Abs(x)));
                Console.WriteLine("\t" + x + "\t\t" + y + "\n");
                x += 0.5;
            }
            Console.ReadLine();
        }
    }
}
