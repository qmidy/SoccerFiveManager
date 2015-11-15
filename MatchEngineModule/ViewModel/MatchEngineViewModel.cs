using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MatchEngineModule
{
    public class MatchEngineViewModel : CommonViewModel, IMatchEngineModuleViewModel
    {
        public List<Player> PlayersTeam1 { get; set; }
        public List<Player> PlayersTeam2 { get; set; }

        private int score1;
        public int Score1 
        {
            get
            {
                return score1;
            }
            set
            {
                score1 = value;
                OnPropertyChanged("Score1");
            }
        }

        private int score2;
        public int Score2 
        {
            get
            {
                return score2;
            }
            set
            {
                score2 = value;
                OnPropertyChanged("Score2");
            }
        }

        private int ballTeam;
        public int BallTeam 
        {
            get
            {
                return ballTeam;
            }
            set
            {
                ballTeam = value;
                OnPropertyChanged("BallTeam");
            }
        }

        public MatchEngineViewModel()
        {
            PlayersTeam1 = new List<Player>();
            PlayersTeam1.Add(new Player() { Name = "p1", Position = new Point() { X = 10, Y = 120 }, Attack = 50, Defense = 50 });
            PlayersTeam1.Add(new Player() { Name = "p2", Position = new Point() { X = 20, Y = 30 }, Attack = 50, Defense = 50 });
            PlayersTeam1.Add(new Player() { Name = "p3", Position = new Point() { X = 30, Y = 40 }, Attack = 50, Defense = 50 });

            PlayersTeam2 = new List<Player>();
            PlayersTeam2.Add(new Player() { Name = "p1", Position = new Point() { X = 500, Y = 20 }, Attack = 10, Defense = 10 });
            PlayersTeam2.Add(new Player() { Name = "p2", Position = new Point() { X = 500, Y = 250 }, Attack = 10, Defense = 10 });
            PlayersTeam2.Add(new Player() { Name = "p3", Position = new Point() { X = 500, Y = 400 }, Attack = 10, Defense = 10 });

            Score1 = 0;
            Score2 = 0;
            BallTeam = 0;
        }

        public void NextTurn()
        {
            int playersTeam1Strenght = 0;
            int playersTeam2Strenght = 0;
            // Computing attack strenght for team with the ball team
            // Computing Defense strenght for team without the ball 
            if(BallTeam == 0)
            {
                foreach(var player in PlayersTeam1)
                {
                    playersTeam1Strenght += player.Attack;
                }
                foreach (var player in PlayersTeam2)
                {
                    playersTeam2Strenght += player.Defense;
                }
            }
            else
            {
                foreach (var player in PlayersTeam2)
                {
                    playersTeam2Strenght += player.Attack;
                }
                foreach (var player in PlayersTeam1)
                {
                    playersTeam1Strenght += player.Defense;
                }
            }
            // Computing the probability that a team recovers the ball, keeps the ball, scores a goal
            // Multiplying the strenght of the two teams by a random number between 0 and 1
            Random rand = new Random();
            double playersTeam1StrenghtRand = playersTeam1Strenght * rand.NextDouble();
            double playersTeam2StrenghtRand = playersTeam2Strenght * rand.NextDouble();

            // computing the difference
            if(BallTeam == 0)
            {
                // Scores a goal
                if(playersTeam1StrenghtRand > playersTeam2StrenghtRand)
                {
                    ++Score1;
                    BallTeam = 1;
                }
                // The other team recover the ball
                else
                {
                    BallTeam = 1;
                }
            }
            else
            {
                // Scores a goal
                if (playersTeam2StrenghtRand > playersTeam1StrenghtRand)
                {
                    ++Score2;
                    BallTeam = 0;
                }
                // The other team recover the ball
                else
                {
                    BallTeam = 0;
                }
            }
        }
    }
}
