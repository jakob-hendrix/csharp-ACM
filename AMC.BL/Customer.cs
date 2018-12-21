using System;

namespace AMC.BL
{
    public class Customer
    {
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
        public string FirstName { get; set; };

        public string EmailAddress { get; set; }

        public int CustomerId { get; private set; }

        public string FullName
        {
            get
            {
                return $"{LastName}, {FirstName}";
            }
        }

    }
}
