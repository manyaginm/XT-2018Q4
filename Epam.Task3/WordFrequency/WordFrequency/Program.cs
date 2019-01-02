using System;
using System.Collections.Generic;

namespace WordFrequency
{
    class Program
    {
        static void Main(string[] args)
        {
            String s1 = "Mama mila ramu mama rammu mila";
          
            String[] words = s1.ToLower().Split(new char[]{ ' ' , ',','.'});

            Dictionary<String, int> wordDictionary = new Dictionary<string, int>();
            foreach (String s in words)
            {
                if (wordDictionary.ContainsKey(s)) {
                    wordDictionary[s] = wordDictionary[s] + 1;
                }
                else
                {
                    wordDictionary.Add(s, 1);
                }
            }

          foreach(KeyValuePair<String, int> keyValue in wordDictionary){
                {
                    Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
                }
            }
        }
    }
}
