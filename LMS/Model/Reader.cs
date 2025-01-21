using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Model
{
    internal class Reader
    {
        public int ReaderId { get; set; }

        public string LName { get; set; }
        
        public string FName { get; set; }
        
        public string MName { get; set; }

        public DateTime Birthday { get; set; }

        public int ResidentialAddressId { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public DateTime DateOfRegistration { get; set; }
    }
}
