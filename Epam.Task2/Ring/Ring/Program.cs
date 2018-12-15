using System;

namespace Ring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter coordinates by x-line");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinates by y-line ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter radius for inner circle");
            int innerRadius = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter radius for outer circle");
            int outerRadius = int.Parse(Console.ReadLine());

            Shape ring = new Ring(new Round(x, y, outerRadius), new Round(x, y, innerRadius));
            Console.WriteLine("Sum of lengths = {0}",ring.getLength());
            Console.WriteLine(ring.getCoordinates());
        }
    }
}
