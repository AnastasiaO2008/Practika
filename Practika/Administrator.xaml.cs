using System;
using System.Windows;

namespace Practika
{
    public partial class Administrator : Window
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Открытие раздела SUPPLIES");

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Открытие раздела BOOKING");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Открытие раздела PRODUCTS");
        }

        private void PhotoButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Открытие профиля пользователя");
        }

        private void PhotoButton2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Уведомления");
        }

        private void PhotoButton_Click3(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Выйти из аккаунта?", "Выход",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }
    }
}
