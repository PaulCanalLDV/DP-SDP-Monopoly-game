using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Monopoly;

namespace MonopolyTest
{
    [TestClass]
    public class JailTest
    {
        [TestMethod]
        public void CheckSingleton()
        {
            Jail jail1 = Jail.GetJail();

            Jail jail2 = Jail.GetJail();

            Assert.IsTrue(jail1 == jail2);
        }
    }
}
