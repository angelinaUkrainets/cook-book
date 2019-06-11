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

        private void Register_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            User user = new User() { Name = name.Text, Login = login.Text, Email = email.Text,
                Number = number.Text, Surname = surname.Text };
            
            if(password.Password == password2.Password)
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
