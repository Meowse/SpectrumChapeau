namespace HW6_calculator
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.calcTextBox = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonDecimal = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonExponent = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonUnary = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSq = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calcTextBox
            // 
            this.calcTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.calcTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.calcTextBox.Location = new System.Drawing.Point(13, 21);
            this.calcTextBox.Name = "calcTextBox";
            this.calcTextBox.Size = new System.Drawing.Size(271, 38);
            this.calcTextBox.TabIndex = 0;
            this.calcTextBox.TextChanged += new System.EventHandler(this.calcTextBox_TextChanged);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonClear.Location = new System.Drawing.Point(228, 75);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(56, 46);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClearClick);
            // 
            // buttonOne
            // 
            this.buttonOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonOne.Location = new System.Drawing.Point(13, 140);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(56, 46);
            this.buttonOne.TabIndex = 2;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = true;
            this.buttonOne.Click += new System.EventHandler(this.ButtonOneClick);
            // 
            // buttonSeven
            // 
            this.buttonSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeven.Location = new System.Drawing.Point(13, 254);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(56, 46);
            this.buttonSeven.TabIndex = 4;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = true;
            this.buttonSeven.Click += new System.EventHandler(this.ButtonSevenClick);
            // 
            // buttonFour
            // 
            this.buttonFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonFour.Location = new System.Drawing.Point(13, 198);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(56, 46);
            this.buttonFour.TabIndex = 3;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = true;
            this.buttonFour.Click += new System.EventHandler(this.ButtonFourClick);
            // 
            // buttonZero
            // 
            this.buttonZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonZero.Location = new System.Drawing.Point(13, 314);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(56, 46);
            this.buttonZero.TabIndex = 5;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = true;
            this.buttonZero.Click += new System.EventHandler(this.ButtonZeroClick);
            // 
            // buttonDecimal
            // 
            this.buttonDecimal.Enabled = false;
            this.buttonDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDecimal.Location = new System.Drawing.Point(85, 314);
            this.buttonDecimal.Name = "buttonDecimal";
            this.buttonDecimal.Size = new System.Drawing.Size(56, 46);
            this.buttonDecimal.TabIndex = 10;
            this.buttonDecimal.TabStop = false;
            this.buttonDecimal.Text = ".";
            this.buttonDecimal.UseVisualStyleBackColor = true;
            // 
            // buttonEight
            // 
            this.buttonEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonEight.Location = new System.Drawing.Point(85, 254);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(56, 46);
            this.buttonEight.TabIndex = 9;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = true;
            this.buttonEight.Click += new System.EventHandler(this.ButtonEightClick);
            // 
            // buttonFive
            // 
            this.buttonFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonFive.Location = new System.Drawing.Point(85, 198);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(56, 46);
            this.buttonFive.TabIndex = 8;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = true;
            this.buttonFive.Click += new System.EventHandler(this.ButtonFiveClick);
            // 
            // buttonTwo
            // 
            this.buttonTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonTwo.Location = new System.Drawing.Point(85, 140);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(56, 46);
            this.buttonTwo.TabIndex = 7;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = true;
            this.buttonTwo.Click += new System.EventHandler(this.ButtonTwoClick);
            // 
            // buttonExponent
            // 
            this.buttonExponent.Enabled = false;
            this.buttonExponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonExponent.Location = new System.Drawing.Point(12, 75);
            this.buttonExponent.Name = "buttonExponent";
            this.buttonExponent.Size = new System.Drawing.Size(56, 46);
            this.buttonExponent.TabIndex = 6;
            this.buttonExponent.TabStop = false;
            this.buttonExponent.Text = "x^y";
            this.buttonExponent.UseVisualStyleBackColor = true;
            // 
            // buttonEqual
            // 
            this.buttonEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonEqual.Location = new System.Drawing.Point(156, 314);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(56, 46);
            this.buttonEqual.TabIndex = 15;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.ButtonEqualClick);
            // 
            // buttonNine
            // 
            this.buttonNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonNine.Location = new System.Drawing.Point(156, 254);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(56, 46);
            this.buttonNine.TabIndex = 14;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = true;
            this.buttonNine.Click += new System.EventHandler(this.ButtonNineClick);
            // 
            // buttonSix
            // 
            this.buttonSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonSix.Location = new System.Drawing.Point(156, 198);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(56, 46);
            this.buttonSix.TabIndex = 13;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = true;
            this.buttonSix.Click += new System.EventHandler(this.ButtonSixClick);
            // 
            // buttonThree
            // 
            this.buttonThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonThree.Location = new System.Drawing.Point(156, 140);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(56, 46);
            this.buttonThree.TabIndex = 12;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = true;
            this.buttonThree.Click += new System.EventHandler(this.ButtonThreeClick);
            // 
            // buttonUnary
            // 
            this.buttonUnary.Enabled = false;
            this.buttonUnary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonUnary.Location = new System.Drawing.Point(85, 75);
            this.buttonUnary.Name = "buttonUnary";
            this.buttonUnary.Size = new System.Drawing.Size(56, 46);
            this.buttonUnary.TabIndex = 11;
            this.buttonUnary.TabStop = false;
            this.buttonUnary.Text = "1/x";
            this.buttonUnary.UseVisualStyleBackColor = true;
            // 
            // buttonDivide
            // 
            this.buttonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonDivide.Location = new System.Drawing.Point(228, 314);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(56, 46);
            this.buttonDivide.TabIndex = 20;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.ButtonDivideClick);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonMultiply.Location = new System.Drawing.Point(228, 254);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(56, 46);
            this.buttonMultiply.TabIndex = 19;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.ButtonMultiplyClick);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonSubtract.Location = new System.Drawing.Point(228, 198);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(56, 46);
            this.buttonSubtract.TabIndex = 18;
            this.buttonSubtract.Text = "-";
            this.buttonSubtract.UseVisualStyleBackColor = true;
            this.buttonSubtract.Click += new System.EventHandler(this.ButtonSubtractClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonAdd.Location = new System.Drawing.Point(228, 140);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(56, 46);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAddClick);
            // 
            // buttonSq
            // 
            this.buttonSq.Enabled = false;
            this.buttonSq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonSq.Location = new System.Drawing.Point(157, 75);
            this.buttonSq.Name = "buttonSq";
            this.buttonSq.Size = new System.Drawing.Size(56, 46);
            this.buttonSq.TabIndex = 16;
            this.buttonSq.TabStop = false;
            this.buttonSq.Text = "sq";
            this.buttonSq.UseVisualStyleBackColor = true;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 386);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSq);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonNine);
            this.Controls.Add(this.buttonSix);
            this.Controls.Add(this.buttonThree);
            this.Controls.Add(this.buttonUnary);
            this.Controls.Add(this.buttonDecimal);
            this.Controls.Add(this.buttonEight);
            this.Controls.Add(this.buttonFive);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.buttonExponent);
            this.Controls.Add(this.buttonZero);
            this.Controls.Add(this.buttonSeven);
            this.Controls.Add(this.buttonFour);
            this.Controls.Add(this.buttonOne);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.calcTextBox);
            this.Location = new System.Drawing.Point(5, 5);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox calcTextBox;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button buttonDecimal;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonExponent;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonUnary;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSq;
    }
}

