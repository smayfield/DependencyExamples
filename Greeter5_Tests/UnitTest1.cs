﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DependencyExamples;

namespace Greeter1_Tests
{
    [TestClass]
    public class UnitTest1
    {
        // NOTE: Expect MOST of these classes to fail because we
        // are still passing in a class that has dependencies on the 
        // current date.

        [TestMethod]
        public void Greet_ReturnsMorningMessage_WhenTimeIsBeforeNoon()
        {
            var mw = new HolidayMessageWriter2();
            var g = new Greeter5(mw);
            var msg = g.Greet();
            Assert.AreEqual("Good Morning.", msg);
        }

        [TestMethod]
        public void Greet_ReturnsAfternoonMessage_WhenTimeBetweenNoonAndSix()
        {
            var mw = new HolidayMessageWriter2();
            var g = new Greeter5(mw);
            var msg = g.Greet();
            Assert.AreEqual("Good Afternoon.", msg);
        }

        [TestMethod]
        public void Greet_ReturnsMorningMessage_WhenTimeAfterSix()
        {
            var mw = new HolidayMessageWriter2();
            var g = new Greeter5(mw);
            var msg = g.Greet();
            Assert.AreEqual("Good Evening.", msg);
        }

        [TestMethod]
        public void Greet_ReturnsNewYearsMessage_WhenFirstOfYear()
        {
            var mw = new HolidayMessageWriter2();
            var g = new Greeter5(mw);
            var msg = g.Greet();
            Assert.AreEqual("Good Evening.", msg);
        }
    }
}
