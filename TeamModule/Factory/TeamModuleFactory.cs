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
        public UserControl CreateView(object obj)
        {
            var teamView = new TeamView();
            teamView.DataContext = new TeamViewModel((ITeam)obj);
            return teamView;
        }
    }
}
