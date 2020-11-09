namespace AcC3D_Plug
{
    partial class CogoPointEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.NVPointNumber = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RbElevationManual = new System.Windows.Forms.RadioButton();
            this.RbElevationAuto = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.RbElevationSurface = new System.Windows.Forms.RadioButton();
            this.NVElevation = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NVPointNumber)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NVElevation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Point Number:";
            // 
            // NVPointNumber
            // 
            this.NVPointNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NVPointNumber.Location = new System.Drawing.Point(121, 12);
            this.NVPointNumber.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.NVPointNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NVPointNumber.Name = "NVPointNumber";
            this.NVPointNumber.Size = new System.Drawing.Size(113, 24);
            this.NVPointNumber.TabIndex = 1;
            this.NVPointNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NVElevation);
            this.panel1.Controls.Add(this.RbElevationSurface);
            this.panel1.Controls.Add(this.RbElevationManual);
            this.panel1.Controls.Add(this.RbElevationAuto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 84);
            this.panel1.TabIndex = 3;
            // 
            // RbElevationManual
            // 
            this.RbElevationManual.AutoSize = true;
            this.RbElevationManual.Location = new System.Drawing.Point(82, 30);
            this.RbElevationManual.Name = "RbElevationManual";
            this.RbElevationManual.Size = new System.Drawing.Size(74, 22);
            this.RbElevationManual.TabIndex = 3;
            this.RbElevationManual.Text = "Manual";
            this.RbElevationManual.UseVisualStyleBackColor = true;
            // 
            // RbElevationAuto
            // 
            this.RbElevationAuto.AutoSize = true;
            this.RbElevationAuto.Checked = true;
            this.RbElevationAuto.Location = new System.Drawing.Point(82, 4);
            this.RbElevationAuto.Name = "RbElevationAuto";
            this.RbElevationAuto.Size = new System.Drawing.Size(96, 22);
            this.RbElevationAuto.TabIndex = 3;
            this.RbElevationAuto.TabStop = true;
            this.RbElevationAuto.Text = "Automatic:";
            this.RbElevationAuto.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Elevation:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TxtDescription);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 88);
            this.panel2.TabIndex = 3;
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(97, 32);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(199, 24);
            this.TxtDescription.TabIndex = 4;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(97, 62);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(74, 22);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "Manual";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(97, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(96, 22);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Automatic:";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description:";
            // 
            // RbElevationSurface
            // 
            this.RbElevationSurface.AutoSize = true;
            this.RbElevationSurface.Location = new System.Drawing.Point(82, 58);
            this.RbElevationSurface.Name = "RbElevationSurface";
            this.RbElevationSurface.Size = new System.Drawing.Size(117, 22);
            this.RbElevationSurface.TabIndex = 3;
            this.RbElevationSurface.Text = "From Surface";
            this.RbElevationSurface.UseVisualStyleBackColor = true;
            // 
            // NVElevation
            // 
            this.NVElevation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NVElevation.DecimalPlaces = 3;
            this.NVElevation.Location = new System.Drawing.Point(184, 4);
            this.NVElevation.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.NVElevation.Name = "NVElevation";
            this.NVElevation.Size = new System.Drawing.Size(112, 24);
            this.NVElevation.TabIndex = 4;
            this.NVElevation.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CogoPointEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(324, 226);
            this.Controls.Add(this.NVPointNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CogoPointEditor";
            this.Text = "COGO Point Options";
            ((System.ComponentModel.ISupportInitialize)(this.NVPointNumber)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NVElevation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NVPointNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RbElevationManual;
        private System.Windows.Forms.RadioButton RbElevationAuto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RbElevationSurface;
        private System.Windows.Forms.NumericUpDown NVElevation;
    }
}