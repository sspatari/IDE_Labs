using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lab2Calculator
{
    interface ICalculator
    {
        void digit0Button_Click(object sender, RoutedEventArgs e);
        void digit1Button_Click(object sender, RoutedEventArgs e);
        void digit2Button_Click(object sender, RoutedEventArgs e);
        void digit3Button_Click(object sender, RoutedEventArgs e);
        void digit4Button_Click(object sender, RoutedEventArgs e);
        void digit5Button_Click(object sender, RoutedEventArgs e);
        void digit6Button_Click(object sender, RoutedEventArgs e);
        void digit7Button_Click(object sender, RoutedEventArgs e);
        void digit8Button_Click(object sender, RoutedEventArgs e);
        void digit9Button_Click(object sender, RoutedEventArgs e);
        void pointButton_Click(object sender, RoutedEventArgs e);
        void equalSignButton_Click(object sender, RoutedEventArgs e);
        void plusButton_Click(object sender, RoutedEventArgs e);
        void minusButton_Click(object sender, RoutedEventArgs e);
        void multipButton_Click(object sender, RoutedEventArgs e);
        void divButton_Click(object sender, RoutedEventArgs e);
        void multiplicationButton_Click(object sender, RoutedEventArgs e);
        void cancelButton_Click(object sender, RoutedEventArgs e);
        void inversionButton_Click(object sender, RoutedEventArgs e);
        void sqrtButton_Click(object sender, RoutedEventArgs e);
    }
}
