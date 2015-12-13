using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TeamModule
{
    public class TeamViewModel : CommonViewModel, ITeamModuleViewModel
    {
        private ITeam team;
        public ITeam Team
        {
            get
            {
                return team;
            }
            set
            {
                team = value;
                OnPropertyChanged("Team");
            }
        }

        public TeamViewModel(ITeam team)
        {
            Team = team;
        }

    }
}
