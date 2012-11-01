using System;
using System.Windows.Forms;

namespace Homework3Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            MessageBox.Show("Hello " + text + "!");
        }

        private void Form1Load(object sender, EventArgs e)
        {
            label1.Text = "Today's date: " + DateTime.Now.ToShortDateString();
        }

    }
}
