using CalendarModule;
using ClubModule;
using CommonLibrary;
using ConfigurationGameModule;
using CreationGameModule;
using MainMenuModule;
using MatchEngineModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using TacticModule;
using TeamModule;
using TopBannerModule;

namespace Main
{
    public class MainViewModel : CommonViewModel
    {
        private int topBannerHeight;
        public int TopBannerHeight
        {
            get
            {
                return topBannerHeight;
            }
            set
            {
                topBannerHeight = value;
                OnPropertyChanged("TopBannerHeight");
            }
        }

        private int bottomBannerHeight;
        public int BottomBannerHeight
        {
            get
            {
                return bottomBannerHeight;
            }
            set
            {
                bottomBannerHeight = value;
                OnPropertyChanged("TopBannerHeight");
            }
        }

        private Visibility isTopBannerVisible;
        public Visibility IsTopBannerVisible
        {
            get
            {
                return isTopBannerVisible;
            }
            set
            {
                isTopBannerVisible = value;
                OnPropertyChanged("IsTopBannerVisible");
            }
        }

        private Visibility isBottomBannerVisible;
        public Visibility IsBottomBannerVisible
        {
            get
            {
                return isBottomBannerVisible;
            }
            set
            {
                isBottomBannerVisible = value;
                OnPropertyChanged("IsBottomBannerVisible");
            }
        }

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

        private UserControl topBannerContent;
        public UserControl TopBannerContent
        {
            get
            {
                return topBannerContent;
            }
            set
            {
                topBannerContent = value;
                OnPropertyChanged("TopBannerContent");
            }
        }

        private void hideTopBanner()
        {
            IsTopBannerVisible = Visibility.Hidden;
            TopBannerHeight = 0;
        }

        private void visibleTopBanner()
        {
            IsTopBannerVisible = Visibility.Visible;
            TopBannerHeight = 50;
        }

        private void hideBottomBannerEvent()
        {
            IsBottomBannerVisible = Visibility.Hidden;
            BottomBannerHeight = 0;
        }

        private void visibleBottomBanner()
        {
            IsBottomBannerVisible = Visibility.Visible;
            BottomBannerHeight = 50;
        }

        public MainViewModel()
        {
            // Initialisation du Calendrier 
            CalendarService.InitializeCalendarService();

            /*A Supprimer, le calendrier sera créé ailleurs*/
            CalendarService.AddEvent(new CommonCalendarEvent() { EventName = "TestEvent" }, 0);
            CalendarService.AddEvent(new CommonCalendarEvent() { EventName = "TestEvent2" }, 0);
            CalendarService.AddEvent(new CommonCalendarEvent() { EventName = "TestEvent3" }, 1);
            CalendarService.AddEvent(new CommonCalendarEvent() { EventName = "TestEvent" }, 2);
            CalendarService.AddEvent(new CommonCalendarEvent() { EventName = "TestEvent5" }, 5);
            CalendarService.AddEvent(new CommonCalendarEvent() { EventName = "TestEvent2" }, 3);
            CalendarService.AddEvent(new CommonCalendarEvent() { EventName = "TestEvent3" }, 4);
            CalendarService.AddEvent(new CommonCalendarEvent() { EventName = "TestEvent" }, 5);
            CalendarService.AddEvent(new CommonCalendarEvent() { EventName = "TestEvent2" }, 6);
            CalendarService.AddEvent(new CommonCalendarEvent() { EventName = "TestEvent3" }, 7);

            // Initialisation des événements de changement de vue
            CommonEventAggregator.GetCommonEventAggregator().GetEvent<GoToMainMenuEvent>().Subscribe(GoToMainMenuCallBack);
            CommonEventAggregator.GetCommonEventAggregator().GetEvent<GoToMatchEngineEvent>().Subscribe(GoToMacthEngineCallBack);
            CommonEventAggregator.GetCommonEventAggregator().GetEvent<GoToCalendarEvent>().Subscribe(GoToCalendarEventCallBack);
            CommonEventAggregator.GetCommonEventAggregator().GetEvent<GoToConfigurationGameEvent>().Subscribe(GoToConfigurationGameCallBack);
            CommonEventAggregator.GetCommonEventAggregator().GetEvent<GoToClubEvent>().Subscribe(GoToClubEventCallBack);
            CommonEventAggregator.GetCommonEventAggregator().GetEvent<GoToTeamEvent>().Subscribe(GoToTeamEventCallBack);
            CommonEventAggregator.GetCommonEventAggregator().GetEvent<GoToTacticEvent>().Subscribe(GoToTacticEventCallBack);
            CommonEventAggregator.GetCommonEventAggregator().GetEvent<GoToCreationGameEvent>().Subscribe(GoToCreationGameEventCallBack);

            // Implémentation des views et des viewmodels
            IModuleFactory<IMainMenuModuleViewModel> mainMenuModuleFactory = new MainMenuModuleFactory();
            MainContent = mainMenuModuleFactory.CreateView(null);
            IModuleFactory<ITopBannerModuleViewModel> topBannerModuleFactory = new TopBannerModuleFactory();
            TopBannerContent = topBannerModuleFactory.CreateView(null);

            // Masquage de la bannière supérieure au démarrage
            hideTopBanner();
            visibleBottomBanner();
        }

