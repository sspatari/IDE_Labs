
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
    public partial class MainWindow : Window, INotifyPropertyChanged
    {

        private string _screenText;

        public event PropertyChangedEventHandler PropertyChanged;

        public string screenText
        {

            get
            {
                return _screenText;
            }
            set
            {
                _screenText = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("screenText"));
            }
        }

        ICalculator calculator;

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            screenText = "Haha";
            this.AddHandler(StandartUserControl.PressButton, new RoutedEventHandler(OnPressButton));
        }

        public void OnPressButton(object sender, RoutedEventArgs e)
        {
            Console.WriteLine((e.OriginalSource as FrameworkElement).Name);
            
            switch ((e.OriginalSource as FrameworkElement).Name)
            {
                case "Num0":
                    calculator?.onRegularButton_Click("0");
                    screenText += "a";
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
    }
}
