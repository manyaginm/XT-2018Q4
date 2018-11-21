using System;

namespace Epam.Task1.X_masTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.Parse(Console.ReadLine());
            for (int k = 0; k < max; k++)

            {

                for (int i = 0; i <= k; i++)

                {

                    String space = "";

                    String star = "";

                    for (int j = 0; j < max - i; j++) space += " ";

                    for (int j = 0; j < 2 * i + 1; j++) star += "*";

                    Console.WriteLine(space + star);
                }
            }
        }
    }
}
        
