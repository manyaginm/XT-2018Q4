using System;
using Game;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            GameField g = GameField.getGameField(64, 64, new Player());
            g.addStaticObject(new Rock(12, 12));
            g.addBonus(new Apple(12,12));
            g.addMovable(new Wolf(23, 34));

        }
    }
}
