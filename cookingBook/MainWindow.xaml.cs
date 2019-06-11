using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace cookingBook
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            using (StreamReader sr = new StreamReader(@"..\..\sourceFiles\loginsAndPasswords.txt"))
            {
                string line;
                int count = 1;
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    if (line == login.Text && count % 2 != 0)
                    {
                        if (sr.ReadLine() == password.Password.ToString())
                        {
                            MessageBox.Show("YMNICHKA");
                            return;
                        }
                    }
                    count++;
                }
            }

            MessageBox.Show("!YMNICHKA");
        }

        private void Label_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            registrationWin registration = new registrationWin();
            this.Close();

            registration.Top = 0;

            registration.Left = 0;

            registration.ShowDialog();
            
        }

        private void Password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(((PasswordBox)sender).Password))
            {
                ((Grid)((PasswordBox)e.Source).Parent).Children[1].Visibility = Visibility.Visible;
            }
            else
            {
                ((Grid)((PasswordBox)e.Source).Parent).Children[1].Visibility = Visibility.Hidden;
            }
        }
    }
}
