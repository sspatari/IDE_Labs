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
    /// Interaction logic for FancyUserControl.xaml
    /// </summary>
    public partial class FancyUserControl : UserControl
    {
        
        public FancyUserControl()
        {
            InitializeComponent();
            FancyUI.DataContext = this;
        }

        public string ScreenText
        {
            get { return (string)GetValue(ScreenTextProperty); }
            set { SetValue(ScreenTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ScreenText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ScreenTextProperty =
            DependencyProperty.Register("ScreenText", typeof(string), typeof(FancyUserControl), new PropertyMetadata("0"));


        public static readonly RoutedEvent PressButton = EventManager.RegisterRoutedEvent(
             "PressButton", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(FancyUserControl));

        // Provide CLR accessors for the event
        public event RoutedEventHandler OnPressButton
        {
            add { AddHandler(PressButton, value); }
            remove { RemoveHandler(PressButton, value); }
        }

        private void clearAllButton_Click(object sender, RoutedEventArgs e)
        {
            (e.OriginalSource as FrameworkElement).Name = "ClearAll";
            RaiseEvent(new RoutedEventArgs(PressButton, sender));
            e.Handled = true;
        }

        private void inversionButton_Click(object sender, RoutedEventArgs e)
        {
            (e.OriginalSource as FrameworkElement).Name = "Inverse";
            RaiseEvent(new RoutedEventArgs(PressButton, sender));
            e.Handled = true;
        }

        private void sqrtButton_Click(object sender, RoutedEventArgs e)
        {
            (e.OriginalSource as FrameworkElement).Name = "Sqrt";
            RaiseEvent(new RoutedEventArgs(PressButton, sender));
            e.Handled = true;
        }

        private void resultButton_Click(object sender, RoutedEventArgs e)
        {
            (e.OriginalSource as FrameworkElement).Name = "Result";
            RaiseEvent(new RoutedEventArgs(PressButton, sender));
            e.Handled = true;
        }

        private void additionButton_Click(object sender, RoutedEventArgs e)
        {
            (e.OriginalSource as FrameworkElement).Name = "Add";
            RaiseEvent(new RoutedEventArgs(PressButton, sender));
            e.Handled = true;
        }

        private void subtractButton_Click(object sender, RoutedEventArgs e)
        {
            (e.OriginalSource as FrameworkElement).Name = "Subtract";
            RaiseEvent(new RoutedEventArgs(PressButton, sender));
            e.Handled = true;
        }

        private void multiplyButton_Click(object sender, RoutedEventArgs e)
        {
            (e.OriginalSource as FrameworkElement).Name = "Multiply";
            RaiseEvent(new RoutedEventArgs(PressButton, sender));
            e.Handled = true;
        }

        private void divisionButton_Click(object sender, RoutedEventArgs e)
        {
            (e.OriginalSource as FrameworkElement).Name = "Divide";
            RaiseEvent(new RoutedEventArgs(PressButton, sender));
            e.Handled = true;
        }

        private void dotButton_Click(object sender, RoutedEventArgs e)
        {
            (e.OriginalSource as FrameworkElement).Name = "Dot";
            RaiseEvent(new RoutedEventArgs(PressButton, sender));
            e.Handled = true;
        }

        private void powerButton_Click(object sender, RoutedEventArgs e)
        {
            (e.OriginalSource as FrameworkElement).Name = "Power";
            RaiseEvent(new RoutedEventArgs(PressButton, sender));
            e.Handled = true;
        }

        private void digit0Button_Click(object sender, RoutedEventArgs e)
        {
            (e.OriginalSource as FrameworkElement).Name = "Num0";
            RaiseEvent(new RoutedEventArgs(PressButton, sender));
            e.Handled = true;
        }

        private void digit1Button_Click(object sender, RoutedEventArgs e)
        {
            (e.OriginalSource as FrameworkElement).Name = "Num1";
            RaiseEvent(new RoutedEventArgs(PressButton, sender));
            e.Handled = true;
        }

        private void digit2Button_Click(object sender, RoutedEventArgs e)
        {
            (e.OriginalSource as FrameworkElement).Name = "Num2";
            RaiseEvent(new RoutedEventArgs(PressButton, sender));
            e.Handled = true;
        }

        private void digit3Button_Click(object sender, RoutedEventArgs e)
        {
            (e.OriginalSource as FrameworkElement).Name = "Num3";
            RaiseEvent(new RoutedEventArgs(PressButton, sender));
            e.Handled = true;
        }

        private void digit4Button_Click(object sender, RoutedEventArgs e)
        {
            (e.OriginalSource as FrameworkElement).Name = "Num4";
            RaiseEvent(new RoutedEventArgs(PressButton, sender));
            e.Handled = true;
        }

        private void digit5Button_Click(object sender, RoutedEventArgs e)
        {
            (e.OriginalSource as FrameworkElement).Name = "Num5";
            RaiseEvent(new RoutedEventArgs(PressButton, sender));
            e.Handled = true;
        }

        private void digit6Button_Click(object sender, RoutedEventArgs e)
        {
            (e.OriginalSource as FrameworkElement).Name = "Num6";
            RaiseEvent(new RoutedEventArgs(PressButton, sender));
            e.Handled = true;
        }

        private void digit7Button_Click(object sender, RoutedEventArgs e)
        {
            (e.OriginalSource as FrameworkElement).Name = "Num7";
            RaiseEvent(new RoutedEventArgs(PressButton, sender));
            e.Handled = true;
        }

        private void digit8Button_Click(object sender, RoutedEventArgs e)
        {
            (e.OriginalSource as FrameworkElement).Name = "Num8";
            RaiseEvent(new RoutedEventArgs(PressButton, sender));
            e.Handled = true;
        }

        private void digit9Button_Click(object sender, RoutedEventArgs e)
        {
            (e.OriginalSource as FrameworkElement).Name = "Num9";
            RaiseEvent(new RoutedEventArgs(PressButton, sender));
            e.Handled = true;
        }

        private void fancyButton_Click(object sender, RoutedEventArgs e)
        {
            (e.OriginalSource as FrameworkElement).Name = "ChangeUI";
            RaiseEvent(new RoutedEventArgs(PressButton, sender));
            e.Handled = true;
        }
    }
}
