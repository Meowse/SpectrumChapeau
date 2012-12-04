using System;
using System.Windows.Forms;

namespace HW6_calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            //calcTextBox.Text = "";
        }

        double _inputValue1;
        double _inputValue2;
        double _result;
        string _operator;
        private bool _lastWasOperator;

       private void ButtonOneClick(object sender, EventArgs e)
       {
           if (_lastWasOperator)
           {
               calcTextBox.Text = buttonOne.Text;
               _lastWasOperator = false;
           }
           else
           {
               calcTextBox.Text = calcTextBox.Text + buttonOne.Text;        
           }
       }

       private void ButtonTwoClick(object sender, EventArgs e)
       {
           if (_lastWasOperator)
           {
               calcTextBox.Text = buttonTwo.Text;
               _lastWasOperator = false;
           }
           else
           {
               calcTextBox.Text = calcTextBox.Text + buttonTwo.Text;
           }
       }

       private void ButtonThreeClick(object sender, EventArgs e)
       {
           if (_lastWasOperator)
           {
               calcTextBox.Text = buttonThree.Text;
               _lastWasOperator = false;
           }
           else
           {
               calcTextBox.Text = calcTextBox.Text + buttonThree.Text;
           }
       }

       private void ButtonFourClick(object sender, EventArgs e)
       {
           if (_lastWasOperator)
           {
               calcTextBox.Text = buttonFour.Text;
               _lastWasOperator = false;
           }
           else
           {
               calcTextBox.Text = calcTextBox.Text + buttonFour.Text;
           }
       }

        private void ButtonFiveClick(object sender, EventArgs e)
       {
           if (_lastWasOperator)
           {
               calcTextBox.Text = buttonFive.Text;
               _lastWasOperator = false;
           }
           else
           {
               calcTextBox.Text = calcTextBox.Text + buttonFive.Text;
           }
       }

       private void ButtonSixClick(object sender, EventArgs e)
       {
           if (_lastWasOperator)
           {
               calcTextBox.Text = buttonSix.Text;
               _lastWasOperator = false;
           }
           else
           {
               calcTextBox.Text = calcTextBox.Text + buttonSix.Text;
           }
       }

       private void ButtonSevenClick(object sender, EventArgs e)
       {
           if (_lastWasOperator)
           {
               calcTextBox.Text = buttonSeven.Text;
               _lastWasOperator = false;
           }
           else
           {
               calcTextBox.Text = calcTextBox.Text + buttonSeven.Text;
           }
       }

       private void ButtonEightClick(object sender, EventArgs e)
       {
           if (_lastWasOperator)
           {
               calcTextBox.Text = buttonEight.Text;
               _lastWasOperator = false;
           }
           else
           {
               calcTextBox.Text = calcTextBox.Text + buttonEight.Text;
           }
       }

       private void ButtonNineClick(object sender, EventArgs e)
       {
           if (_lastWasOperator)
           {
               calcTextBox.Text = buttonNine.Text;
               _lastWasOperator = false;
           }
           else
           {
               calcTextBox.Text = calcTextBox.Text + buttonNine.Text;
           }
       }

       private void ButtonZeroClick(object sender, EventArgs e)
       {
           if (_lastWasOperator)
           {
               calcTextBox.Text = buttonZero.Text;
               _lastWasOperator = false;
           }
           else
           {
               calcTextBox.Text = calcTextBox.Text + buttonZero.Text;
           }
       }

       private void ButtonClearClick(object sender, EventArgs e)
       {
           _inputValue1 = 0;
           _inputValue2 = 0;
           _result = 0;
           _lastWasOperator = true;
           calcTextBox.Text = _result.ToString();
       }

       private void ButtonAddClick(object sender, EventArgs e)
       {
           _inputValue1 = double.Parse(calcTextBox.Text);
           _lastWasOperator = true;
           _operator = "+";
           _result += _inputValue1;
           calcTextBox.Text = _result.ToString();
       }

       private void ButtonSubtractClick(object sender, EventArgs e)
       {
           _inputValue1 = double.Parse(calcTextBox.Text);
           _lastWasOperator = true;
           _operator = "-";
           _result = _result - _inputValue1;
           calcTextBox.Text = _result.ToString();
       }

       private void ButtonMultiplyClick(object sender, EventArgs e)
       {
           _inputValue1 = double.Parse(calcTextBox.Text);
           _lastWasOperator = true;
           _operator = "*";
           _result = _result - _inputValue1;
           calcTextBox.Text = _result.ToString();
       }

       private void ButtonDivideClick(object sender, EventArgs e)
       {
           _inputValue1 = double.Parse(calcTextBox.Text);
           _lastWasOperator = true;
           _operator = "/";
           _result = _result /_inputValue1;
           calcTextBox.Text = _result.ToString();
       }

       private void ButtonEqualClick(object sender, EventArgs e)
       {

           switch (_operator)
           {
               case ("+"):
                   _inputValue2 = double.Parse(calcTextBox.Text);
                   _result = _result + _inputValue2;
                   calcTextBox.Text = _result.ToString();
                   break;

               case ("-"):
                   _inputValue2 = double.Parse(calcTextBox.Text);
                   _result = _inputValue1 - _inputValue2;
                   calcTextBox.Text = _result.ToString();
                   break;

               case ("*"):
                   _inputValue2 = double.Parse(calcTextBox.Text);
                   _result = _inputValue1 * _inputValue2;
                   calcTextBox.Text = _result.ToString();
                   break;

               case ("/"):
                   _inputValue2 = double.Parse(calcTextBox.Text);
                   _result = _inputValue1 / _inputValue2;
                   calcTextBox.Text = _result.ToString();
                   break;
           }       

       }
       private void calcTextBox_TextChanged(object sender, EventArgs e)
       {

       }

    }
}
