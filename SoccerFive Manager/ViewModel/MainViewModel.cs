using CommonLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Main
{
    public class MainViewModel : CommonViewModel
    {
        private UserControl mainContent;
        public UserControl MainContent
        {
            get
            {
                return mainContent;
            }
            set
            {
                mainContent = value;
                OnPropertyChanged("MainContent");
            }
        }
        public MainViewModel()
        {
            // Factory à implémenter pour la création des views et des viewmodels
            MainContent = new MainMenuModule.MainMenuView();
        }
    }
}
