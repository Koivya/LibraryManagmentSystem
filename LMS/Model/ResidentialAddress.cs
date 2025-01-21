using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Model
{
    internal class ResidentialAddress
    {
        public int Id { get; set; }

        public string Area { get; set; }

        public string Locality { get; set; }

        public string Street { get; set; }

        public string HouseNumber { get; set; }

        public string Apartment { get; set; }
    }
}
