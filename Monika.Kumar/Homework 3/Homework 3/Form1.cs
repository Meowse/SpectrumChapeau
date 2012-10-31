using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Homework_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string txtBox = this.textBox1.Text;
            string message = "Hello " + txtBox;
            MessageBox.Show(this, message, "Homework 3");

        }
    }
}
