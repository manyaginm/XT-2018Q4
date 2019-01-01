using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Player : GameObject, Movable
        
    {
        public int health;

        
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

        public void eatBonus <T> (T bonus) where T: Bonus
        {
            Console.WriteLine( bonus.Bonus_count);
        }
    }
}
