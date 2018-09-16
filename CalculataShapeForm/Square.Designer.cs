namespace CalculataShapeForm
{
    partial class Square
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
            this.lblSquare_a = new System.Windows.Forms.Label();
            this.lblSquare_perimeter = new System.Windows.Forms.Label();
            this.lblSquare_area = new System.Windows.Forms.Label();
            this.txtSquare_a = new System.Windows.Forms.TextBox();
            this.txtSquare_perimeter = new System.Windows.Forms.TextBox();
            this.txtSquare_area = new System.Windows.Forms.TextBox();
            this.btnSqure_calculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSquare_a
            // 
            this.lblSquare_a.AutoSize = true;
            this.lblSquare_a.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSquare_a.ForeColor = System.Drawing.Color.Black;
            this.lblSquare_a.Location = new System.Drawing.Point(34, 50);
            this.lblSquare_a.Name = "lblSquare_a";
            this.lblSquare_a.Size = new System.Drawing.Size(52, 13);
            this.lblSquare_a.TabIndex = 0;
            this.lblSquare_a.Text = "Edge(cm)";
            // 
            // lblSquare_perimeter
            // 
            this.lblSquare_perimeter.AutoSize = true;
            this.lblSquare_perimeter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSquare_perimeter.Location = new System.Drawing.Point(34, 151);
            this.lblSquare_perimeter.Name = "lblSquare_perimeter";
            this.lblSquare_perimeter.Size = new System.Drawing.Size(51, 13);
            this.lblSquare_perimeter.TabIndex = 1;
            this.lblSquare_perimeter.Text = "Perimeter";
            // 
            // lblSquare_area
            // 
            this.lblSquare_area.AutoSize = true;
            this.lblSquare_area.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSquare_area.Location = new System.Drawing.Point(37, 196);
            this.lblSquare_area.Name = "lblSquare_area";
            this.lblSquare_area.Size = new System.Drawing.Size(29, 13);
            this.lblSquare_area.TabIndex = 2;
            this.lblSquare_area.Text = "Area";
            // 
            // txtSquare_a
            // 
            this.txtSquare_a.Location = new System.Drawing.Point(119, 50);
            this.txtSquare_a.Name = "txtSquare_a";
            this.txtSquare_a.Size = new System.Drawing.Size(100, 20);
            this.txtSquare_a.TabIndex = 3;
            // 
            // txtSquare_perimeter
            // 
            this.txtSquare_perimeter.Location = new System.Drawing.Point(119, 148);
            this.txtSquare_perimeter.Name = "txtSquare_perimeter";
            this.txtSquare_perimeter.ReadOnly = true;
            this.txtSquare_perimeter.Size = new System.Drawing.Size(100, 20);
            this.txtSquare_perimeter.TabIndex = 4;
            // 
            // txtSquare_area
            // 
            this.txtSquare_area.Location = new System.Drawing.Point(119, 193);
            this.txtSquare_area.Name = "txtSquare_area";
            this.txtSquare_area.ReadOnly = true;
            this.txtSquare_area.Size = new System.Drawing.Size(100, 20);
            this.txtSquare_area.TabIndex = 5;
            // 
            // btnSqure_calculate
            // 
            this.btnSqure_calculate.Location = new System.Drawing.Point(37, 93);
            this.btnSqure_calculate.Name = "btnSqure_calculate";
            this.btnSqure_calculate.Size = new System.Drawing.Size(182, 23);
            this.btnSqure_calculate.TabIndex = 6;
            this.btnSqure_calculate.Text = "Calculate";
            this.btnSqure_calculate.UseVisualStyleBackColor = true;
            this.btnSqure_calculate.Click += new System.EventHandler(this.btnSqure_calculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(119, 119);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Square
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(235, 298);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSqure_calculate);
            this.Controls.Add(this.txtSquare_area);
            this.Controls.Add(this.txtSquare_perimeter);
            this.Controls.Add(this.txtSquare_a);
            this.Controls.Add(this.lblSquare_area);
            this.Controls.Add(this.lblSquare_perimeter);
            this.Controls.Add(this.lblSquare_a);
            this.Name = "Square";
            this.Text = "Square";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSquare_a;
        private System.Windows.Forms.Label lblSquare_perimeter;
        private System.Windows.Forms.Label lblSquare_area;
        private System.Windows.Forms.TextBox txtSquare_a;
        private System.Windows.Forms.TextBox txtSquare_perimeter;
        private System.Windows.Forms.TextBox txtSquare_area;
        private System.Windows.Forms.Button btnSqure_calculate;
        private System.Windows.Forms.Button btnClear;
    }
}