using System;
using System.Text;
namespace CHAR_DOUBLER
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = " написать программу, которая";
            string two = " описание     ,";

            char[] f = one.ToCharArray();
            char[] t = two.ToCharArray();
            StringBuilder res = new StringBuilder();
            for(int i =0; i < f.Length; i++)
            {
                for (int k = 0; k < t.Length; k++)
                {
                    if (char.ToLower(f[i]).Equals(char.ToLower(t[k]))
                        &!(char.IsPunctuation(t[k])|char.IsSeparator(t[k])))
                    {
                        res.Append(f[i]);

                    }
                }
                res.Append(f[i]);
            }
            Console.WriteLine(res.ToString());

        }
    }
}
