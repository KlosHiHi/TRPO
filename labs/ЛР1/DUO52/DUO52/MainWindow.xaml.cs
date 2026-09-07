using Microsoft.Win32;
using System.Windows;

namespace DUO52
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

        private void Authorization_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            Registration reg = new();
            reg.ShowDialog();
        }

        private void Import_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new()
            {
                Filter = "(*.csv)|*.csv|(*.txt)|*.txt",
                Title = "Выберите файл для импорта"
            };

            if (!dialog.ShowDialog() == true)
            {
                MessageBox.Show("Ошибка");
                return;
            }
        }

        private void Export_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new()
            {
                Filter = "(*.csv)|*.csv|(*.txt)|*.txt",
                Title = "Выберите путь для сохранения"
            };

            if (!dialog.ShowDialog() == true)
            {
                MessageBox.Show("Ошибка");
                return;
            }
        }
    }
}