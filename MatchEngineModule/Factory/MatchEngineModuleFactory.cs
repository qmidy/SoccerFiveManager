using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MatchEngineModule
{
    public class MatchEngineModuleFactory : IModuleFactory<IMatchEngineModuleViewModel> 
    {
        public UserControl CreateView(object obj)
        {
            var mainMenuView = new MatchEngineView();
            mainMenuView.DataContext = new MatchEngineViewModel();
            return mainMenuView;
        }
    }
}
