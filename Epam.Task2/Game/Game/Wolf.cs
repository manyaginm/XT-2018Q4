using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Game
{
    class Wolf : GameObject, Movable
    {
        int health;

        public Wolf (int x, int y)
        {
            this.X = x;
            this.Y = y;
            health = 10;
        }
        public override void getCoordinates()
        {
            throw new NotImplementedException();
        }

        public override void getInfo()
        {
            throw new NotImplementedException();
        }

        public void move()
        {
            throw new NotImplementedException();
        }

        public void beatPlayer(ref Player p)
        {
            throw new NotImplementedException();
        }
    }
}