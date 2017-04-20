using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lab2Calculator
{
    interface ICalculator:INotifyPropertyChanged
    {
        String screenTextHistory { get; set; }
        String screenText { get; set; }
        void onRegularButtonClick(String character);
        void onOperationButtonClick(String operation);
        void onCancelButtonClick();
        void onCancelAllButtonClick();
        void onBackspaceButtonClick();
        void onPowerButtonClick();
        void onInversionButtonClick();
        void onSqrtButtonClick();
        void onResultButtonClick();
    }
}
