using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AMC.BL
{
    public class CustomerRepository
    {
        // Private property to hold this repo since no other code should be touching it
        private AddressRepository addressRepository { get; set; }

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        /// <summary>
        /// Retrieve one customer.
        /// </summary>
        public Customer Retrieve(int customerId)
        {
            // Code that retreives the defined customer
            Customer customer = new Customer(customerId);  //"uses a" Customer
            customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();

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
        public bool Save(Customer customer)
        {
            var success = true;

            if (customer.HasChanges && customer.IsValid)
            {
                if (customer.IsNew)
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
