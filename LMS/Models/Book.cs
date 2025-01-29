using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Model
{
    public class Book : INotifyPropertyChanged
    {
        private int bookId;
        private string title;
        private string placeOfPublication;
        private string publisher;
        private string yearOfPublication;
        private string numberOfPages;
        private decimal price;
        private int numberOfCopies;
        private int iSBN;
        private string currentState;
        private string placeInLibrary;

        public int BookId
        {
            get { return bookId; }
            set
            {
                bookId = value;
                OnPropertyChanged("BookId");
            }
        }

        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }

        public string PlaceOfPublication
        {
            get { return placeOfPublication; }
            set
            {
                placeOfPublication = value;
                OnPropertyChanged("PlaceOfPublication");
            }
        }

        public string Publisher
        {
            get { return publisher; }
            set
            {
                publisher = value;
                OnPropertyChanged("Publisher");
            }
        }

        public string YearOfPublication
        {
            get { return yearOfPublication; }
            set
            {
                yearOfPublication = value;
                OnPropertyChanged("YearOfPublication");
            }
        }

        public string NumberOfPages
        {
            get { return numberOfPages; }
            set
            {
                numberOfPages = value;
                OnPropertyChanged("NumberOfPages");
            }
        }

        public decimal Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged("Price");
            }
        }

        public int NumberOfCopies
        {
            get { return numberOfCopies; }
            set
            {
                numberOfCopies = value;
                OnPropertyChanged("NumberOfCopies");
            }
        }

        public int ISBN
        {
            get { return iSBN; }
            set
            {
                iSBN = value;
                OnPropertyChanged("ISBN");
            }
        }

        public string CurrentState
        {
            get { return currentState; }
            set
            {
                currentState = value;
                OnPropertyChanged("CurrentState");
            }
        }

        public string PlaceInLibrary
        {
            get { return placeInLibrary; }
            set
            {
                placeInLibrary = value;
                OnPropertyChanged("PlaceInLibrary");
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
