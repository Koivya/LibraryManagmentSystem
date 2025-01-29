using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Model
{
    public class Reader : INotifyPropertyChanged
    {
        private int readerId;
        private string lName;
        private string fName;
        private string mName;
        private string birthday;
        private int residentialAddressId;
        private string phoneNumber;
        private string dateOfRegistration;

        public int ReaderId
        {
            get { return readerId; }
            set
            {
                readerId = value;
                OnPropertyChanged("ReaderId");
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

        public int ResidentialAddressId
        {
            get { return residentialAddressId; }
            set
            {
                residentialAddressId = value;
                OnPropertyChanged("ResidentialAddressId");
            }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                phoneNumber = value;
                OnPropertyChanged("PhoneNumber");
            }
        }

        public string DateOfRegistration
        {
            get { return dateOfRegistration; }
            set
            {
                dateOfRegistration = value;
                OnPropertyChanged("DateOfRegistration");
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
