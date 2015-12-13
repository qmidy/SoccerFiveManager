using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TeamModule
{
    public class TeamModuleFactory : IModuleFactory<ITeamModuleViewModel> 
    {
        public UserControl CreateView()
        {
            throw new NotImplementedException();
        }

        public ITeamModuleViewModel CreateViewModel()
        {
            throw new NotImplementedException();
        }

        public UserControl CreateView(ITeam team)
        {
            var teamView = new TeamView();
            teamView.DataContext = new TeamViewModel(team);
            return teamView;
        }

        public UserControl CreateViewFromViewModel(ITeamModuleViewModel viewModel)
        {
            var teamView = new TeamView();
            teamView.DataContext = viewModel;
            return teamView;
        }

        public ITeamModuleViewModel CreateViewModel(ITeam team)
        {
            return new TeamViewModel(team);
        }
    }
}
