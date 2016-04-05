using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CreationGameModule
{
    public class CreationGameViewModel : CommonViewModel, ICreationGameModuleViewModel
    {
        public CreationGameViewModel()
        {
            CampaignList = GetCampaignList();
        }

        #region Fields

        private ObservableCollection<ICampaign> campaignList;

        public ObservableCollection<ICampaign> CampaignList
        {
            get
            {
                return campaignList;
            }
            set
            {
                campaignList = value;
                OnPropertyChanged("CampaignList");
            }
        }

        #endregion

        #region Private Methods

        private ObservableCollection<ICampaign> GetCampaignList()
        {
            ObservableCollection<ICampaign> result = new ObservableCollection<ICampaign>();

            string campaignDirectory = "Campaign";
            if(Directory.Exists(campaignDirectory))
            { 
                List<string> dirs = new List<string>(Directory.EnumerateDirectories(campaignDirectory));
                foreach(var dir in dirs)
                {
                    IEnumerable<string> files = Directory.EnumerateFiles(dir);
                    string campaignFilePath = string.Concat(dir, "\\Campaign.txt");
                    if (files.Contains(campaignFilePath))
                    {
                        ICampaign campaign = XmlService<Campaign>.ReadXml(campaignFilePath);
                        if(campaign != null)
                            result.Add(campaign);
                    }
                }
            }
            else
            {
                // RAF
            }
            return result;
        }

        #endregion
    }
}
