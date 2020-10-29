namespace SurveyToolbox
{
    partial class ProjectViewer
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
            this.lblJobNumber = new System.Windows.Forms.Label();
            this.LLblOpenFolder = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.RTxtLog = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbNotes = new System.Windows.Forms.CheckBox();
            this.cbFileManagement = new System.Windows.Forms.CheckBox();
            this.cbEMails = new System.Windows.Forms.CheckBox();
            this.cbAccess = new System.Windows.Forms.CheckBox();
            this.cbAutocad = new System.Windows.Forms.CheckBox();
            this.CmdAddNote = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblJobNumber
            // 
            this.lblJobNumber.AutoSize = true;
            this.lblJobNumber.Location = new System.Drawing.Point(12, 9);
            this.lblJobNumber.Name = "lblJobNumber";
            this.lblJobNumber.Size = new System.Drawing.Size(65, 21);
            this.lblJobNumber.TabIndex = 0;
            this.lblJobNumber.Text = "Project: ";
            // 
            // LLblOpenFolder
            // 
            this.LLblOpenFolder.ActiveLinkColor = System.Drawing.Color.Blue;
            this.LLblOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LLblOpenFolder.AutoSize = true;
            this.LLblOpenFolder.Location = new System.Drawing.Point(876, 9);
            this.LLblOpenFolder.Name = "LLblOpenFolder";
            this.LLblOpenFolder.Size = new System.Drawing.Size(96, 21);
            this.LLblOpenFolder.TabIndex = 1;
            this.LLblOpenFolder.TabStop = true;
            this.LLblOpenFolder.Text = "Open Folder";
            this.LLblOpenFolder.VisitedLinkColor = System.Drawing.Color.Blue;
            this.LLblOpenFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OpenFolder);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(1, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 530);
            this.panel1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(983, 530);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(975, 496);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(975, 496);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tasks";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(975, 496);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "E-Mails";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 30);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(975, 496);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "File Management";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.RTxtLog);
            this.tabPage5.Controls.Add(this.CmdAddNote);
            this.tabPage5.Controls.Add(this.cbAutocad);
            this.tabPage5.Controls.Add(this.cbAccess);
            this.tabPage5.Controls.Add(this.cbEMails);
            this.tabPage5.Controls.Add(this.cbFileManagement);
            this.tabPage5.Controls.Add(this.cbNotes);
            this.tabPage5.Controls.Add(this.textBox1);
            this.tabPage5.Location = new System.Drawing.Point(4, 30);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(975, 496);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Project Log";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // RTxtLog
            // 
            this.RTxtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTxtLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RTxtLog.Location = new System.Drawing.Point(-4, 30);
            this.RTxtLog.Name = "RTxtLog";
            this.RTxtLog.ReadOnly = true;
            this.RTxtLog.Size = new System.Drawing.Size(983, 394);
            this.RTxtLog.TabIndex = 0;
            this.RTxtLog.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(-4, 459);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(841, 37);
            this.textBox1.TabIndex = 1;
            // 
            // cbNotes
            // 
            this.cbNotes.AutoSize = true;
            this.cbNotes.Checked = true;
            this.cbNotes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNotes.Location = new System.Drawing.Point(0, 6);
            this.cbNotes.Name = "cbNotes";
            this.cbNotes.Size = new System.Drawing.Size(70, 25);
            this.cbNotes.TabIndex = 2;
            this.cbNotes.Text = "Notes";
            this.cbNotes.UseVisualStyleBackColor = true;
            // 
            // cbFileManagement
            // 
            this.cbFileManagement.AutoSize = true;
            this.cbFileManagement.Checked = true;
            this.cbFileManagement.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFileManagement.Location = new System.Drawing.Point(76, 6);
            this.cbFileManagement.Name = "cbFileManagement";
            this.cbFileManagement.Size = new System.Drawing.Size(149, 25);
            this.cbFileManagement.TabIndex = 3;
            this.cbFileManagement.Text = "File Management";
            this.cbFileManagement.UseVisualStyleBackColor = true;
            // 
            // cbEMails
            // 
            this.cbEMails.AutoSize = true;
            this.cbEMails.Checked = true;
            this.cbEMails.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEMails.Location = new System.Drawing.Point(231, 6);
            this.cbEMails.Name = "cbEMails";
            this.cbEMails.Size = new System.Drawing.Size(80, 25);
            this.cbEMails.TabIndex = 4;
            this.cbEMails.Text = "E-Mails";
            this.cbEMails.UseVisualStyleBackColor = true;
            // 
            // cbAccess
            // 
            this.cbAccess.AutoSize = true;
            this.cbAccess.Checked = true;
            this.cbAccess.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAccess.Location = new System.Drawing.Point(317, 6);
            this.cbAccess.Name = "cbAccess";
            this.cbAccess.Size = new System.Drawing.Size(127, 25);
            this.cbAccess.TabIndex = 5;
            this.cbAccess.Text = "Project Access";
            this.cbAccess.UseVisualStyleBackColor = true;
            // 
            // cbAutocad
            // 
            this.cbAutocad.AutoSize = true;
            this.cbAutocad.Checked = true;
            this.cbAutocad.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutocad.Location = new System.Drawing.Point(450, 6);
            this.cbAutocad.Name = "cbAutocad";
            this.cbAutocad.Size = new System.Drawing.Size(142, 25);
            this.cbAutocad.TabIndex = 6;
            this.cbAutocad.Text = "AutoCAD Events";
            this.cbAutocad.UseVisualStyleBackColor = true;
            // 
            // CmdAddNote
            // 
            this.CmdAddNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdAddNote.Location = new System.Drawing.Point(843, 459);
            this.CmdAddNote.Name = "CmdAddNote";
            this.CmdAddNote.Size = new System.Drawing.Size(136, 37);
            this.CmdAddNote.TabIndex = 7;
            this.CmdAddNote.Text = "Add Note";
            this.CmdAddNote.UseVisualStyleBackColor = true;
            // 
            // ProjectViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LLblOpenFolder);
            this.Controls.Add(this.lblJobNumber);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "ProjectViewer";
            this.Text = "ProjectViewer";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJobNumber;
        private System.Windows.Forms.LinkLabel LLblOpenFolder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.RichTextBox RTxtLog;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox cbAutocad;
        private System.Windows.Forms.CheckBox cbAccess;
        private System.Windows.Forms.CheckBox cbEMails;
        private System.Windows.Forms.CheckBox cbFileManagement;
        private System.Windows.Forms.CheckBox cbNotes;
        private System.Windows.Forms.Button CmdAddNote;
    }
}