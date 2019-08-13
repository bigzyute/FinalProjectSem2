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
    /// Interaction logic for Supplier.xaml
    /// </summary>
    public partial class Supplier : Window
    {
        public Supplier()
        {
            InitializeComponent();
        }

        private void BtnSupDetails_Clear_Click(object sender, RoutedEventArgs e)
        {
            txtSup_ID.Clear();
            txtSup_Name.Clear();
            txtSup_Address.Clear();
            txtSup_ContactNum.Clear();
            txtSup_EmailAdd.Clear();
            txtSup_SuplyOf.Clear();
            cbSup_Parish.SelectedIndex = -1;
            cbSup_Search.SelectedIndex = -1;
        }
    }
}
