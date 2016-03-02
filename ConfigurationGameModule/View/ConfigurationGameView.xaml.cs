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

namespace ConfigurationGameModule
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class ConfigurationGameView : UserControl
    {
        public ConfigurationGameView()
        {
            InitializeComponent();
        }

        private void CreateGameClick(object sender, RoutedEventArgs e)
        {
            ((sender as Button).DataContext as ConfigurationGameViewModel).CreateGame();
        }
    }
}
