using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakout
{
    public class Brick : ScreenObject
    {
        public string Colour { get; set; }

        public Brick()
        {
            SizeX = 3;
            SizeY = 1;
        }
    }
}
