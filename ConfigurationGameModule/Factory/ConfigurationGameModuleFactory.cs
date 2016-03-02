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
        public UserControl CreateView(object obj)
        {
            var configurationGameView = new ConfigurationGameView();
            configurationGameView.DataContext = new ConfigurationGameViewModel();
            return configurationGameView;
        }
    }
}
