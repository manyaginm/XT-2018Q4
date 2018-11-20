using System;

namespace Epam.Task2.Triangle
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter the number");
			int k = Convert.ToInt32(Console.ReadLine());

			for(int i = 0; i<k; i++)
			{
				int z = 0;
				while (z<=i)
				{
					Console.Write("*");
					z++;
				}
				Console.WriteLine();
			}
		}
	}
}
