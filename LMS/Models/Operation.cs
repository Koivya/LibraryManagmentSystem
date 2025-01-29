using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Model
{
    public class Operation : INotifyPropertyChanged
    {
        private int bookId;
        private int readerId;
        private string dateOfIssue;
        private string returnDate;
        private string status;

        public int BookId
        {
            get { return bookId; }
            set
            {
                bookId = value;
                OnPropertyChanged("BookId");
            }
        }
        public int ReaderId
        {
            get { return readerId; }
            set
            {
                readerId = value;
                OnPropertyChanged("ReaderId");
            }
        }
        public string DateOfIssue
        {
            get { return dateOfIssue; }
            set
            {
                dateOfIssue = value;
                OnPropertyChanged("DateOfIssue");
            }
        }
        public string ReturnDate
        {
            get { return returnDate; }
            set
            {
                returnDate = value;
                OnPropertyChanged("ReturnDate");
            }
        }
        public string Status
        {
            get { return status; }
            set
            {
                status = value;
                OnPropertyChanged("Status");
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
