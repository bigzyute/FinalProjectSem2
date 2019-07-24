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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace La_Bakéry
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }

        private void BtnEmployee_Click(object sender, RoutedEventArgs e)
        {
            gridCustomer.Visibility = Visibility.Hidden;
        }

        private void BtnProduct_Click(object sender, RoutedEventArgs e)
        {
            gridCustomer.Visibility = Visibility.Hidden;
        }

        private void BtnReport_Click(object sender, RoutedEventArgs e)
        {
            gridCustomer.Visibility = Visibility.Hidden;
        }

        private void BtnCustomer_Click(object sender, RoutedEventArgs e)
        {
            gridCustomer.Visibility = Visibility.Visible;
        }
    }
}
