using System;

namespace Epam.Lesson1.Task2
{
    class Program
    {
        static bool isSimple(int x)
        {
            bool flag = true;
            int p = 2;
            while (p<x)
            {
                if (x % p == 0)
                {
                    flag = false;
                    return flag;
                }
                p++;
            }
            return flag;
                
        }
       
        static void Main(string[] args)        {
            var k = "";
            while (k.ToString().ToUpper() != "Q")
            {
                Console.WriteLine("Enter the number");
                k = Console.ReadLine();
                int p = Convert.ToInt32(k);
                Console.WriteLine(isSimple(p)?"Simple":"Not simple");
            }
        }
    }
}
