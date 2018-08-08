using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakout
{
    public class BottomEdge : ScreenObject
    {
        public BottomEdge(int maxX, int maxY)
        {
            SizeX = maxX + 2;
            SizeY = 1;
            PositionX = -1;
            PositionY = maxY;
        }
    }
}
