using System;
using System.Collections.Generic;
using System.Text;

namespace postalservice.Models
{
    public class Parcel
    {
        private ParcelRegistry Id { get; set; }
        private decimal Weight { get; set; }

        private Address Address { get; set; }
        private Customer Customer { get; set; }

        public Parcel(ParcelRegistry id, decimal weight, Address address, Customer customer)
        {
            Id = id;
            Weight = weight;
            Address = address;
            Customer = customer;
                     
        }

        

    }
}
