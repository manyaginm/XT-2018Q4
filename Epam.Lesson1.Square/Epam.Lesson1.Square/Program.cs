using System;

namespace Epam.Lesson1.Square
{
    class Program
    {
        static void printSquare(int x)
        {
            int middle = x / 2 + 1;
            int k = 1;
            int p = 1;
            while (k <= x)
            {
                while (p < x)
                {
                    if (p == middle & k == middle)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                    p++;
                }
                Console.WriteLine("*");
                p = 1;
                k++;
            }
            
        }
        static void Main(string[] args)
        {
            var k = "";
            while (k.ToUpper().ToString() != "Q")
            {
                Console.WriteLine("Enter the number");
                k = Console.ReadLine();
                if (Convert.ToInt32(k) % 2 == 0)
                {
                    Console.WriteLine("Enter the number");
                    k = Console.ReadLine();
                }
                else
                {
                    printSquare(Convert.ToInt32(k));
                    Console.ReadLine();
                }
                
            }
        }
    }
}
