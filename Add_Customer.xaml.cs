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
            txtCustID.Clear();
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
            cbCustSearch.SelectedIndex = -1;
        }

        private void BtnExit__Click(object sender, RoutedEventArgs e)
        {
            MainWindow objMain = new MainWindow();
            objMain.Show();
            Hide();
        }

        /* private void BtnAdd_Cust_Click(object sender, RoutedEventArgs e)
         {



             int telephone;
             Int32.TryParse(txtCustPhone_Num.Text, out telephone);
             //bool validated = false;
             //Input validation
             if (string.IsNullOrWhiteSpace(txtCustFirst_Name.Text) || string.IsNullOrWhiteSpace(txtCustLast_Name.Text))
             {
                 MessageBox.Show("Please complete the required feilds", "Name Error", MessageBoxButton.OK );
             }
             else if (txtCustFirst_Name.Text.Trim().Length < 3 || txtCustLast_Name.Text.Trim().Length < 3)
             {
                 MessageBox.Show("Invalid Name, Please put your full name in the required field", "Name Length", MessageBoxButton.OK);

             }
             else if (string.IsNullOrWhiteSpace(txtCust_Gender.Text))
             {
                 MessageBox.Show("Please complete the required feild", "Gender Error", MessageBoxButton.OK );
             }
             if (!this.txtCustEmail_Add.Text.Contains('@') || !this.txtCustEmail_Add.Text.Contains('.'))
             {
                 MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButton.OK);
             }

             Regex phoneNumpattern = new Regex(@"\+[0-9]{3}\s+[0-9]{3}\s+[0-9]{4}");
             if (phoneNumpattern.IsMatch(txtCustPhone_Num.Text))
             {
                 MessageBox.Show("OK");
             }
             else
             {
                 MessageBox.Show("Invalid phone number");
             }
         }*/

        private void BtnAdd_Cust_Click_1(object sender, RoutedEventArgs e)
        {
            //int telephone;
            string gender = "f";
            bool validated = false;
            //Input validation
            if (string.IsNullOrWhiteSpace(txtCustFirst_Name.Text) || string.IsNullOrWhiteSpace(txtCustLast_Name.Text))
            {
                MessageBox.Show("Please complete the required feilds", "Name Error", MessageBoxButton.OK);
            }
            else if (txtCustFirst_Name.Text.Trim().Length < 3 || txtCustLast_Name.Text.Trim().Length < 3)
            {
                MessageBox.Show("Invalid Name, Please put your full name in the required field", "Name Length", MessageBoxButton.OK);

            }
            else if (CusAddRbFemale.IsChecked == false && CusAddRbMale.IsChecked == false)
            {
                MessageBox.Show("Please select a gender.", "Gender Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (!this.txtCustEmail_Add.Text.Contains('@') || !this.txtCustEmail_Add.Text.Contains('.'))
            {
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButton.OK);
            }
            else if (string.IsNullOrWhiteSpace(txtCustPO_Box.Text))
            {
                MessageBox.Show("Please complete the required feild", " PoB Error", MessageBoxButton.OK);
            }
            else if (string.IsNullOrWhiteSpace(txtCustDistrict.Text))
            {
                MessageBox.Show("Please complete the required feild", " District Error", MessageBoxButton.OK);
            }
            else if (string.IsNullOrWhiteSpace(txtCustParish.Text))
            {
                MessageBox.Show("Please complete the required feild", "  Error", MessageBoxButton.OK);
            }
            else
            {
                validated = true;
            }

            if (validated == true) //Assigning radio buttons
            {

                if (CusAddRbFemale.IsChecked == true)
                {
                    gender = "f";
                }
                else if (CusAddRbMale.IsChecked == true)
                {
                    gender = "m";
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
                }

                    MessageBox.Show("Employee Succesfully Added!", "Employee Added", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }

        private void TxtCustPhone_Num_Leave(object sender, TextChangedEventArgs e)
        {
           /* Regex phoneNumpattern = new Regex(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}");
            if (phoneNumpattern.IsMatch(txtCustPhone_Num.Text))
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("Invalid phone number");
            }
           /* Regex pattern = new Regex(@"^((\+){0,1}91(\s){0,1}(\-){0,1}(\s){0,1}){0,1}9[0-9](\s){0,1}(\-){0,1}(\s){0,1}[1-9]{3}[0-9]{4}$");
            if (pattern.IsMatch(txtCustPhone_Num.Text))
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("Invalid phone number");
            }*/
        }

        private void TxtCustPhone_Num_LostFocus(object sender, RoutedEventArgs e)
        {
            Regex phoneNumpattern = new Regex(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}");
            if (phoneNumpattern.IsMatch(txtCustPhone_Num.Text))
            {
                MessageBox.Show("The Number you entered is valid");
            }
            else
            {
                MessageBox.Show("Invalid phone number");
            }
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

        private void TxtCustMid_Initial_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

