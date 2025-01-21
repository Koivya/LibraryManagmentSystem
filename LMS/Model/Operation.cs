using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Model
{
    internal class Operation
    {
        public int BookID { get; set; }

        public int ReaderID { get; set; }

        public DateTime DateOfIssue { get; set; }

        public DateTime ReturnDate { get; set; }

        public string Status { get; set; }
    }
}
