using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape triangle = new Triangle(10, 15, 20);
            Console.WriteLine(triangle.getPeremiter());
            Console.WriteLine(triangle.getSquare());
        }
    }
}
