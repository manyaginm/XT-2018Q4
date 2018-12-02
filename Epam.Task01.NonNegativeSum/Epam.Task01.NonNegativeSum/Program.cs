using System;

namespace Epam.Task01.NonNegativeSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
          
            Random r = new Random();


            Console.WriteLine("Insert array length");
            int[] mas = new int[int.Parse(Console.ReadLine())];
            Console.WriteLine("Insert min border");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert max border");
            int max = int.Parse(Console.ReadLine());
            for (int i =0; i< mas.Length; i++)
            {
                mas[i] = r.Next(min, max);
            }
            Console.WriteLine("Your array: ");
            foreach(int l in mas)
            {
                if (l > 0)
                {
                    sum =sum+ l;
                }
                Console.WriteLine(l);
            }
            Console.WriteLine("The sum is " + sum);
        }
    }
}
