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
        String screenText { get; set; }
        void onDigit0Button_Click(object sender, RoutedEventArgs e);
        void onDigit1Button_Click(object sender, RoutedEventArgs e);
        void onDigit2Button_Click(object sender, RoutedEventArgs e);
        void onDigit3Button_Click(object sender, RoutedEventArgs e);
        void onDigit4Button_Click(object sender, RoutedEventArgs e);
        void onDigit5Button_Click(object sender, RoutedEventArgs e);
        void onDigit6Button_Click(object sender, RoutedEventArgs e);
        void onDigit7Button_Click(object sender, RoutedEventArgs e);
        void onDigit8Button_Click(object sender, RoutedEventArgs e);
        void onDigit9Button_Click(object sender, RoutedEventArgs e);
        void onPointButton_Click(object sender, RoutedEventArgs e);
        void onEqualSignButton_Click(object sender, RoutedEventArgs e);
        void onPlusButton_Click(object sender, RoutedEventArgs e);
        void onMinusButton_Click(object sender, RoutedEventArgs e);
        void onDivButton_Click(object sender, RoutedEventArgs e);
        void onMultiplicationButton_Click(object sender, RoutedEventArgs e);
        void onCancelButton_Click(object sender, RoutedEventArgs e);
        void onInversionButton_Click(object sender, RoutedEventArgs e);
        void onSqrtButton_Click(object sender, RoutedEventArgs e);
    }

}
