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
        String screenText { get; set; }
        void onRegularButton_Click(String character);
        void onCancelButton_Click();
        void onInversionButton_Click();
        void onSqrtButton_Click();
        void onResultButton_Click();
    }
}
