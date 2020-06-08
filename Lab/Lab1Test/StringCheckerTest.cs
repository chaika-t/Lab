using System;
using Lab;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Lab1Test
{
    [TestClass]
    public class StringCheckerTest
    {
        [TestMethod]
        public void CountAverageLengthTest()
        {
            string[] input = { "1234", "12345", "string" };
            int expected = 5;
            int actual = StringChecker.FindAverageLength(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindMoreThanAverageTest()
        {
            string[] input = { "1234", "12345", "string" };
            string[] expected = { "string" };
            string[] actual = StringChecker.FindMoreThanAverage(input);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
