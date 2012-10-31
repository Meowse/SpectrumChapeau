using System;
using System.Windows.Forms;

namespace HelloWorld_WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HelloTextBoxTextChanged(object sender, EventArgs e)
        {
            Hello_Button.Enabled = Hello_TextBox.Text != "";
        }

        private void HelloButtonClick(object sender, EventArgs e)
        {
            Hello_Label.Text = "Hello, " + Hello_TextBox.Text + "!";
        }
    }
}
