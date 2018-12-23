using System;

namespace MyString
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MyString str = new MyString("Mama");
            Console.WriteLine(str.myEquals("Mama123"));
        }
    }
}
