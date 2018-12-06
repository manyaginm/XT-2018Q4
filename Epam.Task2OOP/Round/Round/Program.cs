using System;

namespace Round
{
    class Program
    {
        static void Main(string[] args)
        {
            Round r = new Round(8, 23);
            Console.WriteLine(r.getLength());
            Console.WriteLine(r.getSquare());

        }
    }
}
