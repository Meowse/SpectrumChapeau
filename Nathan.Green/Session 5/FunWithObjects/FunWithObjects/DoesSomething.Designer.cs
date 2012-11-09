namespace FunWithObjects
{
    partial class DoesSomething
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
            this.DoButton = new System.Windows.Forms.Button();
            this.UndoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DoButton
            // 
            this.DoButton.Location = new System.Drawing.Point(13, 13);
            this.DoButton.Name = "DoButton";
            this.DoButton.Size = new System.Drawing.Size(75, 23);
            this.DoButton.TabIndex = 0;
            this.DoButton.Text = "Do It!";
            this.DoButton.UseVisualStyleBackColor = true;
            this.DoButton.Click += new System.EventHandler(this.DoTheAction);
            // 
            // UndoButton
            // 
            this.UndoButton.Location = new System.Drawing.Point(95, 13);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(75, 23);
            this.UndoButton.TabIndex = 1;
            this.UndoButton.Text = "Undo!";
            this.UndoButton.UseVisualStyleBackColor = true;
            this.UndoButton.Click += new System.EventHandler(this.UndoTheAction);
            // 
            // DoesSomething
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 69);
            this.Controls.Add(this.UndoButton);
            this.Controls.Add(this.DoButton);
            this.Name = "DoesSomething";
            this.Text = "Does Something";
            this.Load += new System.EventHandler(this.DoesSomething_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DoButton;
        private System.Windows.Forms.Button UndoButton;
    }
}