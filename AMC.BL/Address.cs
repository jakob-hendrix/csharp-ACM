using System;
using System.Collections.Generic;
using System.Text;

namespace AMC.BL
{
    public class Address
    {
        public Address()
        {

        }

        public Address(int addressId)
        {
            this.AddressId = addressId;
        }

        public int AddressId { get; private set; }
        public int AddressType { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public override bool Equals(object obj)
        {
            var address = obj as Address;
            if (address == null)
            {
                return false;
            }

            return address.StreetLine1 == this.StreetLine1
                && address.StreetLine2 == this.StreetLine2
                && address.City == this.City
                && address.State == this.State
                && address.Country == this.Country
                && address.PostalCode == this.PostalCode;
        }
    }
}
