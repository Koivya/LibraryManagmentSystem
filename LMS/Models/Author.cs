using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Model
{
    public class Author : INotifyPropertyChanged
    {
        private int authorId;
        private string lName;
        private string fName;
        private string mName;
        private string birthday;
        private string country;

        public int AuthorId 
        {
            get { return authorId; }
            set
            {
                authorId = value;
                OnPropertyChanged("AuthorId");
            }
        }

        public string LName
        {
            get { return lName; }
            set
            {
                lName = value;
                OnPropertyChanged("LName");
            }
        }

        public string FName
        {
            get { return fName; }
            set
            {
                fName = value;
                OnPropertyChanged("FName");
            }
        }

        public string MName
        {
            get { return mName; }
            set
            {
                mName = value;
                OnPropertyChanged("MName");
            }
        }

        public string Birthday
        {
            get { return birthday; }
            set
            {
                birthday = value;
                OnPropertyChanged("Birthday");
            }
        }

        public string Country
        {
            get { return country; }
            set
            {
                country = value;
                OnPropertyChanged("Country");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
