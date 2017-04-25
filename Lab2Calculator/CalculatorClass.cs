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
        private List<int> _leftParantesesIndexList;
        private int _lastRemovedLeftParantesesIndex;
        IEnumerable<string> _operationsEnum;

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public CalculatorClass()
        {
            screenText = "0";
            screenTextHistory = "";
            _regularPress = true;
            _leftParantesesIndexList = new List<int>();
            _operationsEnum = new List<string>() { "+", "-", "*", "/", "^" };
            _lastRemovedLeftParantesesIndex = -1;
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
            screenText = "0";
            screenTextHistory = "";
            _regularPress = true;
            _leftParantesesIndexList.Clear();
            _lastRemovedLeftParantesesIndex = -1;
        }

        public void onInversionButtonClick()
        {
            if (_regularPress == true)
            {
                if (screenText != "0")
                {
                    if (screenText.StartsWith("-"))
                    {
                        screenText.Remove(0, 1);
                    }
                    else
                    {
                        screenText = "-" + screenText;
                    }
                }
            }
            //need to implement the else part if want to be cooler
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
            //need to delete last number when operation not present
        }
        public void onDotButtonClick()
        {
            if(_regularPress == false)
            {
                screenText = "0,";
                _regularPress = true;
            }
            else
            {
                if (!screenText.Contains(","))
                {
                    screenText += ",";
                }
            }
        }

        public void onOperationGradeOneButtonClick(String operation)
        {
            if (_regularPress == true)
            {
                if (Double.Parse(screenText) < 0 && _operationsEnum.Any(item => screenTextHistory.EndsWith(item)))
                {
                    screenTextHistory += "(" + screenText + ")";
                }
                else
                {
                    screenTextHistory += screenText;
                }
                
                _result = findInerResult();             
                screenText = _result;
                screenTextHistory += operation;
                _regularPress = false;
            }
            else
            {
                if(_operationsEnum.Any(item => screenTextHistory.EndsWith(item)))
                {
                    screenTextHistory = screenTextHistory.Remove(screenTextHistory.Length - 1) + operation;
                }
                else
                {
                    _result = findInerResult();
                    screenText = _result;
                    screenTextHistory += operation;
                }
            }   
        }

        private string findInerResult()
        {
            //DataTable dt = new DataTable(); // firt method
            string result;

            if (_leftParantesesIndexList.Count != 0)
            {
                // result = dt.Compute(screenTextHistory.Substring(
                //     _leftParantesesIndexList[_leftParantesesIndexList.Count - 1] + 1), null).ToString(); //second method
                // result = computeResult(screenTextHistory.Substring(
                //    _leftParantesesIndexList[_leftParantesesIndexList.Count - 1] + 1)); //second method
                try { result = Rpn.Calculate(screenTextHistory.Substring(
                    _leftParantesesIndexList[_leftParantesesIndexList.Count - 1] + 1)).ToString(); }
                catch (MyException ex) { result = ex.type; }
            }
            else
            {
                //result = computeResult(screenTextHistory); second method
                try { result = Rpn.Calculate(screenTextHistory).ToString(); }
                catch (MyException ex) { result = ex.type; }
            }
            return result;
        }

        public void onOperationGradeTwoButtonClick(String operation)
        {
            if (_regularPress == true)
            {
                if (Double.Parse(screenText) < 0 && _operationsEnum.Any(item => screenTextHistory.EndsWith(item)))
                {
                    screenTextHistory += "(" + screenText + ")";
                }
                else
                {
                    screenTextHistory += screenText;
                }

                _result = findInerResult();
                screenText = _result;
                screenTextHistory += operation;
                _regularPress = false;
            }
            else
            {
                if (_operationsEnum.Any(item => screenTextHistory.EndsWith(item)))
                {
                    screenTextHistory = screenTextHistory.Remove(screenTextHistory.Length - 1) + operation;
                }
                else
                {
                    _result = findInerResult();
                    screenText = _result;
                    screenTextHistory += operation;
                }
            }
        }

        public void onResultButtonClick()
        {
            // DataTable dt = new DataTable(); //used for first method

            if (_operationsEnum.Any(item => screenTextHistory.EndsWith(item)))
            {
                screenTextHistory += screenText;
            }
            _leftParantesesIndexList.ForEach(item => screenTextHistory += ")"); //adds the remaing right paranteses if needed
            // screenText = dt.Compute(screenTextHistory, null).ToString(); //used for first method
            // screenText = computeResult(screenTextHistory); //used for second method
            try { screenText = Rpn.Calculate(screenTextHistory).ToString(); }
            catch (MyException ex) { screenText = ex.type; }                                                                          
            screenTextHistory = "";
        }

        public void onSqrtButtonClick()
        {
            // sqrt symbol in unicode is \u221A
            if (_regularPress == true)
            {
                screenTextHistory += "\u221A" + "(" + screenText + ")";
                screenText = Math.Sqrt(Double.Parse(screenText)).ToString();
                _regularPress = false;
            }
        }

        private string computeResult(string str)
        {
            string result;
            Type scriptType = Type.GetTypeFromCLSID(Guid.Parse("0E59F1D5-1FBE-11D0-8FF2-00A0D10038BC"));

            dynamic obj = Activator.CreateInstance(scriptType, false);
            obj.Language = "javascript";
            try
            {
                var res = obj.Eval(str);
                result = Convert.ToString(res);

            }
            catch (Exception)
            {
                result = "Syntax error";
            }
            return result;
        }

        public void onBackspaceButtonClick()
        {
            if(_regularPress == true)
            {
                if(screenText.Length == 1 || 
                    (screenText.Length == 2 && String.Equals(screenText[0],"-")) ||
                    (screenText.Length == 3 && String.Equals(screenText.Substring(0,2), "-0")))
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
            if (_regularPress == true)
            {
                if (Double.Parse(screenText) < 0 && _operationsEnum.Any(item => screenTextHistory.EndsWith(item)))
                {
                    screenTextHistory += "(" + screenText + ")";
                }
                else
                {
                    screenTextHistory += screenText;
                }
                _result = findInerResult();
                screenText = _result;
                screenTextHistory += "^";
                _regularPress = false;
            }
            else
            {
                if (_operationsEnum.Any(item => screenTextHistory.EndsWith(item)))
                {
                    screenTextHistory = screenTextHistory.Remove(screenTextHistory.Length - 1) + "^";
                }
                else
                {
                    _result = findInerResult();
                    screenText = _result;
                    screenTextHistory += "^";
                }
            }
        }

        public void onLeftParanthesesClick()
        {
            screenTextHistory += "(";
            if (_regularPress == false)
            {
                screenText = "0";
            }
            _leftParantesesIndexList.Add(screenTextHistory.Length-1);
        }

        public void onRightParanthesesClick()
        {
            if (_leftParantesesIndexList.Count != 0)
            {
                // DataTable dt = new DataTable(); //first method
                if (_operationsEnum.Any(item => screenTextHistory.EndsWith(item)) ||
                    screenTextHistory.Substring(screenTextHistory.Length-1) == "(")
                {
                    screenTextHistory += screenText + ")";
                }
                else
                {
                    screenTextHistory += ")";
                }
                //_result = dt.Compute(screenTextHistory.Substring(
                //_leftParantesesIndexList[_leftParantesesIndexList.Count - 1]), null).ToString(); //first method
                //_result = computeResult(screenTextHistory.Substring(
                //_leftParantesesIndexList[_leftParantesesIndexList.Count - 1])); //second method
                try { _result = Rpn.Calculate(screenTextHistory.Substring(
                    _leftParantesesIndexList[_leftParantesesIndexList.Count - 1])).ToString(); }
                catch (MyException ex) { _result = ex.type; }
                screenText = _result; 
                _regularPress = false;
                _lastRemovedLeftParantesesIndex = _leftParantesesIndexList[_leftParantesesIndexList.Count - 1];
                _leftParantesesIndexList.RemoveAt(_leftParantesesIndexList.Count - 1);
            }
        }
    }
}
