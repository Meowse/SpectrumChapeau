using System.Windows.Forms;

namespace DrawIt
{
    partial class DrawIt
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
            this.CanvasPanel = new System.Windows.Forms.Panel();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DrawLinesButton = new System.Windows.Forms.RadioButton();
            this.DrawCirclesButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DrawXesButton = new System.Windows.Forms.RadioButton();
            this.DrawRectanglesButton = new System.Windows.Forms.RadioButton();
            this.UndoButton = new System.Windows.Forms.Button();
            this.RedoButton = new System.Windows.Forms.Button();
            this.ChangeColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CanvasPanel
            // 
            this.CanvasPanel.Location = new System.Drawing.Point(16, 85);
            this.CanvasPanel.Margin = new System.Windows.Forms.Padding(4);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(761, 656);
            this.CanvasPanel.TabIndex = 0;
            // 
            // ClearButton
            // 
            this.ClearButton.Enabled = false;
            this.ClearButton.Location = new System.Drawing.Point(607, 16);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(100, 28);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButtonClicked);
            // 
            // DrawLinesButton
            // 
            this.DrawLinesButton.AutoSize = true;
            this.DrawLinesButton.Checked = true;
            this.DrawLinesButton.Location = new System.Drawing.Point(8, 23);
            this.DrawLinesButton.Margin = new System.Windows.Forms.Padding(4);
            this.DrawLinesButton.Name = "DrawLinesButton";
            this.DrawLinesButton.Size = new System.Drawing.Size(63, 21);
            this.DrawLinesButton.TabIndex = 2;
            this.DrawLinesButton.TabStop = true;
            this.DrawLinesButton.Text = "Lines";
            this.DrawLinesButton.UseVisualStyleBackColor = true;
            // 
            // DrawCirclesButton
            // 
            this.DrawCirclesButton.AutoSize = true;
            this.DrawCirclesButton.Location = new System.Drawing.Point(83, 23);
            this.DrawCirclesButton.Margin = new System.Windows.Forms.Padding(4);
            this.DrawCirclesButton.Name = "DrawCirclesButton";
            this.DrawCirclesButton.Size = new System.Drawing.Size(71, 21);
            this.DrawCirclesButton.TabIndex = 3;
            this.DrawCirclesButton.TabStop = true;
            this.DrawCirclesButton.Text = "Circles";
            this.DrawCirclesButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DrawXesButton);
            this.groupBox1.Controls.Add(this.DrawRectanglesButton);
            this.groupBox1.Controls.Add(this.DrawCirclesButton);
            this.groupBox1.Controls.Add(this.DrawLinesButton);
            this.groupBox1.Location = new System.Drawing.Point(16, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(348, 70);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Draw:";
            // 
            // DrawXesButton
            // 
            this.DrawXesButton.AutoSize = true;
            this.DrawXesButton.Location = new System.Drawing.Point(280, 25);
            this.DrawXesButton.Margin = new System.Windows.Forms.Padding(4);
            this.DrawXesButton.Name = "DrawXesButton";
            this.DrawXesButton.Size = new System.Drawing.Size(58, 21);
            this.DrawXesButton.TabIndex = 5;
            this.DrawXesButton.TabStop = true;
            this.DrawXesButton.Text = "X-es";
            this.DrawXesButton.UseVisualStyleBackColor = true;
            // 
            // DrawRectanglesButton
            // 
            this.DrawRectanglesButton.AutoSize = true;
            this.DrawRectanglesButton.Location = new System.Drawing.Point(165, 23);
            this.DrawRectanglesButton.Margin = new System.Windows.Forms.Padding(4);
            this.DrawRectanglesButton.Name = "DrawRectanglesButton";
            this.DrawRectanglesButton.Size = new System.Drawing.Size(100, 21);
            this.DrawRectanglesButton.TabIndex = 4;
            this.DrawRectanglesButton.TabStop = true;
            this.DrawRectanglesButton.Text = "Rectangles";
            this.DrawRectanglesButton.UseVisualStyleBackColor = true;
            // 
            // UndoButton
            // 
            this.UndoButton.Enabled = false;
            this.UndoButton.Location = new System.Drawing.Point(373, 16);
            this.UndoButton.Margin = new System.Windows.Forms.Padding(4);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(100, 28);
            this.UndoButton.TabIndex = 5;
            this.UndoButton.Text = "Undo";
            this.UndoButton.UseVisualStyleBackColor = true;
            this.UndoButton.Click += new System.EventHandler(this.UndoButtonClicked);
            // 
            // RedoButton
            // 
            this.RedoButton.Enabled = false;
            this.RedoButton.Location = new System.Drawing.Point(483, 15);
            this.RedoButton.Margin = new System.Windows.Forms.Padding(4);
            this.RedoButton.Name = "RedoButton";
            this.RedoButton.Size = new System.Drawing.Size(100, 28);
            this.RedoButton.TabIndex = 6;
            this.RedoButton.Text = "Redo";
            this.RedoButton.UseVisualStyleBackColor = true;
            this.RedoButton.Click += new System.EventHandler(this.RedoButtonClicked);
            // 
            // ChangeColor
            // 
            this.ChangeColor.Location = new System.Drawing.Point(732, 16);
            this.ChangeColor.Name = "ChangeColor";
            this.ChangeColor.Size = new System.Drawing.Size(102, 28);
            this.ChangeColor.TabIndex = 7;
            this.ChangeColor.Text = "Change Color";
            this.ChangeColor.UseVisualStyleBackColor = true;
            this.ChangeColor.Click += new System.EventHandler(this.ChangeColor_Click);
            // 
            // DrawIt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 706);
            this.Controls.Add(this.ChangeColor);
            this.Controls.Add(this.RedoButton);
            this.Controls.Add(this.UndoButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CanvasPanel);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DrawIt";
            this.Text = "DrawIt!";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.RadioButton DrawLinesButton;
        private System.Windows.Forms.RadioButton DrawCirclesButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton DrawRectanglesButton;
        private System.Windows.Forms.RadioButton DrawXesButton;
        private System.Windows.Forms.Panel CanvasPanel;
        private System.Windows.Forms.Button UndoButton;
        private System.Windows.Forms.Button RedoButton;
        private Button ChangeColor;
        private ColorDialog colorDialog1;
    }
}

