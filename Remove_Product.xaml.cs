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
    /// Interaction logic for Remove_Product.xaml
    /// </summary>
    public partial class Remove_Product : Window
    {
        public Remove_Product()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void BtnRemovePro_Clear_Click(object sender, RoutedEventArgs e)
        {
            txtRemovePro_ID.Clear();
            txtRemovePro_Result.Clear();
        }
    }
}
