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

namespace Chirag_Art
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw=new MainWindow(this);
            if (user_name.Text == "admin" && pass.Password == "pass@123")
            {
                mw.Show();
                this.Hide();
            }
            if (user_name.Text == "jheel" && pass.Password == "WobblyJelly")
            {
                mw.Show();
                mw.rpt.Visibility = Visibility.Hidden;
                this.Hide();
            }
        }
    }
}
