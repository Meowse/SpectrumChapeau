using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{
    public partial class FormCalculate : Form
    {
        private double currentValue = 0;
        private double lastValue = 0;

        public FormCalculate()
        {
            InitializeComponent();
        }

        private double UpdateNumber(double value)
        {
            currentValue = ((currentValue*10) + value);
            return currentValue;
        }

        private void UpdateDisplay(double value)
        {
            textDisplay.Text = UpdateNumber(value).ToString();  
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "";
            lastValue = 0;
            currentValue = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateDisplay(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateDisplay(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateDisplay(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateDisplay(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UpdateDisplay(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UpdateDisplay(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UpdateDisplay(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UpdateDisplay(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            UpdateDisplay(9);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            UpdateDisplay(0);
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (lastValue == 0)
            {
                lastValue = currentValue;
                currentValue = 0;
            }
            else
            {
                currentValue = lastValue + currentValue;
                textDisplay.Text = currentValue.ToString();
                lastValue = 0;
                currentValue = 0;
            }
        }
    }
}