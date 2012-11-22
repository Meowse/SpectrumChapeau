using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calculate
{
    public partial class FormCalculate : Form
    {
        private double _currentValue;

        public FormCalculate()
        {
            _currentValue = 0;
            InitializeComponent();
        }

        private void DoClear(object sender, EventArgs e)
        {
            textDisplay.Text = "0";
            _lastValue = 0;
            _currentValue = 0;
            _lastComputedValue = 0;
            _lastCurrentValue = 0;
            _lastMathematicalAction = "";
            _decimalValue = "";
        }

        private double UpdateNumber(double value)
        {
            _currentValue = ((_currentValue*10) + value);
            return _currentValue;
        }

        private void UpdateDisplay(double value)
        {
            if (_decimalValue != "")
            {
                _decimalValue = _decimalValue + value.ToString();
                textDisplay.Text = _decimalValue;
                _currentValue = Convert.ToDouble(_decimalValue);
            }
            else
            {
                textDisplay.Text = UpdateNumber(value).ToString(CultureInfo.InvariantCulture);   
            }
        }

        private void Do1(object sender, EventArgs e)
        {
            UpdateDisplay(1);
        }

        private void Do2(object sender, EventArgs e)
        {
            UpdateDisplay(2);
        }

        private void Do3(object sender, EventArgs e)
        {
            UpdateDisplay(3);
        }

        private void Do4(object sender, EventArgs e)
        {
            UpdateDisplay(4);
        }

        private void Do5(object sender, EventArgs e)
        {
            UpdateDisplay(5);
        }

        private void Do6(object sender, EventArgs e)
        {
            UpdateDisplay(6);
        }

        private void Do7(object sender, EventArgs e)
        {
            UpdateDisplay(7);
        }

        private void Do8(object sender, EventArgs e)
        {
            UpdateDisplay(8);
        }

        private void Do9(object sender, EventArgs e)
        {
            UpdateDisplay(9);
        }

        private void Do0(object sender, EventArgs e)
        {
            UpdateDisplay(0);
        }

        private void DoDecimal(object sender, EventArgs e)
        {
            if ((!_currentValue.ToString().Contains(".")) && (_decimalValue == ""))
            {
                _decimalValue = _currentValue.ToString() + ".";
            }
        }

        private void DoAdd(object sender, EventArgs e)
        {
            _decimalValue = "";
            if ((_mathematicalAction != "") && (_mathematicalAction != "ADD"))
            {
                DoEquals(null, null);
            }

            _mathematicalAction = "ADD";
            DoMath(_mathematicalAction);
        }

        private void DoSubtract(object sender, EventArgs e)
        {
            _decimalValue = "";
            if ((_mathematicalAction != "") && (_mathematicalAction != "SUBTRACT"))
            {
                DoEquals(null, null);
            }
            
            _mathematicalAction = "SUBTRACT";
            DoMath(_mathematicalAction);
        }

        private void DoMultiply(object sender, EventArgs e)
        {
            _decimalValue = "";
            if ((_mathematicalAction != "") && (_mathematicalAction != "MULTIPLY"))
            {
                DoEquals(null, null);
            }

            _mathematicalAction = "MULTIPLY";
            DoMath(_mathematicalAction);
        }

        private void DoDivision(object sender, EventArgs e)
        {
            _decimalValue = "";
            if ((_mathematicalAction != "") && (_mathematicalAction != "DIVISION"))
            {
                DoEquals(null, null);
            }

            _mathematicalAction = "DIVISION";
            DoMath(_mathematicalAction);
        }

        private void DoAddition()
        {
            if (_lastComputedValue == 0)
            {
                if (_lastValue == 0)
                {
                    _lastValue = _currentValue;
                    _currentValue = 0;
                }
                else
                {
                    _lastComputedValue = _lastValue + _currentValue;
                    textDisplay.Text = _lastComputedValue.ToString(CultureInfo.InvariantCulture);
                    _lastValue = 0;
                    _currentValue = 0;
                }
            }
            else
            {
                if (_currentValue != 0)
                {
                    _lastComputedValue = _lastComputedValue + _currentValue;
                    textDisplay.Text = _lastComputedValue.ToString(CultureInfo.InvariantCulture);
                    _lastValue = 0;
                    _currentValue = 0;
                }
            }
        }

        private void DoSubtraction()
        {
            if (_lastComputedValue == 0)
            {
                if (_lastValue == 0)
                {
                    _lastValue = _currentValue;
                    _currentValue = 0;
                }
                else
                {
                    _lastComputedValue = _lastValue - _currentValue;
                    textDisplay.Text = _lastComputedValue.ToString(CultureInfo.InvariantCulture);
                    _lastValue = 0;
                    _currentValue = 0;
                }
            }
            else
            {
                if (_currentValue != 0)
                {
                    _lastComputedValue = _lastComputedValue - _currentValue;
                    textDisplay.Text = _lastComputedValue.ToString(CultureInfo.InvariantCulture);
                    _lastValue = 0;
                    _currentValue = 0;
                }
            }
        }

        private void DoMultiplication()
        {
            if (_lastComputedValue == 0)
            {
                if (_lastValue == 0)
                {
                    _lastValue = _currentValue;
                    _currentValue = 0;
                }
                else
                {
                    _lastComputedValue = _lastValue * _currentValue;
                    textDisplay.Text = _lastComputedValue.ToString(CultureInfo.InvariantCulture);
                    _lastValue = 0;
                    _currentValue = 0;
                }
            }
            else
            {
                if (_currentValue != 0)
                {
                    _lastComputedValue = _lastComputedValue * _currentValue;
                    textDisplay.Text = _lastComputedValue.ToString(CultureInfo.InvariantCulture);
                    _lastValue = 0;
                    _currentValue = 0;
                }
            }
        }

        private void DoDivision()
        {
            if (_lastComputedValue == 0)
            {
                if (_lastValue == 0)
                {
                    _lastValue = _currentValue;
                    _currentValue = 0;
                }
                else
                {
                    if (_currentValue != 0)
                    {
                        _lastComputedValue = _lastValue / _currentValue;
                        textDisplay.Text = _lastComputedValue.ToString(CultureInfo.InvariantCulture);
                        _lastValue = 0;
                        _currentValue = 0;
                    }
                }
            }
            else
            {
                if (_currentValue != 0)
                {
                    _lastComputedValue = _lastComputedValue / _currentValue;
                    textDisplay.Text = _lastComputedValue.ToString(CultureInfo.InvariantCulture);
                    _lastValue = 0;
                    _currentValue = 0;
                }
            }
        }

        private void DoExponential()
        {
            if (_lastComputedValue == 0)
            {
                if (_lastValue == 0)
                {
                    _lastValue = _currentValue;
                    _currentValue = 0;
                }
                else
                {
                    if (_currentValue != 0)
                    {
                        _lastComputedValue = Math.Pow(_lastValue, _currentValue);
                        textDisplay.Text = _lastComputedValue.ToString(CultureInfo.InvariantCulture);
                        _lastValue = 0;
                        _currentValue = 0;
                    }
                }
            }
            else
            {
                if (_currentValue != 0)
                {
                    _lastComputedValue = Math.Pow(_lastComputedValue, _currentValue);
                    textDisplay.Text = _lastComputedValue.ToString(CultureInfo.InvariantCulture);
                    _lastValue = 0;
                    _currentValue = 0;
                }
            }
        }

        private void DoInversion()
        {
            if (_lastComputedValue == 0)
            {
                if (_currentValue != 0)
                {
                    _lastComputedValue = 1 / _currentValue;
                    textDisplay.Text = _lastComputedValue.ToString(CultureInfo.InvariantCulture);
                    _lastValue = 0;
                    _currentValue = 0;
                }
            }
            else
            {
                _lastComputedValue = 1 / _lastComputedValue;
                textDisplay.Text = _lastComputedValue.ToString(CultureInfo.InvariantCulture);
                _lastValue = 0;
                _currentValue = 0;
            }
        }

        private void DoSquareRoot()
        {
            if (_lastComputedValue == 0)
            {
                if (_currentValue != 0)
                {
                    _lastComputedValue = Math.Sqrt(_currentValue);
                    textDisplay.Text = _lastComputedValue.ToString(CultureInfo.InvariantCulture);
                    _lastValue = 0;
                    _currentValue = 0;
                }
            }
            else
            {
                _lastComputedValue = Math.Sqrt(_lastComputedValue);
                textDisplay.Text = _lastComputedValue.ToString(CultureInfo.InvariantCulture);
                _lastValue = 0;
                _currentValue = 0;
            }
        }

        private void DoMath(string action)
        {
            switch (action)
            {
                case "ADD":
                    DoAddition();
                    break;
                case "SUBTRACT":
                    DoSubtraction();
                    break;
                case "MULTIPLY":
                    DoMultiplication();
                    break;
                case "DIVISION":
                    DoDivision();
                    break;
                case "EXPONENT":
                    DoExponential();
                    break;
                case "INVERSE":
                    DoInversion();
                    break;
                case "SQUAREROOT":
                    DoSquareRoot();
                    break;
            }
        }

        private void SetValues()
        {
            textDisplay.Text = _lastComputedValue.ToString(CultureInfo.InvariantCulture);
            _lastValue = 0;
            _lastCurrentValue = _currentValue;
            _currentValue = 0;
            _lastMathematicalAction = _mathematicalAction;
            _mathematicalAction = "";
        }

        private void DoEquals(object sender, EventArgs e)
        {
            switch (_mathematicalAction)
            {
                case "ADD":
                    if (_lastComputedValue == 0)
                    {
                        _lastComputedValue = _lastValue + _currentValue;
                    }
                    else
                    {
                        _lastComputedValue = _lastComputedValue + _currentValue;                           
                    }
                    SetValues();
                    break;
                case "SUBTRACT":
                    if (_lastComputedValue == 0)
                    {
                        _lastComputedValue = _lastValue - _currentValue;
                    }
                    else
                    {
                        _lastComputedValue = _lastComputedValue - _currentValue;              
                    }
                    SetValues();
                    break;
                case "MULTIPLY":
                    if (_lastComputedValue == 0)
                    {
                        _lastComputedValue = _lastValue * _currentValue;
                    }
                    else
                    {
                        _lastComputedValue = _lastComputedValue * _currentValue;                           
                    }
                    SetValues();
                    break;
                case "DIVISION":
                    if (_lastComputedValue == 0)
                    {
                        if (_currentValue != 0)
                        {
                            _lastComputedValue = _lastValue/_currentValue;
                        }
                    }
                    else
                    {
                        if (_currentValue != 0)
                        {
                            _lastComputedValue = _lastComputedValue/_currentValue;
                        }
                    }
                    SetValues();
                    break;
                case "EXPONENT":
                    if (_lastComputedValue == 0)
                    {
                        if (_currentValue != 0)
                        {
                            _lastComputedValue = Math.Pow(_lastValue, _currentValue);
                        }
                    }
                    else
                    {
                        if (_currentValue != 0)
                        {
                            _lastComputedValue = Math.Pow(_lastComputedValue, _currentValue);
                        }
                    }
                    SetValues();
                    break;
            }
        }

        private void DoExponent(object sender, EventArgs e)
        {
            _decimalValue = "";
            if ((_mathematicalAction != "") && (_mathematicalAction != "EXPONENT"))
            {
                DoEquals(null, null);
            }

            _mathematicalAction = "EXPONENT";
            DoMath(_mathematicalAction);
        }

        private void DoInverse(object sender, EventArgs e)
        {
            _decimalValue = "";
            if ((_mathematicalAction != "") && (_mathematicalAction != "INVERSE"))
            {
                DoEquals(null, null);
            }

            _mathematicalAction = "INVERSE";
            DoMath(_mathematicalAction);
        }

        private void DoSquareRoot(object sender, EventArgs e)
        {
            _decimalValue = "";
            if ((_mathematicalAction != "") && (_mathematicalAction != "SQUAREROOT"))
            {
                DoEquals(null, null);
            }

            _mathematicalAction = "SQUAREROOT";
            DoMath(_mathematicalAction);
        }
    }
}