using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GraphicsEditor
{
    class Circle : Shape
    {
       private int _radius;

        public Circle(): this (0,0,0)
        {
        }

        public Circle(int x, int y, int radius)
        {
            this.X = x;
            this.Y = y;
            this.Radius = radius;
        }

        
        public int Radius { get => _radius; set => _radius = value; }

        public override void getCoordinates()
        {
            Console.WriteLine("Circle with coordinates x = {0}, y = {1}", this.X, this.Y);
        }

        public override void printShape()
        {
            Console.WriteLine("Drawing circle with coordinates x = {0}, y = {1} and radius = {2}", this.X, this.Y, this.Radius);
        }
    }
}