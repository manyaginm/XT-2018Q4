﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Round
{
    class Round
    {
        private int center;
        private int radius;

        public int Radius {
            get { return this.radius; }
            set { this.radius = value; }
        }

        public int Center
        {
            get { return this.radius; }
            set { this.center = value; }
        }
   
        public Round(int center, int radius) {
            this.center = center;
            this.radius = radius;
        }

        public double getLength()
        {
            return 2 * Math.PI * this.radius;
        }

        public double getSquare()
        {
            return Math.PI * radius * radius;
        }
    }
}