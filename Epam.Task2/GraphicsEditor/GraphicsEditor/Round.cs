using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GraphicsEditor
{
    class Round :Shape

        
    {
        private int _radius;

        public int Radius { get => _radius; set => _radius = value; }

        public Round() : this(0, 0, 0) { }

        public Round(int x, int y, int radius)
        {
            this.X = x;
            this.Y = y;
            this.Radius = radius;
        }

        public override void printShape()
        {
            Console.WriteLine("Drawing Round with coordinatex x: {0}, y: {1}, and radius = {2}", this.X, this.Y, this._radius);
        }

        public override void getCoordinates()
        {
            Console.WriteLine("Round with coordinatex x: {0}, y: {1}", this.X, this.Y);
        }

    }
}