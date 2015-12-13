using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TacticModule
{
    public class TacticViewModel : CommonViewModel, ITacticModuleViewModel
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

        public TacticViewModel(ITeam team)
        {
            Team = team;
        }

    }
}
