using System;
using System.Windows;

namespace Practika
{
    /// <summary>
    /// Логика взаимодействия для Order.xaml
    /// </summary>
    public partial class Order : Window
    {
        int count1 = 1;
        int count2 = 1;

        public Order()
        {
            InitializeComponent();

            // Tiramisu buttons
            BtnPlus1.Click += BtnPlus1_Click;
            BtnMinus1.Click += BtnMinus1_Click;

            // Cappuccino buttons
            BtnPlus2.Click += BtnPlus2_Click;
            BtnMinus2.Click += BtnMinus2_Click;
        }

        // Increase Tiramisu
        private void BtnPlus1_Click(object sender, RoutedEventArgs e)
        {
            count1++;
            Count1.Text = count1.ToString();
            UpdateTotal();
        }

        // Decrease Tiramisu
        private void BtnMinus1_Click(object sender, RoutedEventArgs e)
        {
            if (count1 > 0)
                count1--;

            Count1.Text = count1.ToString();
            UpdateTotal();
        }

        // Increase Cappuccino
        private void BtnPlus2_Click(object sender, RoutedEventArgs e)
        {
            count2++;
            Count2.Text = count2.ToString();
            UpdateTotal();
        }

        // Decrease Cappuccino
        private void BtnMinus2_Click(object sender, RoutedEventArgs e)
        {
            if (count2 > 0)
                count2--;

            Count2.Text = count2.ToString();
            UpdateTotal();
        }

        // Recalculate total cost
        private void UpdateTotal()
        {
            int total = count1 * 400 + count2 * 200;
            TotalPriceText.Text = $"{total} rub";
        }
    }
}
