using System;
using System.Collections.Generic;
using System.Text;

namespace postalservice.Models
{
    public class Address
    {
        private string StreetAddress { get; set; }
        private string PostalCode { get; set; }
        private string City { get; set; }

        public Address(string streetAddress, string postalCode, string city)
        {
            StreetAddress = streetAddress;
            PostalCode = postalCode;
            City = city;
        }

    }

    

}
