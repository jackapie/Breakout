using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakout
{
    class LeftEdge : ScreenObject
    {
        public LeftEdge(int maxY)
        {
            SizeY = maxY;
            PositionX = 0;
            PositionY = 0;
        }
    }
}
