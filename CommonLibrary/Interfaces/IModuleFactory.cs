using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CommonLibrary
{
    // Ressort l'interface du viewmodel ou du service
    public interface IModuleFactory<T> 
    {
        UserControl CreateView();

        UserControl CreateViewFromViewModel(T viewModel);

        T CreateViewModel();

    }
}
