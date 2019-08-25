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
            this.Hide();
        }

        private void BtnRem_EmpRemove_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (NewBakeryEntities context = new NewBakeryEntities())
                {
                    var employee = context.EmployeeTables.Find(int.Parse(txtRem_EmpId.Text));
                    var result = MessageBox.Show("Are you sure you want to remove employee " + employee.empFirstName + " " + employee.empLastName + "?",
                        "Remove Employee", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (result == MessageBoxResult.Yes)
                    {
                        context.EmployeeTables.Remove(employee);
                        context.SaveChanges();
                        MessageBox.Show("Employee successfully removed. ", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No records were found ", "No Records", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }
        }

        private void BtnRem_EmpSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (NewBakeryEntities context = new NewBakeryEntities())
                {
                    var employee = context.EmployeeTables.Find(int.Parse(txtRem_EmpId.Text));
                    txtRem_EmpResult.Text = employee.empFirstName + " " + employee.empLastName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No records were found ", "No Records", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }
        }
    }
}
