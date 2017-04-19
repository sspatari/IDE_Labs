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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab2Calculator
{
    /// <summary>
    /// Interaction logic for StandartUserControl.xaml
    /// </summary>
    public partial class StandartUserControl : UserControl
    {
        public string ScreenText
        {
            get { return (string)GetValue(ScreenTextProperty); }
            set { SetValue(ScreenTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ScreenText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ScreenTextProperty =
            DependencyProperty.Register("ScreenText", typeof(string), typeof(StandartUserControl), new PropertyMetadata("0"));

        public StandartUserControl()
        {
            InitializeComponent();
            StandartUI.DataContext = this;
        }

        private void clearAllButton_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(e.ToString());
        }

        private void inversionButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sqrtButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void resultButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void additionButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void multiplyButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void powerButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void digit0Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void digit1Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void digit2Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void digit3Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void digit4Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void digit5Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void digit6Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void digit7Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void digit8Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void digit9Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void divisionButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dotButton_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}
