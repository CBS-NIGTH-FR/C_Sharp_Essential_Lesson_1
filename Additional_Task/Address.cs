﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Task
{
    class Address
    {
        int index;
        string country,city,street,house,apartment;

        public int Index{get { return index; } set { index = value; }}
        public string Country { get { return country; } set { country = value; } }
        public string City { get { return city; } set { city = value; } }
        public string Street { get { return street; } set { street = value; } }
        public string House { get { return house; } set { house = value; } }
        public string Apartment { get { return apartment; } set { apartment = value; } } 

        public Address(int index, string country, string city, string street, string house, string apartment)
        {
            this.index = index;
            this.country = country;
            this.city = city;
            this.street = street;
            this.house = house;
            this.apartment = apartment;
        }

    }
}
