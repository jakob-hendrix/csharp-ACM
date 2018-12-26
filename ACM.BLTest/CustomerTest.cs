using System;
using AMC.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // -- Arrange
            Customer customer = new Customer();  // create new instance of the Customer class
            customer.FirstName = "Bilbo";
            customer.LastName = "Baggins";
            string expected = "Baggins, Bilbo";

            // -- Act
            string actual = customer.FullName;

            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // -- Arrange
            Customer customer = new Customer();  // create new instance of the Customer class
            customer.LastName = "Baggins";
            string expected = "Baggins";

            // -- Act
            string actual = customer.FullName;

            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // -- Arrange
            Customer customer = new Customer();  // create new instance of the Customer class
            customer.FirstName = "Bilbo";
            string expected = "Bilbo";

            // -- Act
            string actual = customer.FullName;

            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            // -- Arrange
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            var c2 = new Customer();
            c2.FirstName = "Frodo";
            var c3 = new Customer();
            c3.FirstName = "Rosie";

            // -- Act

            // -- Assert
            Assert.AreEqual(Customer.InstanceCount,3);
        }

        [TestMethod]
        public void ValidateValid()
        {
            // -- Arrange
            var customer = new Customer();
            customer.LastName = "Baggins";
            customer.EmailAddress = "fbaggins@hobbiton.me";

            var expected = true;

            // -- Act
            var actual = customer.Validate();

            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateLastNameEmpty()
        {
            // -- Arrange
            var customer = new Customer();
            customer.EmailAddress = "fbaggins@hobbiton.me";

            var expected = false;

            // -- Act
            var actual = customer.Validate();

            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateEmailEmpty()
        {
            // -- Arrange
            var customer = new Customer();
            customer.LastName = "Baggins";

            var expected = false;

            // -- Act
            var actual = customer.Validate();

            // -- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
