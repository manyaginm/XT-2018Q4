﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Rock :GameObject, StaticObject
    {
        private Rock() { }
        public Rock(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override void getCoordinates()
        {
            throw new NotImplementedException();
        }

        public override void getInfo()
        {
            throw new NotImplementedException();
        }
    }
}
