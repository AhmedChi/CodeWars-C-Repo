using System;
using System.Collections.Generic;
using NUnit.Framework;
using ConsoleApp;

namespace CodeWars
{
    [TestFixture]
    public class KataTestClass
    {
        private ProblemQ2 _app;

        [SetUp]
        public void SetUp()
        {
            _app = new ProblemQ2();

        }

        [TestCase]
        public void BasicTest1()
        {
            List<string> result = new List<string> { "Hello", "hEllo", "heLlo", "helLo", "hellO" };
            Assert.AreEqual(result, _app.MexicanWave("hello"), "it should return '" + result + "'");
        }

        [TestCase]
        public void BasicTest2()
        {
            List<string> result = new List<string> { "Codewars", "cOdewars", "coDewars", "codEwars", "codeWars", "codewArs", "codewaRs", "codewarS" };
            Assert.AreEqual(result, _app.MexicanWave("codewars"), "it should return '" + result + "'");
        }

        [TestCase]
        public void BasicTest3()
        {
            List<string> result = new List<string> { };
            Assert.AreEqual(result, _app.MexicanWave(""), "it should return '" + result + "'");
        }

        [TestCase]
        public void BasicTest4()
        {
            List<string> result = new List<string> { "Two words", "tWo words", "twO words", "two Words", "two wOrds", "two woRds", "two worDs", "two wordS" };
            Assert.AreEqual(result, _app.MexicanWave("two words"), "it should return '" + result + "'");
        }

        [TestCase]
        public void BasicTest5()
        {
            List<string> result = new List<string> { " Gap ", " gAp ", " gaP " };
            Assert.AreEqual(result, _app.MexicanWave(" gap "), "it should return '" + result + "'");
        }

    }
}