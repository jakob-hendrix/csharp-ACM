using System;
using System.Collections.Generic;
using System.Text;

namespace AMC.BL
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            this.ProductId = productId;
        }

        // The '?' defines a 'nullable' type that allows a definition or a null
        // Allows a differnece between 0 and null
        public decimal? CurrentPrice { get; set; }
        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }
        public string ProductName { get; set; }

        /// <summary>
        ///  Retrieve this product
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            // Code to retrieve the defined product
            return new Product();
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

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}
