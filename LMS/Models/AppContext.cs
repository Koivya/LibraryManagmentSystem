using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace LMS.Model
{
    class AppContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<BookAuthor> BookAuthors { get; set; }

        public DbSet<BookGenre> BookGenres { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Operation> Operations { get; set; }

        public DbSet<Reader> Readers { get; set; }

        public DbSet<ResidentialAddress> ResidentialAddresses { get; set; }
        
        public DbSet<User> Users { get; set; }

        //public AppContext() : base("DefaultConnection") { }
    }
}
