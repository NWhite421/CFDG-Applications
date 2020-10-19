namespace FieldSubmiter
{
    partial class Options
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
            this.CmdEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtFullName = new System.Windows.Forms.TextBox();
            this.TxtDefaultSearch = new System.Windows.Forms.TextBox();
            this.RbEmail = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.RbTCPConnection = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbxEmailSSL = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtEmailPort = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtEmailDomain = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CbHosts = new System.Windows.Forms.ComboBox();
            this.TxtEMailPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtTCPPort = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtTCPIP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CmdApplyChanges = new System.Windows.Forms.Button();
            this.CmdDiscardChanges = new System.Windows.Forms.Button();
            this.TxtReceivers = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmdEdit
            // 
            this.CmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdEdit.Location = new System.Drawing.Point(422, 12);
            this.CmdEdit.Name = "CmdEdit";
            this.CmdEdit.Size = new System.Drawing.Size(108, 38);
            this.CmdEdit.TabIndex = 0;
            this.CmdEdit.Text = "Edit";
            this.CmdEdit.UseVisualStyleBackColor = true;
            this.CmdEdit.Click += new System.EventHandler(this.AllowEdit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search Folder:";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(424, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 28);
            this.button1.TabIndex = 5;
            this.button1.TabStop = false;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TxtFullName
            // 
            this.TxtFullName.Enabled = false;
            this.TxtFullName.Location = new System.Drawing.Point(102, 56);
            this.TxtFullName.Name = "TxtFullName";
            this.TxtFullName.Size = new System.Drawing.Size(428, 26);
            this.TxtFullName.TabIndex = 1;
            // 
            // TxtDefaultSearch
            // 
            this.TxtDefaultSearch.Enabled = false;
            this.TxtDefaultSearch.Location = new System.Drawing.Point(127, 89);
            this.TxtDefaultSearch.Name = "TxtDefaultSearch";
            this.TxtDefaultSearch.Size = new System.Drawing.Size(291, 26);
            this.TxtDefaultSearch.TabIndex = 2;
            // 
            // RbEmail
            // 
            this.RbEmail.AutoSize = true;
            this.RbEmail.Checked = true;
            this.RbEmail.Enabled = false;
            this.RbEmail.Location = new System.Drawing.Point(12, 146);
            this.RbEmail.Name = "RbEmail";
            this.RbEmail.Size = new System.Drawing.Size(71, 24);
            this.RbEmail.TabIndex = 3;
            this.RbEmail.TabStop = true;
            this.RbEmail.Text = "E-Mail";
            this.RbEmail.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Send Method:";
            // 
            // RbTCPConnection
            // 
            this.RbTCPConnection.AutoSize = true;
            this.RbTCPConnection.Enabled = false;
            this.RbTCPConnection.Location = new System.Drawing.Point(12, 176);
            this.RbTCPConnection.Name = "RbTCPConnection";
            this.RbTCPConnection.Size = new System.Drawing.Size(142, 24);
            this.RbTCPConnection.TabIndex = 10;
            this.RbTCPConnection.Text = "TCP Connection";
            this.RbTCPConnection.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtReceivers);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.CbxEmailSSL);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TxtEmailPort);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtEmailDomain);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CbHosts);
            this.groupBox1.Controls.Add(this.TxtEMailPassword);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtEmail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 270);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "E-Mail Settings";
            // 
            // CbxEmailSSL
            // 
            this.CbxEmailSSL.AutoSize = true;
            this.CbxEmailSSL.Enabled = false;
            this.CbxEmailSSL.Location = new System.Drawing.Point(120, 243);
            this.CbxEmailSSL.Name = "CbxEmailSSL";
            this.CbxEmailSSL.Size = new System.Drawing.Size(15, 14);
            this.CbxEmailSSL.TabIndex = 10;
            this.CbxEmailSSL.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Enable SSL:";
            // 
            // TxtEmailPort
            // 
            this.TxtEmailPort.Enabled = false;
            this.TxtEmailPort.Location = new System.Drawing.Point(120, 204);
            this.TxtEmailPort.Name = "TxtEmailPort";
            this.TxtEmailPort.Size = new System.Drawing.Size(392, 26);
            this.TxtEmailPort.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Port:";
            // 
            // TxtEmailDomain
            // 
            this.TxtEmailDomain.Enabled = false;
            this.TxtEmailDomain.Location = new System.Drawing.Point(120, 172);
            this.TxtEmailDomain.Name = "TxtEmailDomain";
            this.TxtEmailDomain.Size = new System.Drawing.Size(392, 26);
            this.TxtEmailDomain.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Domain:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Host:";
            // 
            // CbHosts
            // 
            this.CbHosts.Enabled = false;
            this.CbHosts.FormattingEnabled = true;
            this.CbHosts.Items.AddRange(new object[] {
            "Google Mail",
            "GoDaddy Email Service",
            "Office 365 Service",
            "Other"});
            this.CbHosts.Location = new System.Drawing.Point(120, 138);
            this.CbHosts.Name = "CbHosts";
            this.CbHosts.Size = new System.Drawing.Size(392, 28);
            this.CbHosts.TabIndex = 7;
            this.CbHosts.SelectedIndexChanged += new System.EventHandler(this.UpdateEMailSettings);
            // 
            // TxtEMailPassword
            // 
            this.TxtEMailPassword.Enabled = false;
            this.TxtEMailPassword.Location = new System.Drawing.Point(120, 57);
            this.TxtEMailPassword.Name = "TxtEMailPassword";
            this.TxtEMailPassword.PasswordChar = '*';
            this.TxtEMailPassword.Size = new System.Drawing.Size(392, 26);
            this.TxtEMailPassword.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Password:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Enabled = false;
            this.TxtEmail.Location = new System.Drawing.Point(120, 25);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(392, 26);
            this.TxtEmail.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sender EMail:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.TxtTCPPort);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.TxtTCPIP);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(12, 482);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 116);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(151, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "TO BE IMPLIMENTED";
            // 
            // TxtTCPPort
            // 
            this.TxtTCPPort.Enabled = false;
            this.TxtTCPPort.Location = new System.Drawing.Point(120, 57);
            this.TxtTCPPort.Name = "TxtTCPPort";
            this.TxtTCPPort.Size = new System.Drawing.Size(392, 26);
            this.TxtTCPPort.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(72, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Port:";
            // 
            // TxtTCPIP
            // 
            this.TxtTCPIP.Enabled = false;
            this.TxtTCPIP.Location = new System.Drawing.Point(120, 25);
            this.TxtTCPIP.Name = "TxtTCPIP";
            this.TxtTCPIP.Size = new System.Drawing.Size(392, 26);
            this.TxtTCPIP.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Destination IP:";
            // 
            // CmdApplyChanges
            // 
            this.CmdApplyChanges.Enabled = false;
            this.CmdApplyChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdApplyChanges.Location = new System.Drawing.Point(371, 604);
            this.CmdApplyChanges.Name = "CmdApplyChanges";
            this.CmdApplyChanges.Size = new System.Drawing.Size(159, 38);
            this.CmdApplyChanges.TabIndex = 13;
            this.CmdApplyChanges.Text = "Apply Changes";
            this.CmdApplyChanges.UseVisualStyleBackColor = true;
            this.CmdApplyChanges.Click += new System.EventHandler(this.CmdApplyChanges_Click);
            // 
            // CmdDiscardChanges
            // 
            this.CmdDiscardChanges.Enabled = false;
            this.CmdDiscardChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdDiscardChanges.Location = new System.Drawing.Point(12, 604);
            this.CmdDiscardChanges.Name = "CmdDiscardChanges";
            this.CmdDiscardChanges.Size = new System.Drawing.Size(159, 38);
            this.CmdDiscardChanges.TabIndex = 14;
            this.CmdDiscardChanges.TabStop = false;
            this.CmdDiscardChanges.Text = "Discard Changes";
            this.CmdDiscardChanges.UseVisualStyleBackColor = true;
            this.CmdDiscardChanges.Click += new System.EventHandler(this.CmdDiscardChanges_Click);
            // 
            // TxtReceivers
            // 
            this.TxtReceivers.Enabled = false;
            this.TxtReceivers.Location = new System.Drawing.Point(120, 89);
            this.TxtReceivers.Name = "TxtReceivers";
            this.TxtReceivers.Size = new System.Drawing.Size(392, 26);
            this.TxtReceivers.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Receivers:";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(542, 663);
            this.Controls.Add(this.CmdDiscardChanges);
            this.Controls.Add(this.CmdApplyChanges);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RbTCPConnection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RbEmail);
            this.Controls.Add(this.TxtDefaultSearch);
            this.Controls.Add(this.TxtFullName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmdEdit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.Text = "Options";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtFullName;
        private System.Windows.Forms.TextBox TxtDefaultSearch;
        private System.Windows.Forms.RadioButton RbEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RbTCPConnection;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtEMailPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CbHosts;
        private System.Windows.Forms.CheckBox CbxEmailSSL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtEmailPort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtEmailDomain;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtTCPPort;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtTCPIP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button CmdApplyChanges;
        private System.Windows.Forms.Button CmdDiscardChanges;
        private System.Windows.Forms.TextBox TxtReceivers;
        private System.Windows.Forms.Label label13;
    }
}