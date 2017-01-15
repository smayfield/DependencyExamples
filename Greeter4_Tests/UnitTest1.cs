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
            var mw = new MessageWriter();
            var g = new Greeter4(10, mw); // 10am
            var msg = g.Greet();
            Assert.AreEqual("Good Morning.", msg);
        }

        [TestMethod]
        public void Greet_ReturnsAfternoonMessage_WhenTimeBetweenNoonAndSix()
        {
            var mw = new MessageWriter();
            var g = new Greeter4(14, mw); // 2pm
            var msg = g.Greet();
            Assert.AreEqual("Good Afternoon.", msg);
        }

        [TestMethod]
        public void Greet_ReturnsMorningMessage_WhenTimeAfterSix()
        {
            var mw = new MessageWriter();
            var g = new Greeter4(20, mw); // 8pm
            var msg = g.Greet();
            Assert.AreEqual("Good Evening.", msg);
        }
    }
}
