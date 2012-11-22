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
            if (inputDisplayBox.Text.Equals("0"))
            {
                inputDisplayBox.Text = "9";
            }
            else
            {
                inputDisplayBox.Text = string.Format("{0}9", inputDisplayBox.Text);
            }
        }

        private void ClearKey(object sender, EventArgs e)
        {
            inputDisplayBox.Text = "0";

        }








    }
}
