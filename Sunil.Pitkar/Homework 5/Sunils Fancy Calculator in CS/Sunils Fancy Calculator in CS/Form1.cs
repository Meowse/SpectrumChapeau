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
        public String Action = "";
        public double Result;
        public bool firstNumberEntered = false;
        public bool secondNumberEntered = false;
        public bool decimalEntered = false;

        public Form1()
        {
            InitializeComponent();
        }

       
        private void OnOffButton_Click(object sender, EventArgs e)
        {
            if (powerUpState == false)
            {
                NumberBuffer = "0";
                WhatToDisplay = NumberBuffer;
                Display(WhatToDisplay);
                powerUpState = true;
            }
            else
            {
                Clear();
                powerUpState = false;
                WhatToDisplay = "";
                Display(WhatToDisplay);
            }
        }


        private void Clear()
        {
           //powerUpState = false;
           //WhatToDisplay = "0";
           NumberBuffer = "";
           FirstNumber = 0;
           SecondNumber = 0;
           OperatorIn = false;
           //powerUpState = false;
        
           //Display(WhatToDisplay);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Display(string ToDisplay)
        {
            DisplayBox.Text = ToDisplay;
        }

        private void DetermineSecondNumber()
        {
            SecondNumber = Convert.ToDouble(NumberBuffer);
            ////need to handle repetetive equals
            /// if numbers ="" (you wont come to eval second number) numbers =todouble whatsdisplay, second number entered.
            /// add flas if result is calculated and now of operator is pressed keep first number
            //if (secondNumberEntered ==false) 
            //        {
            //            SecondNumber = Convert.ToDouble(WhatToDisplay);
            //            secondNumberEntered = true;
            //        }
            //else
            //{
            //    if (NumberBuffer=="")
            //    {
                    
            //    }
            //}  
            //        {
            //            SecondNumber = Convert.ToDouble(NumberBuffer);
            //        }
        }

        private void DetermineFirstNumber()
        {
            FirstNumber = Convert.ToDouble(NumberBuffer);
            firstNumberEntered = true;
        }
        private void Evaluate( )
        {
            //FirstNumber = Convert.ToDouble(NumberBuffer);
            //NumberBuffer = "";
            //if (NumberBuffer == "")
            //{
            //    FirstNumber = Result;
            //}
            //else
            //{
            //    FirstNumber = Convert.ToDouble(NumberBuffer);
            //}
            DetermineSecondNumber();
            switch (Action)
            {
                case "+":
                    Result = FirstNumber + SecondNumber;
                    break;
                case "-":
                    Result = FirstNumber - SecondNumber;
                    break;
                case "x":
                    Result = FirstNumber * SecondNumber;
                    break;
                case "/":
                    Result = FirstNumber/SecondNumber;
                    break;
            }
            WhatToDisplay = Convert.ToString(Result);
            Display(WhatToDisplay);
            FirstNumber = Result;
        }

        private void ReadKey(String Key)
        {
            switch (Key)
            {
                   case "0":
                            if (NumberBuffer != "0") AppendNumbers(Key);
                                
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
                   case "+":
                   case "-":
                   case "/":
                   case "x":
                    OperatorIn = true;
                    Action = Key;
                    DetermineFirstNumber();
                    //FirstNumber = Convert.ToDouble(NumberBuffer);
                    NumberBuffer = "";
                    //NumberBuffer = "";
                    //MessageBox.Show(FirstNumber.ToString());
                    //SecondNumber = FirstNumber;
                    //clear flags and numbers
                    //Handle initial operator press and number buffer to start with 0
                    break;
                   case "C":
                    if (powerUpState == true)
                    {
                    Clear();
                    WhatToDisplay = "0";
                    Display(WhatToDisplay);
                    }
                    break;
                   case "=":
                    if (powerUpState == true)
                    {
                       Evaluate(); 
                    }
                    
                    //NumberBuffer = "";
                    break;

            }
            
        }

       private void AppendNumbers(string Key)
       {
           if (powerUpState == true)
           {
               NumberBuffer += Key;
               WhatToDisplay = NumberBuffer;
               Display(WhatToDisplay); 
           }
           else
           {
               Clear();
               WhatToDisplay = "";
               Display(WhatToDisplay); 
           }
       }

        private void OneButton_Click(object sender, EventArgs e)
        {
           //button vlaue is one
            // append string display, could be collection of strings
            //claculate number equivalent, not int, keep state of decimal " isDotpressed", for each item in collection of string increment powers of 10 unitl dot use state is decimanl

            //evaluate will call display
            ReadKey(OneButton.Text);
            //Display(OneButton.Text);

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //add or any operator clicked
            //disable dopt clecked state
            //Remember operator
            //IN evaluate you now should put earlier calculated number in first number and continue collecting number until =
            //on = copy the evalauted number to number 2
            // call calculate with 3 args number 1, number 2 and operator
            //call display with string format of result.
           // TODO Write initialize method for turn on and clear
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
            
            //if (NumberBuffer != "0")
            //{
                ReadKey(ZeroButton.Text);
            //}
            
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
