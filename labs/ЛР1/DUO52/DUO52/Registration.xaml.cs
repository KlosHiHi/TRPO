using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DUO52
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void ConfirmRegistration_Click(object sender, RoutedEventArgs e)
        {
            var login = LoginTextBox.Text;
            var pass = PasswordTextBox.Text;
            File.WriteAllText("pass.txt", $"{login} - {pass}");
        }
    }
}
