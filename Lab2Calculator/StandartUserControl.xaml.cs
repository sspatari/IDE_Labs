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
        public StandartUserControl()
        {
            InitializeComponent();
            StandartUI.DataContext = this;
            this.Focusable = true;
        }
        
        #region Dependency Properties

        public string ScreenText
        {
            get { return (string)GetValue(ScreenTextProperty); }
            set { SetValue(ScreenTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ScreenText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ScreenTextProperty =
            DependencyProperty.Register("ScreenText", typeof(string), typeof(StandartUserControl), new PropertyMetadata("0"));

        public string ScreenTextHistory
        {
            get { return (string)GetValue(ScreenTextHistoryProperty); }
            set { SetValue(ScreenTextHistoryProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ScreenText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ScreenTextHistoryProperty =
            DependencyProperty.Register("ScreenTextHistory", typeof(string), typeof(StandartUserControl), new PropertyMetadata("0"));


        public static readonly RoutedEvent PressButton = EventManager.RegisterRoutedEvent(
             "PressButton", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(StandartUserControl));

        // Provide CLR accessors for the event
        public event RoutedEventHandler OnPressButton
        {
            add { AddHandler(PressButton, value); }
            remove { RemoveHandler(PressButton, value); }
        }

        #endregion

        #region Handlers

        private void RaiseButtonEvent(object sender, RoutedEventArgs e, String name)
        {
            (e.OriginalSource as FrameworkElement).Name = name;
            RaiseEvent(new RoutedEventArgs(PressButton, sender));
            e.Handled = true;
            this.Focus();
        }

        private void clearAllButton_Click(object sender, RoutedEventArgs e)
        {
            RaiseButtonEvent(sender, e, "ClearAll");
        }

        private void inversionButton_Click(object sender, RoutedEventArgs e)
        {
            RaiseButtonEvent(sender, e, "Inverse");
        }

        private void sqrtButton_Click(object sender, RoutedEventArgs e)
        {
            RaiseButtonEvent(sender, e, "Sqrt");
        }

        private void resultButton_Click(object sender, RoutedEventArgs e)
        {
            RaiseButtonEvent(sender, e, "Result");
        }

        private void additionButton_Click(object sender, RoutedEventArgs e)
        {
            RaiseButtonEvent(sender, e, "Add");
        }

        private void subtractButton_Click(object sender, RoutedEventArgs e)
        {
            RaiseButtonEvent(sender, e, "Subtract");
        }

        private void multiplyButton_Click(object sender, RoutedEventArgs e)
        {
            RaiseButtonEvent(sender, e, "Multiply");
        }

        private void divisionButton_Click(object sender, RoutedEventArgs e)
        {
            RaiseButtonEvent(sender, e, "Divide");
        }

        private void dotButton_Click(object sender, RoutedEventArgs e)
        {
            RaiseButtonEvent(sender, e, "Dot");
        }

        private void powerButton_Click(object sender, RoutedEventArgs e)
        {
            RaiseButtonEvent(sender, e, "Power");
        }

        private void digit0Button_Click(object sender, RoutedEventArgs e)
        {
            RaiseButtonEvent(sender, e, "Num0");
        }

        private void digit1Button_Click(object sender, RoutedEventArgs e)
        {
            RaiseButtonEvent(sender, e, "Num1");
        }

        private void digit2Button_Click(object sender, RoutedEventArgs e)
        {
            RaiseButtonEvent(sender, e, "Num2");
        }

        private void digit3Button_Click(object sender, RoutedEventArgs e)
        {
            RaiseButtonEvent(sender, e, "Num3");
        }

        private void digit4Button_Click(object sender, RoutedEventArgs e)
        {
            RaiseButtonEvent(sender, e, "Num4");
        }

        private void digit5Button_Click(object sender, RoutedEventArgs e)
        {
            RaiseButtonEvent(sender, e, "Num5");
        }

        private void digit6Button_Click(object sender, RoutedEventArgs e)
        {
            RaiseButtonEvent(sender, e, "Num6");
        }

        private void digit7Button_Click(object sender, RoutedEventArgs e)
        {
            RaiseButtonEvent(sender, e, "Num7");
        }

        private void digit8Button_Click(object sender, RoutedEventArgs e)
        {
            RaiseButtonEvent(sender, e, "Num8");
        }

        private void digit9Button_Click(object sender, RoutedEventArgs e)
        {
            RaiseButtonEvent(sender, e, "Num9");
        }

        private void fancyButton_Click(object sender, RoutedEventArgs e)
        {
            RaiseButtonEvent(sender, e, "ChangeUI");
        }

        private void paranthesysRightButton_Click(object sender, RoutedEventArgs e)
        {
            RaiseButtonEvent(sender, e, "RightParanthesys");
        }

        private void paranthesysLeftButton_Click(object sender, RoutedEventArgs e)
        {
            RaiseButtonEvent(sender, e, "LeftParanthesys");
        }

        private void backspaceButton_Click(object sender, RoutedEventArgs e)
        {
            RaiseButtonEvent(sender, e, "Backspace");
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            RaiseButtonEvent(sender, e, "Clear");
        }
        #endregion

    }
}
