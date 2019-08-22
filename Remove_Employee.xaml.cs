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
    /// Interaction logic for Remove_Employee.xaml
    /// </summary>
    public partial class Remove_Employee : Window
    {
        public Remove_Employee()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void BtnRem_EmpExit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow objMain = new MainWindow();
            if (objMain.IsVisible == true)
            {
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void BtnRem_EmpRemove_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnRem_EmpSearch_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRem_EmpId.Text) || string.IsNullOrWhiteSpace(txtRem_EmpResult.Text))
            {
                MessageBox.Show("Please enter a valid Employee I.D.", "Name Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
