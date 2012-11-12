using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class formCalculator : Form

    {

        private int number1 = 0;
        private int number2 = 0;
        private byte sign = 0;
        private byte startNewNumber = 0;


        public formCalculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {

            this.labelResult.Text = "0";
            number1 = 0;
            number2 = 0;
            sign = 0;
            startNewNumber = 0;

        }

        private void buttonNumber0_Click(object sender, EventArgs e)
        {
            if (this.labelResult.Text != "0")
            {
                if (startNewNumber == 0)
                    
                        this.labelResult.Text = "";
                startNewNumber = 1;

            }


            this.labelResult.Text += "0";

            
        }

        private void buttonNumber1_Click(object sender, EventArgs e)
        {

            if (this.labelResult.Text != "0")
            {
                if (startNewNumber == 0)

                    this.labelResult.Text = "";
                    startNewNumber = 1;

            }


            this.labelResult.Text += "1";

        }

        private void buttonNumber2_Click(object sender, EventArgs e)
        {
            if (this.labelResult.Text != "0")
            {
                if (startNewNumber == 0)

                    this.labelResult.Text = "";
                startNewNumber = 1;

            }


            this.labelResult.Text += "2";

        }

        private void buttonNumber3_Click(object sender, EventArgs e)
        {
            if (this.labelResult.Text != "0")
            {
                if (startNewNumber == 0)

                    this.labelResult.Text = "";
                startNewNumber = 1;

            }


            this.labelResult.Text += "3";
        }

        private void buttonNumber4_Click(object sender, EventArgs e)
        {
            if (this.labelResult.Text != "0")
            {
                if (startNewNumber == 0)

                    this.labelResult.Text = "";
                startNewNumber = 1;

            }


            this.labelResult.Text += "4";
        }

        private void buttonNumber5_Click(object sender, EventArgs e)
        {
            if (this.labelResult.Text != "0")
            {
                if (startNewNumber == 0)

                    this.labelResult.Text = "";
                startNewNumber = 1;

            }


            this.labelResult.Text += "5";
        }

        private void buttonNumber6_Click(object sender, EventArgs e)
        {
            if (this.labelResult.Text != "0")
            {
                if (startNewNumber == 0)

                    this.labelResult.Text = "";
                startNewNumber = 1;

            }


            this.labelResult.Text += "6";
        }

        private void buttonNumber7_Click(object sender, EventArgs e)
        {
            if (this.labelResult.Text != "0")
            {
                if (startNewNumber == 0)

                    this.labelResult.Text = "";
                startNewNumber = 1;

            }


            this.labelResult.Text += "7";
        }

        private void buttonNumber8_Click(object sender, EventArgs e)
        {
            if (this.labelResult.Text != "0")
            {
                if (startNewNumber == 0)

                    this.labelResult.Text = "";
                startNewNumber = 1;

            }


            this.labelResult.Text += "8";
        }

        private void buttonNumber9_Click(object sender, EventArgs e)
        {
            if (this.labelResult.Text != "0")
            {
                if (startNewNumber == 0)

                    this.labelResult.Text = "";
                startNewNumber = 1;

            }


            this.labelResult.Text += "9";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            sign = 1;
            number1 = int.Parse(this.labelResult.Text);
            startNewNumber = 0;
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            sign = 2;
            number1 = int.Parse(this.labelResult.Text);
            startNewNumber = 0;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            sign = 3;
            number1 = int.Parse(this.labelResult.Text);
            startNewNumber = 0;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            sign = 4;
            number1 = int.Parse(this.labelResult.Text);
            startNewNumber = 0;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            number2 = int.Parse(this.labelResult.Text);
            
            int result = 0;

            if (sign == 1)
                result = number1 + number2;
            if (sign == 2)
                result = number1 - number2;
            if (sign == 3)
                result = number1 * number2;
            if (sign == 4)
            {
                if (number1 != 0)
                    result = number1/number2;
            }
        }
    }
}
