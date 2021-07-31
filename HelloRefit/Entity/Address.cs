using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloRefit.Entity
{
    public class Address
    {
        public string Street { get; set; }
        public string StreetName { get; set; }
        public string BuildingNumber { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public string Country { get; set; }
        public string County_code { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
