using System;

namespace AVERAGE_STRING_LENGTH
{
    class Program
    {
        static void Main(string[] args)
        {

            int bukvcount = 0;
            int separators = 0;
            int wordcount = 0;
            char previous ;


            String k = "o.n,e ,t?w.o th#ree&";
            char[] str = k.ToCharArray();
            for(int i = 0; i<str.Length; i++)
            {
                if (char.IsSeparator(str[i]) | (char.IsPunctuation(str[i]) & i == str.Length - 1))
                {
                    wordcount++;
                }
                if (char.IsLetter(str[i]))
                {
                    bukvcount++;
                }
            
            }
            double p = (bukvcount * 1.0) / (wordcount*1.0);
            Console.WriteLine(wordcount * 1.0);
            Console.WriteLine(bukvcount * 1.0);
            Console.WriteLine(p);
        }
    }
}
