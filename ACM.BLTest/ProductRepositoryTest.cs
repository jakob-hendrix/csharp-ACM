using System;
using AMC.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            // -- Arrange
            var productRepository = new ProductRepository();
            var expected = new Product()
            {
                ProductName = "Sunflowers",
                ProductDescription = "Assorted sizes of Sunflower seeds",
                CurrentPrice = 15.96M
            };

            // -- Act
            var actual = productRepository.Retrieve(2);

            // -- Assert
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        }
    }
}
