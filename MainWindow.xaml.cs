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
        public void showGrid(Grid grid)
        {
            var hide = Visibility.Hidden;
            var show = Visibility.Visible;
            if (grid.Visibility == hide)
            {
                gridCustomer.Visibility = hide;
                gridEmployee.Visibility = hide;
                gridProduct.Visibility = hide;
                gridViewEmployee.Visibility = hide;
                gridViewCustomer.Visibility = hide;
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

        private void BtnEmployee_Click(object sender, RoutedEventArgs e)
        {
            showGrid(gridEmployee);
        }

        private void BtnProduct_Click(object sender, RoutedEventArgs e)
        {
            showGrid(gridProduct);
        }

        private void BtnReport_Click(object sender, RoutedEventArgs e)
        {
            if (gridCustomer.Visibility == Visibility.Visible || gridEmployee.Visibility == Visibility.Visible || gridProduct.Visibility == Visibility.Visible)
            {
                gridCustomer.Visibility = Visibility.Hidden;
                gridEmployee.Visibility = Visibility.Hidden;
                gridProduct.Visibility = Visibility.Hidden;
            }
        }

        private void BtnCustomer_Click(object sender, RoutedEventArgs e)
        {
            showGrid(gridProduct);
        }

        private void BtnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            gridCustomer.IsEnabled = false;
           /* Add_Customer add_Customer = new Add_Customer();
            add_Customer.Show();*/
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
           /* Add_Employee add_Employee = new Add_Employee();
            add_Employee.Show();*/
        }

        private void BtnRemoveEmployee_Click(object sender, RoutedEventArgs e)
        {
            Remove_Employee remove_Employee = new Remove_Employee();
            if (remove_Employee.IsFocused == false)
            {
                remove_Employee.Show(); 
            } else
            {
                remove_Employee.BringIntoView();
                remove_Employee.Focus();
            }
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

        private void BtnViewCustomer_Click(object sender, RoutedEventArgs e)
        {
            gridCustomer.Visibility = Visibility.Hidden;    //Work in progress
            gridViewCustomer.Visibility = Visibility.Visible;
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
            gridEmployee.Visibility = Visibility.Hidden;
            gridViewEmployee.Visibility = Visibility.Visible;
        }
    }
}
