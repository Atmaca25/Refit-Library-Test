using HelloRefit.Abstract;
using HelloRefit.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloRefit.Entity
{
    public class Person
    {
        public string Gender { get; set; }
        public DateTime Birthday { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Address Address { get; set; }
        public string Website { get; set; }
        public string Image { get; set; }
    }
}
