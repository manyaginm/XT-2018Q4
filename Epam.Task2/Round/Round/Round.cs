using System;
using System.Collections.Generic;
using System.Text;

namespace Round
{
    class Round :Shape
    {
        private int x;
        private int y;
        private int radius;

        public int Radius
        {
            get { return this.radius; }
            set { this.radius = value; }
        }

        public int X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public int Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public Round(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public override double getLength()
        {
            return 2 * Math.PI * this.radius;
        }

        public override double getSquare()
        {
            return Math.PI * radius * radius;
        }

        public override string getCoordinates()
        {
            return "Coordinate by x-line:"+ this.x + " Coordinate by y line "+ this.y;
        }
    }
}
