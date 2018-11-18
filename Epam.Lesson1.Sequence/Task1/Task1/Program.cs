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
            bool flag = true;

            while (flag)
            {
                var p = Console.ReadLine();
                if (p.ToString().ToUpper() != "Q")
                {
                    try
                    {
                        int t = Convert.ToInt32(p);
                        printSequnce(t);
                    }catch(FormatException e)
                    {
                        Console.WriteLine("Wrong input");
                        Console.ReadKey();
                        System.Environment.Exit(-1);
                    }
                }
                else
                {
                    System.Environment.Exit(-1);
                }
            }
        }
    }
}
