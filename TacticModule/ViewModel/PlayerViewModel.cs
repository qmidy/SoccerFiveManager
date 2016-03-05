using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace TacticModule
{
    public class PlayerViewModel : CommonViewModel, IPlayer
    {
        private Point position;
        public Point Position 
        { 
            get
            {
                return position;
            }
            set
            {
                position = value;
                OnPropertyChanged("Position");
            }
        }

        private EnumArea area;
        public EnumArea Area 
        { 
            get
            {
                return area;
            }
            set
            {
                area = value;
                OnPropertyChanged("Area");
            }     
        }

        private int number;
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
                OnPropertyChanged("Number");
            }
        }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        private int attack;
        public int Attack
        {
            get
            {
                return attack;
            }
            set
            {
                attack = value;
                OnPropertyChanged("Attack");
            }
        }

        private int defense;
        public int Defense 
        {
            get
            {
                return defense;
            }
            set
            {
                defense = value;
                OnPropertyChanged("Defense");
            }
        }

        private bool isPlayerChecked;
        public bool IsPlayerChecked
        {
            get
            {
                return isPlayerChecked;
            }
            set
            {
                isPlayerChecked = value;
                PlayerSelectedEvent(this, null);
                OnPropertyChanged("IsPlayerChecked");
            }
        }

        private int teamId;
        public int TeamId
        {
            get
            {
                return teamId;
            }

            set
            {
                teamId = value;
                OnPropertyChanged("IsPlayerChecked");
            }
        }

        private int id;
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
                OnPropertyChanged("IsPlayerChecked");
            }
        }

        public void SetOnlyIsPlayerChecked(bool value)
        {
            isPlayerChecked = value;
            OnPropertyChanged("IsPlayerChecked");
        }

        public EventHandler PlayerSelectedEvent;
    }
}
