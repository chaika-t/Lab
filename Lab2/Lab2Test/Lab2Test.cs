using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab2;

namespace Lab2Test
{
    [TestClass]
    public class PersonTests
    {
        private string _fileName;
        private Person _person;
        private JsonConverter _jsonConverter;

     [TestInitialize]
        public void TestInitialize()
        {
            _fileName = "D:/Person.json";
            _person = new Person("Smith ", "jon",  new DateTime(2001, 02, 03), "Male");
            _jsonConverter = new JsonConverter();
            _jsonConverter.ToJson(_person, _fileName);
        }

        [TestMethod]
        public void LoadFromJsonTest()
        {
            Person personFromJson = _jsonConverter.FromJson(_fileName);
            Assert.IsTrue(_person.Equals(personFromJson));
        }
    }
}
