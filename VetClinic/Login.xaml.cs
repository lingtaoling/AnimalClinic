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

namespace VetClinic
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

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
        private void BtnMain_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            
            Globals.mainWindow.Show();
        }

        private void BtnLogIn_Click(object sender, RoutedEventArgs e)
        {

            string email = EmailInput.Text;
            string password = PasswordInput.Password;


        }

        private void BtnSignUp_Click(object sender, RoutedEventArgs e)
        {
            
         Hide();
         Globals.registerWindow.Show();

        }
    }
}
