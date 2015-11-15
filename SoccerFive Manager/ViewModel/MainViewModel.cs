using CommonLibrary;
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
            // Factory à implémenter pour la création des views et des viewmodels
            MainMenuModuleFactory mainMenuModuleFactory = new MainMenuModuleFactory();
            MainContent = mainMenuModuleFactory.CreateView();
            HideTopBanner += hideTopBannerEvent;
            HideBottomBanner += hideBottomBannerEvent;

            IsBottomBannerVisible = Visibility.Hidden;
            IsTopBannerVisible = Visibility.Visible;
            hideBottomBannerEvent(this, null);
            hideTopBannerEvent(this, null);

            CommonEventAggregator.GetCommonEventAggregator().GetEvent<GoToMatchEngineEvent>().Subscribe(GoToMacthEngineCallBack);
        }

        private void GoToMacthEngineCallBack(string arg)
        {
            MatchEngineModuleFactory matchEngineModuleFactory = new MatchEngineModuleFactory();
            MainContent = matchEngineModuleFactory.CreateView();
        }
    }
}
