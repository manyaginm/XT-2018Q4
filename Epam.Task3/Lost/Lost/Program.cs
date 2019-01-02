using System;
using System.Collections.Generic;

namespace Lost
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 10;
            Dictionary<int,Person> queue = new Dictionary<int, Person>();
            for (int i = 1; i <= k; i++)
            {
                queue.Add(i,new Person(i));
            }

            while (queue.Count != 1)
            {
                int peopleCount = queue.Count;
                Dictionary<int, Person> tmpQueue = new Dictionary<int, Person>();
                int p = 1;
                for (int i =1; i< peopleCount; i++)
                {
                   

                    if (i % 2 == 0)
                    {
                        queue.Remove(i);
                    }
                    else
                    {
                        tmpQueue.Add(p, queue[i]);
                        p++;
                    }
                   
                }
                Console.WriteLine("In queue now {0} people", queue.Count);
                queue = null;
                queue =  tmpQueue;
            }
           
        }
    }
}
    