﻿namespace FunWithObjects
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
            this.DoAllButton = new System.Windows.Forms.Button();
            this.UndoAllButton = new System.Windows.Forms.Button();
            this.RevertLastActionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create a New DoesSomething Window";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.MakeNewDoesSomething);
            // 
            // WhatToDo
            // 
            this.WhatToDo.Location = new System.Drawing.Point(243, 13);
            this.WhatToDo.Name = "WhatToDo";
            this.WhatToDo.Size = new System.Drawing.Size(100, 20);
            this.WhatToDo.TabIndex = 1;
            // 
            // DoAllButton
            // 
            this.DoAllButton.Location = new System.Drawing.Point(13, 42);
            this.DoAllButton.Name = "DoAllButton";
            this.DoAllButton.Size = new System.Drawing.Size(115, 23);
            this.DoAllButton.TabIndex = 2;
            this.DoAllButton.Text = "Do ALL the Things!";
            this.DoAllButton.UseVisualStyleBackColor = true;
            this.DoAllButton.Click += new System.EventHandler(this.DoAllTheThings);
            // 
            // UndoAllButton
            // 
            this.UndoAllButton.Location = new System.Drawing.Point(135, 42);
            this.UndoAllButton.Name = "UndoAllButton";
            this.UndoAllButton.Size = new System.Drawing.Size(101, 23);
            this.UndoAllButton.TabIndex = 3;
            this.UndoAllButton.Text = "Undo All";
            this.UndoAllButton.UseVisualStyleBackColor = true;
            this.UndoAllButton.Click += new System.EventHandler(this.UndoAllTheThings);
            // 
            // RevertLastActionButton
            // 
            this.RevertLastActionButton.Location = new System.Drawing.Point(69, 71);
            this.RevertLastActionButton.Name = "RevertLastActionButton";
            this.RevertLastActionButton.Size = new System.Drawing.Size(115, 23);
            this.RevertLastActionButton.TabIndex = 4;
            this.RevertLastActionButton.Text = "Revert Last Action";
            this.RevertLastActionButton.UseVisualStyleBackColor = true;
            this.RevertLastActionButton.Click += new System.EventHandler(this.RevertLastAction);
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 216);
            this.Controls.Add(this.RevertLastActionButton);
            this.Controls.Add(this.UndoAllButton);
            this.Controls.Add(this.DoAllButton);
            this.Controls.Add(this.WhatToDo);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox WhatToDo;
        private System.Windows.Forms.Button DoAllButton;
        private System.Windows.Forms.Button UndoAllButton;
        private System.Windows.Forms.Button RevertLastActionButton;
    }
}

