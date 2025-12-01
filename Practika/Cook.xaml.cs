using System;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;
using System.Windows.Media.Imaging;

namespace Practika
{
    /// <summary>
    /// Логика взаимодействия для Cook.xaml
    /// </summary>
    public partial class Cook : Window
    {
        public Cook()
        {
            InitializeComponent();
        }

        // BUTTON: MENU
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Открываем меню!");
        }

        // BUTTON: ORDERS
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Открываем заказы!");
        }

        // BUTTON: RECIPES
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Открываем рецепты!");
        }

        // ROUND BUTTON (little icon)
        private void PhotoButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Нажата круглая кнопка!");
        }

        // BELL BUTTON
        private void PhotoButton2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Уведомления!");
        }

        // EXIT BUTTON
        private void PhotoButton_Click3(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
