// Bryna Shane
// .Net Development Foundations, Fall 2012
// Homework Assignment #3
// October 31, 2012
//
//  Assignment Tasks:  
//
//  Create a Visual Studio solution.
//  Create a Windows Forms application in this solution.
//  Put a TextBox, a Button (“Hello!”), and a Label on the form.
//  
//  When the user types their name into the TextBox, and clicks the “Hello!” button,
//  show a MessageBox that says, “Hello, <contents of the TextBox>!”
//
//  HelloForm.cs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Homework3
{
    public partial class HelloForm : Form
    {
        string PREPEND = "Hello, ";
        string PUNCTUATION = "!";

        public HelloForm()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            lblOutput.Text = PREPEND + txtUserEntry.Text + PUNCTUATION;
        }
        
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblOutput.Text = string.Empty;
            txtUserEntry.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
