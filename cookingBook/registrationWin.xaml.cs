using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

namespace cookingBook
{
    /// <summary>
    /// Логика взаимодействия для registrationWin.xaml
    /// </summary>
    public partial class registrationWin : Window
    {
        public registrationWin()
        {
            InitializeComponent();
        }

        public static bool IsValidEmailAddress(string s)
        {
            Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            return regex.IsMatch(s);
        }

        public static bool IsValidPhoneNumber(string s)
        {
            Regex regex = new Regex(@"^[0-9\-\+]{9,15}$");
            return regex.IsMatch(s);
        }

        private void Register_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //MessageBox.Show(IsValidEmailAddress(email.Text).ToString())

            User user = new User()
            {
                Name = name.Text,
                Login = login.Text,
                Surname = surname.Text
            };

            if (IsValidEmailAddress(email.Text))
            {
                user.Email = email.Text;
            }
            else
                MessageBox.Show("Not correct e-mail adress");

            if(IsValidPhoneNumber(number.Text))
            {
                user.Number = number.Text;
            }
            else
                MessageBox.Show("Not correct phone number");


            if (password.Password == password2.Password)
            {
                user.Password = password.Password.ToString();
            }

            if (male.IsChecked == true)
                user.IsMale = true;
            if (female.IsChecked == true)
                user.IsMale = false;

            MessageBox.Show($"{user.Password}, {user.IsMale}");
        }
    }
}
