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
    /// Interaction logic for Add_Employee.xaml
    /// </summary>
    public partial class Add_Employee : Window
    {
        public Add_Employee()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCustClear_Click(object sender, RoutedEventArgs e)
        {
            txtCustID.Clear();
            txtCustFirst_Name.Clear();
            txtCustLast_Name.Clear();
            txtCustMid_Initial.Clear();
            txtCust_Gender.Clear();
            txtCustPhone_Num.Clear();
            txtCustEmail_Add.Clear();
            txtCustPO_Box.Clear();
            txtCustDistrict.Clear();
            txtCustParish.Clear();
            cbCustSearch.SelectedIndex=-1;


        }
    }
}
