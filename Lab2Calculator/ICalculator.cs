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
        void onRegularButton_Click(String text);
        void onCancelButton_Click(String text);
        void onInversionButton_Click(String text);
        void onSqrtButton_Click(String text);
        void onResultButton_Click(String text);
    }

}
