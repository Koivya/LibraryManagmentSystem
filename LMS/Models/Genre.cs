using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Model
{
    public class Genre : INotifyPropertyChanged
    {
        private int genreId;
        private string genreName;

        public int GenreId
        {
            get { return genreId; }
            set
            {
                genreId = value;
                OnPropertyChanged("GenreId");
            }
        }

        public string GenreName
        {
            get { return genreName; }
            set
            {
                genreName = value;
                OnPropertyChanged("GenreName");
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
