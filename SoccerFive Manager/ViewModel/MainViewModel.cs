using CalendarModule;
using ClubModule;
using CommonLibrary;
using ConfigurationGameModule;
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

        public EventHandler HideTopBanner;

        private void hideTopBannerEvent(object sender, EventArgs e)
        {
            if (IsTopBannerVisible == Visibility.Visible)
            {
                IsTopBannerVisible = Visibility.Hidden;
                TopBannerHeight = 0;
            }
            else
            {
                IsTopBannerVisible = Visibility.Visible;
                TopBannerHeight = 50;
            }
        }

        public EventHandler HideBottomBanner;

        private void hideBottomBannerEvent(object sender, EventArgs e)
        {
            if (IsBottomBannerVisible == Visibility.Visible)
            {
                IsBottomBannerVisible = Visibility.Hidden;
                BottomBannerHeight = 0;
            }
            else
            {
                IsBottomBannerVisible = Visibility.Visible;
                BottomBannerHeight = 50;
            }
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

            // Initialisation des événements de changement de visibilité des bannières supérieures et inférieures
            HideTopBanner += hideTopBannerEvent;
            HideBottomBanner += hideBottomBannerEvent;
            IsBottomBannerVisible = Visibility.Hidden;
            IsTopBannerVisible = Visibility.Hidden;
            hideBottomBannerEvent(this, null);
            hideTopBannerEvent(this, null);

            // Initialisation des événements de changement de vue
            CommonEventAggregator.GetCommonEventAggregator().GetEvent<GoToMainMenuEvent>().Subscribe(GoToMainMenuCallBack);
            CommonEventAggregator.GetCommonEventAggregator().GetEvent<GoToMatchEngineEvent>().Subscribe(GoToMacthEngineCallBack);
            CommonEventAggregator.GetCommonEventAggregator().GetEvent<GoToCalendarEvent>().Subscribe(GoToCalendarEventCallBack);
            CommonEventAggregator.GetCommonEventAggregator().GetEvent<GoToConfigurationGameEvent>().Subscribe(GoToConfigurationGameCallBack);
            CommonEventAggregator.GetCommonEventAggregator().GetEvent<GoToClubEvent>().Subscribe(GoToClubEventCallBack);
            CommonEventAggregator.GetCommonEventAggregator().GetEvent<GoToTeamEvent>().Subscribe(GoToTeamEventCallBack);
            CommonEventAggregator.GetCommonEventAggregator().GetEvent<GoToTacticEvent>().Subscribe(GoToTacticEventCallBack);

            // Implémentation des views et des viewmodels
            MainMenuModuleFactory mainMenuModuleFactory = new MainMenuModuleFactory();
            MainContent = mainMenuModuleFactory.CreateView();
            TopBannerModuleFactory topBannerModuleFactory = new TopBannerModuleFactory();
            TopBannerContent = topBannerModuleFactory.CreateView();
        }

        #region Go To View Private Methods
        private void GoToMainMenuCallBack(string arg)
        {
            MainMenuModuleFactory mainMenuModuleFactory = new MainMenuModuleFactory();
            MainContent = mainMenuModuleFactory.CreateView();
        }
        private void GoToMacthEngineCallBack(string arg)
        {
            MatchEngineModuleFactory matchEngineModuleFactory = new MatchEngineModuleFactory();
            MainContent = matchEngineModuleFactory.CreateView();
        }

        private void GoToCalendarEventCallBack(string arg)
        {
            CalendarModuleFactory calendarModuleFactory = new CalendarModuleFactory();
            MainContent = calendarModuleFactory.CreateView();
        }

        private void GoToConfigurationGameCallBack(string arg)
        {
            ConfigurationGameModuleFactory configurationGameModuleFactory = new ConfigurationGameModuleFactory();
            MainContent = configurationGameModuleFactory.CreateView();
        }

        private void GoToClubEventCallBack(IClub arg)
        {
            ClubModuleFactory clubModuleFactory = new ClubModuleFactory();
            //MainContent = clubModuleFactory.CreateView(arg);3
            MainContent = clubModuleFactory.CreateView(new Club() { Name = "Nom du club" });
        }

        private void GoToTeamEventCallBack(ITeam arg)
        {
            TeamModuleFactory teamModuleFactory = new TeamModuleFactory();
            //MainContent = teamModuleFactory.CreateView(arg);
            List<IPlayer> players = new List<IPlayer>();
            players.Add(new Player() { Attack = 10, Defense = 10, Name = "Nom1" });
            players.Add(new Player() { Attack = 10, Defense = 10, Name = "Nom2" });
            players.Add(new Player() { Attack = 10, Defense = 10, Name = "Nom3" });
            players.Add(new Player() { Attack = 10, Defense = 10, Name = "Nom4" });
            players.Add(new Player() { Attack = 10, Defense = 10, Name = "Nom5" });
            ITeam team = new Team() { Players = players };
            MainContent = teamModuleFactory.CreateView(team);
        }

        private void GoToTacticEventCallBack(ITeam arg)
        {
            TacticModuleFactory tacticModuleFactory = new TacticModuleFactory();
            //MainContent = teamModuleFactory.CreateView(arg);
            List<IPlayer> players = new List<IPlayer>();
            players.Add(new Player() { Attack = 10, Defense = 10, Name = "Nom1", Number = 1 });
            players.Add(new Player() { Attack = 10, Defense = 10, Name = "Nom2", Number = 2 });
            players.Add(new Player() { Attack = 10, Defense = 10, Name = "Nom3", Number = 3 });
            players.Add(new Player() { Attack = 10, Defense = 10, Name = "Nom4", Number = 4 });
            players.Add(new Player() { Attack = 10, Defense = 10, Name = "Nom5", Number = 5 });
            ITeam team = new Team() { Players = players };
            MainContent = tacticModuleFactory.CreateView(team);
        }
        #endregion
    }
}
