using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Calculator
{
    class CalculatorClass : ICalculator
    {
        private string _text;
        private string _textHistory;
        private string _result;
        private bool _regularPress;
        
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public CalculatorClass()
        {
            _text = "0";
            _textHistory = "";
            _regularPress = true;
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
            _regularPress = true;
        }

        public void onCancelAllButtonClick()
        {
            screenTextHistory = "";
            screenText = "0";
            _regularPress = true;
        }

        public void onInversionButtonClick()
        {

        }

        public void onRegularButtonClick(String character)
        {
            if(_regularPress == false)
            {
                screenText = character;
            }
            else
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
            _regularPress = true;
        }
        public void onDotButtonClick()
        {

        }

        public void onOperationButtonClick(String operation)
        {
            DataTable dt = new DataTable();

            if(_regularPress == true)
            {
                screenTextHistory += screenText;
                _result = dt.Compute(screenTextHistory,null).ToString();
                screenText = _result;
                screenTextHistory += operation;
                _regularPress = false;
            }
            else
            {
                screenTextHistory = screenTextHistory.Remove(screenTextHistory.Length-1) + operation;
                screenText = _result;
            }
        }
        public void onOperationGradeOneButtonClick(String operation)
        {
            DataTable dt = new DataTable();

            if (_regularPress == true)
            {
                screenTextHistory += screenText;
                _result = dt.Compute(screenTextHistory, null).ToString();
                screenText = _result;
                screenTextHistory += operation;
                _regularPress = false;
            }
            else
            {
                screenTextHistory = screenTextHistory.Remove(screenTextHistory.Length - 1) + operation;
                screenText = _result;
            }
        }
        public void onOperationGradeTwoButtonClick(String operation)
        {
            DataTable dt = new DataTable();

            if (_regularPress == true)
            {
                screenTextHistory += screenText;
                _result = dt.Compute(screenTextHistory, null).ToString();
                screenText = _result;
                screenTextHistory += operation;
                _regularPress = false;
            }
            else
            {
                screenTextHistory = screenTextHistory.Remove(screenTextHistory.Length - 1) + operation;
                screenText = _result;
            }
        }

        public void onResultButtonClick()
        {
            DataTable dt = new DataTable();

            screenTextHistory += screenText;
            screenText = dt.Compute(screenTextHistory, null).ToString();
            screenTextHistory = "";
        }

        public void onSqrtButtonClick()
        {
            // sqrt symbol in unicode is \u221A

        }

        public void onBackspaceButtonClick()
        {
            if(_regularPress == true)
            {
                if(screenText.Length == 1 || (screenText.Length == 2 && String.Equals(screenText[0],"-")))
                {
                    screenText = "0";
                }
                else
                {
                    screenText = screenText.Remove(screenText.Length - 1);
                }
            }
        }

        public void onPowerButtonClick()
        {
            
        }

        public void onLeftParanthesesClick()
        {

        }

        public void onRightParanthesesClick()
        {

        }
    }
}
