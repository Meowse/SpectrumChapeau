namespace Calculator
{
    partial class formCalculator
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
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonNumber1 = new System.Windows.Forms.Button();
            this.buttonNumber2 = new System.Windows.Forms.Button();
            this.buttonNumber3 = new System.Windows.Forms.Button();
            this.buttonNumber4 = new System.Windows.Forms.Button();
            this.buttonNumber5 = new System.Windows.Forms.Button();
            this.buttonNumber6 = new System.Windows.Forms.Button();
            this.buttonNumber7 = new System.Windows.Forms.Button();
            this.buttonNumber8 = new System.Windows.Forms.Button();
            this.buttonNumber9 = new System.Windows.Forms.Button();
            this.buttonNumber0 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelResult
            // 
            this.labelResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelResult.Location = new System.Drawing.Point(12, 9);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(278, 69);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "0.";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelResult.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonNumber1
            // 
            this.buttonNumber1.Location = new System.Drawing.Point(12, 102);
            this.buttonNumber1.Name = "buttonNumber1";
            this.buttonNumber1.Size = new System.Drawing.Size(65, 45);
            this.buttonNumber1.TabIndex = 1;
            this.buttonNumber1.Text = "1";
            this.buttonNumber1.UseVisualStyleBackColor = true;
            this.buttonNumber1.Click += new System.EventHandler(this.buttonNumber1_Click);
            // 
            // buttonNumber2
            // 
            this.buttonNumber2.Location = new System.Drawing.Point(83, 102);
            this.buttonNumber2.Name = "buttonNumber2";
            this.buttonNumber2.Size = new System.Drawing.Size(65, 45);
            this.buttonNumber2.TabIndex = 2;
            this.buttonNumber2.Text = "2";
            this.buttonNumber2.UseVisualStyleBackColor = true;
            this.buttonNumber2.Click += new System.EventHandler(this.buttonNumber2_Click);
            // 
            // buttonNumber3
            // 
            this.buttonNumber3.Location = new System.Drawing.Point(154, 102);
            this.buttonNumber3.Name = "buttonNumber3";
            this.buttonNumber3.Size = new System.Drawing.Size(65, 45);
            this.buttonNumber3.TabIndex = 3;
            this.buttonNumber3.Text = "3";
            this.buttonNumber3.UseVisualStyleBackColor = true;
            this.buttonNumber3.Click += new System.EventHandler(this.buttonNumber3_Click);
            // 
            // buttonNumber4
            // 
            this.buttonNumber4.Location = new System.Drawing.Point(12, 153);
            this.buttonNumber4.Name = "buttonNumber4";
            this.buttonNumber4.Size = new System.Drawing.Size(65, 45);
            this.buttonNumber4.TabIndex = 4;
            this.buttonNumber4.Text = "4";
            this.buttonNumber4.UseVisualStyleBackColor = true;
            this.buttonNumber4.Click += new System.EventHandler(this.buttonNumber4_Click);
            // 
            // buttonNumber5
            // 
            this.buttonNumber5.Location = new System.Drawing.Point(83, 153);
            this.buttonNumber5.Name = "buttonNumber5";
            this.buttonNumber5.Size = new System.Drawing.Size(65, 45);
            this.buttonNumber5.TabIndex = 5;
            this.buttonNumber5.Text = "5";
            this.buttonNumber5.UseVisualStyleBackColor = true;
            this.buttonNumber5.Click += new System.EventHandler(this.buttonNumber5_Click);
            // 
            // buttonNumber6
            // 
            this.buttonNumber6.Location = new System.Drawing.Point(154, 153);
            this.buttonNumber6.Name = "buttonNumber6";
            this.buttonNumber6.Size = new System.Drawing.Size(65, 45);
            this.buttonNumber6.TabIndex = 6;
            this.buttonNumber6.Text = "6";
            this.buttonNumber6.UseVisualStyleBackColor = true;
            this.buttonNumber6.Click += new System.EventHandler(this.buttonNumber6_Click);
            // 
            // buttonNumber7
            // 
            this.buttonNumber7.Location = new System.Drawing.Point(12, 204);
            this.buttonNumber7.Name = "buttonNumber7";
            this.buttonNumber7.Size = new System.Drawing.Size(65, 45);
            this.buttonNumber7.TabIndex = 7;
            this.buttonNumber7.Text = "7";
            this.buttonNumber7.UseVisualStyleBackColor = true;
            this.buttonNumber7.Click += new System.EventHandler(this.buttonNumber7_Click);
            // 
            // buttonNumber8
            // 
            this.buttonNumber8.Location = new System.Drawing.Point(83, 204);
            this.buttonNumber8.Name = "buttonNumber8";
            this.buttonNumber8.Size = new System.Drawing.Size(65, 45);
            this.buttonNumber8.TabIndex = 8;
            this.buttonNumber8.Text = "8";
            this.buttonNumber8.UseVisualStyleBackColor = true;
            this.buttonNumber8.Click += new System.EventHandler(this.buttonNumber8_Click);
            // 
            // buttonNumber9
            // 
            this.buttonNumber9.Location = new System.Drawing.Point(154, 204);
            this.buttonNumber9.Name = "buttonNumber9";
            this.buttonNumber9.Size = new System.Drawing.Size(65, 45);
            this.buttonNumber9.TabIndex = 9;
            this.buttonNumber9.Text = "9";
            this.buttonNumber9.UseVisualStyleBackColor = true;
            this.buttonNumber9.Click += new System.EventHandler(this.buttonNumber9_Click);
            // 
            // buttonNumber0
            // 
            this.buttonNumber0.Location = new System.Drawing.Point(12, 255);
            this.buttonNumber0.Name = "buttonNumber0";
            this.buttonNumber0.Size = new System.Drawing.Size(65, 45);
            this.buttonNumber0.TabIndex = 10;
            this.buttonNumber0.Text = "0";
            this.buttonNumber0.UseVisualStyleBackColor = true;
            this.buttonNumber0.Click += new System.EventHandler(this.buttonNumber0_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(225, 102);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(65, 45);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.Location = new System.Drawing.Point(225, 153);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(65, 45);
            this.buttonSubtract.TabIndex = 12;
            this.buttonSubtract.Text = "-";
            this.buttonSubtract.UseVisualStyleBackColor = true;
            this.buttonSubtract.Click += new System.EventHandler(this.buttonSubtract_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(225, 204);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(65, 45);
            this.buttonMultiply.TabIndex = 13;
            this.buttonMultiply.Text = "x";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Location = new System.Drawing.Point(225, 255);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(65, 45);
            this.buttonDivide.TabIndex = 14;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // buttonEquals
            // 
            this.buttonEquals.Location = new System.Drawing.Point(154, 255);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(65, 45);
            this.buttonEquals.TabIndex = 15;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(83, 255);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(65, 45);
            this.buttonClear.TabIndex = 16;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // formCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 312);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonNumber0);
            this.Controls.Add(this.buttonNumber9);
            this.Controls.Add(this.buttonNumber8);
            this.Controls.Add(this.buttonNumber7);
            this.Controls.Add(this.buttonNumber6);
            this.Controls.Add(this.buttonNumber5);
            this.Controls.Add(this.buttonNumber4);
            this.Controls.Add(this.buttonNumber3);
            this.Controls.Add(this.buttonNumber2);
            this.Controls.Add(this.buttonNumber1);
            this.Controls.Add(this.labelResult);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formCalculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonNumber1;
        private System.Windows.Forms.Button buttonNumber2;
        private System.Windows.Forms.Button buttonNumber3;
        private System.Windows.Forms.Button buttonNumber4;
        private System.Windows.Forms.Button buttonNumber5;
        private System.Windows.Forms.Button buttonNumber6;
        private System.Windows.Forms.Button buttonNumber7;
        private System.Windows.Forms.Button buttonNumber8;
        private System.Windows.Forms.Button buttonNumber9;
        private System.Windows.Forms.Button buttonNumber0;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonClear;
    }
}

