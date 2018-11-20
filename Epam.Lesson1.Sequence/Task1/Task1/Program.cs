using System;

namespace Task1
{
    class Program
    {
        static void printSequnce(int k)
        {
            int x = 1;
            while (x <= k)
            {
                if (x < k)
                {
                    Console.Write(x + ", ");
                }
                else
                {
                    Console.WriteLine(x + " ");
                }
                x++;
            }



        }
        static void Main(string[] args)
        {
                int t = Convert.ToInt32(Console.ReadLine());               
                printSequnce(t);                 
                          
        }
    }
}
