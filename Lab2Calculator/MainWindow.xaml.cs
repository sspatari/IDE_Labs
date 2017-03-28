using System.Windows;

namespace Lab2Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ICalculator calculator;

        public MainWindow()
        {
            InitializeComponent();
            calculator = new CalculatorClass();
            
        }

        private void clearAllButton_Click(object sender, RoutedEventArgs e)
        {
            calculator.onCancelButton_Click();
        }

        private void inversionButton_Click(object sender, RoutedEventArgs e)
        {
            calculator.onInversionButton_Click();
        }

        private void sqrtButton_Click(object sender, RoutedEventArgs e)
        {
            calculator.onSqrtButton_Click();
        }

        private void resultButton_Click(object sender, RoutedEventArgs e)
        {
            calculator.onResultButton_Click();
        }

        private void dotButton_Click(object sender, RoutedEventArgs e)
        {
            calculator.onRegularButton_Click(".");
        }
        
        private void additionButton_Click(object sender, RoutedEventArgs e)
        {
            calculator.onRegularButton_Click("+");
        }

        private void multiplyButton_Click(object sender, RoutedEventArgs e)
        {
            calculator.onRegularButton_Click("*");
        }

        private void divisionButton_Click(object sender, RoutedEventArgs e)
        {
            calculator.onRegularButton_Click("/");
        }

        private void powerButton_Click(object sender, RoutedEventArgs e)
        {
            calculator.onRegularButton_Click("^");
        }

        private void digit0Button_Click(object sender, RoutedEventArgs e)
        {
            calculator.onRegularButton_Click("0");

        }

        private void digit1Button_Click(object sender, RoutedEventArgs e)
        {
            calculator.onRegularButton_Click("1");

        }

        private void digit2Button_Click(object sender, RoutedEventArgs e)
        {
            calculator.onRegularButton_Click("2");

        }

        private void digit3Button_Click(object sender, RoutedEventArgs e)
        {
            calculator.onRegularButton_Click("3");
        }

        private void digit4Button_Click(object sender, RoutedEventArgs e)
        {
            calculator.onRegularButton_Click("4");
        }

        private void digit5Button_Click(object sender, RoutedEventArgs e)
        {
            calculator.onRegularButton_Click("5");
        }

        private void digit6Button_Click(object sender, RoutedEventArgs e)
        {
            calculator.onRegularButton_Click("6");
        }

        private void digit7Button_Click(object sender, RoutedEventArgs e)
        {
            calculator.onRegularButton_Click("7");

        }

        private void digit8Button_Click(object sender, RoutedEventArgs e)
        {
            calculator.onRegularButton_Click("8");
        }

        private void digit9Button_Click(object sender, RoutedEventArgs e)
        {
            calculator.onRegularButton_Click("9");

        }
    }
}
