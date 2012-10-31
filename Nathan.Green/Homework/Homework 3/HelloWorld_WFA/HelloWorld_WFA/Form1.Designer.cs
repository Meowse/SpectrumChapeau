namespace HelloWorld_WFA
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
            this.Hello_TextBox = new System.Windows.Forms.TextBox();
            this.Hello_Button = new System.Windows.Forms.Button();
            this.Hello_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Hello_TextBox
            // 
            this.Hello_TextBox.Location = new System.Drawing.Point(27, 13);
            this.Hello_TextBox.Name = "Hello_TextBox";
            this.Hello_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Hello_TextBox.TabIndex = 0;
            this.Hello_TextBox.TextChanged += new System.EventHandler(this.HelloTextBoxTextChanged);
            // 
            // Hello_Button
            // 
            this.Hello_Button.Enabled = false;
            this.Hello_Button.Location = new System.Drawing.Point(156, 9);
            this.Hello_Button.Name = "Hello_Button";
            this.Hello_Button.Size = new System.Drawing.Size(75, 23);
            this.Hello_Button.TabIndex = 1;
            this.Hello_Button.Text = "Hello!";
            this.Hello_Button.UseVisualStyleBackColor = true;
            this.Hello_Button.Click += new System.EventHandler(this.HelloButtonClick);
            // 
            // Hello_Label
            // 
            this.Hello_Label.AutoSize = true;
            this.Hello_Label.Location = new System.Drawing.Point(116, 96);
            this.Hello_Label.Name = "Hello_Label";
            this.Hello_Label.Size = new System.Drawing.Size(0, 13);
            this.Hello_Label.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Hello_Label);
            this.Controls.Add(this.Hello_Button);
            this.Controls.Add(this.Hello_TextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Hello_TextBox;
        private System.Windows.Forms.Button Hello_Button;
        private System.Windows.Forms.Label Hello_Label;
    }
}

