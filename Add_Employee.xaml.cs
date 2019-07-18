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
    /// Interaction logic for Add_Customer.xaml
    /// </summary>
    public partial class Add_Customer : Window
    {
        public Add_Customer()
        {
            InitializeComponent();
        }

        private void BtnAdd_CusExit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow objMain = new MainWindow();
            objMain.Show();
            Hide();
          
        }

        private void BtnAdd_CusAdd_Click(object sender, RoutedEventArgs e)
        {
            int telephone;
        }

    }
}