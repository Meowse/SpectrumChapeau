using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HW6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       


        private void button6_Click(object sender, EventArgs e)
        {
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        double total1 = 0;
        double total2 = 0;
        private string theOperator;
        private bool plusbuttonclicked = false;
        private bool minusbuttonclicked = false;
        private bool multiplybuttonclicked = false;
        private bool dividebuttonclicked = false;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {   
            textBox1.Text = textBox1.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += button10.Text;
        }

        private void plusbutton_Click_1(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(textBox1.Text);
            theOperator = "+";
            textBox1.Clear();
            
        }

        private void Equalbutton_Click(object sender, EventArgs e)
        {
            switch(theOperator)
            {
                case "+":
                total2 = total1 + double.Parse(textBox1.Text);
                textBox1.Text = total2.ToString();
                total1 = 0;
                break;

                case "-": 
                total2 = total1 - double.Parse(textBox1.Text);
                textBox1.Text = total2.ToString();
                total1 = 0;
                break;

                case "*": 
                total2 = total1*double.Parse(textBox1.Text);
                textBox1.Text = total2.ToString();
                total1 = 0;
                break;

                case "/": total2 = total1/double.Parse(textBox1.Text);
                textBox1.Text = total2.ToString();
                total1 = 0;
                break;

                default:
                total2 = 0;
                break;

            }
        }
        private void pointbutton_Click(object sender, EventArgs e)
        {
            textBox1.Text += pointbutton.Text;
        }

        private void minusbutton_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(textBox1.Text);
            theOperator = "-";
            textBox1.Clear();
            }

        private void multiplybutton_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(textBox1.Text);
            theOperator = "*";
            textBox1.Clear();
        }
        private void dividebutton_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(textBox1.Text);
            theOperator = "/";
            textBox1.Clear();
        }
        private void clearbutton_Click(object sender, EventArgs e)
        {
           textBox1.Clear();
        }

        

        
    }
}
