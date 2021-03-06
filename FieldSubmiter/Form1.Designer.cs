﻿namespace FieldSubmiter
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
            this.CmdContext = new System.Windows.Forms.Button();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TsMiOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.checkUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Job:";
            // 
            // TxtNumber
            // 
            this.TxtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TxtNumber.Location = new System.Drawing.Point(110, 12);
            this.TxtNumber.Mask = "00-00-000";
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(158, 32);
            this.TxtNumber.TabIndex = 1;
            this.TxtNumber.TextChanged += new System.EventHandler(this.OnNumberChanged);
            this.TxtNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNumber_KeyDown);
            // 
            // LbNumbers
            // 
            this.LbNumbers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.LbNumbers.FormattingEnabled = true;
            this.LbNumbers.ItemHeight = 25;
            this.LbNumbers.Location = new System.Drawing.Point(12, 50);
            this.LbNumbers.Name = "LbNumbers";
            this.LbNumbers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LbNumbers.Size = new System.Drawing.Size(256, 77);
            this.LbNumbers.TabIndex = 2;
            this.LbNumbers.Click += new System.EventHandler(this.OnSelectionChange);
            this.LbNumbers.SelectedIndexChanged += new System.EventHandler(this.OnSelectionChange);
            // 
            // CmdAddNumber
            // 
            this.CmdAddNumber.Enabled = false;
            this.CmdAddNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdAddNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CmdAddNumber.Location = new System.Drawing.Point(12, 133);
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
            this.CmdRemoveNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CmdRemoveNumber.Location = new System.Drawing.Point(143, 133);
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(12, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Purpose:";
            // 
            // CbPurpose
            // 
            this.CbPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CbPurpose.FormattingEnabled = true;
            this.CbPurpose.Location = new System.Drawing.Point(12, 205);
            this.CbPurpose.Name = "CbPurpose";
            this.CbPurpose.Size = new System.Drawing.Size(256, 33);
            this.CbPurpose.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(278, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Note:";
            // 
            // TxtNotes
            // 
            this.TxtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TxtNotes.Location = new System.Drawing.Point(282, 206);
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.Size = new System.Drawing.Size(256, 32);
            this.TxtNotes.TabIndex = 8;
            // 
            // LbFiles
            // 
            this.LbFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.LbFiles.FormattingEnabled = true;
            this.LbFiles.ItemHeight = 25;
            this.LbFiles.Location = new System.Drawing.Point(282, 50);
            this.LbFiles.Name = "LbFiles";
            this.LbFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LbFiles.Size = new System.Drawing.Size(256, 77);
            this.LbFiles.TabIndex = 10;
            this.LbFiles.Click += new System.EventHandler(this.OnSelectionChange);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(278, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Files:";
            // 
            // CmdRemoveFiles
            // 
            this.CmdRemoveFiles.Enabled = false;
            this.CmdRemoveFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdRemoveFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CmdRemoveFiles.Location = new System.Drawing.Point(413, 133);
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
            this.CmdAddFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CmdAddFiles.Location = new System.Drawing.Point(282, 133);
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
            this.CmdSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CmdSubmit.Location = new System.Drawing.Point(12, 244);
            this.CmdSubmit.Name = "CmdSubmit";
            this.CmdSubmit.Size = new System.Drawing.Size(256, 55);
            this.CmdSubmit.TabIndex = 16;
            this.CmdSubmit.Text = "Submit";
            this.CmdSubmit.UseVisualStyleBackColor = true;
            this.CmdSubmit.Click += new System.EventHandler(this.SendData);
            // 
            // CmdContext
            // 
            this.CmdContext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdContext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CmdContext.Location = new System.Drawing.Point(268, 244);
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 312);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(549, 26);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(157, 21);
            this.lblStatus.Text = "toolStripStatusLabel1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(549, 338);
            this.Controls.Add(this.statusStrip1);
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
            this.Controls.Add(this.CmdContext);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Submit Data";
            this.contextMenuStrip.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.Button CmdSubmit;
        private System.Windows.Forms.Button CmdContext;
        private System.Windows.Forms.ToolStripMenuItem checkUpdate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TsMiOptions;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}

