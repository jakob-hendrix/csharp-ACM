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

            Object myObject = new object();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"Object: {product.ToString()}");

            return product;
        }

        /// <summary>
        /// Saves the current product
        /// </summary>
        /// <returns></returns>
        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges && product.IsValid)
            {
                if (product.IsNew)
                {
                    // Call an Insert Stored Procedure
                }
                else
                {
                    // Call an update Stored Procedure
                }
            }
            return success;
        }
    }
}
