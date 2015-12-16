using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
                if (sender != player)
                {
                    player.SetOnlyIsPlayerChecked(false);
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

        private void TakePlayerOffHisList(PlayerViewModel player)
        {
            switch(player.Area)
            {
                case EnumArea.AttackLeft:
                    LeftAttackPlayers.Remove(player);
                    break;
                case EnumArea.AttackCenter:
                    CenterAttackPlayers.Remove(player);
                    break;
                case EnumArea.AttackRight:
                    RightAttackPlayers.Remove(player);
                    break;
                case EnumArea.MiddleLeft:
                    LeftMiddlePlayers.Remove(player);
                    break;
                case EnumArea.MiddleCenter:
                    CenterMiddlePlayers.Remove(player);
                    break;
                case EnumArea.MiddleRight:
                    RightMiddlePlayers.Remove(player);
                    break;
                case EnumArea.DefenseLeft:
                    LeftDefensePlayers.Remove(player);
                    break;
                case EnumArea.DefenseCenter:
                    CenterDefensePlayers.Remove(player);
                    break;
                case EnumArea.DefenseRight:
                    RightDefensePlayers.Remove(player);
                    break;
                case EnumArea.GoalKeeper:
                    GoalKeeperPlayer = null;
                    break;
            }
        }

        private void AddPlayerToHisList(PlayerViewModel player)
        {
            switch (player.Area)
            {
                case EnumArea.AttackLeft:
                    LeftAttackPlayers.Add(player);
                    break;
                case EnumArea.AttackCenter:
                    CenterAttackPlayers.Add(player);
                    break;
                case EnumArea.AttackRight:
                    RightAttackPlayers.Add(player);
                    break;
                case EnumArea.MiddleLeft:
                    LeftMiddlePlayers.Add(player);
                    break;
                case EnumArea.MiddleCenter:
                    CenterMiddlePlayers.Add(player);
                    break;
                case EnumArea.MiddleRight:
                    RightMiddlePlayers.Add(player);
                    break;
                case EnumArea.DefenseLeft:
                    LeftDefensePlayers.Add(player);
                    break;
                case EnumArea.DefenseCenter:
                    CenterDefensePlayers.Add(player);
                    break;
                case EnumArea.DefenseRight:
                    RightDefensePlayers.Add(player);
                    break;
                case EnumArea.GoalKeeper:
                    if (GoalKeeperPlayer != null)
                        GoalKeeperPlayer.Area = EnumArea.None;
                    GoalKeeperPlayer = player;
                    break;
            }
        }

        public void AreaSelected(EnumArea area)
        {
            if (SelectedPlayer != null)
            {
                // Enlever le joueur de sa liste précédente
                TakePlayerOffHisList(SelectedPlayer);

                // Mettre le joueur dans sa nouvelle liste
                SelectedPlayer.Area = area;
                AddPlayerToHisList(SelectedPlayer);
            }
        }

        private PlayerViewModel goalKeeperPlayer;
        public PlayerViewModel GoalKeeperPlayer
        {
            get
            {
                return goalKeeperPlayer;
            }
            set
            {
                goalKeeperPlayer = value;
                OnPropertyChanged("GoalKeeperPlayer");
            }
        }

        private ObservableCollection<PlayerViewModel> leftAttackPlayers;
        public ObservableCollection<PlayerViewModel> LeftAttackPlayers
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

        private ObservableCollection<PlayerViewModel> centerAttackPlayers;
        public ObservableCollection<PlayerViewModel> CenterAttackPlayers
        {
            get
            {
                return centerAttackPlayers;
            }
            set
            {
                centerAttackPlayers = value;
                OnPropertyChanged("CenterAttackPlayers");
            }
        }

        private ObservableCollection<PlayerViewModel> rightAttackPlayers;
        public ObservableCollection<PlayerViewModel> RightAttackPlayers
        {
            get
            {
                return rightAttackPlayers;
            }
            set
            {
                rightAttackPlayers = value;
                OnPropertyChanged("RightAttackPlayers");
            }
        }

        private ObservableCollection<PlayerViewModel> leftMiddlePlayers;
        public ObservableCollection<PlayerViewModel> LeftMiddlePlayers
        {
            get
            {
                return leftMiddlePlayers;
            }
            set
            {
                leftMiddlePlayers = value;
                OnPropertyChanged("LeftMiddlePlayers");
            }
        }

        private ObservableCollection<PlayerViewModel> centerMiddlePlayers;
        public ObservableCollection<PlayerViewModel> CenterMiddlePlayers
        {
            get
            {
                return centerMiddlePlayers;
            }
            set
            {
                centerMiddlePlayers = value;
                OnPropertyChanged("CenterMiddlePlayers");
            }
        }

        private ObservableCollection<PlayerViewModel> rightMiddlePlayers;
        public ObservableCollection<PlayerViewModel> RightMiddlePlayers
        {
            get
            {
                return rightMiddlePlayers;
            }
            set
            {
                rightMiddlePlayers = value;
                OnPropertyChanged("RightMiddlePlayers");
            }
        }

        private ObservableCollection<PlayerViewModel> leftDefensePlayers;
        public ObservableCollection<PlayerViewModel> LeftDefensePlayers
        {
            get
            {
                return leftDefensePlayers;
            }
            set
            {
                leftDefensePlayers = value;
                OnPropertyChanged("LeftDefensePlayers");
            }
        }

        private ObservableCollection<PlayerViewModel> centerDefensePlayers;
        public ObservableCollection<PlayerViewModel> CenterDefensePlayers
        {
            get
            {
                return centerDefensePlayers;
            }
            set
            {
                centerDefensePlayers = value;
                OnPropertyChanged("CenterDefensePlayers");
            }
        }

        private ObservableCollection<PlayerViewModel> rightDefensePlayers;
        public ObservableCollection<PlayerViewModel> RightDefensePlayers
        {
            get
            {
                return rightDefensePlayers;
            }
            set
            {
                rightDefensePlayers = value;
                OnPropertyChanged("RightDefensePlayers");
            }
        }

        #endregion

        public TacticViewModel(ITeam team)
        {
            // Initialisation des listes
            Players = new List<PlayerViewModel>();
            LeftAttackPlayers = new ObservableCollection<PlayerViewModel>();
            CenterAttackPlayers = new ObservableCollection<PlayerViewModel>();
            RightAttackPlayers = new ObservableCollection<PlayerViewModel>();
            LeftMiddlePlayers = new ObservableCollection<PlayerViewModel>();
            CenterMiddlePlayers = new ObservableCollection<PlayerViewModel>();
            RightMiddlePlayers = new ObservableCollection<PlayerViewModel>();
            LeftDefensePlayers = new ObservableCollection<PlayerViewModel>();
            CenterDefensePlayers = new ObservableCollection<PlayerViewModel>();
            RightDefensePlayers = new ObservableCollection<PlayerViewModel>();

            foreach (var teamPlayer in team.Players)
            {
                PlayerViewModel playerViewModel = new PlayerViewModel();
                playerViewModel.Area = teamPlayer.Area;
                playerViewModel.Attack = teamPlayer.Attack;
                playerViewModel.Defense = teamPlayer.Defense;
                playerViewModel.Name = teamPlayer.Name;
                playerViewModel.Number = teamPlayer.Number;
                playerViewModel.Position = teamPlayer.Position;
                playerViewModel.PlayerSelectedEvent += playerSelectedEvent;
                Players.Add(playerViewModel);
            }
        }
    }
}
