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
using System.Windows.Shapes;

namespace DevAppMAXI
{
    /// <summary>
    /// Interaction logic for frmHome.xaml
    /// </summary>
    public partial class frmHome : Window
    {
        usrHome home = new usrHome();
        
        public frmHome()
        {
            InitializeComponent();
            container.Children.Add(home);
        }

        private void opneMenu_Click(object sender, RoutedEventArgs e)
        {
            drMenu.IsLeftDrawerOpen = true;
        }

        private void listMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = listMenu.SelectedIndex;

            switch (index)
            {
                case 0:
                    container.Children.Clear();
                    container.Children.Add(home);
                    break;

                case 7:
                    this.Hide();
                    new frmLogin().ShowDialog();                 
                    break;

                case 9:
                    dialog.IsOpen = true;
                    break;
                default:
                    break;
            }
        }

        private void btnSim_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void btnNao_Click(object sender, RoutedEventArgs e)
        {
            dialog.IsOpen = false;
        }
    }
}
