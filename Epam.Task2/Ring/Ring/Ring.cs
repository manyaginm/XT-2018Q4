using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Ring
{
    class Ring :Shape
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

        public override double getLength()
        {
            return this.innerRound.getLength() + this.outerRound.getLength();
            
        }

        public override double getSquare()
        {
            return Math.PI * (Math.Sqrt(this.outerRound.Radius) - Math.Sqrt(this.innerRound.Radius));      
        }

        public override string getCoordinates()
        {
            return "Coordinate of ring by x-line:" + this.x + " Coordinate by y line " + this.y;
        }
    }
}