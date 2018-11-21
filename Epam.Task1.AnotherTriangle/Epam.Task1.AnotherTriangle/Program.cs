using System;

namespace Epam.Task1.AnotherTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = Convert.ToInt32(Console.ReadLine());

            int i = 0;

            while (i < max)

            {

                String space = "";

                String star = "";

                for (int j = 0; j < max - i; j++) space += " ";

                for (int j = 0; j < 2 * i + 1; j++) star += "*";

                Console.WriteLine(space + star);

                i++;

            }


        }
    }
}
