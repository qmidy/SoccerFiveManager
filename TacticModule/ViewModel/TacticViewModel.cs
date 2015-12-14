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
        private List<PlayerViewModel> players;
        public List<PlayerViewModel> Players
        {
            get
            {
                return players;
            }
            set
            {
                players = value;
                OnPropertyChanged("Players");
            }
        }

        #region Player Selected
        // A la sélection d'un joueur, un événement se déclenche afin de déselectionner tous les autres joueurs sélectionnés
        private void playerSelectedEvent(object sender, EventArgs e)
        {
            foreach(var player in Players)
            {
                if (player.IsPlayerChecked && sender != player)
                {
                    player.IsPlayerChecked = false;
                }
            }
            if ((sender as PlayerViewModel).IsPlayerChecked)
            {
                SelectedPlayer = sender as PlayerViewModel;
            }
            else
            {
                SelectedPlayer = null;
            }
        }

        private PlayerViewModel selectedPlayer;
        public PlayerViewModel SelectedPlayer
        {
            get
            {
                return selectedPlayer;
            }
            set
            {
                selectedPlayer = value;
                OnPropertyChanged("SelectedPlayer");
            }
        }
        #endregion

        #region Players List by Area

        public void LeftAttackAreaSelected()
        {
            if (SelectedPlayer != null)
            {
                // Enlever le joueur de sa liste précédente

                // A FAIRE

                // Mettre le joueur dans sa nouvelle liste
                SelectedPlayer.Area = EnumArea.AttackLeft;
                LeftAttackPlayers.Add(SelectedPlayer);
                LeftAttackPlayers = new List<PlayerViewModel>(LeftAttackPlayers);

            }
        }

        private List<PlayerViewModel> leftAttackPlayers;
        public List<PlayerViewModel> LeftAttackPlayers
        {
            get
            {
                return leftAttackPlayers;
            }
            set
            {
                leftAttackPlayers = value;
                OnPropertyChanged("LeftAttackPlayers");
            }
        }

        #endregion

        public TacticViewModel(ITeam team)
        {
            // Initialisation des listes
            Players = new List<PlayerViewModel>();
            LeftAttackPlayers = new List<PlayerViewModel>();
            foreach (var teamPlayer in team.Players)
            {
                PlayerViewModel playerViewModel = new PlayerViewModel();
                playerViewModel.Area = teamPlayer.Area;
                playerViewModel.Attack = teamPlayer.Attack;
                playerViewModel.Defense = teamPlayer.Defense;
                playerViewModel.Name = teamPlayer.Name;
                playerViewModel.Position = teamPlayer.Position;
                playerViewModel.PlayerSelectedEvent += playerSelectedEvent;
                Players.Add(playerViewModel);
            }
        }
    }
}
