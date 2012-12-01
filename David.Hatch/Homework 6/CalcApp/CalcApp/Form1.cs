using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalcApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //int textBoxValue = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int KeyPressedValue = 1;

            //MessageBox.Show("1").ToString();
            //textBoxTotal.Text = '1'.ToString();
            updateTextBox(KeyPressedValue);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void updateTextBox(int sentnumber)
        {
           //MessageBox.Show(sentnumber.ToString());

            //currentValue = textBoxTotal.Text;
            //int currentValue = 1;
          
            int currentValue;

            int.TryParse(textBoxTotal.Text, out currentValue);

            //here you have currentValue of text box
            // you can check here for what to do 

            // put value just pressed in textbox
            // need to hold this in public var and wait for plus key etc.
            textBoxTotal.Text = sentnumber.ToString();

            //textBoxTotal.Text.ToString();

            //add operation:

            int newValue = currentValue += sentnumber;

            textBoxTotal.Text=newValue.ToString();



        }
    }
}
