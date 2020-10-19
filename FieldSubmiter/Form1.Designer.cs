namespace FieldSubmiter
{
    partial class MainForm
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
            this.TxtNumber = new System.Windows.Forms.MaskedTextBox();
            this.LbNumbers = new System.Windows.Forms.ListBox();
            this.CmdAddNumber = new System.Windows.Forms.Button();
            this.CmdRemoveNumber = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CbPurpose = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.LbFiles = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CmdRemoveFiles = new System.Windows.Forms.Button();
            this.CmdAddFiles = new System.Windows.Forms.Button();
            this.CmdSubmit = new System.Windows.Forms.Button();
            this.LblStatus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CmdUpdate = new System.Windows.Forms.Button();
            this.AutoUpdater = new wyDay.Controls.AutomaticUpdater();
            ((System.ComponentModel.ISupportInitialize)(this.AutoUpdater)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Job Number:";
            // 
            // TxtNumber
            // 
            this.TxtNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNumber.Location = new System.Drawing.Point(117, 96);
            this.TxtNumber.Mask = "00-00-000";
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(128, 26);
            this.TxtNumber.TabIndex = 1;
            this.TxtNumber.TextChanged += new System.EventHandler(this.OnNumberChanged);
            this.TxtNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNumber_KeyDown);
            // 
            // LbNumbers
            // 
            this.LbNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbNumbers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbNumbers.FormattingEnabled = true;
            this.LbNumbers.ItemHeight = 20;
            this.LbNumbers.Location = new System.Drawing.Point(12, 128);
            this.LbNumbers.Name = "LbNumbers";
            this.LbNumbers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LbNumbers.Size = new System.Drawing.Size(233, 82);
            this.LbNumbers.TabIndex = 2;
            this.LbNumbers.Click += new System.EventHandler(this.OnSelectionChange);
            this.LbNumbers.SelectedIndexChanged += new System.EventHandler(this.OnSelectionChange);
            // 
            // CmdAddNumber
            // 
            this.CmdAddNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdAddNumber.Enabled = false;
            this.CmdAddNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdAddNumber.Location = new System.Drawing.Point(12, 216);
            this.CmdAddNumber.Name = "CmdAddNumber";
            this.CmdAddNumber.Size = new System.Drawing.Size(115, 37);
            this.CmdAddNumber.TabIndex = 3;
            this.CmdAddNumber.Text = "Add";
            this.CmdAddNumber.UseVisualStyleBackColor = true;
            this.CmdAddNumber.Click += new System.EventHandler(this.AddValue);
            // 
            // CmdRemoveNumber
            // 
            this.CmdRemoveNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdRemoveNumber.Enabled = false;
            this.CmdRemoveNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdRemoveNumber.Location = new System.Drawing.Point(130, 216);
            this.CmdRemoveNumber.Name = "CmdRemoveNumber";
            this.CmdRemoveNumber.Size = new System.Drawing.Size(115, 37);
            this.CmdRemoveNumber.TabIndex = 4;
            this.CmdRemoveNumber.Text = "Remove";
            this.CmdRemoveNumber.UseVisualStyleBackColor = true;
            this.CmdRemoveNumber.Click += new System.EventHandler(this.RemoveValue);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Purpose:";
            // 
            // CbPurpose
            // 
            this.CbPurpose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbPurpose.FormattingEnabled = true;
            this.CbPurpose.Location = new System.Drawing.Point(12, 281);
            this.CbPurpose.Name = "CbPurpose";
            this.CbPurpose.Size = new System.Drawing.Size(233, 28);
            this.CbPurpose.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Note:";
            // 
            // TxtNotes
            // 
            this.TxtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNotes.Location = new System.Drawing.Point(12, 335);
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.Size = new System.Drawing.Size(233, 26);
            this.TxtNotes.TabIndex = 8;
            // 
            // LbFiles
            // 
            this.LbFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbFiles.FormattingEnabled = true;
            this.LbFiles.ItemHeight = 20;
            this.LbFiles.Location = new System.Drawing.Point(12, 395);
            this.LbFiles.Name = "LbFiles";
            this.LbFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LbFiles.Size = new System.Drawing.Size(233, 82);
            this.LbFiles.TabIndex = 10;
            this.LbFiles.Click += new System.EventHandler(this.OnSelectionChange);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Files:";
            // 
            // CmdRemoveFiles
            // 
            this.CmdRemoveFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdRemoveFiles.Enabled = false;
            this.CmdRemoveFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdRemoveFiles.Location = new System.Drawing.Point(130, 483);
            this.CmdRemoveFiles.Name = "CmdRemoveFiles";
            this.CmdRemoveFiles.Size = new System.Drawing.Size(115, 37);
            this.CmdRemoveFiles.TabIndex = 15;
            this.CmdRemoveFiles.Text = "Remove";
            this.CmdRemoveFiles.UseVisualStyleBackColor = true;
            this.CmdRemoveFiles.Click += new System.EventHandler(this.RemoveValue);
            // 
            // CmdAddFiles
            // 
            this.CmdAddFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdAddFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdAddFiles.Location = new System.Drawing.Point(12, 483);
            this.CmdAddFiles.Name = "CmdAddFiles";
            this.CmdAddFiles.Size = new System.Drawing.Size(115, 37);
            this.CmdAddFiles.TabIndex = 14;
            this.CmdAddFiles.Text = "Add";
            this.CmdAddFiles.UseVisualStyleBackColor = true;
            this.CmdAddFiles.Click += new System.EventHandler(this.AddValue);
            // 
            // CmdSubmit
            // 
            this.CmdSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdSubmit.Location = new System.Drawing.Point(12, 544);
            this.CmdSubmit.Name = "CmdSubmit";
            this.CmdSubmit.Size = new System.Drawing.Size(233, 55);
            this.CmdSubmit.TabIndex = 16;
            this.CmdSubmit.Text = "Submit";
            this.CmdSubmit.UseVisualStyleBackColor = true;
            // 
            // LblStatus
            // 
            this.LblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(12, 645);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(0, 20);
            this.LblStatus.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(130, 605);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 37);
            this.button1.TabIndex = 18;
            this.button1.Text = "Options";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // CmdUpdate
            // 
            this.CmdUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdUpdate.Location = new System.Drawing.Point(9, 605);
            this.CmdUpdate.Name = "CmdUpdate";
            this.CmdUpdate.Size = new System.Drawing.Size(115, 37);
            this.CmdUpdate.TabIndex = 19;
            this.CmdUpdate.Text = "Update";
            this.CmdUpdate.UseVisualStyleBackColor = true;
            this.CmdUpdate.Click += new System.EventHandler(this.CheckForUpdates);
            // 
            // AutoUpdater
            // 
            this.AutoUpdater.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoUpdater.ContainerForm = this;
            this.AutoUpdater.Location = new System.Drawing.Point(229, 12);
            this.AutoUpdater.Name = "AutoUpdater";
            this.AutoUpdater.Size = new System.Drawing.Size(16, 16);
            this.AutoUpdater.TabIndex = 20;
            this.AutoUpdater.Visible = false;
            this.AutoUpdater.wyUpdateCommandline = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(257, 672);
            this.Controls.Add(this.AutoUpdater);
            this.Controls.Add(this.CmdUpdate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.CmdSubmit);
            this.Controls.Add(this.CmdRemoveFiles);
            this.Controls.Add(this.CmdAddFiles);
            this.Controls.Add(this.LbFiles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtNotes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbPurpose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmdRemoveNumber);
            this.Controls.Add(this.CmdAddNumber);
            this.Controls.Add(this.LbNumbers);
            this.Controls.Add(this.TxtNumber);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Submit Data";
            ((System.ComponentModel.ISupportInitialize)(this.AutoUpdater)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox TxtNumber;
        private System.Windows.Forms.ListBox LbNumbers;
        private System.Windows.Forms.Button CmdAddNumber;
        private System.Windows.Forms.Button CmdRemoveNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbPurpose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.ListBox LbFiles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CmdRemoveFiles;
        private System.Windows.Forms.Button CmdAddFiles;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Button CmdSubmit;
        private System.Windows.Forms.Button CmdUpdate;
        private System.Windows.Forms.Button button1;
        private wyDay.Controls.AutomaticUpdater AutoUpdater;
    }
}

