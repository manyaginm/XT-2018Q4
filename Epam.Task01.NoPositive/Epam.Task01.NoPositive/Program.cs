using System;

namespace Epam.Task01.NoPositive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] myArr = new int[4, 5,3];

            Random ran = new Random();

            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int z = 0; z < 3; z++)
                    {
                        myArr[i, j, z] = ran.Next(-200, 15);
                        Console.Write("{0}\t", myArr[i, j, z]);
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("===============New array========================");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int z = 0; z < 3; z++)
                    {
                    
                        if(myArr[i, j, z] > 0)
                        {
                            myArr[i, j, z] = 0;
                        }
                        Console.Write("{0}\t", myArr[i, j, z]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
