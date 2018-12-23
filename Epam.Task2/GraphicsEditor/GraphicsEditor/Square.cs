using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GraphicsEditor
{
    class Square : Shape
    {

        private int _a;
        private int _b;

        public int A { get => _a; set => _a = value; }
        public int B { get => _b; set => _b = value; }

        public Square(): this(0,0,0,0){ }

        public Square(int a, int b, int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.A = a;
            this.B = b;
        }
        public override void printShape() {
            Console.WriteLine("Drawing square. Side a = {0}, side b = {1}", this.A, this.B);
        }
        public override void getCoordinates()
        {
            Console.WriteLine("Square with coordinatex x: {0}, y: {1}", this.X, this.Y);
        }
    }
}