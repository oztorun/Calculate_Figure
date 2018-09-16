namespace CalculataShapeForm
{
    partial class Triangle
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
            this.lblTriangle_a = new System.Windows.Forms.Label();
            this.lblTriangle_b = new System.Windows.Forms.Label();
            this.lblTriangle_c = new System.Windows.Forms.Label();
            this.lblTriangle_perimeter = new System.Windows.Forms.Label();
            this.lblTriangle_area = new System.Windows.Forms.Label();
            this.btnTriange_calculate = new System.Windows.Forms.Button();
            this.txtTriangle_a = new System.Windows.Forms.TextBox();
            this.txtTriangle_b = new System.Windows.Forms.TextBox();
            this.txtTriangle_c = new System.Windows.Forms.TextBox();
            this.txtTriangle_perimeter = new System.Windows.Forms.TextBox();
            this.txtTriangle_area = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTriangle_a
            // 
            this.lblTriangle_a.AutoSize = true;
            this.lblTriangle_a.Location = new System.Drawing.Point(12, 25);
            this.lblTriangle_a.Name = "lblTriangle_a";
            this.lblTriangle_a.Size = new System.Drawing.Size(42, 13);
            this.lblTriangle_a.TabIndex = 0;
            this.lblTriangle_a.Text = "Edge A";
            // 
            // lblTriangle_b
            // 
            this.lblTriangle_b.AutoSize = true;
            this.lblTriangle_b.Location = new System.Drawing.Point(12, 59);
            this.lblTriangle_b.Name = "lblTriangle_b";
            this.lblTriangle_b.Size = new System.Drawing.Size(42, 13);
            this.lblTriangle_b.TabIndex = 1;
            this.lblTriangle_b.Text = "Edge B";
            // 
            // lblTriangle_c
            // 
            this.lblTriangle_c.AutoSize = true;
            this.lblTriangle_c.Location = new System.Drawing.Point(12, 89);
            this.lblTriangle_c.Name = "lblTriangle_c";
            this.lblTriangle_c.Size = new System.Drawing.Size(42, 13);
            this.lblTriangle_c.TabIndex = 2;
            this.lblTriangle_c.Text = "Edge C";
            // 
            // lblTriangle_perimeter
            // 
            this.lblTriangle_perimeter.AutoSize = true;
            this.lblTriangle_perimeter.Location = new System.Drawing.Point(12, 169);
            this.lblTriangle_perimeter.Name = "lblTriangle_perimeter";
            this.lblTriangle_perimeter.Size = new System.Drawing.Size(51, 13);
            this.lblTriangle_perimeter.TabIndex = 3;
            this.lblTriangle_perimeter.Text = "Perimeter";
            // 
            // lblTriangle_area
            // 
            this.lblTriangle_area.AutoSize = true;
            this.lblTriangle_area.Location = new System.Drawing.Point(18, 204);
            this.lblTriangle_area.Name = "lblTriangle_area";
            this.lblTriangle_area.Size = new System.Drawing.Size(29, 13);
            this.lblTriangle_area.TabIndex = 4;
            this.lblTriangle_area.Text = "Area";
            // 
            // btnTriange_calculate
            // 
            this.btnTriange_calculate.Location = new System.Drawing.Point(15, 114);
            this.btnTriange_calculate.Name = "btnTriange_calculate";
            this.btnTriange_calculate.Size = new System.Drawing.Size(204, 23);
            this.btnTriange_calculate.TabIndex = 5;
            this.btnTriange_calculate.Text = "Calculate";
            this.btnTriange_calculate.UseVisualStyleBackColor = true;
            this.btnTriange_calculate.Click += new System.EventHandler(this.btnTriange_calculate_Click);
            // 
            // txtTriangle_a
            // 
            this.txtTriangle_a.Location = new System.Drawing.Point(119, 25);
            this.txtTriangle_a.Name = "txtTriangle_a";
            this.txtTriangle_a.Size = new System.Drawing.Size(100, 20);
            this.txtTriangle_a.TabIndex = 6;
            // 
            // txtTriangle_b
            // 
            this.txtTriangle_b.Location = new System.Drawing.Point(119, 51);
            this.txtTriangle_b.Name = "txtTriangle_b";
            this.txtTriangle_b.Size = new System.Drawing.Size(100, 20);
            this.txtTriangle_b.TabIndex = 7;
            // 
            // txtTriangle_c
            // 
            this.txtTriangle_c.Location = new System.Drawing.Point(119, 82);
            this.txtTriangle_c.Name = "txtTriangle_c";
            this.txtTriangle_c.Size = new System.Drawing.Size(100, 20);
            this.txtTriangle_c.TabIndex = 8;
            // 
            // txtTriangle_perimeter
            // 
            this.txtTriangle_perimeter.Enabled = false;
            this.txtTriangle_perimeter.Location = new System.Drawing.Point(119, 169);
            this.txtTriangle_perimeter.Name = "txtTriangle_perimeter";
            this.txtTriangle_perimeter.ReadOnly = true;
            this.txtTriangle_perimeter.Size = new System.Drawing.Size(100, 20);
            this.txtTriangle_perimeter.TabIndex = 9;
            
            // 
            // txtTriangle_area
            // 
            this.txtTriangle_area.Location = new System.Drawing.Point(119, 204);
            this.txtTriangle_area.Name = "txtTriangle_area";
            this.txtTriangle_area.ReadOnly = true;
            this.txtTriangle_area.Size = new System.Drawing.Size(100, 20);
            this.txtTriangle_area.TabIndex = 10;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(119, 143);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(100, 23);
            this.btnclear.TabIndex = 11;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Triangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(240, 277);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.txtTriangle_area);
            this.Controls.Add(this.txtTriangle_perimeter);
            this.Controls.Add(this.txtTriangle_c);
            this.Controls.Add(this.txtTriangle_b);
            this.Controls.Add(this.txtTriangle_a);
            this.Controls.Add(this.btnTriange_calculate);
            this.Controls.Add(this.lblTriangle_area);
            this.Controls.Add(this.lblTriangle_perimeter);
            this.Controls.Add(this.lblTriangle_c);
            this.Controls.Add(this.lblTriangle_b);
            this.Controls.Add(this.lblTriangle_a);
            this.Name = "Triangle";
            this.Text = "Triangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTriangle_a;
        private System.Windows.Forms.Label lblTriangle_b;
        private System.Windows.Forms.Label lblTriangle_c;
        private System.Windows.Forms.Label lblTriangle_perimeter;
        private System.Windows.Forms.Label lblTriangle_area;
        private System.Windows.Forms.Button btnTriange_calculate;
        private System.Windows.Forms.TextBox txtTriangle_a;
        private System.Windows.Forms.TextBox txtTriangle_b;
        private System.Windows.Forms.TextBox txtTriangle_c;
        private System.Windows.Forms.TextBox txtTriangle_perimeter;
        private System.Windows.Forms.TextBox txtTriangle_area;
        private System.Windows.Forms.Button btnclear;
    }
}