using Acme.Common;
using System;
using System.Collections.Generic;

namespace AMC.BL
{
    public class Customer : EntityBase, ILoggable
    {
        // Default Constructor
        public Customer()
            : this(0)
        {

        }

        public Customer(int customerId)
        {
            this.CustomerId = customerId;

            /* Where do this data come from?
             */ 
            AddressList = new List<Address>();  // empty list instead of null
        }

        public static int InstanceCount{ get; set; }

        private string _lastName;

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public int CustomerType { get; set; }

        public List<Address> AddressList { get; set; }  // default is null

        public string FirstName { get; set; }

        public string EmailAddress { get; set; }

        public int CustomerId { get; private set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(LastName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public override bool Validate()
        {
            var isValid = true;

            /* What makes a customer a valid entry member?
             */
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        public override string ToString()
        {
            return FullName;
        }

        public string Log()
        {
            var logString = $"{this.CustomerId}: Name: {this.FullName} Email: {this.EmailAddress} Status: {this.EntityState.ToString()}";
            return logString;                
        }

    }
}
