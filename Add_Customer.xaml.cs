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
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void BtnCustClear_Click(object sender, RoutedEventArgs e)
        {
            txtCustFirst_Name.Clear();
            txtCustLast_Name.Clear();
            txtCustMid_Initial.Clear();
            CusAddRbFemale.IsChecked = null;
            CusAddRbMale.IsChecked = null;
            txtCustPhone_Num.Clear();
            txtCustEmail_Add.Clear();
            txtCustPO_Box.Clear();
            txtCustDistrict.Clear();
            txtCustParish.Clear();
        }

        private void BtnExit__Click(object sender, RoutedEventArgs e)
        {
            MainWindow objMain = new MainWindow();
            objMain.Show();
            Hide();
        }

        private void BtnAdd_Cust_Click_1(object sender, RoutedEventArgs e)
        {
            string gender = "F";
            bool validated = false;
            //Input validation
            if (string.IsNullOrWhiteSpace(txtCustFirst_Name.Text) || string.IsNullOrWhiteSpace(txtCustLast_Name.Text))
            {
                MessageBox.Show("Please complete the required feilds", "Name Error", MessageBoxButton.OK);
                txtCustFirst_Name.Focus();
            }
            else if (txtCustFirst_Name.Text.Trim().Length < 3 || txtCustLast_Name.Text.Trim().Length < 3)
            {
                MessageBox.Show("Invalid Name, Please put your full name in the required field", "Name Length", MessageBoxButton.OK);
                txtCustFirst_Name.Focus();
            }
            else if (CusAddRbFemale.IsChecked == false && CusAddRbMale.IsChecked == false)
            {
                MessageBox.Show("Please select a gender.", "Gender Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (!this.txtCustEmail_Add.Text.Contains('@') || !this.txtCustEmail_Add.Text.Contains('.'))
            {
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButton.OK);
                txtCustEmail_Add.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtCustParish.Text))
            {
                MessageBox.Show("Please complete the required feild", "  Error", MessageBoxButton.OK);
                lblEmailErrorIcon.Visibility = Visibility.Visible;
                txtCustParish.Focus();
            }
            else
            {
                validated = true;
            }

            if (validated == true) //Assigning radio buttons
            {

                if (CusAddRbFemale.IsChecked == true)
                {
                    gender = "F";
                }
                else if (CusAddRbMale.IsChecked == true)
                {
                    gender = "M";
                }
                using (NewBakeryEntities context = new NewBakeryEntities())
                {
                    CustomerTable customer = new CustomerTable
                    {

                        cusFirstName = txtCustFirst_Name.Text,
                        cusMidInitial = txtCustMid_Initial.Text,
                        cusLastName = txtCustLast_Name.Text,
                        cusGender = gender,
                        cusTelephone = txtCustPhone_Num.Text,
                        email = txtCustEmail_Add.Text,
                        poBox = txtCustPO_Box.Text,
                        district = txtCustDistrict.Text,
                        parish = txtCustParish.Text,
                        dateCreated = DateTime.Now
                    };
                    context.CustomerTables.Add(customer);
                    context.SaveChanges();

                    MessageBox.Show("Customer with ID#" +customer.CustomerId +" Succesfully Added!", "Customer Added", MessageBoxButton.OK, MessageBoxImage.Information);
                }                    
            }

        }

        private void BtnExit__Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TxtCustMid_Initial_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCustMid_Initial.Text))
            {
                txtCustMid_Initial.Text = txtCustMid_Initial.Text.ToUpper(); 
            }
        }

        private void TxtCustFirst_Name_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCustFirst_Name.Text))
            {
                txtCustFirst_Name.Text = char.ToUpper(txtCustFirst_Name.Text[0]) + txtCustFirst_Name.Text.Substring(1);
            }
        }

        private void TxtCustLast_Name_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCustLast_Name.Text))
            {
                txtCustLast_Name.Text = char.ToUpper(txtCustLast_Name.Text[0]) + txtCustLast_Name.Text.Substring(1);
            }
        }

        private void TxtCustEmail_Add_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCustEmail_Add.Text))
            {
                txtCustEmail_Add.Text = txtCustEmail_Add.Text.ToLower();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}

