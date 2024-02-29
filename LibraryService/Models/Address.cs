using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryService.Models
{
    public class Address
    {

        private int id { get; set; }
        private string neighborhood { get; set; }
        private string city { get; set; }
        private string state { get; set; }
        private string country { get; set; }
        private string zipCode { get; set; }
        private string complement { get; set; }

        public Address() { }

        public Address(int id, string neighborhood, string city, string state, string country, string zipCode, string complement)
        {
            this.id = id;
            this.neighborhood = neighborhood;
            this.city = city;
            this.state = state;
            this.country = country;
            this.zipCode = zipCode;
            this.complement = complement;
        }
    }
}
