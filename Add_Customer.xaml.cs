using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    public partial class Add_Customer : Window
    {

        public Add_Customer()
        {
            InitializeComponent();
            CustomerTable customer = new CustomerTable();
            var id = customer.customerId + 1;
            txtCustID.Text = id.ToString();
        }

        private void BtnCustClear_Click(object sender, RoutedEventArgs e)
        {
            txtCustID.Clear();
            txtCustFirst_Name.Clear();
            txtCustLast_Name.Clear();
            txtCustMid_Initial.Clear();
            grdbAdd_CusFemale.IsChecked = false;
            grdbAdd_CusMale.IsChecked = false;
            txtCustPhone_Num.Clear();
            txtCustEmail_Add.Clear();
            txtCustPO_Box.Clear();
            txtCustDistrict.Clear();
            txtCustParish.Clear();
            cbCustSearch.SelectedIndex = -1;
        }

        private void BtnExit__Click(object sender, RoutedEventArgs e)
        {
            MainWindow objMain = new MainWindow();
            objMain.Show();
            Hide();
        }
        private void BtnAdd_Cust_Click_1(object sender, RoutedEventArgs e)
        {
            //Input validation
            string gender;
            bool validated = false;
            if (string.IsNullOrWhiteSpace(txtCustFirst_Name.Text) || string.IsNullOrWhiteSpace(txtCustLast_Name.Text))
            {
                MessageBox.Show("Please complete the required feilds", "Name Error", MessageBoxButton.OK);
            }
            else if (grdbAdd_CusFemale.IsChecked == false && grdbAdd_CusMale.IsChecked == false)
            {
                MessageBox.Show("Please select a gender.", "Gender Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (!string.IsNullOrWhiteSpace(txtCustEmail_Add.Text) && !this.txtCustEmail_Add.Text.Contains('@') || !this.txtCustEmail_Add.Text.Contains('.'))
            {
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButton.OK);
            }
            else
            {
                validated = true;
            }

            if (validated == true) //Assigning radio buttons
            {

                if (grdbAdd_CusFemale.IsChecked == true)
                {
                    gender = "f";
                }
                else
                {
                    gender = "m";
                }

                using (La_BakeryEntities databaseHandler = new La_BakeryEntities())
                {
                    CustomerTable customer = new CustomerTable
                    {
                        firstName = txtCustFirst_Name.Text,
                        mInitial = txtCustFirst_Name.Text,
                        lastName = txtCustFirst_Name.Text,
                        gender = gender,
                        phoneNumber = Int32.Parse(txtCustFirst_Name.Text),
                        poBox = txtCustPO_Box.Text,
                        district = txtCustDistrict.Text,
                        parish = txtCustDistrict.Text
                    };
                    databaseHandler.CustomerTables.Add(customer);
                    databaseHandler.SaveChanges();
                }

                MessageBox.Show("Employee Succesfully Added!", "Employee Added", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void TxtCustPhone_Num_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtCustPhone_Num_LostFocus(object sender, RoutedEventArgs e)
        {
          /*  var num = txtCustPhone_Num.Text;

           var regex = (@"\+[0-9]{3}\s+[0-9]{3}\s+[0-9]{4}");
          //  Match getmatch = phoneNumpattern.Match(txtCustPhone_Num.Text);
            
            
            if (Regex.IsMatch(num, regex))
            {
                MessageBox.Show(num + " Great Number accepted");
            }
            else
            {
                MessageBox.Show("Invalid phone number entered, please try again");
            }*/
        }

        private void TxtCustPO_Box_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnExit__Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

