using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Model
{
    public class BookAuthor : INotifyPropertyChanged
    {
        private int bookId;
        private int authorId;

        public int BookId
        {
            get { return bookId; }
            set
            {
                bookId = value;
                OnPropertyChanged("BookId");
            }
        }

        public int AuthorId
        {
            get { return authorId; }
            set
            {
                authorId = value;
                OnPropertyChanged("AuthorId");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
