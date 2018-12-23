using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GraphicsEditor
{
    class Ring : Shape
    {
        private Round innerRound;
        private Round outerRound;
        private int x;
        private int y;
        public Ring() : this(null, null) { }
        public Ring(Round outer, Round inner)
        {
            if (outer.Y != inner.Y | outer.X != inner.X)
            {
                throw new ArgumentException("Center of shape shoud be equals");
            }
            if (outer.Radius < inner.Radius)
            {
                throw new ArgumentException("Outer radius should be greater than inner radius");
            }
            else
            {
                this.innerRound = inner;
                this.outerRound = outer;
                this.x = inner.X;
                this.y = inner.Y;
            }
        }

       

        public override void getCoordinates()
        {
            Console.WriteLine("Ring with coordinates x = {0}, y = {1}", this.X, this.Y);
        }

        public override void printShape()
        {
            Console.WriteLine("Drawing ring with coordinates x = {0}, y = {1}, inner radius = {2} and outer radius = {3}",
               this.X, this.Y, this.innerRound.Radius, this.outerRound.Radius);
        }
    }
}