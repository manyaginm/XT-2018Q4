using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter side a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter side b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter side c");
            int c = int.Parse(Console.ReadLine());

            Shape triangle = new Triangle(a, b, c);
            Console.WriteLine("Perimiter is {0}",triangle.getPeremiter());
            Console.WriteLine("Square is {0}", triangle.getSquare());
            Console.WriteLine("Triangle type is {0}", triangle.shapeDescribe());
        }
    }
}
