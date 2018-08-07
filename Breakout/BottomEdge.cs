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
            SizeX = maxX;
            PositionX = 0;
            PositionY = maxY;
        }
    }
}
