using Acme.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMC.BL
{
    public class Order : EntityBase, ILoggable
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            this.OrderId = orderId;
        }


        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }

        // Value type - nullable. Tracks date, time, and time zone offset
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; set; }
        public List<OrderItem> orderItems { get; set; }

        /// <summary>
        /// Validate the current order
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

        public override string ToString()
        {
            return $"{OrderDate} ({OrderId})";
        }

        public string Log()
        {
            var logString = $"{this.OrderId}: Order Date: {this.OrderDate} Status: {this.EntityState.ToString()}";
            return logString;
        }
    }
}
