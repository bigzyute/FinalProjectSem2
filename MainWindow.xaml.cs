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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace La_Bakéry
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BlurEffect blurEffect = new BlurEffect();
        public MainWindow()
        {
            InitializeComponent();
            blurEffect.Radius = 0;
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }

        private void BtnEmployee_Click(object sender, RoutedEventArgs e)
        {
            if (gridCustomer.Visibility == Visibility.Visible)
            {
                gridCustomer.Visibility = Visibility.Hidden;
                blurEffect.Radius = 0;
            }
            imgDashBackground.Effect = blurEffect;
        }

        private void BtnProduct_Click(object sender, RoutedEventArgs e)
        {
            if (gridCustomer.Visibility == Visibility.Visible)
            {
                gridCustomer.Visibility = Visibility.Hidden;
                blurEffect.Radius = 0;
            }
            imgDashBackground.Effect = blurEffect;
        }

        private void BtnReport_Click(object sender, RoutedEventArgs e)
        {
            if (gridCustomer.Visibility == Visibility.Visible)
            {
                gridCustomer.Visibility = Visibility.Hidden;
                blurEffect.Radius = 0;
            }
            imgDashBackground.Effect = blurEffect;
        }

        private void BtnCustomer_Click(object sender, RoutedEventArgs e)
        {
            if (gridCustomer.Visibility == Visibility.Hidden)
            {
                gridCustomer.Visibility = Visibility.Visible;
                blurEffect.Radius = 5;
            }
            imgDashBackground.Effect = blurEffect;
        }
    }
}
