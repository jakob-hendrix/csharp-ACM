using System;
using System.Collections.Generic;
using System.Text;

namespace AMC.BL
{
    public class CustomerRepository
    {
        /// <summary>
        /// Retrieve one customer.
        /// </summary>
        public Customer Retrieve(int customerId)
        {
            // Code that retreives the defined customer
            Customer customer = new Customer(customerId);

            // Temp code to return a populated customer
            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }
            return customer;
        }

        /// <summary>
        /// Retrieves multiple customers.
        /// </summary>
        public List<Customer> Retrieve()
        {
            // Code that retreives the defined customer
            return new List<Customer>();
        }

        /// <summary>
        /// Saves the current customer
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the defined customer
            return true;
        }
    }
}
