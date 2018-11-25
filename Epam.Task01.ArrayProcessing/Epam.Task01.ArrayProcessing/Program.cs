using System;

namespace Epam.Task01.ArrayProcessing
{
    class Program
    {
        static int[] getRandomArray(int min, int max, int count)
        {
            Random r = new Random();
            int[] arr = new int[count];

            for (int i = 0; i < count; i++)
            {
                arr[i] = r.Next(min, max + 1);

            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальное значение");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите максимальное значение");
            int max = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите размер массива");
            int count = int.Parse(Console.ReadLine()); ;
            int[] arr = getRandomArray(min, max, count);


            Console.WriteLine();
            foreach (int k in arr)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("Минимум: {0}", arr[0].ToString());
            Console.WriteLine("Максимум: {0}", arr[count - 1].ToString());


        }
    }
}
