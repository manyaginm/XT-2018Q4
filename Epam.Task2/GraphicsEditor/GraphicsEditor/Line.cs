using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GraphicsEditor
{
    class Line :Shape
    {
        public Line():  this(0, 0){}

        public Line(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override void printShape()
        {
           Console.WriteLine("Drawing line with coordinatex x: {0}, y: {1}", this.X, this.Y);
        }

        public override void getCoordinates()
        {
            Console.WriteLine("line with coordinatex x: {0}, y: {1}", this.X, this.Y);
        }
    }
}