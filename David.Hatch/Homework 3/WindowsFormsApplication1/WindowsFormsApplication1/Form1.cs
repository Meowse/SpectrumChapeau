using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           string display_string = textBox1.Text;

           MessageBox.Show(display_string);

           
        }
    }
}



////
//        // The simplest overload of MessageBox.Show. [1]
//        //
//        MessageBox.Show("Dot Net Perls is awesome.");
//        //
//        // Dialog box with text and a title. [2]
//        //
//        MessageBox.Show("Dot Net Perls is awesome.",
//        "Important Message");
//        //
//        // Dialog box with two buttons: yes and no. [3]
//        //
//        DialogResult result1 = MessageBox.Show("Is Dot Net Perls awesome?",
//        "Important Question",
//        MessageBoxButtons.YesNo);
//        //
//        // Dialog box with question icon. [4]
//        //
//        DialogResult result2 = MessageBox.Show("Is Dot Net Perls awesome?",
//        "Important Query",
//        MessageBoxButtons.YesNoCancel,
//        MessageBoxIcon.Question);
//        //
//        // Dialog box with question icon and default button. [5]
//        //
//        DialogResult result3 = MessageBox.Show("Is Visual Basic awesome?",
//        "The Question",
//        MessageBoxButtons.YesNoCancel,
//        MessageBoxIcon.Question,
//        MessageBoxDefaultButton.Button2);
//        //
//        // Test the results of the previous three dialogs. [6]
//        //
//        if (result1 == DialogResult.Yes &&
//        result2 == DialogResult.Yes &&
//        result3 == DialogResult.No)
//        {
//        MessageBox.Show("You answered yes, yes and no.");
//        }
//        //
//        // Dialog box that is right-aligned (not useful). [7]
//        //
//        MessageBox.Show("Dot Net Perls is the best.",
//        "Critical Warning",
//        MessageBoxButtons.OKCancel,
//        MessageBoxIcon.Warning,
//        MessageBoxDefaultButton.Button1,
//        MessageBoxOptions.RightAlign,
//        true);
//        //
//        // Dialog box with exclamation icon. [8]
//        //
//        MessageBox.Show("Dot Net Perls is super.",
//        "Important Note",
//        MessageBoxButtons.OK,
//        MessageBoxIcon.Exclamation,
//        MessageBoxDefaultButton.Button1);