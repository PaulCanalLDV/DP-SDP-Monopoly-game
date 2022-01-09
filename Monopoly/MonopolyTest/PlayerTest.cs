using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Monopoly;

namespace MonopolyTest
{
    [TestClass]
    public class PlayerTest
    {
        [TestMethod]
        public void ShowTest()
        {
            Player p1 = new Player("test", new StandardPosition());
            int x = p1.RollTheDice();
            Assert.IsTrue(2 <= x && x <= 12);
        }
    }
}
