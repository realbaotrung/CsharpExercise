using Bai_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Bai_1Test
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void FullNameValid()
        {
            //-- Arrange
            var person = new Person()
            {
                FirstName = "Trung",
                LastName = "Nguyen Bao"
            };

            var expected = "Nguyen Bao Trung";

            //-- Act
            var actual = person.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange
            var person = new Person()
            {
                LastName = "Nguyen Bao"
            };

            var expected = "Nguyen Bao";

            //-- Act
            var actual = person.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //-- Arrange
            var person = new Person()
            {
                FirstName = "Trung"
            };

            var expected = "Trung";

            //-- Act
            var actual = person.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
