using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalcForm : Form
    {

        private enum Actions
        {
            invalid = -1,
            add = 0,
            sub,
            equal,
            multiply,
            power,
            div
        };

        private double _prevInput = 0;
        private double _currentInput = 0;

        private int _currentAction = (int) Actions.invalid;

        public CalcForm()
        {
            _currentInput = 0;
            _prevInput = 0;
            _currentAction = (int) Actions.invalid;

            InitializeComponent();
        }

       private void CalcForm_Load(object sender, EventArgs e)
        {

        }

       /* public void button1_Click(object sender, EventArgs e)
        {

        }*/

        private void UpdateDisplay()
        {
            TextDisplay.Text = _currentInput.ToString(CultureInfo.InvariantCulture);
        }

        private double updateInputNumber(double digit)
        {

            return _currentInput = _currentInput*10 + digit;
        }

        private void reset()
        {
            _currentAction = (int) Actions.invalid;
            _prevInput = _currentInput;
            _currentInput = 0;
        }

        private void number_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            double myValue = Convert.ToDouble(clickedButton.Text);

            if (_currentAction == (int)Actions.equal)
            {
                reset();
            }
            updateInputNumber(myValue);
            UpdateDisplay();
            
        }

        private void binaryOperand_click(object sender , EventArgs e)
        {
            Button clickedButton = (Button)sender;
 
            if (_currentAction != (int)Actions.invalid)
            {
                doAction();
                UpdateDisplay();
            }
            _prevInput = _currentInput;
            _currentInput = 0;
            setAction(clickedButton.Text);
        }

        private void equals_Click(object sender, EventArgs e)
        {
            doAction();
            UpdateDisplay();
            _currentAction = (int) Actions.equal;
        }

        private void setAction(string operand)
        {
            if ( System.String.Compare(operand, "+") == 0)
            {
                _currentAction = (int)Actions.add;
            }
            else if (System.String.Compare(operand, "-") == 0)
            {
                _currentAction = (int) Actions.sub;
            }
            else if (System.String.Compare(operand, "*") == 0)
            {
                _currentAction = (int) Actions.multiply;
            }
            else if (System.String.Compare(operand, "x^y") == 0)
            {
                _currentAction = (int) Actions.power;
            }
            else if (System.String.Compare(operand, "/") == 0)
            {
                _currentAction = (int)Actions.div;
            }

        }

        private void doAction()
        {
            switch(_currentAction)
            {
                case (int) Actions.add:
                    _currentInput = _prevInput + _currentInput;
                    break;

               case (int)Actions.sub:
                    _currentInput = _prevInput - _currentInput;
                    break;

               case (int)Actions.multiply:
                    _currentInput = _prevInput * _currentInput;
                    break;
                case (int)Actions.power:
                    _currentInput = System.Math.Pow(_prevInput, _currentInput);
                    break;
                case (int)Actions.div:
                    _currentInput = _prevInput/_currentInput;
                    break;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            reset();
            UpdateDisplay();

        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            _currentInput = System.Math.Pow(_currentInput,0.5);
            UpdateDisplay();
        }

        private void inverse_Click(object sender, EventArgs e)
        {
            _currentInput = 1/_currentInput;
            UpdateDisplay();

        }

    }

}

/*
private void one_Click(object sender, EventArgs e)
{
    //string test = (System.Windows.Forms.Button)sender.Text;
    Button clickedButton = (Button)sender;
    string myValue = clickedButton.Text;
 
    if(_currentAction == (int)Actions.equal)
    {
        reset();
    }
    updateInputNumber(1);
    UpdateDisplay();
}

private void Two_Click(object sender, EventArgs e)
{
    if (_currentAction == (int)Actions.equal)
    {
        reset();
    }

    updateInputNumber(2);
    UpdateDisplay();
}

private void three_Click(object sender, EventArgs e)
{
    if (_currentAction == (int)Actions.equal)
    {
        reset();
    }

    updateInputNumber(3);
    UpdateDisplay();
}

private void four_Click(object sender, EventArgs e)
{
    if (_currentAction == (int)Actions.equal)
    {
        reset();
    }

    updateInputNumber(4);
    UpdateDisplay();
}

private void five_Click(object sender, EventArgs e)
{
    if (_currentAction == (int)Actions.equal)
    {
        reset();
    }

    updateInputNumber(5);
    UpdateDisplay();
}

private void six_Click(object sender, EventArgs e)
{
    if (_currentAction == (int)Actions.equal)
    {
        reset();
    }

    updateInputNumber(6);
    UpdateDisplay();
}

private void seven_Click(object sender, EventArgs e)
{
    if (_currentAction == (int)Actions.equal)
    {
        reset();
    }

    updateInputNumber(7);
    UpdateDisplay();
}

private void eight_Click(object sender, EventArgs e)
{
    if (_currentAction == (int)Actions.equal)
    {
        reset();
    }
    updateInputNumber(8);
    UpdateDisplay();
}

private void nine_Click(object sender, EventArgs e)
{
    if (_currentAction == (int)Actions.equal)
    {
        reset();
    }
    updateInputNumber(9);
    UpdateDisplay();
}

private void zero_Click(object sender, EventArgs e)
{
    if (_currentAction == (int)Actions.equal)
    {
        reset();
    }
    updateInputNumber(0);
    UpdateDisplay();
}*/

/*
private void plus_Click(object sender, EventArgs e)
{
    if (_currentAction != (int)Actions.invalid)
    {
        doAction();
        UpdateDisplay();
    }
    _prevInput = _currentInput;
    _currentInput = 0;
    _currentAction = (int) Actions.add;
}
private void substract_Click(object sender, EventArgs e)
{
    if (_currentAction != (int)Actions.invalid)
    {
        doAction();
        UpdateDisplay();
    }
    _prevInput = _currentInput;
    _currentInput = 0;
    _currentAction = (int)Actions.sub;
}
private void multiply_Click(object sender, EventArgs e)
{
    if (_currentAction != (int)Actions.invalid)
    {
        doAction();
        UpdateDisplay();
    }
    _prevInput = _currentInput;
    _currentInput = 0;
    _currentAction = (int)Actions.multiply;
}

private void power_Click(object sender, EventArgs e)
{
    if (_currentAction != (int)Actions.invalid)
    {
        doAction();
        UpdateDisplay();
    }
    _prevInput = _currentInput;
    _currentInput = 0;
    _currentAction = (int)Actions.power;
}*/




