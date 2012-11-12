using System;
using System.Windows.Forms;

namespace homework_3_hello_world
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1Click(object sender, EventArgs e)
        {
           const string initialText = "Please enter your name";

            MessageBox.Show(textBox1.Text != initialText
                                ? string.Format("Hello {0}", textBox1.Text)
                                : string.Format(
                                    "I'm sorry I'm not allowed to talk to strangers, please enter your name in the text box and click the button again"));
            textBox1.Focus();
        }

        private void TextBox1TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
