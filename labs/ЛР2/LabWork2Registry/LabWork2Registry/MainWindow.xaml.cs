using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LabWork2Registry
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {

            if (String.IsNullOrEmpty(loginTextBox.Text))
            {
                MessageBox.Show("Отсутствует логин");
                return;
            }

            else if (!Regex.IsMatch(passwordTextBox.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[/+!@#$%^&*(),.?"":{}|<>]).{8,30}$")) {
                MessageBox.Show("Пароль не соответствует требованиям \n(латиница, прописные и заглавные буквы, от 8 до 30 символов, специальные знаки)");
                return;
            }

            else if (!String.Equals(passwordTextBox.Text, confirmPasswordTextBox.Text))
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }
            else
            {
                MessageBox.Show("Вы были успешно зарегистрированы!!!");
            }
        }
    }
}