using System;

namespace Round
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter coordinates by x-line");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinates by y-line");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter radius");
            int radius = int.Parse(Console.ReadLine());


            Shape round1 = new Round(x, y, radius);
            Console.WriteLine(round1.getLength());
            Console.WriteLine(round1.getSquare());
            Console.WriteLine(round1.getCoordinates());

        }
    }
}
