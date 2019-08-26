using Microsoft.Win32;
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
    /// Interaction logic for Add_Product.xaml
    /// </summary>
    public partial class Add_Product : Window
    {
        public Add_Product()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (NewBakeryEntities context = new NewBakeryEntities())
                {
                    ProductTable product = new ProductTable
                    {
                        productName = txtProduct_Name.Text,
                        productCost = float.Parse(txtProduct_Cost.Text),
                        dateCreated = DateTime.Now
                    };
                    context.ProductTables.Add(product);
                    context.SaveChanges();

                    MessageBox.Show("Product with ID#" + product.productCode + " Succesfully Added!", "Product Added", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Generated. Details: " + ex.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }            
        }

        private void BtnClear_Product_Click(object sender, RoutedEventArgs e)
        {
            txtProduct_Cost.Clear();
            txtProduct_Name.Clear();
            
        }

        private void BtnExit_Product_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
