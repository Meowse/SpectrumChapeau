using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calculate
{
    public partial class FormCalculate : Form
    {
        private double _currentValue;
        private bool isDecimal = false;

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
            isDecimal = false;
        }
        
        private void UpdateDisplay(double value)
        {
            if ((_currentValue == 0) && (!isDecimal))
            {
                textDisplay.Text = "";
            }

            if (!isDecimal)
            {
                textDisplay.Text = textDisplay.Text + value.ToString();
                _currentValue = Convert.ToDouble(textDisplay.Text);
            }
            else
            {
                if (!textDisplay.Text.Contains("."))
                {
                    textDisplay.Text = textDisplay.Text + "." + value.ToString();
                    _currentValue = Convert.ToDouble(textDisplay.Text);
                }
                else
                {
                    textDisplay.Text = textDisplay.Text + value.ToString();
                    _currentValue = Convert.ToDouble(textDisplay.Text);                    
                }
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
            if (!isDecimal)
            {
                isDecimal = true;
            }
        }

        private void DoAdd(object sender, EventArgs e)
        {
            isDecimal = false;

            if ((_mathematicalAction != "") && (_mathematicalAction != "ADD"))
            {
                DoEquals(null, null);
            }

            _mathematicalAction = "ADD";
            DoMath(_mathematicalAction);
        }

        private void DoSubtract(object sender, EventArgs e)
        {
            isDecimal = false;

            if ((_mathematicalAction != "") && (_mathematicalAction != "SUBTRACT"))
            {
                DoEquals(null, null);
            }
            
            _mathematicalAction = "SUBTRACT";
            DoMath(_mathematicalAction);
        }

        private void DoMultiply(object sender, EventArgs e)
        {
            isDecimal = false;

            if ((_mathematicalAction != "") && (_mathematicalAction != "MULTIPLY"))
            {
                DoEquals(null, null);
            }

            _mathematicalAction = "MULTIPLY";
            DoMath(_mathematicalAction);
        }

        private void DoDivision(object sender, EventArgs e)
        {
            isDecimal = false;

            if ((_mathematicalAction != "") && (_mathematicalAction != "DIVISION"))
            {
                DoEquals(null, null);
            }

            _mathematicalAction = "DIVISION";
            DoMath(_mathematicalAction);
        }

        private void DoMath(string action)
        {
            switch (action)
            {
                case "ADD":
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
                        else
                        {
                            _currentValue = _lastComputedValue;
                        }
                    }
                    break;
                case "SUBTRACT":
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
                    break;
                case "MULTIPLY":
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
                            _lastComputedValue = _lastComputedValue*_currentValue;
                            textDisplay.Text = _lastComputedValue.ToString(CultureInfo.InvariantCulture);
                            _lastValue = 0;
                            _currentValue = 0;
                        }
                    }
                    break;
                case "DIVISION":
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
                                _lastComputedValue = _lastValue/_currentValue;
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
            if((_mathematicalAction == "") && (_lastComputedValue != 0) && (_lastCurrentValue != 0))
            {
                _mathematicalAction = _lastMathematicalAction;
                _currentValue = _lastCurrentValue;
            }

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
            }
        }
    }
}