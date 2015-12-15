using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TacticModule
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class TacticView : UserControl
    {
        public TacticView()
        {
            InitializeComponent();
        }

        private void LeftAttackAreaClick(object sender, MouseButtonEventArgs e)
        {
            var dataContext = (sender as Border).DataContext as TacticViewModel;
            dataContext.AreaSelected(EnumArea.AttackLeft);
        }

        private void CenterAttackAreaClick(object sender, MouseButtonEventArgs e)
        {
            var dataContext = (sender as Border).DataContext as TacticViewModel;
            dataContext.AreaSelected(EnumArea.AttackCenter);
        }

        private void RightAttackAreaClick(object sender, MouseButtonEventArgs e)
        {
            var dataContext = (sender as Border).DataContext as TacticViewModel;
            dataContext.AreaSelected(EnumArea.AttackRight);
        }

        private void LeftMiddleAreaClick(object sender, MouseButtonEventArgs e)
        {
            var dataContext = (sender as Border).DataContext as TacticViewModel;
            dataContext.AreaSelected(EnumArea.MiddleLeft);
        }

        private void CenterMiddleAreaClick(object sender, MouseButtonEventArgs e)
        {
            var dataContext = (sender as Border).DataContext as TacticViewModel;
            dataContext.AreaSelected(EnumArea.MiddleCenter);
        }

        private void RightMiddleAreaClick(object sender, MouseButtonEventArgs e)
        {
            var dataContext = (sender as Border).DataContext as TacticViewModel;
            dataContext.AreaSelected(EnumArea.MiddleRight);
        }

        private void LeftDefenseAreaClick(object sender, MouseButtonEventArgs e)
        {
            var dataContext = (sender as Border).DataContext as TacticViewModel;
            dataContext.AreaSelected(EnumArea.DefenseLeft);
        }

        private void CenterDefenseAreaClick(object sender, MouseButtonEventArgs e)
        {
            var dataContext = (sender as Border).DataContext as TacticViewModel;
            dataContext.AreaSelected(EnumArea.DefenseCenter);
        }

        private void RightDefenseAreaClick(object sender, MouseButtonEventArgs e)
        {
            var dataContext = (sender as Border).DataContext as TacticViewModel;
            dataContext.AreaSelected(EnumArea.DefenseRight);
        }

        private void GoalKeeperAreaClick(object sender, MouseButtonEventArgs e)
        {
            var dataContext = (sender as Border).DataContext as TacticViewModel;
            dataContext.AreaSelected(EnumArea.GoalKeeper);
        }
    }
}
