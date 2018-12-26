using System;
using System.Collections.Generic;
using System.Text;

namespace AMC.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            this.OrderItemId = orderItemId;
        }
        public int OrderItemId { get; set; }
        public int OrderQuantity { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }

        /// <summary>
        /// Retrieve one order item
        /// </summary>
        /// <param name="orderItemId"></param>
        /// <returns></returns>
        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }

        /// <summary>
        ///  Save the current order item.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }

        /// <summary>
        ///  Validate this order item.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            bool isValid = true;

            // What make an order item invalid?
            if (OrderQuantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
    }
}
