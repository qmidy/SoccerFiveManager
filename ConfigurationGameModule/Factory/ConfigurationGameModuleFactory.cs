using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ConfigurationGameModule
{
    public class ConfigurationGameModuleFactory : IModuleFactory<IConfigurationGameModuleViewModel> 
    {
        public UserControl CreateView()
        {
            var configurationGameView = new ConfigurationGameView();
            configurationGameView.DataContext = new ConfigurationGameViewModel();
            return configurationGameView;
        }

        public UserControl CreateViewFromViewModel(IConfigurationGameModuleViewModel viewModel)
        {
            var configurationGameView = new ConfigurationGameView();
            configurationGameView.DataContext = viewModel;
            return configurationGameView;
        }

        public IConfigurationGameModuleViewModel CreateViewModel()
        {
            return new ConfigurationGameViewModel();
        }
    }
}
