using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sunils_Fancy_Calculator_in_CS
{
    public partial class Form1 : Form
    {
        public bool powerUpState = false;
        public string WhatToDisplay = "";
        public string NumberBuffer = "";
        public double FirstNumber = 0;
        public double SecondNumber = 0;
        public bool OperatorIn = false;
        public String Action;
        public double Result;
        public bool decimalEntered = false;
        public string PreviousButton = "";
        public const string ErrorMessage = "ERR-ON/OFF";
        public bool CalcError = false;

        public Form1()
        {
            InitializeComponent();
        }

       
        private void OnOffButton_Click(object sender, EventArgs e)
        {
          

            if(powerUpState==true)
            {
                ReadKey(OnOffButton.Text);  
            }
            else
            {
                Clear();
                NumberBuffer = "0";
                WhatToDisplay = NumberBuffer;
                powerUpState = true;
                SwitchDisplay(powerUpState);

            }

        }



        private void reset()
        {
            //Add flags to clear
            Clear();
            NumberBuffer = "0";
            WhatToDisplay = NumberBuffer;
            Display(WhatToDisplay);
        }


        private void Clear()
        {

            NumberBuffer = "";
            FirstNumber = 0;
            SecondNumber = 0;
            Result = 0;
            OperatorIn = false;
            decimalEntered = false;
            Action = "";
            PreviousButton = "";
            CalcError = false;

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Display(string ToDisplay)
        {
            //MessageBox.Show(ToDisplay);
            DisplayBox.Text = ToDisplay;
        }

        //private void DetermineSecondNumber()
        //{
        //    SecondNumber = Convert.ToDouble(NumberBuffer);
        //    ////need to handle repetetive equals
        //    /// if numbers ="" (you wont come to eval second number) numbers =todouble whatsdisplay, second number entered.
        //    /// add flas if result is calculated and now of operator is pressed keep first number
            
        //}

        //private void DetermineFirstNumber()
        //{
        //    FirstNumber = Convert.ToDouble(NumberBuffer);
        
        //}

        
        
        private void determineOperation()
        {
            
            switch (PreviousButton)
            {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    Evaluate();
                    break;
                case ".":
                    AppendNumbers("0");
                     Evaluate();
                    break;
              
                //case "+":
                //case "-":
                //case "/":
                //case "x":
                //   break;
                //case "=":
                //   break;
              
            } 
        }
        
        private void Evaluate( )
        {
            if(NumberBuffer =="")
            {
                //NumberBuffer = WhatToDisplay;
                NumberBuffer = Convert.ToString(SecondNumber);
            }

            if(!OperatorIn)
            {
                Result = Convert.ToDouble(NumberBuffer);
                //SecondNumber = Result;
                //NumberBuffer = "";

            }
            else
            {
                switch (Action)
                {
                    case "+":
                        //Result = FirstNumber + SecondNumber;
                        Result = Result + Convert.ToDouble(NumberBuffer);
                        break;
                    case "-":
                        //Result = FirstNumber - SecondNumber;
                        Result = Result - Convert.ToDouble(NumberBuffer);
                        break;
                    case "x":
                        //Result = FirstNumber * SecondNumber;
                        Result = Result * Convert.ToDouble(NumberBuffer);
                        break;
                    case "/":
                        //Result = FirstNumber/SecondNumber;
                        if(NumberBuffer == "0")
                        {
                            //Clear();
                            //WhatToDisplay = ErrorMessage;
                            //MessageBox.Show(WhatToDisplay);
                            //Display(WhatToDisplay);
                            //Application.DoEvents();
                            //System.Threading.Thread.Sleep(30);
                            CalcError = true;
                        }
                        else
                        {
                            Result = Result / Convert.ToDouble(NumberBuffer);    
                        }
                        break;

                }  
            }
            
            if(CalcError)
            {
                WhatToDisplay = ErrorMessage;
            }
            else
            {
                WhatToDisplay = Convert.ToString(Result);  
            }
            Display(WhatToDisplay);
            
            if (NumberBuffer == "0")
            {
                SecondNumber = 0;
            }
            else
            {
                SecondNumber = Convert.ToDouble(NumberBuffer);
                
            }
            NumberBuffer = "";

        }

        private void ReadKey(String Key)
        {
            
            if (powerUpState == true)
            {
                switch (Key)
                    {
                        case "0":
                        case "1":
                        case "2":
                        case "3":
                        case "4":
                        case "5":
                        case "6":
                        case "7":
                        case "8":
                        case "9":
                        case ".":
                            ActionOnNumberButton(Key);
                            break;
                        case "+":
                        case "-":
                        case "/":
                        case "x":

                            determineOperation();
                            OperatorIn = true;
                            Action = Key;
                            //NumberBuffer = "";
                            break;
                        case "C":
                            Clear();
                            SwitchDisplay(powerUpState);
                            break;
                        case "=":
                            Evaluate();
                            break;
                        case "On/Off":
                            Clear();
                            powerUpState = false;
                            SwitchDisplay(powerUpState);
                            break;
                    }
                    
            
            }
PreviousButton = Key;
            }

        private void SwitchDisplay(bool On)
        {
            if (On) NumberBuffer = "0";
            else NumberBuffer = "";

            WhatToDisplay = NumberBuffer;
            Display(WhatToDisplay);
        }

        private void ActionOnNumberButton(string Key)
        {
            switch (Key)
            {

                case "0":
                    if (NumberBuffer != "0")
                    {
                        AppendNumbers(Key);
                    }
                    break;
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    if (NumberBuffer == "0")
                    {
                        NumberBuffer = "";
                        AppendNumbers(Key);
                    }
                    else
                    {
                        AppendNumbers(Key);
                    }
                    break;

                case ".":
                    if (decimalEntered == false)
                    {
                        AppendNumbers(Key);
                        decimalEntered = true;
                    }
                    break;
                
            }
        }
        

       private void AppendNumbers(string Key)
       {
           NumberBuffer += Key;
           WhatToDisplay = NumberBuffer;
           //MessageBox.Show(NumberBuffer);
           Display(WhatToDisplay); 
       }

        private void OneButton_Click(object sender, EventArgs e)
        {
           ReadKey(OneButton.Text);
         }

        private void AddButton_Click(object sender, EventArgs e)
        {
           ReadKey(AddButton.Text);
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            ReadKey(TwoButton.Text);
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            ReadKey(ThreeButton.Text);
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            ReadKey(FourButton.Text);
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            ReadKey(FiveButton.Text);
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            ReadKey(SixButton.Text);
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            ReadKey(SevenButton.Text);
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            ReadKey(EightButton.Text);
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            ReadKey(NineButton.Text);
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            ReadKey(ZeroButton.Text);   
        }

        private void PointButton_Click(object sender, EventArgs e)
        {
            ReadKey(PointButton.Text);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ReadKey(ClearButton.Text);
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            ReadKey(EqualsButton.Text);
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            ReadKey(MinusButton.Text);
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            ReadKey(MultiplyButton.Text);
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            ReadKey(DivideButton.Text);
        }

        

       
        
    }
}
