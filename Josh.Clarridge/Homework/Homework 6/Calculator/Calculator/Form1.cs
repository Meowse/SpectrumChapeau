using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calculator
{

    public partial class Form1 : Form
    {
        private readonly List<string> _operands = new List<string>();
        private readonly List<string> _operations = new List<string>();
        private string _currentTotal;
        private bool _startNewNumber;

        public Form1()
        {
            InitializeComponent();
        }

        private void EnterNumberInTextField(int i)
        {
            if (_startNewNumber)
            {
                textBox1.Text = i.ToString();
                _startNewNumber = false;
            }
            else
            {
                textBox1.Text = (Convert.ToDouble(textBox1.Text)*10 + i).ToString();
            }
        }

        private void ZeroClick(object sender, EventArgs e)
        {
            EnterNumberInTextField(0);
        }

        private void OneClick(object sender, EventArgs e)
        {
            EnterNumberInTextField(1);
        }

        private void TwoClick(object sender, EventArgs e)
        {
            EnterNumberInTextField(2);
        }

        private void ThreeClick(object sender, EventArgs e)
        {
            EnterNumberInTextField(3);
        }

        private void FourClick(object sender, EventArgs e)
        {
            EnterNumberInTextField(4);
        }

        private void FiveClick(object sender, EventArgs e)
        {
            EnterNumberInTextField(5);
        }

        private void SixClick(object sender, EventArgs e)
        {
            EnterNumberInTextField(6);
        }

        private void SevenClick(object sender, EventArgs e)
        {
            EnterNumberInTextField(7);
        }

        private void EightClick(object sender, EventArgs e)
        {
            EnterNumberInTextField(8);
        }

        private void NineClick(object sender, EventArgs e)
        {
            EnterNumberInTextField(9);
        }

        private void ClearClick(object sender, EventArgs e)
        {
            ResetCalculator();
        }

        private void ResetCalculator()
        {
            textBox1.Text = "0";
            _operands.Clear();
            _operations.Clear();
        }

        private void NonUnaryOperatorSelected(string operation)
        {
            _operands.Add(textBox1.Text);
            _operations.Add(operation);
            _startNewNumber = true;
        }

        private void AdditionClick(object sender, EventArgs e)
        {
            NonUnaryOperatorSelected("addition");
        }

        private void SubtractionClick(object sender, EventArgs e)
        {
            NonUnaryOperatorSelected("subtraction");
        }

        private void MultiplicationClick(object sender, EventArgs e)
        {
            NonUnaryOperatorSelected("multiplication");
        }

        private void DivisionClick(object sender, EventArgs e)
        {
            NonUnaryOperatorSelected("division");
        }

        private void ExponentiationClick(object sender, EventArgs e)
        {
            NonUnaryOperatorSelected("exponentiation");
        }

        private void SquarerootClick(object sender, EventArgs e)
        {
            DoUnaryCalculation("squareroot");
        }

        private void InverseClick(object sender, EventArgs e)
        {
            DoUnaryCalculation("inverse");
        }

        private void EqualsClick(object sender, EventArgs e)
        {
            _operands.Add(textBox1.Text);
            _startNewNumber = true;
            _currentTotal = _operands[0];
            for (int i = 1; i < _operands.Count; i++)
            {
                DoCalculation(_currentTotal, _operands[i], _operations[i - 1]);
            }
            textBox1.Text = _currentTotal;
            _operands.Clear();
            _operations.Clear();
        }

        private void DoCalculation(string currentTotal, string number, string operation)
        {
            switch (operation)
            {
                case "addition":
                    _currentTotal = (Convert.ToDouble(currentTotal) + Convert.ToDouble(number)).ToString();
                    break;
                case "subtraction":
                    _currentTotal = (Convert.ToDouble(currentTotal) - Convert.ToDouble(number)).ToString();
                    break;
                case "multiplication":
                    _currentTotal = (Convert.ToDouble(currentTotal) * Convert.ToDouble(number)).ToString();
                    break;
                case "division":
                    _currentTotal = (Convert.ToDouble(currentTotal) / Convert.ToDouble(number)).ToString();
                    break;
                case "exponentiation":
                    _currentTotal = (Math.Pow(Convert.ToDouble(currentTotal), Convert.ToDouble(number))).ToString();
                    break;
            }
        }

        private void DoUnaryCalculation(string operation)
        {
            switch (operation)
            {
                case "squareroot":
                    textBox1.Text = Math.Sqrt(Convert.ToDouble(textBox1.Text)).ToString();
                    break;
                case "inverse":
                    textBox1.Text = (1 / Convert.ToDouble(textBox1.Text)).ToString();
                    break;
            }
        }
    }
}
