using Bai_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Bai_3Test
{
    [TestClass]
    public class NameBaseTest
    {
        [TestMethod]
        public void FullNameValid()
        {
            //-- Arrange
            var personName = new NameBase()
            {
                LastNameBase = "Nguyen Bao",
                FirstNameBase = "Trung",
            };
            var expected = "Nguyen Bao Trung";

            //-- Act
            var actual = personName.FullNameBase;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange
            var personName = new NameBase()
            {
                LastNameBase = "Nguyen Bao",
            };

            var expected = "Nguyen Bao";

            //-- Act
            var actual = personName.FullNameBase;

            //-- Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //-- Arrange
            var personName = new NameBase()
            {
                FirstNameBase = "Trung",
            };

            var expected = "Trung";

            //-- Act
            var actual = personName.FullNameBase;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
