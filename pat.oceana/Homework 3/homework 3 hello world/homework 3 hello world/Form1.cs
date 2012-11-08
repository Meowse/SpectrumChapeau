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
            MessageBox.Show(textBox1 != null
                                ? string.Format("Hello {0}", textBox1.Text)
                                : string.Format(
                                    "I'm sorry I'm not allowed to talk to strangers, please enter your name in the text box and click the button again"));
        }

        private void Form1Load(object sender, EventArgs e)
        {

        }

        private void TextBox1TextChanged(object sender, EventArgs e)
        {
            string text = textBox1.Text;
        }

        private void Label1Click(object sender, EventArgs e)
        {

        }
    }
}
