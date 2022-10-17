using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;


namespace VetClinic
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        
        public Register()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void BtnSignUp_Click(object sender, RoutedEventArgs e)
        {
            if (!AreInputsValid()) return;
            int.TryParse(PhoneInput.Text, out int phone);
            int role=0;
            if(RbnAdmin.IsChecked == true)
            {
                role = 0;
            }
            if (RbnVet.IsChecked == true)
            {
                role = 1;
            }
            try
            {
                User newUser= new User();
                newUser.username = UserNameInput.Text;
                newUser.email = EmailInput.Text;
                newUser.name = NameInput.Text;
                newUser.phone = phone;
                newUser.password = PasswordInput.Password;
                newUser.role = role;


                 //User newUser = new User(UserNameInput.Text, NameInput.Text, EmailInput.Text, PasswordInput.Password, phone, role);
                //
                // dbContext.Users.Add(newUser);
                // dbContext.SaveChanges(); // SystemException
                ResetFields();
                Globals.mainWindow.Show();

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(this, ex.Message, "Input error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (SystemException ex)
            {
                MessageBox.Show(this, "Error reading from database\n" + ex.Message, "Database error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void BtnLogIn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Globals.loginWindow.Show();
        }

        private bool AreInputsValid()
        {
            
                 string userName = UserNameInput.Text;
                if (userName.Length < 2 || userName.Length > 30)

                {
                    MessageBox.Show(this, "Userame must be 2 - 30 characters long", "Input error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }

                string email = EmailInput.Text;
                if (email.Length > 100 || !Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$") )

                {
                    MessageBox.Show(this, "Invalid email", "Input error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }

                string password = PasswordInput.Password;
                if (!Regex.IsMatch(password, @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,50}$"))

                {
                    MessageBox.Show(this, "At least one upper case english letter • At least one lower case english letter • At least one digit • At least one special character • Minimum 8 in length• Maxinum 50 in length", "Input error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }

                string repPassword = RepPasswordInput.Password;
                if (repPassword != password)

                {
                    MessageBox.Show(this, "Password are not matching", "Input error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }

                string name = NameInput.Text;
                if (name.Length < 2 || name.Length > 30)

                {
                    MessageBox.Show(this, "Name must be 2 - 30 characters long", "Input error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }

            try
                {  
                if ((!int.TryParse(PhoneInput.Text, out int phone)) || phone < 1000000000)

                {
                    MessageBox.Show(this, "Phone must be 10 digits", "Input error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
                }
                catch (SystemException ex)
                {
                    Console.WriteLine("Error to parse: " + ex.Message);
                    return false;
                }

                if(RbnVet.IsChecked == false || RbnAdmin.IsChecked == false)
                {
                MessageBox.Show(this, "Please choose admin or vet", "Input error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
               }
           
                return true;  
            
        }

        private void ResetFields()
        {
            NameInput.Text = "";
            UserNameInput.Text = "";
            PasswordInput.Password = "";
            EmailInput.Text = "";
            PhoneInput.Text = "";
            

        }
    }
}
