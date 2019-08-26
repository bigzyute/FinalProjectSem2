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
        public void showGrid(Grid grid) //This method is designed to handle the visibility property of all the grids in the Application
        {
            var hide = Visibility.Hidden;
            var show = Visibility.Visible;
            if (grid.Visibility == hide)
            {
                gridCustomer.Visibility = hide;
                gridEmployee.Visibility = hide;
                gridProduct.Visibility = hide;
                gridOrder.Visibility = hide;
                gridViewEmployee.Visibility = hide;
                gridViewCustomer.Visibility = hide;
                gridViewProduct.Visibility = hide;
                /*gridReport.Visibility = hide;*/
                grid.Visibility = show;
            } else
            {
                grid.Focus();
            }
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to exit", "Exit Application", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }

        private void BtnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            Add_Customer add_Customer = new Add_Customer();
            add_Customer.ShowDialog();
        }

        private void BtnRemoveCustomer_Click(object sender, RoutedEventArgs e) 
        {
            Remove_Customer remove_Customer = new Remove_Customer();
            remove_Customer.ShowDialog();
        }

        private void BtnAddEmployee_Click(object sender, RoutedEventArgs e)
        {
            Add_Employee add_Employee = new Add_Employee();
            add_Employee.ShowDialog();
        }

        private void BtnRemoveEmployee_Click(object sender, RoutedEventArgs e)
        {
            Remove_Employee remove_Employee = new Remove_Employee();
            remove_Employee.ShowDialog();
        }

        private void BtnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            Add_Product add_Product = new Add_Product();
            add_Product.ShowDialog();
        }

        private void BtnRemoveProduct_Click(object sender, RoutedEventArgs e)
        {
            Remove_Product remove_Product = new Remove_Product();
            remove_Product.ShowDialog();
        }

        private void BtnViewCustomer_Click(object sender, RoutedEventArgs e)
        {
            showGrid(gridViewCustomer);
        }

        private void Dashboard_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to exit", "Exit Application", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }else
            {
                Environment.Exit(0);
            }
        }

        private void BtnViewEmployee_Click(object sender, RoutedEventArgs e)
        {
            showGrid(gridViewEmployee);
        }

        private void ListOrder_Selected(object sender, RoutedEventArgs e)
        {
            showGrid(gridOrder);
        }

        private void ListCustomer_Selected(object sender, RoutedEventArgs e)
        {
            showGrid(gridCustomer);
        }

        private void ListEmployee_Selected(object sender, RoutedEventArgs e)
        {
            showGrid(gridEmployee);
        }

        private void ListProduct_Selected(object sender, RoutedEventArgs e)
        {
            showGrid(gridProduct);
        }

        private void GridViewCustomer_Loaded(object sender, RoutedEventArgs e)
        {
            using(NewBakeryEntities context = new NewBakeryEntities())
            {
                dataGridViewCustomer.ItemsSource = context.CustomerTables.ToList();
            }
        }

        private void GridViewEmployee_Loaded(object sender, RoutedEventArgs e)
        {
            using (NewBakeryEntities context = new NewBakeryEntities())
            {
                dataGridViewEmployee.ItemsSource = context.EmployeeTables.ToList();
            }
        }

        private void BtnViewProduct_Click(object sender, RoutedEventArgs e)
        {
            showGrid(gridViewProduct);
        }

        private void Dashboard_Loaded(object sender, RoutedEventArgs e)
        {
            dashboardEpander.Header = CurrentUser.getCurrUser;
        }
    }
}
