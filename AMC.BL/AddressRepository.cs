using System;
using System.Collections.Generic;
using System.Text;

namespace AMC.BL
{
    public class AddressRepository
    {
        /// <summary>
        /// Retrieve a single address
        /// </summary>
        /// <param name="addressId"></param>
        /// <returns></returns>
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            // Temp default values
            if (addressId == 1)
            {
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot Row";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            }
            return address;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            // Code to retrieve the address for the customer

            // Temp default values
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag End",
                StreetLine2 = "Bagshot Row",
                City = "Hobbiton",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "144",
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Green Dragon",
                City = "Bywater",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "146",
            };
            addressList.Add(address);

            return addressList;
        }

        /// <summary>
        /// Saves the current address
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public bool Save(Address address)
        {
            return true;
        }
    }
}
