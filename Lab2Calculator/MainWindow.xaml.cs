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

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            screenText = "Haha";
            this.AddHandler(StandartUserControl.PressButton, new RoutedEventHandler(OnPressButton));
        }

        public void OnPressButton(object sender, RoutedEventArgs e)
        {
            screenText += "a";
            Console.WriteLine((e.OriginalSource as FrameworkElement).Name);
            
            //TODO: list below all button names and the corresponding handlers, if any
            switch ((e.OriginalSource as FrameworkElement).Name)
            {
                default:
                    break;
            };
        }
    }
}
