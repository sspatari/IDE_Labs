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
            System.Console.WriteLine("screenTextHistory = " + calculator.screenTextHistory);
            System.Console.WriteLine("screenText = " + calculator.screenText);
            calculator.onRegularButtonClick("9");
            calculator.onRegularButtonClick("9");
            System.Console.WriteLine("screenTextHistory = " + calculator.screenTextHistory);
            System.Console.WriteLine("screenText = " + calculator.screenText);
            calculator.onOperationButtonClick("*");
            System.Console.WriteLine("screenTextHistory = " + calculator.screenTextHistory);
            System.Console.WriteLine("screenText = " + calculator.screenText);
            calculator.onOperationButtonClick("+");
            System.Console.WriteLine("screenTextHistory = " + calculator.screenTextHistory);
            System.Console.WriteLine("screenText = " + calculator.screenText);
            calculator.onRegularButtonClick("7");
            System.Console.WriteLine("screenTextHistory = " + calculator.screenTextHistory);
            System.Console.WriteLine("screenText = " + calculator.screenText);
            calculator.onResultButtonClick();
            System.Console.WriteLine("screenTextHistory = " + calculator.screenTextHistory);
            System.Console.WriteLine("screenText = " + calculator.screenText);
 


        }

        private void clearAllButton_Click(object sender, RoutedEventArgs e)
        {
            calculator.onCancelButtonClick();
        }

        private void inversionButton_Click(object sender, RoutedEventArgs e)
        {
            calculator.onInversionButtonClick();
        }

        private void sqrtButton_Click(object sender, RoutedEventArgs e)
        {
            calculator.onSqrtButtonClick();
        }

        private void resultButton_Click(object sender, RoutedEventArgs e)
        {
            calculator.onResultButtonClick();
        }

        private void dotButton_Click(object sender, RoutedEventArgs e)
        {
            calculator.onRegularButtonClick(".");
        }
        
        private void additionButton_Click(object sender, RoutedEventArgs e)
        {
            calculator.onRegularButtonClick("+");
        }

        private void multiplyButton_Click(object sender, RoutedEventArgs e)
        {
            calculator.onRegularButtonClick("*");
        }

        private void divisionButton_Click(object sender, RoutedEventArgs e)
        {
            calculator.onRegularButtonClick("/");
        }

        private void powerButton_Click(object sender, RoutedEventArgs e)
        {
            calculator.onRegularButtonClick("^");
        }

        private void digit0Button_Click(object sender, RoutedEventArgs e)
        {

            calculator.onRegularButtonClick("0");
        }

        private void digit1Button_Click(object sender, RoutedEventArgs e)
        {
            calculator.onRegularButtonClick("1");

        }

        private void digit2Button_Click(object sender, RoutedEventArgs e)
        {
            calculator.onRegularButtonClick("2");

        }

        private void digit3Button_Click(object sender, RoutedEventArgs e)
        {
            calculator.onRegularButtonClick("3");
        }

        private void digit4Button_Click(object sender, RoutedEventArgs e)
        {
            calculator.onRegularButtonClick("4");
        }

        private void digit5Button_Click(object sender, RoutedEventArgs e)
        {
            calculator.onRegularButtonClick("5");
        }

        private void digit6Button_Click(object sender, RoutedEventArgs e)
        {
            calculator.onRegularButtonClick("6");
        }

        private void digit7Button_Click(object sender, RoutedEventArgs e)
        {
            calculator.onRegularButtonClick("7");

        }

        private void digit8Button_Click(object sender, RoutedEventArgs e)
        {
            calculator.onRegularButtonClick("8");
        }

        private void digit9Button_Click(object sender, RoutedEventArgs e)
        {
            calculator.onRegularButtonClick("9");

        }
    }
}
