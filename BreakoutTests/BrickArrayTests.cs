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
    public class BrickArrayTests
    {
        [TestMethod()]
        public void BrickArrayTest()
        {
            var array = new BrickArray();
            Assert.AreEqual(30, array.Bricks.Count);
        }
    }
}