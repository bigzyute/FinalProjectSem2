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
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnClear_Product_Click(object sender, RoutedEventArgs e)
        {
            txtProduct_Code.Clear();
            txtProduct_Cost.Clear();
            txtProduct_Name.Clear();
            
        }

        private void BtnExit_Product_Click(object sender, RoutedEventArgs e)
        {
            MainWindow objMain = new MainWindow();
            objMain.Show();
            Hide();
        }
    }
}
