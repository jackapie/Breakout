using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakout
{
    public class GameArea
    {
        public const int MaxX = 60;
        public const int MaxY = 30;

        public Ball Ball { get; set; }

        public Bat Bat { get; set; }

        public BrickArray BrickArray { get; set; }

        public GameArea()
        {
            Ball = new Ball();
            {
                Ball.PositionX = Bat.PositionX + 1;
                Ball.PositionY = Bat.PositionY + 1;
            }
            Bat = new Bat();
            {
                Bat.PositionX = MaxX / 2;
                Bat.PositionY = MaxY - 2;
            }
            BrickArray = new BrickArray();

            
        }

        public void FireBall()
        {

        }

        public void PlayTurn()
        {

        }
    }
}
