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

        [TestMethod]
        public void EqualsValid()
        {
            //-- Arrange
            var expected = new Person(123);

            //-- Act
            var actual = new Person(123);

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetTaxWithoutParamValid()
        {
            //-- Arrange
            var person = new Person()
            {
                PersonIncome = 3_500_000M,
                TaxCoe = 0.05
            };

            var expected = 175_000M;

            //-- Act
            var actual = person.GetTax();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetTaxWithParamValid()
        {
            //-- Arrange
            var person = new Person();

            var expected = 175_000M;

            //-- Act
            var actual = person.GetTax(3_500_000M, 0.05);

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
