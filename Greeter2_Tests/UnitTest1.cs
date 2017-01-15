using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DependencyExamples;

namespace Greeter1_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Greet_ReturnsMorningMessage_WhenTimeIsBeforeNoon()
        {
            var g = new Greeter2();
            var msg = g.Greet(10); // 10am
            Assert.AreEqual("Good Morning.", msg);
        }

        [TestMethod]
        public void Greet_ReturnsAfternoonMessage_WhenTimeBetweenNoonAndSix()
        {
            var g = new Greeter2();
            var msg = g.Greet(14); // 2pm
            Assert.AreEqual("Good Afternoon.", msg);
        }

        [TestMethod]
        public void Greet_ReturnsMorningMessage_WhenTimeAfterSix()
        {
            var g = new Greeter2();
            var msg = g.Greet(20); // 8pm
            Assert.AreEqual("Good Evening.", msg);
        }
    }
}
