using Microsoft.VisualStudio.TestTools.UnitTesting;
using Breakout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakout.Tests
{
    [TestClass()]
    public class GameAreaTests
    {


        [TestMethod()]
        public void TestCollisionBrickBallTest()
        {
            var gameArea = new GameArea();
            var brick = new Brick();
            var ball = new Ball();
            ball.PositionX = 20;
            ball.PositionY = 17;
            brick.PositionX = 20;
            brick.PositionY = 17;

            Assert.AreEqual(true, gameArea.TestCollisionBrickBall(brick, ball));
            
        }
    }
}