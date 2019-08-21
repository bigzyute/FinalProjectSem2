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
    /// Interaction logic for Remove_Customer.xaml
    /// </summary>
    public partial class Remove_Customer : Window
    {
        public Remove_Customer()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void BtnReCust_Clear_Click(object sender, RoutedEventArgs e)
        {

            txtReCust_ID.Clear();
            txtReCust_Result.Clear();
        }

        private void TxtReCust_ID_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnReCust_Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
