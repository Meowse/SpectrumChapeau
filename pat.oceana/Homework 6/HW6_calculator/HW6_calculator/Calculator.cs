using System;
using System.Windows.Forms;

namespace HW6_calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        double _inputValue1;
        double _inputValue2;
        double _result;
        string _operator;

       private void ButtonOneClick(object sender, EventArgs e)
        {
            calcTextBox.Text = buttonOne.Text;
        }

       private void ButtonTwoClick(object sender, EventArgs e)
       {
           calcTextBox.Text = calcTextBox.Text + buttonTwo.Text;
       }

       private void ButtonThreeClick(object sender, EventArgs e)
       {
           calcTextBox.Text = calcTextBox.Text + buttonThree.Text;
       }

       private void ButtonFourClick(object sender, EventArgs e)
       {
           calcTextBox.Text = calcTextBox.Text + buttonFour.Text;
       }

       private void ButtonFiveClick(object sender, EventArgs e)
       {
           calcTextBox.Text = calcTextBox.Text + buttonFive.Text;
       }

       private void ButtonSixClick(object sender, EventArgs e)
       {
           calcTextBox.Text = calcTextBox.Text + buttonSix.Text;
       }

       private void ButtonSevenClick(object sender, EventArgs e)
       {
           calcTextBox.Text = calcTextBox.Text + buttonSeven.Text;
       }

       private void ButtonEightClick(object sender, EventArgs e)
       {
           calcTextBox.Text = calcTextBox.Text + buttonEight.Text;
       }

       private void ButtonNineClick(object sender, EventArgs e)
       {
           calcTextBox.Text = calcTextBox.Text + buttonNine.Text;
       }

       private void ButtonZeroClick(object sender, EventArgs e)
       {
           calcTextBox.Text = calcTextBox.Text + buttonZero.Text;
       }

       private void ButtonClearClick(object sender, EventArgs e)
       {
           calcTextBox.Text = "";
       }

       private void ButtonAddClick(object sender, EventArgs e)
       {
           _inputValue1 = double.Parse(calcTextBox.Text);
           calcTextBox.Text = "";
           _operator = "+";
       }

       private void ButtonSubtractClick(object sender, EventArgs e)
       {
           _inputValue1 = double.Parse(calcTextBox.Text);
           calcTextBox.Text = "";
           _operator = "-";
       }

       private void ButtonMultiplyClick(object sender, EventArgs e)
       {
           _inputValue1 = double.Parse(calcTextBox.Text);
           calcTextBox.Text = "";
           _operator = "*";
       }

       private void ButtonDivideClick(object sender, EventArgs e)
       {
           _inputValue1 = double.Parse(calcTextBox.Text);
           calcTextBox.Text = "";
           _operator = "/";
       }

       private void ButtonEqualClick(object sender, EventArgs e)
       {

           switch (_operator)
           {
               case ("+"):
                   _inputValue2 = double.Parse(calcTextBox.Text);
                   _result = _inputValue1 + _inputValue2;
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


    }
}
