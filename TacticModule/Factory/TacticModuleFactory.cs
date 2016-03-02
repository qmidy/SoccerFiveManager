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
        public UserControl CreateView(object obj)
        {
            var teamView = new TacticView();
            teamView.DataContext = new TacticViewModel((ITeam)obj);
            return teamView;
        }
    }
}
