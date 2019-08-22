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
    /// Interaction logic for Add_Customer.xaml
    /// </summary>
    public partial class Add_Employee : Window
    {
        public Add_Employee()
        {
            InitializeComponent();
        }

        private void BtnAdd_CusExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void BtnAdd_CusAdd_Click(object sender, RoutedEventArgs e)
        {
            int telephone;
            char gender = 'm';
            String marStat = "single";
            
            Int32.TryParse(txtAdd_EmpTelephone.Text, out telephone);
            bool valid = false;

            //Validations
            if (string.IsNullOrWhiteSpace(txtAdd_EmpFName.Text) || string.IsNullOrWhiteSpace(txtAdd_EmpLName.Text))
            {
                MessageBox.Show("Please complete the required feilds", "Name Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (grdbAdd_EmpFemale.IsChecked == false && grdbAdd_EmpMale.IsChecked == false)
            {
                MessageBox.Show("Please select a gender.", "Gender Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (rdbAdd_EmpSingle.IsChecked == false && rdbAdd_EmpMarried.IsChecked == false && rdbAdd_EmpDivorced.IsChecked == false &&
              rdbAdd_EmpWidowed.IsChecked == false)
            {
                MessageBox.Show("Please select a Marital Status.", "Marital Status Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtAdd_EmpTown.Text))
            {
                MessageBox.Show("A Town must be added.", "Town Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtAdd_EmpPassword.Password.ToString()) || string.IsNullOrWhiteSpace(txtAdd_EmpUserName.Text))
            {
                MessageBox.Show("Please enter a username and password", "Credentials Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                valid = true; //If input is validated, the variable "valid" is set to true
            }

            if (valid == true) //Assigning radio buttons
            {

                if (grdbAdd_EmpFemale.IsChecked == true)
                {
                    gender = 'f';
                }
                else if (grdbAdd_EmpMale.IsChecked == true)
                {
                    gender = 'm';
                }

                if (valid == true)
                {

                    if (rdbAdd_EmpSingle.IsChecked == true)
                    {
                        marStat = "divorced";
                    }
                    else if (rdbAdd_EmpMarried.IsChecked == true)
                    {
                        marStat = "married";
                    }
                    else if (rdbAdd_EmpDivorced.IsChecked == true)
                    {
                        marStat = "widowed";
                    }
                    else
                    {
                        marStat = "single";
                    }
                }
                MessageBox.Show("Employee Succesfully Added!", "Employee Added", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void TxtAdd_EmpTelephone_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}