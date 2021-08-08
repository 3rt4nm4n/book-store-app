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

namespace LabWorkQ2
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void loginButton_Click(object sender, RoutedEventArgs e) //after user inputs his login information and clicks this button if the username and password matches he will be directed to next window
        {           
            if (usrnameTxtBox.Text == "admin" && passTxtBox.Password == "password")
            {
                Window2 win2 = new Window2();
                win2.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }
    }
}
