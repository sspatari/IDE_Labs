using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Calculator
{
    class CalculatorClass : ICalculator
    {
        private string _text;

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public string screenText
        {
            get
            {
                return _text;
            }

            set
            {
                _text = value;
                PropertyChanged(this, new PropertyChangedEventArgs("screenText"));
            }
        }

        public void onCancelButton_Click()
        {
            
        }

        public void onInversionButton_Click()
        {
           
        }

        public String onRegularButton_Click(String character)
        {
            screenText = screenText + character;
            return screenText;
        }

        public void onResultButton_Click()
        {
            
        }

        public void onSqrtButton_Click()
        {
            
        }
    }
}
