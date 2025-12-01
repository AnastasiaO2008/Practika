using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Practika
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Кнопка Выход
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        // Кнопка Регистрации
        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string first = FirstNameBox.Text;
            string last = LastNameBox.Text;
            string code = CodeBox.Text;

            if (string.IsNullOrWhiteSpace(first) ||
                string.IsNullOrWhiteSpace(last) ||
                string.IsNullOrWhiteSpace(code))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            MessageBox.Show(
                $"Регистрация успешна!\nИмя: {first}\nФамилия: {last}\nКод: {code}");
        }
    }
}
