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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.CmdContext = new System.Windows.Forms.Button();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TsMiOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.checkUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoUpdate = new wyDay.Controls.AutomaticUpdater();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutoUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Job Number:";
            // 
            // TxtNumber
            // 
            this.TxtNumber.Location = new System.Drawing.Point(117, 30);
            this.TxtNumber.Mask = "00-00-000";
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(151, 26);
            this.TxtNumber.TabIndex = 1;
            this.TxtNumber.TextChanged += new System.EventHandler(this.OnNumberChanged);
            this.TxtNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNumber_KeyDown);
            // 
            // LbNumbers
            // 
            this.LbNumbers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbNumbers.FormattingEnabled = true;
            this.LbNumbers.ItemHeight = 20;
            this.LbNumbers.Location = new System.Drawing.Point(12, 62);
            this.LbNumbers.Name = "LbNumbers";
            this.LbNumbers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LbNumbers.Size = new System.Drawing.Size(256, 82);
            this.LbNumbers.TabIndex = 2;
            this.LbNumbers.Click += new System.EventHandler(this.OnSelectionChange);
            this.LbNumbers.SelectedIndexChanged += new System.EventHandler(this.OnSelectionChange);
            // 
            // CmdAddNumber
            // 
            this.CmdAddNumber.Enabled = false;
            this.CmdAddNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdAddNumber.Location = new System.Drawing.Point(12, 150);
            this.CmdAddNumber.Name = "CmdAddNumber";
            this.CmdAddNumber.Size = new System.Drawing.Size(125, 37);
            this.CmdAddNumber.TabIndex = 3;
            this.CmdAddNumber.Text = "Add";
            this.CmdAddNumber.UseVisualStyleBackColor = true;
            this.CmdAddNumber.Click += new System.EventHandler(this.AddValue);
            // 
            // CmdRemoveNumber
            // 
            this.CmdRemoveNumber.Enabled = false;
            this.CmdRemoveNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdRemoveNumber.Location = new System.Drawing.Point(143, 150);
            this.CmdRemoveNumber.Name = "CmdRemoveNumber";
            this.CmdRemoveNumber.Size = new System.Drawing.Size(125, 37);
            this.CmdRemoveNumber.TabIndex = 4;
            this.CmdRemoveNumber.Text = "Remove";
            this.CmdRemoveNumber.UseVisualStyleBackColor = true;
            this.CmdRemoveNumber.Click += new System.EventHandler(this.RemoveValue);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Purpose:";
            // 
            // CbPurpose
            // 
            this.CbPurpose.FormattingEnabled = true;
            this.CbPurpose.Location = new System.Drawing.Point(12, 215);
            this.CbPurpose.Name = "CbPurpose";
            this.CbPurpose.Size = new System.Drawing.Size(256, 28);
            this.CbPurpose.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Note:";
            // 
            // TxtNotes
            // 
            this.TxtNotes.Location = new System.Drawing.Point(284, 215);
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.Size = new System.Drawing.Size(256, 26);
            this.TxtNotes.TabIndex = 8;
            // 
            // LbFiles
            // 
            this.LbFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbFiles.FormattingEnabled = true;
            this.LbFiles.ItemHeight = 20;
            this.LbFiles.Location = new System.Drawing.Point(284, 59);
            this.LbFiles.Name = "LbFiles";
            this.LbFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LbFiles.Size = new System.Drawing.Size(256, 82);
            this.LbFiles.TabIndex = 10;
            this.LbFiles.Click += new System.EventHandler(this.OnSelectionChange);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Files:";
            // 
            // CmdRemoveFiles
            // 
            this.CmdRemoveFiles.Enabled = false;
            this.CmdRemoveFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdRemoveFiles.Location = new System.Drawing.Point(415, 147);
            this.CmdRemoveFiles.Name = "CmdRemoveFiles";
            this.CmdRemoveFiles.Size = new System.Drawing.Size(125, 37);
            this.CmdRemoveFiles.TabIndex = 15;
            this.CmdRemoveFiles.Text = "Remove";
            this.CmdRemoveFiles.UseVisualStyleBackColor = true;
            this.CmdRemoveFiles.Click += new System.EventHandler(this.RemoveValue);
            // 
            // CmdAddFiles
            // 
            this.CmdAddFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdAddFiles.Location = new System.Drawing.Point(284, 147);
            this.CmdAddFiles.Name = "CmdAddFiles";
            this.CmdAddFiles.Size = new System.Drawing.Size(125, 37);
            this.CmdAddFiles.TabIndex = 14;
            this.CmdAddFiles.Text = "Add";
            this.CmdAddFiles.UseVisualStyleBackColor = true;
            this.CmdAddFiles.Click += new System.EventHandler(this.AddValue);
            // 
            // CmdSubmit
            // 
            this.CmdSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdSubmit.Location = new System.Drawing.Point(12, 249);
            this.CmdSubmit.Name = "CmdSubmit";
            this.CmdSubmit.Size = new System.Drawing.Size(256, 55);
            this.CmdSubmit.TabIndex = 16;
            this.CmdSubmit.Text = "Submit";
            this.CmdSubmit.UseVisualStyleBackColor = true;
            this.CmdSubmit.Click += new System.EventHandler(this.SendData);
            // 
            // LblStatus
            // 
            this.LblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(8, 307);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(27, 20);
            this.LblStatus.TabIndex = 17;
            this.LblStatus.Text = "ph";
            // 
            // CmdContext
            // 
            this.CmdContext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdContext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CmdContext.Location = new System.Drawing.Point(274, 249);
            this.CmdContext.Name = "CmdContext";
            this.CmdContext.Size = new System.Drawing.Size(55, 55);
            this.CmdContext.TabIndex = 23;
            this.CmdContext.Text = "▼";
            this.CmdContext.UseVisualStyleBackColor = true;
            this.CmdContext.Click += new System.EventHandler(this.CmdContext_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.TsMiOptions,
            this.checkUpdate});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(167, 54);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // TsMiOptions
            // 
            this.TsMiOptions.Name = "TsMiOptions";
            this.TsMiOptions.Size = new System.Drawing.Size(166, 22);
            this.TsMiOptions.Text = "Options";
            // 
            // checkUpdate
            // 
            this.checkUpdate.Name = "checkUpdate";
            this.checkUpdate.Size = new System.Drawing.Size(166, 22);
            this.checkUpdate.Text = "Check for Update";
            // 
            // AutoUpdate
            // 
            this.AutoUpdate.ContainerForm = this;
            this.AutoUpdate.DaysBetweenChecks = 1;
            this.AutoUpdate.GUID = "e99d13f4-49aa-4180-83e2-232a5ff27b3d";
            this.AutoUpdate.Location = new System.Drawing.Point(8, 8);
            this.AutoUpdate.Name = "AutoUpdate";
            this.AutoUpdate.Size = new System.Drawing.Size(16, 16);
            this.AutoUpdate.TabIndex = 20;
            this.AutoUpdate.ToolStripItem = this.checkUpdate;
            this.AutoUpdate.WaitBeforeCheckSecs = 1;
            this.AutoUpdate.wyUpdateCommandline = null;
            this.AutoUpdate.ClosingAborted += new System.EventHandler(this.AutoUpdate_ClosingAborted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(549, 336);
            this.Controls.Add(this.CmdContext);
            this.Controls.Add(this.AutoUpdate);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Submit Data";
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AutoUpdate)).EndInit();
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
        private wyDay.Controls.AutomaticUpdater AutoUpdate;
        private System.Windows.Forms.Button CmdContext;
        private System.Windows.Forms.ToolStripMenuItem checkUpdate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TsMiOptions;
    }
}

