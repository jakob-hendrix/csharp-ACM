using System;
using System.Collections.Generic;
using System.Text;

namespace AMC.BL
{
    public class ProductRepository
    {
        /// <summary>
        ///  Retrieve this product
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            // Code to retrieve the defined product
            Product product = new Product(productId);

            // Temp hard coded values for testing
            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted sizes of Sunflower seeds";

                // Money!
                product.CurrentPrice = 15.96M;
            }

            return product;
        }

        /// <summary>
        /// Saves the current product
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the defined product
            return true;
        }
    }
}
