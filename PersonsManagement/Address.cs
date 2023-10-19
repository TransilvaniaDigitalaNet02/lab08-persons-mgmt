using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsManagement
{
    public class Address
    {
        public Address(
            string country,
            string county,
            string city,
            string street,
            string streetNumber) 
        {
            Country = country ?? string.Empty;
            County = county ?? string.Empty;
            City = city ?? string.Empty;
            Street = street ?? string.Empty;
            StreetNumber = streetNumber ?? string.Empty;
        }

        public string Country { get; }

        public string County { get; }

        public string City { get; }

        public string Street { get; }

        public string StreetNumber { get; }
    }
}
