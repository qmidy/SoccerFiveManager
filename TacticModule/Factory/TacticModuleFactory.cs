using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TacticModule
{
    public class TacticModuleFactory : IModuleFactory<ITacticModuleViewModel> 
    {
        public UserControl CreateView()
        {
            throw new NotImplementedException();
        }

        public ITacticModuleViewModel CreateViewModel()
        {
            throw new NotImplementedException();
        }

        public UserControl CreateView(ITeam team)
        {
            var teamView = new TacticView();
            teamView.DataContext = new TacticViewModel(team);
            return teamView;
        }

        public UserControl CreateViewFromViewModel(ITacticModuleViewModel viewModel)
        {
            var teamView = new TacticView();
            teamView.DataContext = viewModel;
            return teamView;
        }

        public ITacticModuleViewModel CreateViewModel(ITeam team)
        {
            return new TacticViewModel(team);
        }
    }
}
