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

        public OrderDisplay RetrieveOrderDisplay(int orderId)
        {
            OrderDisplay orderDisplay = new OrderDisplay();

            // TODO - Code that retrives the defined order fields

            // Temp hard-coded values
            if (orderId == 10)
            {
                orderDisplay.FirstName = "Bilbo";
                orderDisplay.LastName = "Baggins";
                orderDisplay.OrderDate = new DateTimeOffset(2018, 4, 14, 10, 00, 00, new TimeSpan(0));
                orderDisplay.ShippingAddress = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot Row",
                    City = "Hobbiton",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144"
                };
            }

            orderDisplay.orderDisplayItemList = new List<OrderDisplayItem>();

            // Code that retrieves the order items

            // Temp hard-coded order items
            if (orderId == 10)
            {
                var orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Sunflowers",
                    PurchasePrice = 15.96M,
                    OrderQuantity = 2
                };
                orderDisplay.orderDisplayItemList.Add(orderDisplayItem);

                orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Rake",
                    PurchasePrice = 6M,
                    OrderQuantity = 1
                };
                orderDisplay.orderDisplayItemList.Add(orderDisplayItem);
            }

            return orderDisplay;
        }

        /// <summary>
        /// Save the current order.
        /// </summary>
        /// <returns></returns>
        public bool Save(Order order)
        {
            return true;
        }
    }
}
