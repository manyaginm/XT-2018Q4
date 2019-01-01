
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Game
{
    class GameField
    {
        private int x;
        private int y;
        private static GameField gameField;
        private Player p;


        List<GameObject> staticObjects = new List<GameObject>();
        List<GameObject> bonuses = new List<GameObject>();
        List<GameObject> movable = new List<GameObject>();


        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        internal Player P { get => p; set => p = value; }

        protected GameField(int x, int y, Player p)
        {
            this.X = x;
            this.Y = y;
            this.P = p;
        }

        public static GameField getGameField(int x, int y, Player p)
        {
            if(gameField == null)
            {
                gameField = new GameField(x, y, p);
            }
            return gameField;
        }

        public void drawGameField() { }

        public void addStaticObject<T>(T statObj) where T: GameObject, StaticObject
        {
            
            this.staticObjects.Add(statObj);
        }

        public void addBonus<T>(T bonus) where T: Bonus, StaticObject
        {
            this.bonuses.Add(bonus);
        }

        public void addMovable<T>(T movable) where T : GameObject, Movable
        {
            this.movable.Add(movable);
        }
  
        public Player getPlayer()
        {
            return this.P;
        }
    }
}