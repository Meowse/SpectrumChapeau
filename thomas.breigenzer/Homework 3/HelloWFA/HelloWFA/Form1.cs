using System;
using System.Windows.Forms;

namespace HelloWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1Click(object sender, EventArgs e)
        {
            string nameEnteredInTextBox = textBox1.Text;
            if (nameEnteredInTextBox == null) throw new ArgumentNullException("sender");
            MessageBox.Show(string.Format("Hello, {0}", nameEnteredInTextBox));
        }
    }
}
