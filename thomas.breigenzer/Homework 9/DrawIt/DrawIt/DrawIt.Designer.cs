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
            this.FillShapeCheckBox = new System.Windows.Forms.CheckBox();
            this.DrawXesButton = new System.Windows.Forms.RadioButton();
            this.DrawRectanglesButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UndoButton = new System.Windows.Forms.Button();
            this.RedoButton = new System.Windows.Forms.Button();
            this.ColorSelectionButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CanvasPanel
            // 
            this.CanvasPanel.Location = new System.Drawing.Point(12, 101);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(639, 501);
            this.CanvasPanel.TabIndex = 0;
            // 
            // ClearButton
            // 
            this.ClearButton.Enabled = false;
            this.ClearButton.Location = new System.Drawing.Point(576, 19);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButtonClicked);
            // 
            // DrawLinesButton
            // 
            this.DrawLinesButton.AutoSize = true;
            this.DrawLinesButton.Checked = true;
            this.DrawLinesButton.Location = new System.Drawing.Point(6, 19);
            this.DrawLinesButton.Name = "DrawLinesButton";
            this.DrawLinesButton.Size = new System.Drawing.Size(50, 17);
            this.DrawLinesButton.TabIndex = 2;
            this.DrawLinesButton.TabStop = true;
            this.DrawLinesButton.Text = "Lines";
            this.DrawLinesButton.UseVisualStyleBackColor = true;
            // 
            // DrawCirclesButton
            // 
            this.DrawCirclesButton.AutoSize = true;
            this.DrawCirclesButton.Location = new System.Drawing.Point(62, 19);
            this.DrawCirclesButton.Name = "DrawCirclesButton";
            this.DrawCirclesButton.Size = new System.Drawing.Size(56, 17);
            this.DrawCirclesButton.TabIndex = 3;
            this.DrawCirclesButton.TabStop = true;
            this.DrawCirclesButton.Text = "Circles";
            this.DrawCirclesButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FillShapeCheckBox);
            this.groupBox1.Controls.Add(this.DrawXesButton);
            this.groupBox1.Controls.Add(this.DrawRectanglesButton);
            this.groupBox1.Controls.Add(this.DrawCirclesButton);
            this.groupBox1.Controls.Add(this.DrawLinesButton);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 75);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Draw:";
            // 
            // FillShapeCheckBox
            // 
            this.FillShapeCheckBox.AutoSize = true;
            this.FillShapeCheckBox.Location = new System.Drawing.Point(62, 52);
            this.FillShapeCheckBox.Name = "FillShapeCheckBox";
            this.FillShapeCheckBox.Size = new System.Drawing.Size(102, 17);
            this.FillShapeCheckBox.TabIndex = 8;
            this.FillShapeCheckBox.Text = "Fill Shape Mode";
            this.FillShapeCheckBox.UseVisualStyleBackColor = true;
            // 
            // DrawXesButton
            // 
            this.DrawXesButton.AutoSize = true;
            this.DrawXesButton.Location = new System.Drawing.Point(214, 20);
            this.DrawXesButton.Name = "DrawXesButton";
            this.DrawXesButton.Size = new System.Drawing.Size(46, 17);
            this.DrawXesButton.TabIndex = 5;
            this.DrawXesButton.TabStop = true;
            this.DrawXesButton.Text = "X-es";
            this.DrawXesButton.UseVisualStyleBackColor = true;
            // 
            // DrawRectanglesButton
            // 
            this.DrawRectanglesButton.AutoSize = true;
            this.DrawRectanglesButton.Location = new System.Drawing.Point(124, 19);
            this.DrawRectanglesButton.Name = "DrawRectanglesButton";
            this.DrawRectanglesButton.Size = new System.Drawing.Size(79, 17);
            this.DrawRectanglesButton.TabIndex = 4;
            this.DrawRectanglesButton.TabStop = true;
            this.DrawRectanglesButton.Text = "Rectangles";
            this.DrawRectanglesButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(6, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 56);
            this.panel1.TabIndex = 7;
            // 
            // UndoButton
            // 
            this.UndoButton.Enabled = false;
            this.UndoButton.Location = new System.Drawing.Point(407, 19);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(54, 23);
            this.UndoButton.TabIndex = 5;
            this.UndoButton.Text = "Undo";
            this.UndoButton.UseVisualStyleBackColor = true;
            this.UndoButton.Click += new System.EventHandler(this.UndoButtonClicked);
            // 
            // RedoButton
            // 
            this.RedoButton.Enabled = false;
            this.RedoButton.Location = new System.Drawing.Point(469, 19);
            this.RedoButton.Name = "RedoButton";
            this.RedoButton.Size = new System.Drawing.Size(57, 23);
            this.RedoButton.TabIndex = 6;
            this.RedoButton.Text = "Redo";
            this.RedoButton.UseVisualStyleBackColor = true;
            this.RedoButton.Click += new System.EventHandler(this.RedoButtonClicked);
            // 
            // ColorSelectionButton
            // 
            this.ColorSelectionButton.Location = new System.Drawing.Point(308, 25);
            this.ColorSelectionButton.Name = "ColorSelectionButton";
            this.ColorSelectionButton.Size = new System.Drawing.Size(49, 49);
            this.ColorSelectionButton.TabIndex = 7;
            this.ColorSelectionButton.Text = "Select Object Color";
            this.ColorSelectionButton.UseVisualStyleBackColor = true;
            this.ColorSelectionButton.Click += new System.EventHandler(this.ColorSelectionButton_Click);
            // 
            // DrawIt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 574);
            this.Controls.Add(this.ColorSelectionButton);
            this.Controls.Add(this.RedoButton);
            this.Controls.Add(this.UndoButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CanvasPanel);
            this.KeyPreview = true;
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
        private CheckBox FillShapeCheckBox;
        private Panel panel1;
        private Button ColorSelectionButton;
    }
}

