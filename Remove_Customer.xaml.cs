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
            using (La_BakeryEntities databaseHandler = new La_BakeryEntities())
            {
                try
                {
                    var entity = databaseHandler.CustomerTables.Find(Int32.Parse(txtReCust_ID.Text)); //var blog = context.Blogs.Find(3);
                    txtReCust_Result.Text = entity.firstName;
                }
                catch (Exception)
                {

                    MessageBox.Show("Please enter a valid Customer ID", "ID Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (La_BakeryEntities databaseHandler = new La_BakeryEntities())
            {
                try
                {
                    var entity = databaseHandler.CustomerTables.Find(Int32.Parse(txtReCust_ID.Text)); //var blog = context.Blogs.Find(3);
                    txtReCust_Result.Text = entity.firstName;
                    MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this Customer?", "Delete Customer", MessageBoxButton.YesNo, MessageBoxImage.Asterisk);
                    if (result == MessageBoxResult.Yes)
                    {
                        databaseHandler.CustomerTables.Remove(entity);
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Please enter a valid Customer ID", "ID Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
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
