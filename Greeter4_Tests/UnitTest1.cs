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
            var mw = new HolidayMessageWriter();
            var g = new Greeter4(mw);
            var msg = g.Greet();
            Assert.AreEqual("Good Morning.", msg);
        }

        [TestMethod]
        public void Greet_ReturnsAfternoonMessage_WhenTimeBetweenNoonAndSix()
        {
            var mw = new HolidayMessageWriter();
            var g = new Greeter4(mw);
            var msg = g.Greet();
            Assert.AreEqual("Good Afternoon.", msg);
        }

        [TestMethod]
        public void Greet_ReturnsMorningMessage_WhenTimeAfterSix()
        {
            var mw = new HolidayMessageWriter();
            var g = new Greeter4(mw);
            var msg = g.Greet();
            Assert.AreEqual("Good Evening.", msg);
        }

        [TestMethod]
        public void Greet_ReturnsNewYearsMessage_WhenFirstOfYear()
        {
            var mw = new HolidayMessageWriter();
            var g = new Greeter4(mw);
            var msg = g.Greet();
            Assert.AreEqual("Good Evening.", msg);
        }
    }
}
