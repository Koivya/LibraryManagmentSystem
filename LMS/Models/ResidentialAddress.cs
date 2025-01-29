using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Model
{
    public class ResidentialAddress : INotifyPropertyChanged
    {
        private int rAId;
        private string area;
        private string locality;
        private string street;
        private string houseNumber;
        private string apartment;

        public int RAId
        {
            get { return rAId; }
            set
            {
                rAId = value;
                OnPropertyChanged("RAId");
            }
        }

        public string Area
        {
            get { return area; }
            set
            {
                area = value;
                OnPropertyChanged("Area");
            }
        }

        public string Locality
        {
            get { return locality; }
            set
            {
                locality = value;
                OnPropertyChanged("Locality");
            }
        }

        public string Street
        {
            get { return street; }
            set
            {
                street = value;
                OnPropertyChanged("Street");
            }
        }

        public string HouseNumber
        {
            get { return houseNumber; }
            set
            {
                houseNumber = value;
                OnPropertyChanged("HouseNumber");
            }
        }

        public string Apartment
        {
            get { return apartment; }
            set
            {
                apartment = value;
                OnPropertyChanged("Apartment");
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
