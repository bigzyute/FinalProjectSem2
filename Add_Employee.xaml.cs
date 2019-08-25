﻿using System;
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
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void BtnAdd_CusExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void BtnAdd_CusAdd_Click(object sender, RoutedEventArgs e)
        {
            int telephone;
            string gender = "M";
            String marStat = "single";
            
            Int32.TryParse(txtAdd_EmpTelephone.Text, out telephone);
            bool valid = false;

            //Validations
            if (string.IsNullOrWhiteSpace(txtAdd_EmpFName.Text) || string.IsNullOrWhiteSpace(txtAdd_EmpLName.Text))
            {
                MessageBox.Show("Please complete the required feilds", "Name Error", MessageBoxButton.OK, MessageBoxImage.Error);
                txtAdd_EmpFName.Focus();
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
                txtAdd_EmpTown.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtAdd_EmpPassword.Password.ToString()) || string.IsNullOrWhiteSpace(txtAdd_EmpUserName.Text))
            {
                MessageBox.Show("Please enter a username and password", "Credentials Error", MessageBoxButton.OK, MessageBoxImage.Error);
                txtAdd_EmpUserName.Focus();
            }
            else
            {
                valid = true; //If input is validated, the variable "valid" is set to true
            }

            if (valid == true) //Assigning radio buttons
            {

                if (grdbAdd_EmpFemale.IsChecked == true)
                {
                    gender = "f";
                }
                else if (grdbAdd_EmpMale.IsChecked == true)
                {
                    gender = "m";
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

                    using (NewBakeryEntities context = new NewBakeryEntities())
                    {
                        EmployeeTable employee = new EmployeeTable
                        {
                            empFirstName = txtAdd_EmpFName.Text,
                            empMidInit = txtAdd_EmpMName.Text,
                            empLastName = txtAdd_EmpLName.Text,
                            dob = empDobDatePicker.SelectedDate, //if i get a convert DateTime to DateTime error, its this line
                            gender = gender.ToUpper(),
                            maritalStat = marStat.ToUpper(),
                            town = txtAdd_EmpTown.Text,
                            poBox = txtAdd_EmpPOBox.Text,
                            parish = txtAdd_EmpParish.Text,
                            telephone = txtAdd_EmpTelephone.Text,
                            email = txtAdd_EmpEmail.Text,
                            dateCreated = DateTime.Now
                        };
                        LoginTable login = new LoginTable
                        {
                            username = txtAdd_EmpUserName.Text,
                            password = txtAdd_EmpPassword.Password
                        };
                        context.EmployeeTables.Add(employee);
                        context.LoginTables.Add(login);
                        context.SaveChanges();

                        MessageBox.Show("Employee with ID#" + employee.employeeId + " Succesfully Added!", "Employee Added", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
        }

        private void TxtAdd_EmpTelephone_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtAdd_EmpFName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAdd_EmpFName.Text))
            {
                txtAdd_EmpFName.Text = char.ToUpper(txtAdd_EmpFName.Text[0]) + txtAdd_EmpFName.Text.Substring(1);
            }
        }

        private void TxtAdd_EmpMName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAdd_EmpMName.Text))
            {
                txtAdd_EmpMName.Text = char.ToUpper(txtAdd_EmpMName.Text[0]) + txtAdd_EmpMName.Text.Substring(1);
            }
        }

        private void TxtAdd_EmpLName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAdd_EmpLName.Text))
            {
                txtAdd_EmpLName.Text = char.ToUpper(txtAdd_EmpLName.Text[0]) + txtAdd_EmpLName.Text.Substring(1);
            }
        }

        private void TxtAdd_EmpTown_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAdd_EmpTown.Text))
            {
                txtAdd_EmpTown.Text = char.ToUpper(txtAdd_EmpTown.Text[0]) + txtAdd_EmpTown.Text.Substring(1);
            }
        }

        private void BtnAdd_EmpClear_Click(object sender, RoutedEventArgs e)
        {
            txtAdd_EmpFName.Clear();
            txtAdd_EmpMName.Clear();
            txtAdd_EmpLName.Clear();
            empDobDatePicker.SelectedDate = null;
            grdbAdd_EmpFemale.IsChecked = false;
            grdbAdd_EmpMale.IsChecked = false;
            rdbAdd_EmpSingle.IsChecked = false;
            rdbAdd_EmpMarried.IsChecked = false;
            rdbAdd_EmpDivorced.IsChecked = false;
            rdbAdd_EmpWidowed.IsChecked = false;
            txtAdd_EmpTown.Clear();
            txtAdd_EmpPOBox.Clear();
            txtAdd_EmpParish.Clear();
            txtAdd_EmpTelephone.Clear();
            txtAdd_EmpEmail.Clear();
            txtAdd_EmpUserName.Clear();
            txtAdd_EmpPassword.Clear();
        }
    }
}