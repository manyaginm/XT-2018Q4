using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MyString
{
    class MyString
    {
        
        private char [] str;
        public MyString() : this(null) { }

        public MyString(String str) {
            this.str = str.ToCharArray();

        }

        public bool myEquals(string m)
        {
            bool flag = true;
            char[] inputStr = m.ToCharArray();
            if (inputStr.Length == this.str.Length)
            {
                for (int i = 0; i < inputStr.Length; i++)
                {
                    if (this.str[i] != inputStr[i])
                    {
                        flag = false;
                        return flag;
                    }
                    else
                    {
                        flag = true;
                    }
                }
            }
            else
            {
                flag =  false;
                return flag;
            }
           
            return flag;
            
        }


    }
}