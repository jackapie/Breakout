using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakout
{
    class RightEdge : ScreenObject
    {
        public RightEdge(int maxX, int maxY)
        {
            SizeY = maxY;
            PositionX = maxX;
            PositionY = 0;
        }
    }
}
