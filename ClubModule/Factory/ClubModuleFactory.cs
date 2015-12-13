using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ClubModule
{
    public class ClubModuleFactory : IModuleFactory<IClubModuleViewModel> 
    {
        public UserControl CreateView()
        {
            throw new NotImplementedException();
        }

        public IClubModuleViewModel CreateViewModel()
        {
            throw new NotImplementedException();
        }

        public UserControl CreateView(IClub club)
        {
            var clubView = new ClubView();
            clubView.DataContext = new ClubViewModel(club);
            return clubView;
        }

        public UserControl CreateViewFromViewModel(IClubModuleViewModel viewModel)
        {
            var clubView = new ClubView();
            clubView.DataContext = viewModel;
            return clubView;
        }

        public IClubModuleViewModel CreateViewModel(IClub club)
        {
            return new ClubViewModel(club);
        }
    }
}
