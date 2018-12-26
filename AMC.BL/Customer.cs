using System;
using System.Collections.Generic;

namespace AMC.BL
{
    public class Customer
    {
        // Default Constructor
        public Customer()
        {
            InstanceCount += 1;
        }

        public Customer(int customerId) : this()
        {
            this.CustomerId = customerId;
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

        public bool Validate()
        {
            var isValid = true;

            /* What makes a customer a valid entry member?
             */
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

    }
}
