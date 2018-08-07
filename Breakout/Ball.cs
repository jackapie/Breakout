using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakout
{
    public class Ball : ScreenObject
    {
        public Ball()
        {
            SizeX = 1;
            SizeY = 1;

            BallDirection = new Vector();
            BallDirection.X = 0;
            BallDirection.Y = 0;
            

        }
        /// <summary>
        /// function to get the direction
        /// </summary>
        public Vector BallDirection { get; set; }


    }

}


        
   

