namespace CalculataShapeForm
{
    partial class Rectangle
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
            this.lblRectangle_a = new System.Windows.Forms.Label();
            this.lblRectangle_b = new System.Windows.Forms.Label();
            this.txtRectangle_a = new System.Windows.Forms.TextBox();
            this.txtRectangle_b = new System.Windows.Forms.TextBox();
            this.txtRectangle_perimeter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRectangle_area = new System.Windows.Forms.Label();
            this.txtRectangle_area = new System.Windows.Forms.TextBox();
            this.lblRectangle_perimeter = new System.Windows.Forms.Label();
            this.btnRectangle_calculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRectangle_a
            // 
            this.lblRectangle_a.AutoSize = true;
            this.lblRectangle_a.BackColor = System.Drawing.Color.MistyRose;
            this.lblRectangle_a.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRectangle_a.Location = new System.Drawing.Point(15, 53);
            this.lblRectangle_a.Name = "lblRectangle_a";
            this.lblRectangle_a.Size = new System.Drawing.Size(36, 13);
            this.lblRectangle_a.TabIndex = 0;
            this.lblRectangle_a.Text = "X-Axis";
            // 
            // lblRectangle_b
            // 
            this.lblRectangle_b.AutoSize = true;
            this.lblRectangle_b.BackColor = System.Drawing.Color.MistyRose;
            this.lblRectangle_b.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRectangle_b.Location = new System.Drawing.Point(15, 100);
            this.lblRectangle_b.Name = "lblRectangle_b";
            this.lblRectangle_b.Size = new System.Drawing.Size(36, 13);
            this.lblRectangle_b.TabIndex = 1;
            this.lblRectangle_b.Text = "Y-Axis";
            // 
            // txtRectangle_a
            // 
            this.txtRectangle_a.Location = new System.Drawing.Point(103, 50);
            this.txtRectangle_a.Name = "txtRectangle_a";
            this.txtRectangle_a.Size = new System.Drawing.Size(100, 20);
            this.txtRectangle_a.TabIndex = 2;
            // 
            // txtRectangle_b
            // 
            this.txtRectangle_b.Location = new System.Drawing.Point(103, 93);
            this.txtRectangle_b.Name = "txtRectangle_b";
            this.txtRectangle_b.Size = new System.Drawing.Size(100, 20);
            this.txtRectangle_b.TabIndex = 3;
            // 
            // txtRectangle_perimeter
            // 
            this.txtRectangle_perimeter.Location = new System.Drawing.Point(103, 202);
            this.txtRectangle_perimeter.Name = "txtRectangle_perimeter";
            this.txtRectangle_perimeter.ReadOnly = true;
            this.txtRectangle_perimeter.Size = new System.Drawing.Size(100, 20);
            this.txtRectangle_perimeter.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // lblRectangle_area
            // 
            this.lblRectangle_area.AutoSize = true;
            this.lblRectangle_area.BackColor = System.Drawing.Color.MistyRose;
            this.lblRectangle_area.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRectangle_area.Location = new System.Drawing.Point(18, 248);
            this.lblRectangle_area.Name = "lblRectangle_area";
            this.lblRectangle_area.Size = new System.Drawing.Size(29, 13);
            this.lblRectangle_area.TabIndex = 6;
            this.lblRectangle_area.Text = "Area";
            // 
            // txtRectangle_area
            // 
            this.txtRectangle_area.Location = new System.Drawing.Point(103, 241);
            this.txtRectangle_area.Name = "txtRectangle_area";
            this.txtRectangle_area.ReadOnly = true;
            this.txtRectangle_area.Size = new System.Drawing.Size(100, 20);
            this.txtRectangle_area.TabIndex = 7;
            // 
            // lblRectangle_perimeter
            // 
            this.lblRectangle_perimeter.AutoSize = true;
            this.lblRectangle_perimeter.BackColor = System.Drawing.Color.MistyRose;
            this.lblRectangle_perimeter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRectangle_perimeter.Location = new System.Drawing.Point(18, 205);
            this.lblRectangle_perimeter.Name = "lblRectangle_perimeter";
            this.lblRectangle_perimeter.Size = new System.Drawing.Size(51, 13);
            this.lblRectangle_perimeter.TabIndex = 8;
            this.lblRectangle_perimeter.Text = "Perimeter";
            // 
            // btnRectangle_calculate
            // 
            this.btnRectangle_calculate.Location = new System.Drawing.Point(12, 142);
            this.btnRectangle_calculate.Name = "btnRectangle_calculate";
            this.btnRectangle_calculate.Size = new System.Drawing.Size(191, 23);
            this.btnRectangle_calculate.TabIndex = 9;
            this.btnRectangle_calculate.Text = "Calculate";
            this.btnRectangle_calculate.UseVisualStyleBackColor = true;
            this.btnRectangle_calculate.Click += new System.EventHandler(this.btnRectangle_calculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(103, 166);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear ";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Rectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(235, 301);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRectangle_calculate);
            this.Controls.Add(this.lblRectangle_perimeter);
            this.Controls.Add(this.txtRectangle_area);
            this.Controls.Add(this.lblRectangle_area);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRectangle_perimeter);
            this.Controls.Add(this.txtRectangle_b);
            this.Controls.Add(this.txtRectangle_a);
            this.Controls.Add(this.lblRectangle_b);
            this.Controls.Add(this.lblRectangle_a);
            this.Name = "Rectangle";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRectangle_a;
        private System.Windows.Forms.Label lblRectangle_b;
        private System.Windows.Forms.TextBox txtRectangle_a;
        private System.Windows.Forms.TextBox txtRectangle_b;
        private System.Windows.Forms.TextBox txtRectangle_perimeter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRectangle_area;
        private System.Windows.Forms.TextBox txtRectangle_area;
        private System.Windows.Forms.Label lblRectangle_perimeter;
        private System.Windows.Forms.Button btnRectangle_calculate;
        private System.Windows.Forms.Button btnClear;
    }
}