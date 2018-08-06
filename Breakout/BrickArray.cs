using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakout
{
    public class BrickArray
    {
        public List<Brick> Bricks { get; set;}

        public BrickArray()
        {
            Bricks = new List<Brick>();

            for (int Counter = 0; Counter < 10; Counter++)
            {
                var brick1 = new Brick();
                brick1.PositionX = 3 * Counter + 15;
                brick1.PositionY = 15;
                Bricks.Add(brick1);

                var brick2 = new Brick();
                brick2.PositionX = 3 * Counter + 15;
                brick2.PositionY = 16;
                Bricks.Add(brick2);

                var brick3 = new Brick();
                brick3.PositionX = 3 * Counter + 15;
                brick3.PositionY = 17;
                Bricks.Add(brick3);

                int a = brick1.PositionX % 2;
                int b = brick2.PositionX % 2;
                int c = brick3.PositionX % 2;

                {
                    if (a == 0)
                    {
                        brick1.Colour = "red";
                    }
                    else
                    {
                        brick1.Colour = "green";
                    }
                }

                {
                    if (b == 0)
                    {
                        brick2.Colour = "green";
                    }
                    else
                    {
                        brick2.Colour = "red";
                    }
                }
                {
                    if (c == 0)
                    {
                        brick3.Colour = "red";
                    }
                    else
                    {
                        brick3.Colour = "green";
                    }
                }
            }
        }
    }
}
