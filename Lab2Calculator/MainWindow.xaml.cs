
﻿using System;
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
            this.DataContext = calculator;
            this.AddHandler(StandartUserControl.PressButton, new RoutedEventHandler(OnPressButton));
            this.AddHandler(FancyUserControl.PressButton, new RoutedEventHandler(OnPressButton));
        }

        #endregion

        #region Handlers

        public void OnPressButton(object sender, RoutedEventArgs e)
        {
            Console.WriteLine((e.OriginalSource as FrameworkElement).Name);
            switch ((e.OriginalSource as FrameworkElement).Name)
            {
                case "Num0":
                    calculator?.onRegularButton_Click("0");
                    break;
                case "Num1":
                    calculator?.onRegularButton_Click("1");
                    break;
                case "Num2":
                    calculator?.onRegularButton_Click("2");
                    break;
                case "Num3":
                    calculator?.onRegularButton_Click("3");
                    break;
                case "Num4":
                    calculator?.onRegularButton_Click("4");
                    break;
                case "Num5":
                    calculator?.onRegularButton_Click("5");
                    break;
                case "Num6":
                    calculator?.onRegularButton_Click("6");
                    break;
                case "Num7":
                    calculator?.onRegularButton_Click("7");
                    break;
                case "Num8":
                    calculator?.onRegularButton_Click("8");
                    break;
                case "Num9":
                    calculator?.onRegularButton_Click("9");
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
                    calculator?.onRegularButton_Click("^");
                    break;
                case "Dot":
                    calculator?.onRegularButton_Click(".");
                    break;
                case "Add":
                    calculator?.onRegularButton_Click("+");
                    break;
                case "Divide":
                    calculator?.onRegularButton_Click("/");
                    break;
                case "Multiply":
                    calculator?.onRegularButton_Click("*");
                    break;
                case "Subtract":
                    calculator?.onRegularButton_Click("-");
                    break;
                case "Sqrt":
                    calculator?.onSqrtButton_Click("");
                    break;
                case "Inverse":
                    calculator?.onInversionButton_Click("");
                    break;
                case "ClearAll":
                    calculator?.onCancelButton_Click("");
                    break;
                default:
                    break;
            };
        }

        #endregion
    }
}
