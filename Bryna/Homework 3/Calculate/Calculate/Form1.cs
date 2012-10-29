// Bryna Shane
// .Net Development Foundations, Fall 2012
// Homework Assignment #3
// October 31, 2012

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EqualsButtonClicked(object sender, EventArgs e)
        {
            Decimal leftOperand = Convert.ToDecimal(leftOperandField.Text);
            Decimal rightOperand = Convert.ToDecimal(rightOperandField.Text);
            var result = CalculateResult(rightOperand, leftOperand);
            resultLabel.Text = FormatForDisplay(result);
        }

        private static string FormatForDisplay(decimal result)
        {
            return string.Format("{0:#.##}", result);
        }

        private decimal CalculateResult(decimal rightOperand, decimal leftOperand)
        {
            switch (operationDropdown.Text)
            {
                case "+":
                    return leftOperand + rightOperand;
                case "-":
                    return leftOperand - rightOperand;
                case "*":
                    return leftOperand*rightOperand;
                default:
                    return leftOperand/rightOperand;
            }
        }
    }
}
