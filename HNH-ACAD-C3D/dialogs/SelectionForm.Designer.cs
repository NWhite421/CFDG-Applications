namespace AcC3D_Plug
{
    partial class SelectionForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVFiles = new System.Windows.Forms.DataGridView();
            this.CbPerformRepeatFiltering = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rbCustom = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rbFile = new System.Windows.Forms.RadioButton();
            this.rbCombined = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.CmdAccept = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LblJobNumber = new System.Windows.Forms.LinkLabel();
            this.CbXrefAssociatedCADFile = new System.Windows.Forms.CheckBox();
            this.FileDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFiles)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVFiles
            // 
            this.DGVFiles.AllowUserToAddRows = false;
            this.DGVFiles.AllowUserToDeleteRows = false;
            this.DGVFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVFiles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileDate,
            this.Points,
            this.FileName});
            this.DGVFiles.Location = new System.Drawing.Point(12, 36);
            this.DGVFiles.Name = "DGVFiles";
            this.DGVFiles.ReadOnly = true;
            this.DGVFiles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGVFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVFiles.ShowEditingIcon = false;
            this.DGVFiles.Size = new System.Drawing.Size(334, 204);
            this.DGVFiles.TabIndex = 0;
            // 
            // CbPerformRepeatFiltering
            // 
            this.CbPerformRepeatFiltering.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CbPerformRepeatFiltering.AutoSize = true;
            this.CbPerformRepeatFiltering.Checked = true;
            this.CbPerformRepeatFiltering.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbPerformRepeatFiltering.Location = new System.Drawing.Point(12, 246);
            this.CbPerformRepeatFiltering.Name = "CbPerformRepeatFiltering";
            this.CbPerformRepeatFiltering.Size = new System.Drawing.Size(253, 25);
            this.CbPerformRepeatFiltering.TabIndex = 1;
            this.CbPerformRepeatFiltering.Text = "Perform repeating point filtering";
            this.CbPerformRepeatFiltering.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.rbCustom);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.rbFile);
            this.panel1.Controls.Add(this.rbCombined);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 155);
            this.panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(137, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(445, 29);
            this.textBox1.TabIndex = 5;
            // 
            // rbCustom
            // 
            this.rbCustom.AutoSize = true;
            this.rbCustom.Location = new System.Drawing.Point(3, 118);
            this.rbCustom.Name = "rbCustom";
            this.rbCustom.Size = new System.Drawing.Size(128, 25);
            this.rbCustom.TabIndex = 4;
            this.rbCustom.Text = "Custom Name";
            this.rbCustom.UseVisualStyleBackColor = true;
            this.rbCustom.CheckedChanged += new System.EventHandler(this.OnCustomNameCheckChange);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 87);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 25);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "None";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rbFile
            // 
            this.rbFile.AutoSize = true;
            this.rbFile.Location = new System.Drawing.Point(3, 56);
            this.rbFile.Name = "rbFile";
            this.rbFile.Size = new System.Drawing.Size(126, 25);
            this.rbFile.TabIndex = 2;
            this.rbFile.Text = "File Seperated";
            this.rbFile.UseVisualStyleBackColor = true;
            // 
            // rbCombined
            // 
            this.rbCombined.AutoSize = true;
            this.rbCombined.Checked = true;
            this.rbCombined.Location = new System.Drawing.Point(3, 25);
            this.rbCombined.Name = "rbCombined";
            this.rbCombined.Size = new System.Drawing.Size(200, 25);
            this.rbCombined.TabIndex = 1;
            this.rbCombined.TabStop = true;
            this.rbCombined.Text = "Import Event (combined)";
            this.rbCombined.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Point Group Handling";
            // 
            // CmdAccept
            // 
            this.CmdAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CmdAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdAccept.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CmdAccept.Location = new System.Drawing.Point(12, 469);
            this.CmdAccept.Name = "CmdAccept";
            this.CmdAccept.Size = new System.Drawing.Size(235, 61);
            this.CmdAccept.TabIndex = 3;
            this.CmdAccept.Text = "Import Data";
            this.CmdAccept.UseVisualStyleBackColor = true;
            this.CmdAccept.Click += new System.EventHandler(this.AcceptImport);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(362, 469);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(235, 61);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel Import";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Job Number:";
            // 
            // LblJobNumber
            // 
            this.LblJobNumber.AutoSize = true;
            this.LblJobNumber.Location = new System.Drawing.Point(117, 9);
            this.LblJobNumber.Name = "LblJobNumber";
            this.LblJobNumber.Size = new System.Drawing.Size(85, 21);
            this.LblJobNumber.TabIndex = 6;
            this.LblJobNumber.TabStop = true;
            this.LblJobNumber.Text = "XX-XX-XXX";
            this.LblJobNumber.VisitedLinkColor = System.Drawing.Color.Blue;
            this.LblJobNumber.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.handleLinkAction);
            // 
            // CbXrefAssociatedCADFile
            // 
            this.CbXrefAssociatedCADFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CbXrefAssociatedCADFile.AutoSize = true;
            this.CbXrefAssociatedCADFile.Checked = true;
            this.CbXrefAssociatedCADFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbXrefAssociatedCADFile.Location = new System.Drawing.Point(12, 277);
            this.CbXrefAssociatedCADFile.Name = "CbXrefAssociatedCADFile";
            this.CbXrefAssociatedCADFile.Size = new System.Drawing.Size(203, 25);
            this.CbXrefAssociatedCADFile.TabIndex = 7;
            this.CbXrefAssociatedCADFile.Text = "X-Ref associated CAD file";
            this.CbXrefAssociatedCADFile.UseVisualStyleBackColor = true;
            // 
            // FileDate
            // 
            this.FileDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FileDate.HeaderText = "Date";
            this.FileDate.Name = "FileDate";
            this.FileDate.ReadOnly = true;
            this.FileDate.Width = 67;
            // 
            // Points
            // 
            this.Points.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Points.HeaderText = "Points";
            this.Points.Name = "Points";
            this.Points.ReadOnly = true;
            this.Points.Width = 77;
            // 
            // FileName
            // 
            this.FileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FileName.HeaderText = "Name";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Width = 77;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(352, 36);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(242, 204);
            this.textBox2.TabIndex = 8;
            // 
            // SelectionForm
            // 
            this.AcceptButton = this.CmdAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(609, 538);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.CbXrefAssociatedCADFile);
            this.Controls.Add(this.LblJobNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CmdAccept);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CbPerformRepeatFiltering);
            this.Controls.Add(this.DGVFiles);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectionForm";
            this.Text = "Select Job Data";
            ((System.ComponentModel.ISupportInitialize)(this.DGVFiles)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVFiles;
        private System.Windows.Forms.CheckBox CbPerformRepeatFiltering;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rbFile;
        private System.Windows.Forms.RadioButton rbCombined;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CmdAccept;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel LblJobNumber;
        private System.Windows.Forms.CheckBox CbXrefAssociatedCADFile;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rbCustom;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Points;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.TextBox textBox2;
    }
}