using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MainMenuModule
{
    public class MainMenuModuleFactory : IModuleFactory<IMainMenuModuleViewModel> 
    {
        public UserControl CreateView()
        {
            var mainMenuView = new MainMenuView();
            mainMenuView.DataContext = new MainMenuViewModel();
            return mainMenuView;
        }

        public UserControl CreateViewFromViewModel(IMainMenuModuleViewModel viewModel)
        {
            var mainMenuView = new MainMenuView();
            mainMenuView.DataContext = viewModel;
            return mainMenuView;
        }

        public IMainMenuModuleViewModel CreateViewModel()
        {
            return new MainMenuViewModel();
        }
    }
}
