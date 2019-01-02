using System;
using System.Collections.Generic;
using System.Text;
using Acme.Common;

namespace AMC.BL
{
    public class Product : EntityBase, ILoggable
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
        //public string ProductName { get; set; }

        private string _ProductName;

        public string ProductName   
        {
            get
            {
                return _ProductName.InsertSpaces();
            }
            set { _ProductName = value; }
        }


        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        public override string ToString()
        {
            return ProductName;
        }

        public string Log()
        {
            var logString = $"{this.ProductId}: ProductName: {this.ProductName} Detail: {this.ProductDescription} Status: {this.EntityState.ToString()}";
            return logString;
        }
    }
}
