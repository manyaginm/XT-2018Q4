using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Apple : Bonus, StaticObject
    {
        public Apple(int x, int y)
        {
            this.Bonus_count = 10;
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

        public int getBonus() {
            return this.Bonus_count;
        }
    }

}
