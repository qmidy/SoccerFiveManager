using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TopBannerModule
{
    /// <summary>
    /// Interaction logic for TopBannerMenuPopup.xaml
    /// </summary>
    public partial class TopBannerMenuPopup : Popup
    {
        public TopBannerMenuPopup()
        {
            InitializeComponent();
        }
        private void MatchEngineClick(object sender, RoutedEventArgs e)
        {
            CommonEventAggregator.GetCommonEventAggregator().GetEvent<GoToMatchEngineEvent>().Publish(string.Empty);
        }

        private void CalendarClick(object sender, RoutedEventArgs e)
        {
            CommonEventAggregator.GetCommonEventAggregator().GetEvent<GoToCalendarEvent>().Publish(string.Empty);
        }

        private void ClubClick(object sender, RoutedEventArgs e)
        {
            CommonEventAggregator.GetCommonEventAggregator().GetEvent<GoToClubEvent>().Publish(null);
        }

        private void TeamClick(object sender, RoutedEventArgs e)
        {
            CommonEventAggregator.GetCommonEventAggregator().GetEvent<GoToTeamEvent>().Publish(null);
        }

        private void TacticClick(object sender, RoutedEventArgs e)
        {
            CommonEventAggregator.GetCommonEventAggregator().GetEvent<GoToTacticEvent>().Publish(null);
        }

        private void MainMenuClick(object sender, RoutedEventArgs e)
        {
            CommonEventAggregator.GetCommonEventAggregator().GetEvent<GoToMainMenuEvent>().Publish(string.Empty);
        }
    }
}
