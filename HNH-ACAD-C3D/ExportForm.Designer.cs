namespace AcC3D_Plug
{
    partial class ExportForm
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
            this.lbLayouts = new System.Windows.Forms.ListBox();
            this.cbMultipleFiles = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbLayouts
            // 
            this.lbLayouts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLayouts.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lbLayouts.FormattingEnabled = true;
            this.lbLayouts.ItemHeight = 25;
            this.lbLayouts.Items.AddRange(new object[] {
            "Test Item 1",
            "Test Item 2",
            "Test Item 3"});
            this.lbLayouts.Location = new System.Drawing.Point(12, 12);
            this.lbLayouts.Name = "lbLayouts";
            this.lbLayouts.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbLayouts.Size = new System.Drawing.Size(446, 227);
            this.lbLayouts.TabIndex = 0;
            // 
            // cbMultipleFiles
            // 
            this.cbMultipleFiles.AutoSize = true;
            this.cbMultipleFiles.Location = new System.Drawing.Point(12, 265);
            this.cbMultipleFiles.Name = "cbMultipleFiles";
            this.cbMultipleFiles.Size = new System.Drawing.Size(225, 25);
            this.cbMultipleFiles.TabIndex = 1;
            this.cbMultipleFiles.Text = "Plot layouts in seperate files.";
            this.cbMultipleFiles.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(12, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "PLOT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnAccept);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(246, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 60);
            this.button2.TabIndex = 3;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnCancel);
            // 
            // ExportForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(470, 371);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbMultipleFiles);
            this.Controls.Add(this.lbLayouts);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExportForm";
            this.Text = "ExportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbLayouts;
        private System.Windows.Forms.CheckBox cbMultipleFiles;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}