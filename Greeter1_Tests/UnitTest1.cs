﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DependencyExamples;

namespace Greeter1_Tests
{
    // NOTE: Expect MOST of these classes to fail because we
    // are still passing in a class that has dependencies on the 
    // current date.

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Greet_ReturnsMorningMessage_WhenTimeIsBeforeNoon()
        {
            var g = new Greeter1();
            var msg = g.Greet();
            Assert.AreEqual("Good Morning.", msg);
        }

        [TestMethod]
        public void Greet_ReturnsAfternoonMessage_WhenTimeBetweenNoonAndSix()
        {
            var g = new Greeter1();
            var msg = g.Greet();
            Assert.AreEqual("Good Afternoon.", msg);
        }

        [TestMethod]
        public void Greet_ReturnsMorningMessage_WhenTimeAfterSix()
        {
            var g = new Greeter1();
            var msg = g.Greet();
            Assert.AreEqual("Good Evening.", msg);
        }
    }
}
