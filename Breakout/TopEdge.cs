using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakout
{
    class TopEdge : ScreenObject
    {
        public TopEdge(int MaxX)
        {
            SizeX = MaxX;
            PositionX = 0;
            PositionY = 0;
        }
    }
}
