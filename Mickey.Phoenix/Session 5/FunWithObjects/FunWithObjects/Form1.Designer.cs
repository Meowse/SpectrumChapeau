namespace FunWithObjects
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
            this.button1 = new System.Windows.Forms.Button();
            this.WhatToDo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.doOrUndoLastCreated = new System.Windows.Forms.Button();
            this.doOrUndoLastChanged = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create a New Action";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.MakeNewDoesSomething);
            // 
            // WhatToDo
            // 
            this.WhatToDo.Location = new System.Drawing.Point(144, 14);
            this.WhatToDo.Name = "WhatToDo";
            this.WhatToDo.Size = new System.Drawing.Size(100, 20);
            this.WhatToDo.TabIndex = 1;
            this.WhatToDo.Text = "Default";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Do ALL the Things!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.DoAllTheThings);
            // 
            // doOrUndoLastCreated
            // 
            this.doOrUndoLastCreated.Location = new System.Drawing.Point(13, 72);
            this.doOrUndoLastCreated.Name = "doOrUndoLastCreated";
            this.doOrUndoLastCreated.Size = new System.Drawing.Size(176, 23);
            this.doOrUndoLastCreated.TabIndex = 3;
            this.doOrUndoLastCreated.Text = "Do or Undo Last Created";
            this.doOrUndoLastCreated.UseVisualStyleBackColor = true;
            this.doOrUndoLastCreated.Click += new System.EventHandler(this.ToggleLastActionState);
            // 
            // doOrUndoLastChanged
            // 
            this.doOrUndoLastChanged.Enabled = false;
            this.doOrUndoLastChanged.Location = new System.Drawing.Point(13, 101);
            this.doOrUndoLastChanged.Name = "doOrUndoLastChanged";
            this.doOrUndoLastChanged.Size = new System.Drawing.Size(176, 23);
            this.doOrUndoLastChanged.TabIndex = 4;
            this.doOrUndoLastChanged.Text = "Do or Undo Last Changed";
            this.doOrUndoLastChanged.UseVisualStyleBackColor = true;
            this.doOrUndoLastChanged.Click += new System.EventHandler(this.DoOrUndoLastChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 216);
            this.Controls.Add(this.doOrUndoLastChanged);
            this.Controls.Add(this.doOrUndoLastCreated);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.WhatToDo);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Main Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox WhatToDo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button doOrUndoLastCreated;
        private System.Windows.Forms.Button doOrUndoLastChanged;
    }
}

