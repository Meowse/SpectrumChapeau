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
        public FormCalculate()
        {
            InitializeComponent();
        }

        private void UpdateDisplay(int value)
        {
            if (textDisplay.Text.Length == 0)
            {
                textDisplay.Text = value.ToString(); 
            }
            else
            {
                textDisplay.Text = textDisplay.Text + value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateDisplay(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateDisplay(2);
        }
    }
}
