using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakout
{
    public class TopEdge : ScreenObject
    {
        public TopEdge(int MaxX)
        {
            SizeX = MaxX + 2;
            SizeY = 1;
            PositionX = -1;
            PositionY = 0;
        }
    }
}
