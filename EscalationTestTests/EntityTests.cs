using Microsoft.VisualStudio.TestTools.UnitTesting;
using EscalationTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscalationTest.Tests
{
    [TestClass()]
    public class EntityTests
    {
        [TestMethod()]
        public void ToStringTest()
        {
            Assert.AreEqual("Chest", new Entity() {TypeId = 1}.ToString());
            Assert.AreEqual("Ogre", new Entity() { TypeId = 5 }.ToString());
            Assert.AreEqual("", new Entity() {TypeId = 6}.ToString());

        }
    }
}