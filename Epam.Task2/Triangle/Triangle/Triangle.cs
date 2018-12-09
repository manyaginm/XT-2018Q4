using System;
using System.Collections.Generic;
using System.Text;


namespace Triangle
{
    class Triangle : Shape
    {
        private int a;
        private int b;
        private int c;

        public int A
        {
            get { return this.a; }
            set
            {
                if (value > 0) { this.a = value; }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public int B
        {
            get { return this.b; }
            set
            {
                if (value > 0) { this.b = value; }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public int C
        {
            get { return this.c; }
            set
            {
                if (value > 0) { this.c = value; }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public Triangle() : this(1, 1, 1) { }
        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double getPeremiter()
        {
            return ((a * b) + (b * c) + (a * c)) * 1.0;
        }

        public override double getSquare()
        {
            int p = ((a * b) + (b * c) + (a * c)) / 2;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public override string shapeDescribe()
        {
            if (a >= b + c || b >= a + c || c >= b + a)
            {
                return "Not a triangle";

            }
            else if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == b * b + a * a)
            {

                return "Rectangular triangle";

            }
            else if (a * a > b * b + c * c || b * b > a * a + c * c || c * c > b * b + a * a)
            {
                //тупоугольный
                return "Obtuse triangle";
                // ...
            }
            else
            {
                //остроугольный
                return "Acutangular triangle";
                // ...
            }
        }



    }
}
