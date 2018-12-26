using System;
using System.Collections.Generic;
using System.Text;

namespace AMC.BL
{
    public class OrderRepository
    {
        /// <summary>
        /// Retrieve one order.
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            // Temp values for testing
            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(2019,12,26,17,0,0,TimeSpan.Zero);
            }

            return order;
        }

        /// <summary>
        /// Save the current order.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }
    }
}
