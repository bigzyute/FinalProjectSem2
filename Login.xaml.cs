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

namespace La_Bakéry
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginSubmitButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            try
            {
                using (NewBakeryEntities context = new NewBakeryEntities())
                {
                    EmployeeTable employee = context.EmployeeTables.FirstOrDefault(l => l.username == txtBoxUsername.Text && l.password == loginPasswordBox.Password);
                    if (employee.username == txtBoxUsername.Text.Trim() && employee.password == loginPasswordBox.Password.Trim())
                    {
                        CurrentUser.getCurrUser = employee.empFirstName + " " + employee.empLastName;
                        mainWindow.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid username and password", "Login Error", MessageBoxButton.OK, MessageBoxImage.Error);
                txtBoxUsername.Focus();
            }                        
        }

        private void LoginPage_Loaded(object sender, RoutedEventArgs e)
        {
            txtBoxUsername.Focus();
            txtBoxUsername.SelectAll();
        }

        private void LoginPage_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                loginSubmitButton.IsDefault = true;
            }
        }

        private void LoginPage_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to exit", "Exit Login", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
