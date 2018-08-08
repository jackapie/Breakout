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
        int GameTurn = 1;

        public Ball ball { get; set; }

        public Bat bat { get; set; }

        public BrickArray brickArray { get; set; }

        public TopEdge topEdge { get; set; }

        public BottomEdge bottomEdge { get; set; }

        public RightEdge rightEdge { get; set; }

        public LeftEdge leftEdge { get; set; }

        public GameArea()
        {
            topEdge = new TopEdge(MaxX);
            bottomEdge = new BottomEdge(MaxX, MaxY);
            rightEdge = new RightEdge(MaxX, MaxY);
            leftEdge = new LeftEdge(MaxY);

            bat = new Bat();
            {
                bat.PositionX = MaxX / 2;
                bat.PositionY = MaxY - 2;
            }
            ball = new Ball();
            {
                ball.PositionX = bat.PositionX - 1;
                ball.PositionY = bat.PositionY - 1;
            }

            brickArray = new BrickArray();


        }
        /// <summary>
        /// This function is to set the velocity of the ball when it is fired
        /// </summary>
        public void FireBall()
        {
            Random rndm = new Random();
            int randomXY = rndm.Next(0, 2);

            var xDirection = 1;
            if (randomXY == 1)
            {
                xDirection = -1;
            }

            ball.BallDirection.X = xDirection;
            ball.BallDirection.Y = -1;



        }

        /// <summary>
        /// This function (atm) should keep the ball travelling in the direction of balldirection
        /// , set by the FireBall function.
        /// However, the ball should have velocity (O,O) until the ball is fired.
        /// </summary>

        public void PlayTurn()
        {
            if (GameTurn % 2 == 0)
            {

                ball.Move(ball.BallDirection.X, ball.BallDirection.Y);

                var brick = CollisionBrickVsBall();
                if (brick != null)
                {
                    brickArray.Bricks.Remove(brick);
                    ball.BallDirection.Y = -1 * ball.BallDirection.Y;
                }

                if ((AreCollided(leftEdge, ball)) || (AreCollided(rightEdge, ball)))
                {
                    ball.BallDirection.X = -1 * ball.BallDirection.X;
                }

                if (AreCollided(topEdge, ball))
                {
                    ball.BallDirection.Y = -1 * ball.BallDirection.Y;
                }

                if (AreCollided(bat, ball))
                {
                    ball.BallDirection.Y = -ball.BallDirection.Y;
                }

                if (AreCollided(bottomEdge, ball))
                {
                    ball = new Ball();
                    ball.PositionX = bat.PositionX;
                    ball.PositionY = bat.PositionY - 1;


                }
            }
            GameTurn++;
        }

        /// <summary>
        /// A function that decides if the ball has collided with a brick
        /// </summary>
        public Brick CollisionBrickVsBall()
        {
            foreach (var brick in brickArray.Bricks)
            {
                if (AreCollided(brick, ball))
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
