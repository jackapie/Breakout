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

        public TopEdge TopEdge { get; set; }

        public BottomEdge BottomEdge { get; set; }

        public RightEdge RightEdge { get; set; }

        public LeftEdge LeftEdge { get; set; }

        public GameArea()
        {
            TopEdge = new TopEdge(MaxX);
            BottomEdge = new BottomEdge(MaxX, MaxY);
            RightEdge = new RightEdge(MaxX, MaxY);
            LeftEdge = new LeftEdge(MaxY);

            Bat = new Bat();
            {
                Bat.PositionX = MaxX / 2;
                Bat.PositionY = MaxY - 2;
            }
            Ball = new Ball();
            {
                Ball.PositionX = Bat.PositionX - 1;
                Ball.PositionY = Bat.PositionY - 1;
            }

            BrickArray = new BrickArray();


        }
        /// <summary>
        /// This function is to set the velocity of the ball when it is fired
        /// </summary>
        public void FireBall()
        {
            Random rndm = new Random();
            int randomXY = rndm.Next(0, 2);

            var xDirection = 1;
            if (randomXY == 2)
            {
                xDirection = -1;
            }

            Ball.BallDirection.X = xDirection;
            Ball.BallDirection.Y = -1;



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
            if (brick != null)
            {
                BrickArray.Bricks.Remove(brick);
                Ball.BallDirection.Y = -1 * Ball.BallDirection.Y;
            }

            if ((AreCollided(LeftEdge, Ball)) || (AreCollided(RightEdge, Ball)))
            {
                Ball.BallDirection.X = -1 * Ball.BallDirection.X;
            }

            if (AreCollided(TopEdge, Ball))
            {
                Ball.BallDirection.Y = -1 * Ball.BallDirection.Y;
            }

            if (AreCollided(Bat, Ball))
            {
                Ball.BallDirection.Y = -Ball.BallDirection.Y;
            }

            if (AreCollided(BottomEdge, Ball))
            {
                Ball = null;
            }

        }

        /// <summary>
        /// A function that decides if the ball has collided with a brick
        /// </summary>
        public Brick CollisionBrickVsBall()
        {
            foreach (var brick in BrickArray.Bricks)
            {
                if (AreCollided(brick, Ball))
                {
                    return brick;
                }
            }
            return null;
        }


        public bool AreCollided(ScreenObject object1, ScreenObject object2)
        {
            var xMissing = (object1.PositionX > object2.PositionX + object2.SizeX) 
                || (object2.PositionX > object1.PositionX + object1.SizeX);
            var yMissing = (object1.PositionY > object2.PositionY + object2.SizeY) 
                || (object2.PositionY > object1.PositionY + object1.SizeY);
            if (xMissing == false && yMissing == false)

            {
                return true;
            }
            return false;
        }
    }
}
