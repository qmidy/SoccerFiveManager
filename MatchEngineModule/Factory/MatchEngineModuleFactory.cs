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
        public UserControl CreateView()
        {
            var mainMenuView = new MatchEngineView();
            mainMenuView.DataContext = new MatchEngineViewModel();
            return mainMenuView;
        }

        public UserControl CreateViewFromViewModel(IMatchEngineModuleViewModel viewModel)
        {
            var mainMenuView = new MatchEngineView();
            mainMenuView.DataContext = viewModel;
            return mainMenuView;
        }

        public IMatchEngineModuleViewModel CreateViewModel()
        {
            return new MatchEngineViewModel();
        }
    }
}
