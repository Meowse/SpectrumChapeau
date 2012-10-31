using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Homework_3___Simple_Windows_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonHello_Click(object sender, EventArgs e)
        {
            String displayMessage = textBoxName.Text;

            if(displayMessage == "Enter your name")
            {
                displayMessage = "Didnt enter your name did ya?\nPlease enter your name.";
            }
            else
            {
                displayMessage = "Hello, " + textBoxName.Text;
            }
            MessageBox.Show(displayMessage,"Greetings");
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int a = 0;
            while (Visible)
            {
                for (int c = a; c < 255 & Visible; c++)
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(3);
                }
                for (int c = 254 - a; c >= 0 && Visible; c--)
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(3);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
