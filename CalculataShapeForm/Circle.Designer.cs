namespace CalculataShapeForm
{
    partial class Circle
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
            this.lblCircle_a = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCircle_a = new System.Windows.Forms.TextBox();
            this.txtCircle_perimeter = new System.Windows.Forms.TextBox();
            this.txtCircle_area = new System.Windows.Forms.TextBox();
            this.btnCircle_calculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCircle_a
            // 
            this.lblCircle_a.AutoSize = true;
            this.lblCircle_a.BackColor = System.Drawing.SystemColors.Info;
            this.lblCircle_a.Location = new System.Drawing.Point(29, 48);
            this.lblCircle_a.Name = "lblCircle_a";
            this.lblCircle_a.Size = new System.Drawing.Size(40, 13);
            this.lblCircle_a.TabIndex = 0;
            this.lblCircle_a.Text = "Radius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(29, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Perimeter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(29, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Area";
            // 
            // txtCircle_a
            // 
            this.txtCircle_a.Location = new System.Drawing.Point(126, 45);
            this.txtCircle_a.Name = "txtCircle_a";
            this.txtCircle_a.Size = new System.Drawing.Size(100, 20);
            this.txtCircle_a.TabIndex = 3;
            // 
            // txtCircle_perimeter
            // 
            this.txtCircle_perimeter.Location = new System.Drawing.Point(126, 138);
            this.txtCircle_perimeter.Name = "txtCircle_perimeter";
            this.txtCircle_perimeter.ReadOnly = true;
            this.txtCircle_perimeter.Size = new System.Drawing.Size(100, 20);
            this.txtCircle_perimeter.TabIndex = 4;
            // 
            // txtCircle_area
            // 
            this.txtCircle_area.Location = new System.Drawing.Point(126, 183);
            this.txtCircle_area.Name = "txtCircle_area";
            this.txtCircle_area.ReadOnly = true;
            this.txtCircle_area.Size = new System.Drawing.Size(100, 20);
            this.txtCircle_area.TabIndex = 5;
            // 
            // btnCircle_calculate
            // 
            this.btnCircle_calculate.Location = new System.Drawing.Point(32, 82);
            this.btnCircle_calculate.Name = "btnCircle_calculate";
            this.btnCircle_calculate.Size = new System.Drawing.Size(194, 23);
            this.btnCircle_calculate.TabIndex = 6;
            this.btnCircle_calculate.Text = "Calculate";
            this.btnCircle_calculate.UseVisualStyleBackColor = true;
            this.btnCircle_calculate.Click += new System.EventHandler(this.btnCircle_calculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(126, 109);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(100, 23);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Circle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(246, 304);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnCircle_calculate);
            this.Controls.Add(this.txtCircle_area);
            this.Controls.Add(this.txtCircle_perimeter);
            this.Controls.Add(this.txtCircle_a);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCircle_a);
            this.Name = "Circle";
            this.Text = "Circle";
            this.Load += new System.EventHandler(this.Circle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCircle_a;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCircle_a;
        private System.Windows.Forms.TextBox txtCircle_perimeter;
        private System.Windows.Forms.TextBox txtCircle_area;
        private System.Windows.Forms.Button btnCircle_calculate;
        private System.Windows.Forms.Button btnclear;
    }
}