using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Bonus : GameObject
    {
        int bonus_count;

        public int Bonus_count { get => bonus_count; set => bonus_count = value; }

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
