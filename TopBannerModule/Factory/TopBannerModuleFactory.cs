using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TopBannerModule
{
    public class TopBannerModuleFactory : IModuleFactory<ITopBannerModuleViewModel> 
    {
        public UserControl CreateView(object obj)
        {
            var topBannerView = new TopBannerView();
            topBannerView.DataContext = new TopBannerViewModel();
            return topBannerView;
        }

        public UserControl CreateViewFromViewModel(ITopBannerModuleViewModel viewModel)
        {
            var topBannerView = new TopBannerView();
            topBannerView.DataContext = viewModel;
            return topBannerView;
        }

        public ITopBannerModuleViewModel CreateViewModel()
        {
            return new TopBannerViewModel();
        }
    }
}
