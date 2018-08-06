using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakout
{
    public class ScreenObject

    {
        public int PositionX { get; protected set; }
        public int PositionY { get; protected set; }
        public void Move(int dx, int dy)
        {
            PositionX = PositionX + dx;
            PositionY = PositionY + dy;
        }

        public int SizeX { get; protected set; }
        public int SizeY { get; protected set; }

    }
}
