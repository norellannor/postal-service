using System;
using System.Collections.Generic;
using System.Text;

namespace postalservice.Models
{
    public class ParcelRegistry
    {
        private int Id { get; set; }
        private Parcel Parcel { get; set; }

        public ParcelRegistry( int id, Parcel parcel) 
        { 
            Id = id;
            Parcel=parcel;
           
        }


        public int GenerateParcelId()
        {
            Id = RandomNumberGenerater.Create();

            
          
        }
    }
}
