using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle
{
    class Triangle
    {
        private int a;
        private int b;
        private int c;


        public Triangle() :this(1,1,1){}
        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int getPerimeter()
        {
            return (a * b) + (b * c) + (a * c);
        }

        public double getSquare()
        {
            int p = ((a * b) + (b * c) + (a * c)) / 2;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
