using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Model
{
    internal class Author
    {
        public int AuthorId { get; set; }

        public string LName { get; set; }

        public string FName { get; set; }

        public string MName { get; set; }

        public DateTime Birthday { get; set; }

        public string Country { get; set; }
    }
}
