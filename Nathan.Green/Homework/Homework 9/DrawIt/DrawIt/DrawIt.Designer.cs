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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ColorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxSnapToGrid = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPixels = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CanvasPanel
            // 
            this.CanvasPanel.Location = new System.Drawing.Point(10, 70);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(600, 500);
            this.CanvasPanel.TabIndex = 0;
            // 
            // ClearButton
            // 
            this.ClearButton.Enabled = false;
            this.ClearButton.Location = new System.Drawing.Point(534, 12);
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
            this.groupBox1.Controls.Add(this.DrawXesButton);
            this.groupBox1.Controls.Add(this.DrawRectanglesButton);
            this.groupBox1.Controls.Add(this.DrawCirclesButton);
            this.groupBox1.Controls.Add(this.DrawLinesButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 57);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Draw:";
            // 
            // DrawXesButton
            // 
            this.DrawXesButton.AutoSize = true;
            this.DrawXesButton.Location = new System.Drawing.Point(210, 20);
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
            // UndoButton
            // 
            this.UndoButton.Enabled = false;
            this.UndoButton.Location = new System.Drawing.Point(280, 13);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(75, 23);
            this.UndoButton.TabIndex = 5;
            this.UndoButton.Text = "Undo";
            this.UndoButton.UseVisualStyleBackColor = true;
            this.UndoButton.Click += new System.EventHandler(this.UndoButtonClicked);
            // 
            // RedoButton
            // 
            this.RedoButton.Enabled = false;
            this.RedoButton.Location = new System.Drawing.Point(362, 12);
            this.RedoButton.Name = "RedoButton";
            this.RedoButton.Size = new System.Drawing.Size(75, 23);
            this.RedoButton.TabIndex = 6;
            this.RedoButton.Text = "Redo";
            this.RedoButton.UseVisualStyleBackColor = true;
            this.RedoButton.Click += new System.EventHandler(this.RedoButtonClicked);
            // 
            // ColorButton
            // 
            this.ColorButton.Location = new System.Drawing.Point(362, 40);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(23, 23);
            this.ColorButton.TabIndex = 7;
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButtonClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Choose Color:";
            // 
            // checkBoxSnapToGrid
            // 
            this.checkBoxSnapToGrid.AutoSize = true;
            this.checkBoxSnapToGrid.Location = new System.Drawing.Point(443, 16);
            this.checkBoxSnapToGrid.Name = "checkBoxSnapToGrid";
            this.checkBoxSnapToGrid.Size = new System.Drawing.Size(85, 17);
            this.checkBoxSnapToGrid.TabIndex = 11;
            this.checkBoxSnapToGrid.Text = "Snap to Grid";
            this.checkBoxSnapToGrid.UseVisualStyleBackColor = true;
            this.checkBoxSnapToGrid.CheckedChanged += new System.EventHandler(this.CheckBoxSnapToGridCheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Line Width:";
            // 
            // textBoxPixels
            // 
            this.textBoxPixels.Location = new System.Drawing.Point(462, 45);
            this.textBoxPixels.Name = "textBoxPixels";
            this.textBoxPixels.Size = new System.Drawing.Size(31, 20);
            this.textBoxPixels.TabIndex = 13;
            this.textBoxPixels.Text = "3";
            this.textBoxPixels.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPixels.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Pixels";
            // 
            // DrawIt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 580);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPixels);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxSnapToGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ColorButton);
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
            this.PerformLayout();

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
        private ColorDialog colorDialog1;
        private Button ColorButton;
        private Label label1;
        private CheckBox checkBoxSnapToGrid;
        private Label label2;
        private TextBox textBoxPixels;
        private Label label3;
    }
}

