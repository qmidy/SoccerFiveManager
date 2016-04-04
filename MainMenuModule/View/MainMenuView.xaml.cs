using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MainMenuModule
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainMenuView : UserControl
    {
        public MainMenuView()
        {
            InitializeComponent();
        }

        private void NewGameClick(object sender, RoutedEventArgs e)
        {
            CommonEventAggregator.GetCommonEventAggregator().GetEvent<GoToConfigurationGameEvent>().Publish(string.Empty);
        }

        private void CreateGameClick(object sender, RoutedEventArgs e)
        {
            CommonEventAggregator.GetCommonEventAggregator().GetEvent<GoToCreationGameEvent>().Publish(string.Empty);
        }
    }
}
