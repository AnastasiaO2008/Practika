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

namespace Practika
{
    /// <summary>
    /// Логика взаимодействия для TABLE.xaml
    /// </summary>
    public partial class TABLE : Window
    {
        // Переменная для хранения выбранного стола
        private int selectedTable = 0;

        public TABLE()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Выйти из аккаунта?", "Выход",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

      

        private void MainSpace_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Main Space selected", "Room Selection",
                           MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Table1_Click(object sender, RoutedEventArgs e)
        {
            // Код для стола 1
            selectedTable = 1;
            
            MessageBox.Show($"Table {selectedTable} selected", "Table Selection",
                           MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Table2_Click(object sender, RoutedEventArgs e)
        {
            // Код для стола 2
            selectedTable = 2;
            
            MessageBox.Show($"Table {selectedTable} selected", "Table Selection",
                           MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Table3_Click(object sender, RoutedEventArgs e)
        {
            // Код для стола 3
            selectedTable = 3;
           
            MessageBox.Show($"Table {selectedTable} selected", "Table Selection",
                           MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void SelectTable_Click(object sender, RoutedEventArgs e)
        {
            // Код для кнопки SELECT THE TABLE
            if (selectedTable > 0)
            {
                MessageBox.Show($"Table {selectedTable} confirmed!\nProceeding to order...",
                              "Table Confirmation",
                              MessageBoxButton.OK, MessageBoxImage.Information);

                // Здесь можно открыть новое окно для заказа
                // Например:
                // OrderWindow orderWindow = new OrderWindow(selectedTable);
                // orderWindow.Show();
                // this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a table first!", "No Table Selected",
                              MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}