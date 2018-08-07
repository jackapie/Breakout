using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakout
{
    public class GameArea
    {
        public const int MaxX = 60;
        public const int MaxY = 30;

        public Ball Ball { get; set; }

        public Bat Bat { get; set; }

        public BrickArray BrickArray { get; set; }

        public GameArea()
        {
            Bat = new Bat();
            {
                Bat.PositionX = MaxX / 2;
                Bat.PositionY = MaxY - 2;
            }
            Ball = new Ball();
            {
                Ball.PositionX = Bat.PositionX + 1;
                Ball.PositionY = Bat.PositionY + 1;
            }
           
            BrickArray = new BrickArray();

            
        }
        /// <summary>
        /// This function is to set the velocity of the ball when it is fired
        /// </summary>
        public void FireBall()
        {
            Random rndm = new Random();
            int randomXY = rndm.Next(-2, -4);
            
            
            Ball.BallDirection.X = randomXY;
            Ball.BallDirection.Y = randomXY;

            

        }

        /// <summary>
        /// This function (atm) should keep the ball travelling in the direction of balldirection
        /// , set by the FireBall function.
        /// However, the ball should have velocity (O,O) until the ball is fired.
        /// </summary>

        public void PlayTurn()
        {
            
            Ball.Move(Ball.BallDirection.X, Ball.BallDirection.Y);

            var brick = CollisionBrickVsBall();
            if(brick != null)
            {
                BrickArray.Bricks.Remove(brick);
                Ball.BallDirection.Y = -1 * Ball.BallDirection.Y;
            }

            if(CollisionXEdge() == true)
            {
                Ball.BallDirection.X = -1 * Ball.BallDirection.X;
            }

            if(CollisionZeroYEdge() == true)
            {
                Ball.BallDirection.Y = -1 * Ball.BallDirection.Y;
            }

            if(CollisionMaxYEdge() == true)
            {
                Ball = null;
            }
            
        }

        /// <summary>
        /// A function that decides if the ball has collided with a brick
        /// </summary>
        public Brick CollisionBrickVsBall()
        {
            foreach(var brick in BrickArray.Bricks)
            {
                if(((brick.PositionX == Ball.PositionX) || (brick.PositionX + 1 == Ball.PositionX) || (brick.PositionX - 1 == Ball.PositionX)) 
                    && brick.PositionY == Ball.PositionY)
                {
                    return brick;
                }
             }
            return null;
        }

        /// <summary>
        /// #A function that decides if the ball has collided with the MaxX edge of the game area.
        /// </summary>
        public bool CollisionXEdge()
        {
            if(Ball.PositionX == MaxX || Ball.PositionX == 0)
            {
                return true;
            }
            return false;
        }

        public bool CollisionZeroYEdge()
        {
            if(Ball.PositionY == 0)
            {
                return true;
            }
            return false;
        }

        public bool CollisionMaxYEdge()
        {
            if(Ball.PositionY == MaxY)
            {
                return true;
            }
            return false;
        }

        public bool TestCollisionBrickBall(Brick brick, Ball ball)
        {
            if(((brick.PositionX == ball.PositionX) || (brick.PositionX + 1 == ball.PositionX) || (brick.PositionX - 1 == ball.PositionX))
                    && brick.PositionY == ball.PositionY)
            {
                return true;
            }
            return false;
        }
    }
}
