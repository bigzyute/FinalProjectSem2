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
        private readonly object dialog;

        public object Image { get; private set; }

        public Add_Product()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            using (NewBakeryEntities context = new NewBakeryEntities())
            {
                ProductTable product = new ProductTable
                {
                    productName = txtProduct_Name.Text,
                    productCost = float.Parse(txtProduct_Cost.Text),
                    //productImage = pbNewPro_Image
                };
            }
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
            this.Hide();
        }

        private void BtnUpload_ProPic_Click(object sender, RoutedEventArgs e)
        {
          /*  String imageLocation = "";
            try
            {
                OpenFileDialog JuPic = new OpenFileDialog();
                JuPic.Filter = "jpg files (*.jpg)|*.jpg| PNG Files(*.png)|*png| All Files(*.*)|*.*";
                if (JuPic.ShowDialog() == DialogResult)
                {
                    imageLocation = dialog.GetType.
                    pbNewPro_Image = imageLocation;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            */
        }
    }
}
