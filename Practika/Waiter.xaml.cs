using System;
using System.Windows;
using System.Windows.Controls;

namespace Practika
{
    public partial class Waiter : Window
    {
        public Waiter()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Orders button clicked!");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Table button clicked!");
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Table button clicked!");
        }

        private void PhotoButton_Click3(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Выйти из аккаунта?", "Выход",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }


        private void PhotoButton2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Right photo button clicked!");
        }

        private void CircleButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Circle button clicked!");
        }
        private void PhotoButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("photo button clicked!");
        }
    }
}
