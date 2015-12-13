using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClubModule
{
    public class ClubViewModel : CommonViewModel, IClubModuleViewModel
    {
        private IClub club;
        public IClub Club
        {
            get
            {
                return club;
            }
            set
            {
                club = value;
                OnPropertyChanged("Club");
            }
        }

        public ClubViewModel(IClub club)
        {
            Club = club;
        }

    }
}
