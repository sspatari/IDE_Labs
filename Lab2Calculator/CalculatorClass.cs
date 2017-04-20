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
        private string _textHistory;

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public CalculatorClass()
        {
            _text = "0";
            _textHistory = "";
        }

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

        public string screenTextHistory
        {
            get
            {
                return _textHistory;
            }

            set
            {
                _textHistory = value;
                PropertyChanged(this, new PropertyChangedEventArgs("screenTextHistory"));
            }
        }

        public void onCancelButtonClick()
        {
            screenText = "0";
        }

        public void onCancelAllButtonClick()
        {
            screenTextHistory = "";
            screenText = "0";
        }

        public void onInversionButtonClick()
        {

        }

        public void onRegularButtonClick(String character)
        {
            if (screenText == "0")
            {
                screenText = character;
            }
            else
            {
                screenText += character;
            }
        }

        public void onOperationButtonClick(String operation)
        {
            if(screenTextHistory == "")
            {
                screenTextHistory += screenText;
                screenTextHistory += operation;
                screenText = "0";//need to change to show result till this moment
            }
            else
            {
                screenTextHistory = screenTextHistory.Remove(screenTextHistory.Length-1) + operation;
                screenText = "0";//need to change to show result till this moment
            }
        }

        public void onResultButtonClick()
        {
            
        }

        public void onSqrtButtonClick()
        {
            
        }

        public void onBackspaceButtonClick()
        {
            
        }

        public void onPowerButtonClick()
        {
            
        }
    }
}
