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
        public UserControl CreateView(object obj)
        {
            var clubView = new ClubView();
            clubView.DataContext = new ClubViewModel((IClub)obj);
            return clubView;
        }
    }
}
