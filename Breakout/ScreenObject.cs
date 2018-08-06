using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakout
{
    public class ScreenObject

    {
        public int PositionX { get; set; } //changed from "protected set" so that value can be set in BrickArray class.
        public int PositionY { get; set; }

        public void Move(int dx, int dy)
        {
            PositionX = PositionX + dx;
            PositionY = PositionY + dy;
        }

        public int SizeX { get; protected set; }
        public int SizeY { get; protected set; }

        public string Colour { get; set; }

    }
}
