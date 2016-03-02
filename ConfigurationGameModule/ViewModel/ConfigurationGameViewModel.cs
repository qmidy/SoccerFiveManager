using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ConfigurationGameModule
{
    public class ConfigurationGameViewModel : CommonViewModel, IConfigurationGameModuleViewModel
    {
        public ConfigurationGameViewModel()
        {
        }

        private string clubName;
        public string ClubName
        {
            get
            {
                return clubName;
            }
            set
            {
                clubName = value;
                OnPropertyChanged("ClubName");
            }
        }

        public void CreateGame()
        {
            if (!String.IsNullOrEmpty(ClubName))
            {
                DaoService.CreateGameDatabase(ClubName);
                CommonEventAggregator.GetCommonEventAggregator().GetEvent<GoToTacticEvent>().Publish(null);
            }
        }
    }
}
