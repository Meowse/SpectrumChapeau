namespace Calculate
{
    partial class Form1
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
            this.leftOperandField = new System.Windows.Forms.TextBox();
            this.rightOperandField = new System.Windows.Forms.TextBox();
            this.equalsButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.operationDropdown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // leftOperandField
            // 
            this.leftOperandField.Location = new System.Drawing.Point(12, 24);
            this.leftOperandField.Name = "leftOperandField";
            this.leftOperandField.Size = new System.Drawing.Size(62, 20);
            this.leftOperandField.TabIndex = 0;
            // 
            // rightOperandField
            // 
            this.rightOperandField.Location = new System.Drawing.Point(123, 25);
            this.rightOperandField.Name = "rightOperandField";
            this.rightOperandField.Size = new System.Drawing.Size(50, 20);
            this.rightOperandField.TabIndex = 2;
            // 
            // equalsButton
            // 
            this.equalsButton.Location = new System.Drawing.Point(179, 21);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(27, 23);
            this.equalsButton.TabIndex = 3;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = true;
            this.equalsButton.Click += new System.EventHandler(this.EqualsButtonClicked);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(230, 31);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(31, 13);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "        ";
            // 
            // operationDropdown
            // 
            this.operationDropdown.FormattingEnabled = true;
            this.operationDropdown.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.operationDropdown.Location = new System.Drawing.Point(80, 25);
            this.operationDropdown.Name = "operationDropdown";
            this.operationDropdown.Size = new System.Drawing.Size(33, 21);
            this.operationDropdown.TabIndex = 1;
            this.operationDropdown.Text = "+";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.operationDropdown);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.equalsButton);
            this.Controls.Add(this.rightOperandField);
            this.Controls.Add(this.leftOperandField);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox leftOperandField;
        private System.Windows.Forms.TextBox rightOperandField;
        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.ComboBox operationDropdown;
    }
}

