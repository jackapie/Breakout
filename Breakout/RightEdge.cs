using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakout
{
    public class RightEdge : ScreenObject
    {
        public RightEdge(int maxX, int maxY)
        {
            SizeX = 1;
            SizeY = maxY + 2;
            PositionX = maxX;
            PositionY = -1;
        }
    }
}
