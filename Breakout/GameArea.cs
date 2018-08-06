using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakout
{
    public class GameArea
    {
        public const int MaxX = 90;
        public const int MaxY = 60;

        public Ball Ball { get; set; }

        public Bat Bat { get; set; }

        public BrickArray BrickArray { get; set; }

        public void FireBall()
        {

        }

        public void PlayTurn()
        {

        }
    }
}
