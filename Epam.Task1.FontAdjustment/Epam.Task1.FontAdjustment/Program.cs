using System;

namespace Epam.Task1.FontAdjustment
{
    class Program
    {
        static void setParams( int x, ref String[] par) {
            switch (x) {
                case 1: 
                    par[0]= par[0].Length>0? "": "Bold";
                    break;
                case 2:
                    par[1] = par[1].Length > 0 ? "" : "Italic";
                    break;
                case 3:
                    par[2] = par[2].Length > 0 ? "" : "Underline";
                    break;
            }
        }

        static String getParam(String[]p)
        {
            String result = "";
            for (int i =0; i<p.Length; i++)
            {
                if (p[i].Length > 0)
                {
                    if (i > 0 )
                    {
                        if (p[i - 1].Length > 0 | p[0].Length > 0)
                        { result += ", " + p[i]; }
                        else { result += p[i]; }
                    }
                    else
                    {
                        result +=p[i];
                    }
                    
                }
                
            }
            if (result.Length == 0)
            {
                result = "None";
            }
            return result;
        }
       
        
        static void Main(string[] args)
        {
            String[] param = {"","",""};
            while (true)
            {
                Console.WriteLine("Параметры надписи: {0}",getParam(param));
                Console.WriteLine("Введите число: \n\t 1. Bold \n\t 2. Italic \n\t 3. Underline");
                setParams(int.Parse(Console.ReadLine()), ref param);
            }
        }
    }
}
