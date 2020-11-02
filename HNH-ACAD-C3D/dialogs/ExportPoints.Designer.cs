namespace AcC3D_Plug
{
    partial class ExportPoints
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustomName = new System.Windows.Forms.TextBox();
            this.rbCustomName = new System.Windows.Forms.RadioButton();
            this.rbAutoGenName = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdBrowseFolder = new System.Windows.Forms.Button();
            this.txtCustomFolder = new System.Windows.Forms.TextBox();
            this.rbSetFolder = new System.Windows.Forms.RadioButton();
            this.rbAutoFolder = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lbGroups = new System.Windows.Forms.ListBox();
            this.CmdExport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(-2, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "POINT GROUPS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(271, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "EXPORT SETTINGS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Filename:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCustomName);
            this.panel1.Controls.Add(this.rbCustomName);
            this.panel1.Controls.Add(this.rbAutoGenName);
            this.panel1.Location = new System.Drawing.Point(271, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 87);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = ".txt";
            // 
            // txtCustomName
            // 
            this.txtCustomName.Enabled = false;
            this.txtCustomName.Location = new System.Drawing.Point(32, 57);
            this.txtCustomName.Name = "txtCustomName";
            this.txtCustomName.Size = new System.Drawing.Size(316, 25);
            this.txtCustomName.TabIndex = 7;
            // 
            // rbCustomName
            // 
            this.rbCustomName.AutoSize = true;
            this.rbCustomName.Location = new System.Drawing.Point(13, 30);
            this.rbCustomName.Name = "rbCustomName";
            this.rbCustomName.Size = new System.Drawing.Size(112, 21);
            this.rbCustomName.TabIndex = 6;
            this.rbCustomName.Text = "Custom Name:";
            this.rbCustomName.UseVisualStyleBackColor = true;
            this.rbCustomName.CheckedChanged += new System.EventHandler(this.CheckCustomInput);
            // 
            // rbAutoGenName
            // 
            this.rbAutoGenName.AutoSize = true;
            this.rbAutoGenName.Checked = true;
            this.rbAutoGenName.Location = new System.Drawing.Point(13, 3);
            this.rbAutoGenName.Name = "rbAutoGenName";
            this.rbAutoGenName.Size = new System.Drawing.Size(150, 21);
            this.rbAutoGenName.TabIndex = 5;
            this.rbAutoGenName.TabStop = true;
            this.rbAutoGenName.Text = "Auto-Generate Name";
            this.rbAutoGenName.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmdBrowseFolder);
            this.panel2.Controls.Add(this.txtCustomFolder);
            this.panel2.Controls.Add(this.rbSetFolder);
            this.panel2.Controls.Add(this.rbAutoFolder);
            this.panel2.Location = new System.Drawing.Point(271, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 87);
            this.panel2.TabIndex = 9;
            // 
            // cmdBrowseFolder
            // 
            this.cmdBrowseFolder.Enabled = false;
            this.cmdBrowseFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBrowseFolder.Location = new System.Drawing.Point(300, 57);
            this.cmdBrowseFolder.Name = "cmdBrowseFolder";
            this.cmdBrowseFolder.Size = new System.Drawing.Size(79, 25);
            this.cmdBrowseFolder.TabIndex = 10;
            this.cmdBrowseFolder.Text = "Browse";
            this.cmdBrowseFolder.UseVisualStyleBackColor = true;
            this.cmdBrowseFolder.Click += new System.EventHandler(this.SelectFolder);
            // 
            // txtCustomFolder
            // 
            this.txtCustomFolder.Enabled = false;
            this.txtCustomFolder.Location = new System.Drawing.Point(32, 57);
            this.txtCustomFolder.Name = "txtCustomFolder";
            this.txtCustomFolder.Size = new System.Drawing.Size(262, 25);
            this.txtCustomFolder.TabIndex = 7;
            // 
            // rbSetFolder
            // 
            this.rbSetFolder.AutoSize = true;
            this.rbSetFolder.Location = new System.Drawing.Point(13, 30);
            this.rbSetFolder.Name = "rbSetFolder";
            this.rbSetFolder.Size = new System.Drawing.Size(112, 21);
            this.rbSetFolder.TabIndex = 6;
            this.rbSetFolder.Text = "Custom Name:";
            this.rbSetFolder.UseVisualStyleBackColor = true;
            this.rbSetFolder.CheckedChanged += new System.EventHandler(this.CheckCustomInput);
            // 
            // rbAutoFolder
            // 
            this.rbAutoFolder.AutoSize = true;
            this.rbAutoFolder.Checked = true;
            this.rbAutoFolder.Location = new System.Drawing.Point(13, 3);
            this.rbAutoFolder.Name = "rbAutoFolder";
            this.rbAutoFolder.Size = new System.Drawing.Size(155, 21);
            this.rbAutoFolder.TabIndex = 5;
            this.rbAutoFolder.TabStop = true;
            this.rbAutoFolder.Text = "Project\'s Comp Folder";
            this.rbAutoFolder.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Destination Folder:";
            // 
            // lbGroups
            // 
            this.lbGroups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbGroups.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.lbGroups.FormattingEnabled = true;
            this.lbGroups.ItemHeight = 19;
            this.lbGroups.Items.AddRange(new object[] {
            "!All Points",
            "!Comp Points",
            "!Control Points"});
            this.lbGroups.Location = new System.Drawing.Point(12, 31);
            this.lbGroups.Name = "lbGroups";
            this.lbGroups.Size = new System.Drawing.Size(253, 249);
            this.lbGroups.Sorted = true;
            this.lbGroups.TabIndex = 10;
            // 
            // CmdExport
            // 
            this.CmdExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdExport.Location = new System.Drawing.Point(574, 258);
            this.CmdExport.Name = "CmdExport";
            this.CmdExport.Size = new System.Drawing.Size(79, 33);
            this.CmdExport.TabIndex = 11;
            this.CmdExport.Text = "Export";
            this.CmdExport.UseVisualStyleBackColor = true;
            this.CmdExport.Click += new System.EventHandler(this.ExportConfirm);
            // 
            // ExportPoints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(657, 297);
            this.Controls.Add(this.CmdExport);
            this.Controls.Add(this.lbGroups);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExportPoints";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Export Point Group";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCustomName;
        private System.Windows.Forms.RadioButton rbCustomName;
        private System.Windows.Forms.RadioButton rbAutoGenName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCustomFolder;
        private System.Windows.Forms.RadioButton rbSetFolder;
        private System.Windows.Forms.RadioButton rbAutoFolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdBrowseFolder;
        private System.Windows.Forms.ListBox lbGroups;
        private System.Windows.Forms.Button CmdExport;
        private System.Windows.Forms.Label label5;
    }
}