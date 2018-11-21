using System;

namespace Epam.Task1._1.Rectangle
{
    class Program
    {
        static void RectangleSquare(int a, int b)
        {
            int p = a * b;
            Console.WriteLine("Sqare is: {0}", p);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Insert first number");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert second number");
            int p = Convert.ToInt32(Console.ReadLine());

            if (k <= 0 | p <= 0)
            {
                Console.WriteLine("Numbers should be greater than 0");
                System.Environment.Exit(-1);
            }
            else
            {
                RectangleSquare(k, p);
            }
        }
    }
}
