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

namespace MatchEngineModule
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MatchEngineView : UserControl
    {
        public MatchEngineView()
        {
            InitializeComponent();
        }

        private void NextTurn(object sender, RoutedEventArgs e)
        {
            var viewmodel = (sender as Button).DataContext as MatchEngineViewModel;
            viewmodel.NextTurn();
        }
    }
}
