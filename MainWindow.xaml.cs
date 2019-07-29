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
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void BtnEmployee_Click(object sender, RoutedEventArgs e)
        {
            if (gridEmployee.Visibility == Visibility.Hidden)
            {
                gridCustomer.Visibility = Visibility.Hidden;
                gridProduct.Visibility = Visibility.Hidden;
                gridEmployee.Visibility = Visibility.Visible;
            }
            imgDashBackground.Effect = blurEffect;
        }

        private void BtnProduct_Click(object sender, RoutedEventArgs e)
        {
            if (gridProduct.Visibility == Visibility.Hidden)
            {
                gridCustomer.Visibility = Visibility.Hidden;
                gridEmployee.Visibility = Visibility.Hidden;
                gridProduct.Visibility = Visibility.Visible;
                blurEffect.Radius = 0;
            }
            imgDashBackground.Effect = blurEffect;
        }

        private void BtnReport_Click(object sender, RoutedEventArgs e)
        {
            if (gridCustomer.Visibility == Visibility.Visible || gridEmployee.Visibility == Visibility.Visible || gridProduct.Visibility == Visibility.Visible)
            {
                gridCustomer.Visibility = Visibility.Hidden;
                gridEmployee.Visibility = Visibility.Hidden;
                gridProduct.Visibility = Visibility.Hidden;
                blurEffect.Radius = 0;
            }
            imgDashBackground.Effect = blurEffect;
        }

        private void BtnCustomer_Click(object sender, RoutedEventArgs e)
        {
            if (gridCustomer.Visibility == Visibility.Hidden)
            {
                gridProduct.Visibility = Visibility.Hidden;
                gridEmployee.Visibility = Visibility.Hidden;
                gridCustomer.Visibility = Visibility.Visible;
                blurEffect.Radius = 5;
            }
            imgDashBackground.Effect = blurEffect;
        }

        private void BtnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            gridCustomer.IsEnabled = false;
            Add_Customer add_Customer = new Add_Customer();
            add_Customer.Show();
        }

        private void BtnRemoveCustomer_Click(object sender, RoutedEventArgs e)
        {
            gridCustomer.IsEnabled = false;
            Remove_Customer remove_Customer = new Remove_Customer();
            remove_Customer.Show();
        }

        private void BtnAddEmployee_Click(object sender, RoutedEventArgs e)
        {
            gridEmployee.IsEnabled = false;
            Add_Employee add_Employee = new Add_Employee();
            add_Employee.Show();
        }

        private void BtnRemoveEmployee_Click(object sender, RoutedEventArgs e)
        {
            gridEmployee.IsEnabled = false;
            Remove_Employee remove_Employee = new Remove_Employee();
            remove_Employee.Show();
        }

        private void BtnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            gridProduct.IsEnabled = false;
            Add_Product add_Product = new Add_Product();
            add_Product.Show();
        }

        private void BtnRemoveProduct_Click(object sender, RoutedEventArgs e)
        {
            gridProduct.IsEnabled = false;
            Remove_Product remove_Product = new Remove_Product();
            remove_Product.Show();
        }
    }
}
