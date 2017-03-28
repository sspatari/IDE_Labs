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
            screenText = "0";
        }

        public void onInversionButton_Click()
        {
          
        }

        public void onRegularButton_Click(String character)
        {
            screenText = character;
        }

        public void onResultButton_Click()
        {
            
        }

        public void onSqrtButton_Click()
        {
            
        }
    }
}
