using Bai_1;
using Bai_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Bai_2Test
{
    [TestClass]
    public class TaxDataTest
    {
        [TestMethod]
        public void GetTaxCoeValid()
        {
            //-- Arrange
            var person1 = new Person()
            {
                PersonAge = 16,
                PersonIncome = 2_600_000M

            };

            var person2 = new Person()
            {
                PersonAge = 22,
                PersonIncome = 7_600_000M

            };

            var person3 = new Person()
            {
                PersonAge = 28,
                PersonIncome = 12_350_000M

            };

            var person4 = new Person()
            {
                PersonAge = 31,
                PersonIncome = 17_500_000M

            };

            var person5 = new Person()
            {
                PersonAge = 27,
                PersonIncome = 22_760_000M

            };

            var expectedPerson1 = 0;
            var expectedPerson2 = 0.05;
            var expectedPerson3 = 0.1;
            var expectedPerson4 = 0.15;
            var expectedPerson5 = 0.2;

            //-- Act
            var actualPerson1 = TaxData.GetTaxCoe(person1);
            var actualPerson2 = TaxData.GetTaxCoe(person2);
            var actualPerson3 = TaxData.GetTaxCoe(person3);
            var actualPerson4 = TaxData.GetTaxCoe(person4);
            var actualPerson5 = TaxData.GetTaxCoe(person5);

            //-- Assert
            Assert.AreEqual(expectedPerson1, actualPerson1);
            Assert.AreEqual(expectedPerson2, actualPerson2);
            Assert.AreEqual(expectedPerson3, actualPerson3);
            Assert.AreEqual(expectedPerson4, actualPerson4);
            Assert.AreEqual(expectedPerson5, actualPerson5);
        }

        [TestMethod]
        public void GetTaxCoeValidWithDataFromTaxData()
        {
            //-- Arrange
            List<Person> people = TaxData.PersonList;

            var expectedPerson1 = 0;
            var expectedPerson2 = 0.05;
            var expectedPerson3 = 0.1;
            var expectedPerson4 = 0.15;
            var expectedPerson5 = 0.2;

            //-- Act
            var actualPerson1 = TaxData.GetTaxCoe(people[0]);
            var actualPerson2 = TaxData.GetTaxCoe(people[1]);
            var actualPerson3 = TaxData.GetTaxCoe(people[2]);
            var actualPerson4 = TaxData.GetTaxCoe(people[3]);
            var actualPerson5 = TaxData.GetTaxCoe(people[4]);

            //-- Assert
            Assert.AreEqual(expectedPerson1, actualPerson1);
            Assert.AreEqual(expectedPerson2, actualPerson2);
            Assert.AreEqual(expectedPerson3, actualPerson3);
            Assert.AreEqual(expectedPerson4, actualPerson4);
            Assert.AreEqual(expectedPerson5, actualPerson5);
        }
    }
}