        #region Go To View Private Methods
        private void GoToMainMenuCallBack(string arg)
        {
            hideTopBanner();
            visibleBottomBanner();
            IModuleFactory<IMainMenuModuleViewModel> mainMenuModuleFactory = new MainMenuModuleFactory();
            MainContent = mainMenuModuleFactory.CreateView(null);
        }

        private void GoToMacthEngineCallBack(string arg)
        {
            visibleTopBanner();
            visibleBottomBanner();
            IModuleFactory<IMatchEngineModuleViewModel> matchEngineModuleFactory = new MatchEngineModuleFactory();
            MainContent = matchEngineModuleFactory.CreateView(null);
        }

        private void GoToCalendarEventCallBack(string arg)
        {
            visibleTopBanner();
            visibleBottomBanner();
            IModuleFactory<ICalendarModuleViewModel> calendarModuleFactory = new CalendarModuleFactory();
            MainContent = calendarModuleFactory.CreateView(null);
        }

        private void GoToConfigurationGameCallBack(string arg)
        {
            hideTopBanner();
            visibleBottomBanner();
            IModuleFactory<IConfigurationGameModuleViewModel> configurationGameModuleFactory = new ConfigurationGameModuleFactory();
            MainContent = configurationGameModuleFactory.CreateView(null);
        }

        private void GoToClubEventCallBack(IClub arg)
        {
            visibleTopBanner();
            visibleBottomBanner();
            IModuleFactory<IClubModuleViewModel> clubModuleFactory = new ClubModuleFactory();
            MainContent = clubModuleFactory.CreateView(arg);
        }

        private void GoToTeamEventCallBack(ITeam arg)
        {
            visibleTopBanner();
            visibleBottomBanner();
            IModuleFactory<ITeamModuleViewModel> teamModuleFactory = new TeamModuleFactory();
            MainContent = teamModuleFactory.CreateView(arg);
        }

        private void GoToTacticEventCallBack(ITeam arg)
        {
            visibleTopBanner();
            visibleBottomBanner();
            IModuleFactory<ITacticModuleViewModel> tacticModuleFactory = new TacticModuleFactory();
            MainContent = tacticModuleFactory.CreateView(arg);
        }

        private void GoToCreationGameEventCallBack(string arg)
        {
            visibleTopBanner();
            visibleBottomBanner();
            IModuleFactory<ICreationGameModuleViewModel> creationGameModuleFactory = new CreationGameModuleFactory();
            MainContent = creationGameModuleFactory.CreateView(null);
        }
        #endregion
    }
}
