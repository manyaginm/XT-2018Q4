using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Ring
{
    abstract class Shape
    {
        public abstract double getLength();
        public abstract double getSquare();
        public abstract String getCoordinates();
    }
}