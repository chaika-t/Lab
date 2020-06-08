using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab5;
namespace Lab5Test
{
    [TestClass]
    public class CashRegisterTest
    {
        private CashRegister _cashRegister;
        [TestInitialize]
        public void Initialization()
        {
          _cashRegister = new CashRegister(new Dictionary<string, double>
                {{"Bread", 39.0}, {"Tomato", 20.0}, {"Garlic", 15.0}});

            _cashRegister.AddProduct("Bread", 2);
            _cashRegister.AddProduct("Tomato", 3);
            _cashRegister.AddProduct("Garlic", 1);
        }

        [TestMethod]
        public void GetReceipt()
        {
            string expected = @"Bread 2 * 39 = 78
Garlic 1 * 15 = 15
Tomato 3 * 20 = 60
Total price =153
";
            string actual = _cashRegister.GetReceipt();
            Assert.AreEqual(expected, actual);
        }
    }
}
