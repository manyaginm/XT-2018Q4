using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Lost
{
    class Person
    {
        int number;

        public int Number { get => number; set => number = value; }

        public Person(int number)
        {
            this.Number = number;
        }

    }
}