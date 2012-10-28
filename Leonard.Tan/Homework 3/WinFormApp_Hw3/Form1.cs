using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormApp_Hw3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length != 0 )
            {
                label.Text = "Hello, " + textBox.Text + "!";
                MessageBox.Show(label.Text);
            }
            else
            {
                MessageBox.Show("TextBox is Empty.");
                textBox.Focus();
            }
        }
    }
}
