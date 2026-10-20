using System;
using System.Collections.Generic;
using System.Text;

namespace postalservice.Models
{
    public class Customer
    {
        private string Name { get; set; }
        private string Email { get; set; } = string.Empty;
        private string PhoneNumber { get; set; }
        private Address Address { get; set; }


        public Customer(string name, string email, string phoneNumber, Address address)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;

        }
        
    }
}
