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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CommonEventAggregator.GetCommonEventAggregator().GetEvent<GoToMatchEngineEvent>().Publish(string.Empty);
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            CommonEventAggregator.GetCommonEventAggregator().GetEvent<GoToCalendarEvent>().Publish(string.Empty);
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            CommonEventAggregator.GetCommonEventAggregator().GetEvent<GoToClubEvent>().Publish(null);
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            CommonEventAggregator.GetCommonEventAggregator().GetEvent<GoToTeamEvent>().Publish(null);
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            CommonEventAggregator.GetCommonEventAggregator().GetEvent<GoToTacticEvent>().Publish(null);
        }
    }
}
