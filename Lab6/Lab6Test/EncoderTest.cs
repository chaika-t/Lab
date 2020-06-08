using System;
using System.IO;
using Lab6;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab6Test
{
    [TestClass]
    public class EncoderTest
    {
        private string filePath;
        private int _key;
        [TestInitialize]
        public void TestInitialize()
        {
            filePath = "input.txt";
            _key = 5;
        }

        [TestMethod]
        public void EncodeTest()
        {
            var expected = @"Yjxy%xywnsl";
            var encoder = new Encoder(new StreamWriter(filePath), _key);
            encoder.Encode("Test string");
            encoder.Close();

            Assert.AreEqual(expected, encoder.GetString());
        }

        [TestMethod]
        public void DecodeTest()
        {
            var expected = "Test string";
            var decoder = new Decoder(new StreamReader(filePath), _key);
            var actual = decoder.Decode();
            decoder.Close();
            Assert.AreEqual(expected, actual);
        }
    }
}
