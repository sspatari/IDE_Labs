using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        #region UI styles declaration

        public enum UIStyles
        {
            Standart,
            Fancy
        }

        // Using a DependencyProperty as the backing store for UIStyle.  This enables animation, styling, binding, etc... 
        private static readonly DependencyPropertyKey UIStylePropertyKey = 
            DependencyProperty.RegisterReadOnly("UIStyle", typeof(UIStyles), typeof(MainWindow), new FrameworkPropertyMetadata(UIStyles.Standart));

        public static readonly DependencyProperty UIStyleProperty = MainWindow.UIStylePropertyKey.DependencyProperty;

        public UIStyles UIStyle
        {
            get { return (UIStyles)GetValue(UIStyleProperty); }
            set { SetValue(UIStylePropertyKey, value); }
        }

        #endregion

        #region Fields

        ICalculator calculator;

        #endregion

        #region Constructors

        public MainWindow()
        {
            InitializeComponent();
            calculator = new CalculatorClass();
            this.DataContext = calculator;
            this.AddHandler(StandartUserControl.PressButton, new RoutedEventHandler(OnPressButton));
            this.AddHandler(FancyUserControl.PressButton, new RoutedEventHandler(OnPressButton));
            this.KeyDown += MainWindow_KeyDown;
            //this.Focus();
        }

        
        #endregion

        #region Handlers

        public void OnPressButton(object sender, RoutedEventArgs e)
        {
            Console.WriteLine((e.OriginalSource as FrameworkElement).Name);
            switch ((e.OriginalSource as FrameworkElement).Name)
            {
                case "Num0":
                    calculator?.onRegularButtonClick("0");
                    break;
                case "Num1":
                    calculator?.onRegularButtonClick("1");
                    break;
                case "Num2":
                    calculator?.onRegularButtonClick("2");
                    break;
                case "Num3":
                    calculator?.onRegularButtonClick("3");
                    break;
                case "Num4":
                    calculator?.onRegularButtonClick("4");
                    break;
                case "Num5":
                    calculator?.onRegularButtonClick("5");
                    break;
                case "Num6":
                    calculator?.onRegularButtonClick("6");
                    break;
                case "Num7":
                    calculator?.onRegularButtonClick("7");
                    break;
                case "Num8":
                    calculator?.onRegularButtonClick("8");
                    break;
                case "Num9":
                    calculator?.onRegularButtonClick("9");
                    break;
                case "ChangeUI":
                    switch (UIStyle)
                    {
                        case UIStyles.Standart:
                            UIStyle = UIStyles.Fancy;
                            StandartView.Visibility = Visibility.Hidden;
                            FancyView.Visibility = Visibility.Visible;
                            break;
                        case UIStyles.Fancy:
                            UIStyle = UIStyles.Standart;
                            StandartView.Visibility = Visibility.Visible;
                            FancyView.Visibility = Visibility.Hidden;
                            break;
                    }
                    break;
                case "Power":
                    calculator?.onPowerButtonClick();
                    break;
                case "Dot":
                    calculator?.onDotButtonClick();
                    break;
                case "Add":
                    calculator?.onOperationGradeOneButtonClick("+");
                    break;
                case "Divide":
                    calculator?.onOperationGradeTwoButtonClick("/");
                    break;
                case "Multiply":
                    calculator?.onOperationGradeTwoButtonClick("*");
                    break;
                case "Subtract":
                    calculator?.onOperationGradeOneButtonClick("-");
                    break;
                case "Sqrt":
                    calculator?.onSqrtButtonClick();
                    break;
                case "Inverse":
                    calculator?.onInversionButtonClick();
                    break;
                case "ClearAll":
                    calculator?.onCancelAllButtonClick();
                    break;
                case "Result":
                    calculator?.onResultButtonClick();
                    break;
                case "Clear":
                    calculator?.onCancelButtonClick();
                    break;
                case "LeftParanthesys":
                    calculator?.onLeftParanthesesClick();
                    break;
                case "RightParanthesys":
                    calculator?.onRightParanthesesClick();
                    break;
                case "Backspace":
                    calculator?.onBackspaceButtonClick();
                    break;
                default:
                    break;
            };
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine($"Pressed {e.Key}");
            switch (e.Key)
            {
                case Key.NumPad0:
                case Key.D0:
                    calculator?.onRegularButtonClick("0");
                    break;
                case Key.NumPad1:
                case Key.D1:
                    calculator?.onRegularButtonClick("1");
                    break;
                case Key.NumPad2:
                case Key.D2:
                    calculator?.onRegularButtonClick("2");
                    break;
                case Key.NumPad3:
                case Key.D3:
                    calculator?.onRegularButtonClick("3");
                    break;
                case Key.NumPad4:
                case Key.D4:
                    calculator?.onRegularButtonClick("4");
                    break;
                case Key.NumPad5:
                case Key.D5:
                    calculator?.onRegularButtonClick("5");
                    break;
                case Key.NumPad6:
                case Key.D6:
                    calculator?.onRegularButtonClick("6");
                    break;
                case Key.NumPad7:
                case Key.D7:
                    calculator?.onRegularButtonClick("7");
                    break;
                case Key.NumPad8:
                case Key.D8:
                    calculator?.onRegularButtonClick("8");
                    break;
                case Key.NumPad9:
                case Key.D9:
                    calculator?.onRegularButtonClick("9");
                    break;
                case Key.Back:
                    calculator?.onBackspaceButtonClick();
                    break;
                case Key.Multiply:
                    calculator?.onOperationGradeTwoButtonClick("*");
                    break;
                case Key.Divide:
                    calculator?.onOperationGradeTwoButtonClick("/");
                    break;
                case Key.Add:
                    calculator?.onOperationGradeOneButtonClick("+");
                    break;
                case Key.Subtract:
                    calculator?.onOperationGradeOneButtonClick("-");
                    break;
                case Key.Enter:
                    calculator?.onResultButtonClick();
                    break;
                case Key.OemPeriod:
                    calculator?.onDotButtonClick();
                    break;
                case Key.OemCloseBrackets:
                    calculator?.onRightParanthesesClick();
                    break;
                case Key.OemOpenBrackets:
                    calculator?.onLeftParanthesesClick();
                    break;
                case Key.Delete:
                    calculator?.onCancelButtonClick();
                    break;
            }
        }

        #endregion
               
    }
}