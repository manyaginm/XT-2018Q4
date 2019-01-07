using System;
using System.Collections.Generic;

namespace DynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(3);
            list.Add(15);
            list.Add(25);
            DynamiArray<int> arr = new DynamiArray<int>(8);
            arr.addElement(8);
            arr.addElement(9);
            arr.addRange(list);

            arr.addRange(list);
            foreach (int p in arr.R)
            {
                Console.WriteLine(p);
            }
            
            Console.WriteLine("");
            Console.WriteLine(arr.Fillness);


            Console.ReadLine();

        }
    }
}
