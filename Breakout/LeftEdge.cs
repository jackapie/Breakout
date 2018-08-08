using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakout
{
    public class LeftEdge : ScreenObject
    {
        public LeftEdge(int maxY)
        {
            SizeX = 1;
            SizeY = maxY + 2;
            PositionX = 0;
            PositionY = -1;
        }
    }
}
