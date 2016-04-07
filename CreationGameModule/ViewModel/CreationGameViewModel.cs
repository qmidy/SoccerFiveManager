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
            SelectedCampaign = null;
            ChampionshipList = null;
            ClubList = null;
            TeamList = null;
            PlayerList = null;
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

        private ICampaign selectedCampaign;

        public ICampaign SelectedCampaign
        {
            get
            {
                return selectedCampaign;
            }
            set
            {
                selectedCampaign = value;
                GetDatabase();
                OnPropertyChanged("SelectedCampaign");
            }
        }

        private ObservableCollection<IClub> clubList;

        public ObservableCollection<IClub> ClubList
        {
            get
            {
                return clubList;
            }
            set
            {
                clubList = value;
                OnPropertyChanged("ClubList");
            }
        }

        private ObservableCollection<IClub> championshipList;

        public ObservableCollection<IClub> ChampionshipList
        {
            get
            {
                return championshipList;
            }
            set
            {
                championshipList = value;
                OnPropertyChanged("ChampionshipList");
            }
        }

        private ObservableCollection<IClub> teamList;

        public ObservableCollection<IClub> TeamList
        {
            get
            {
                return teamList;
            }
            set
            {
                teamList = value;
                OnPropertyChanged("TeamList");
            }
        }

        private ObservableCollection<IClub> playerList;

        public ObservableCollection<IClub> PlayerList
        {
            get
            {
                return playerList;
            }
            set
            {
                playerList = value;
                OnPropertyChanged("PlayerList");
            }
        }

        #endregion

        #region Public Methods

        public void CreateCampaign()
        {
            // Initiliaser un objet Campaign
            ICampaign campaign = new Campaign() { Name = "Nouvelle Campagne", Description = "Description Nouvelle Campagne" };
            
            // On vérifie qu'une campagne appelée "Nouvelle Campagne" n'existe pas déjà / Maitrise du multi-clic

            // Générer un fichier XML Campaign.txt
            // XmlService<Campaign>.WriteXml(campaign);
            
            // Générer un fichier DB Campaign.db
            // DaoService.CreateCampaignDatabase();
            
            // On rappelle la méthode GetCampaignList afin de remettre à jour la liste des campagnes 
            //  On verra la campagne nouvellement créée apparaître
            CampaignList = GetCampaignList();
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
                        {
                            while (result.Select(x => x.Name).Contains(campaign.Name))
                                string.Concat(campaign.Name, "1"); 
                            result.Add(campaign);
                        }
                    }
                }
            }
            else
            {
                // RAF
            }
            return result;
        }

        private void GetDatabase()
        {
            if (SelectedCampaign != null)
            {
                string selectedCampaignDirectory = string.Concat("Campaign\\", SelectedCampaign.Name);
                if (Directory.Exists(selectedCampaignDirectory))
                {
                    string campaignDataBasePath = string.Concat(selectedCampaignDirectory, "\\Campaign.db");
                    if (File.Exists(campaignDataBasePath))
                    {
                        /*DaoService.Initialize(campaignDataBasePath);
                        ChampionshipList = DaoServicesChampionship.GetAllChampionship();
                        ClubList = DaoServicesClub.GetAllClub();
                        TeamList = DaoServicesTeam.GetAllTeam();
                        PlayerList = DaoServicesPlayer.GetAllPlayer();*/
                    }
                }
                else
                {
                    // RAF
                }
            }
        }

        #endregion
    }
}
