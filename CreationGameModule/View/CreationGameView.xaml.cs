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

namespace CreationGameModule
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class CreationGameView : UserControl
    {
        public CreationGameView()
        {
            InitializeComponent();
        }

        private void CampaignClick(object sender, RoutedEventArgs e)
        {
            ICampaign campaign = (sender as Button).DataContext as ICampaign;
            (this.DataContext as CreationGameViewModel).SelectedCampaign = campaign;
        }
    }
}
