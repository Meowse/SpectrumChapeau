using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string lastKeyClickedValue;
        private bool operatorKeyClicked;
        private decimal previousDisplayValue;
        private decimal currentDisplayValue;
        private bool numberButtonClicked;
        //TODO: Use single click event for all with value from key 
        private void ZeroKey(object sender, EventArgs e)
        {
            if (inputDisplayBox.Text.Equals("0"))
            {
                inputDisplayBox.Text = inputDisplayBox.Text;
            }
            else
            {
                inputDisplayBox.Text = string.Format("{0}0", inputDisplayBox.Text);
            }
        }

        private void OneKey(object sender, EventArgs e)
        {
            if (inputDisplayBox.Text.Equals("0"))
            {
                inputDisplayBox.Text = "1";
            }
            else
            {
                inputDisplayBox.Text = string.Format("{0}1", inputDisplayBox.Text);
            }
        }

        private void TwoKey(object sender, EventArgs e)
        {
            if (inputDisplayBox.Text.Equals("0"))
            {
                inputDisplayBox.Text = "2";
            }
            else
            {
                inputDisplayBox.Text = string.Format("{0}2", inputDisplayBox.Text);
            }
        }

        private void ThreeKey(object sender, EventArgs e)
        {
            inputDisplayBox.Text = inputDisplayBox.Text.Equals("0") ? "3" : string.Format("{0}3", inputDisplayBox.Text);
        }

        private void FourKey(object sender, EventArgs e)
        {
            if (inputDisplayBox.Text.Equals("0"))
            {
                inputDisplayBox.Text = "4";
            }
            else
            {
                inputDisplayBox.Text = string.Format("{0}4", inputDisplayBox.Text);
            }
        }

        private void FiveKey(object sender, EventArgs e)
        {
            if (inputDisplayBox.Text.Equals("0"))
            {
                inputDisplayBox.Text = "5";
            }
            else
            {
                inputDisplayBox.Text = string.Format("{0}5", inputDisplayBox.Text);
            }
        }

        private void SixKey(object sender, EventArgs e)
        {
            if (inputDisplayBox.Text.Equals("0"))
            {
                inputDisplayBox.Text = "6";
            }
            else
            {
                inputDisplayBox.Text = string.Format("{0}6", inputDisplayBox.Text);
            }
        }

        private void SevenKey(object sender, EventArgs e)
        {
            if (inputDisplayBox.Text.Equals("0"))
            {
                inputDisplayBox.Text = "7";
            }
            else
            {
                inputDisplayBox.Text = string.Format("{0}7", inputDisplayBox.Text);
            }
        }

        private void EightKey(object sender, EventArgs e)
        {
            if (inputDisplayBox.Text.Equals("0"))
            {
                inputDisplayBox.Text = "8";
            }
            else
            {
                inputDisplayBox.Text = string.Format("{0}8", inputDisplayBox.Text);
            }
        }

        private void NineKey(object sender, EventArgs e)
        {
            //MessageBox.Show(string.Format("operator key is {0}", operatorKeyClicked));

            if (operatorKeyClicked)
            {
                if (!numberButtonClicked)
                {
                    MessageBox.Show("number button not clicked");
                    //ClearKey(null, null);
                    inputDisplayBox.Text = "9";
                    //operatorKeyClicked = false;
                    //MessageBox.Show(string.Format("currentVal key=true is {0}", currentDisplayValue));
                }

            }
            inputDisplayBox.Text = string.Format("{0}9", inputDisplayBox.Text);
            //numberButtonClicked = true;
            //MessageBox.Show(string.Format("currentVal key=false is {0}", currentDisplayValue));

            //else if (operatorKeyClicked == false)
            //{
            //    //MessageBox.Show("operatorKey is false");
            //    if (inputDisplayBox.Text == string.Empty)
            //    {
            //        inputDisplayBox.Text = "9";
            //    }
            //    else
            //    {
            //        inputDisplayBox.Text = string.Format("{0}9", inputDisplayBox.Text);
            //    }
            //}

            //inputDisplayBox.Text = string.Format("{0}9", inputDisplayBox.Text);
            //operatorKeyClicked = false;
        }

        private void ClearKey(object sender, EventArgs e)
        {
            inputDisplayBox.Text = string.Empty;
            lastKeyClickedValue = string.Empty;
            operatorKeyClicked = false;
        }
        private void DecimalKey(object sender, EventArgs e)
        {

        }
        private void MinusKey(object sender, EventArgs e)
        {
            //previousDisplayValue = System.Convert.ToDecimal(inputDisplayBox.Text);
            MessageBox.Show(string.Format("operator key is {0}", operatorKeyClicked));
            if (operatorKeyClicked)
            {
                CalculateResult();
                //MessageBox.Show(string.Format("currentVal is {0}", currentDisplayValue));
            }
            else
            {
                previousDisplayValue = System.Convert.ToDecimal(inputDisplayBox.Text);
                //MessageBox.Show(string.Format("operator false, value is {0}", previousDisplayValue));
            }
            operatorKeyClicked = true;
            //operatorKeyClickToggle();
            //MessageBox.Show(string.Format("operator key [after true] is {0}", operatorKeyClicked));
            lastKeyClickedValue = "Subtraction";
        }
        
        private void CalculateResult()
        {
            currentDisplayValue = System.Convert.ToDecimal(inputDisplayBox.Text);
            //MessageBox.Show(string.Format("prevVal is {0}", previousDisplayValue));
            //MessageBox.Show(string.Format("currentVal is {0}", currentDisplayValue));
            switch (lastKeyClickedValue)
            {
                    case "Subtraction":
                    inputDisplayBox.Text = (previousDisplayValue - currentDisplayValue).ToString();
                    previousDisplayValue = System.Convert.ToDecimal(inputDisplayBox.Text);
                    //operatorKeyClickToggle();
                    operatorKeyClicked = false;
                    numberButtonClicked = false;
                    //MessageBox.Show(string.Format("operator key in CalcResult is {0}", operatorKeyClicked));

                    break;
                case "Addition":
                    previousDisplayValue = previousDisplayValue + currentDisplayValue;
                    break;

            }
        }

        private void operatorKeyClickToggle()
        {
            //bool b = false == operatorKeyClicked ? true : false;
            //operatorKeyClicked = b;

            if (operatorKeyClicked)
            {
                operatorKeyClicked = false;
            }
            operatorKeyClicked = true;
        }
    }
}
