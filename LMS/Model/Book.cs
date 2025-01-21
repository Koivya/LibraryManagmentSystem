using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Model
{
    public class Book
    {
        public int BookId { get; set; }

        public string Title { get; set; }

        public DateTime YearOfPublication { get; set; }

        public int ISBN { get; set; }

        public int NumberOfCopies { get; set; }

        public string CurrentState { get; set; }
    }
}
