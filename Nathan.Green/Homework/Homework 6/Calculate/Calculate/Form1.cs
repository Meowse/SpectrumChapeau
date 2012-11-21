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

        private double UpdateNumber(double value)
        {
            _currentValue = ((_currentValue*10) + value);
            return _currentValue;
        }

        private void UpdateDisplay(double value)
        {
            textDisplay.Text = UpdateNumber(value).ToString(CultureInfo.InvariantCulture);  
        }

        private void DoClear(object sender, EventArgs e)
        {
            textDisplay.Text = "";
            _lastValue = 0;
            _currentValue = 0;
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
        }

        private void DoPlus(object sender, EventArgs e)
        {
            if (_lastValue == 0)
            {
                _lastValue = _currentValue;
                _currentValue = 0;
                _mathematicalAction = "ADD";
            }
            else
            {
                _currentValue = _lastValue + _currentValue;
                textDisplay.Text = _currentValue.ToString(CultureInfo.InvariantCulture);
                _lastValue = 0;
                _currentValue = 0;
                _mathematicalAction = "";
            }
        }

        private void DoSubtract(object sender, EventArgs e)
        {
            if (_lastValue == 0)
            {
                _lastValue = _currentValue;
                _currentValue = 0;
                _mathematicalAction = "SUBTRACT";
            }
            else
            {
                _currentValue = _lastValue - _currentValue;
                textDisplay.Text = _currentValue.ToString(CultureInfo.InvariantCulture);
                _lastValue = 0;
                _currentValue = 0;
                _mathematicalAction = "";
            }
        }

        private void DoMultiply(object sender, EventArgs e)
        {
            if (_lastValue == 0)
            {
                _lastValue = _currentValue;
                _currentValue = 0;
                _mathematicalAction = "MULTIPLY";
            }
            else
            {
                _currentValue = _lastValue * _currentValue;
                textDisplay.Text = _currentValue.ToString(CultureInfo.InvariantCulture);
                _lastValue = 0;
                _currentValue = 0;
                _mathematicalAction = "";
            }
        }

        private void DoDivision(object sender, EventArgs e)
        {
            if (_lastValue == 0)
            {
                _lastValue = _currentValue;
                _currentValue = 0;
                _mathematicalAction = "DIVISION";
            }
            else
            {
                _currentValue = _lastValue / _currentValue;
                textDisplay.Text = _currentValue.ToString(CultureInfo.InvariantCulture);
                _lastValue = 0;
                _currentValue = 0;
                _mathematicalAction = "";
            }
        }

        private void DoEquals(object sender, EventArgs e)
        {
            if (_lastValue != 0)
            {

                switch (_mathematicalAction)
                {
                    case "ADD":
                        _currentValue = _lastValue + _currentValue;
                        textDisplay.Text = _currentValue.ToString(CultureInfo.InvariantCulture);
                        _lastValue = 0;
                        _currentValue = 0;
                        _mathematicalAction = "";
                        break;
                    case "SUBTRACT":
                        _currentValue = _lastValue - _currentValue;
                        textDisplay.Text = _currentValue.ToString(CultureInfo.InvariantCulture);
                        _lastValue = 0;
                        _currentValue = 0;
                        _mathematicalAction = "";
                        break;
                    case "MULTIPLY":
                        _currentValue = _lastValue * _currentValue;
                        textDisplay.Text = _currentValue.ToString(CultureInfo.InvariantCulture);
                        _lastValue = 0;
                        _currentValue = 0;
                        _mathematicalAction = "";
                        break;
                    case "DIVISION":
                        _currentValue = _lastValue / _currentValue;
                        textDisplay.Text = _currentValue.ToString(CultureInfo.InvariantCulture);
                        _lastValue = 0;
                        _currentValue = 0;
                        _mathematicalAction = "";
                        break;
                }
            }
        }
    }
}