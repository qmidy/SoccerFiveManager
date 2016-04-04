using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CreationGameModule
{
    public class CreationGameModuleFactory : IModuleFactory<ICreationGameModuleViewModel> 
    {
        public UserControl CreateView(object obj)
        {
            var creationGameView = new CreationGameView();
            creationGameView.DataContext = new CreationGameViewModel();
            return creationGameView;
        }
    }
}
