namespace SurveyToolbox
{
    partial class AdminWindow
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
            this.CmdSaveChanges = new System.Windows.Forms.Button();
            this.cmdDiscardChanges = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.CmdAddUser = new System.Windows.Forms.Button();
            this.RemoveUser = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MTxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.MTxtZip = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtState = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtAddress2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtAddress1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtShortName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Admin = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ActiveUser = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ResetPW = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ForceReset = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmdSaveChanges
            // 
            this.CmdSaveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdSaveChanges.Location = new System.Drawing.Point(511, 632);
            this.CmdSaveChanges.Name = "CmdSaveChanges";
            this.CmdSaveChanges.Size = new System.Drawing.Size(150, 33);
            this.CmdSaveChanges.TabIndex = 2;
            this.CmdSaveChanges.Text = "Save Changes";
            this.CmdSaveChanges.UseVisualStyleBackColor = true;
            this.CmdSaveChanges.Click += new System.EventHandler(this.CmdSaveChanges_Click);
            // 
            // cmdDiscardChanges
            // 
            this.cmdDiscardChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdDiscardChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDiscardChanges.Location = new System.Drawing.Point(0, 632);
            this.cmdDiscardChanges.Name = "cmdDiscardChanges";
            this.cmdDiscardChanges.Size = new System.Drawing.Size(150, 33);
            this.cmdDiscardChanges.TabIndex = 3;
            this.cmdDiscardChanges.Text = "Discard Changes";
            this.cmdDiscardChanges.UseVisualStyleBackColor = true;
            this.cmdDiscardChanges.Click += new System.EventHandler(this.cmdDiscardChanges_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "COMPANY INFORMATION";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "EMPLOYEE INFORMATION";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.PersonName,
            this.User,
            this.Admin,
            this.ActiveUser,
            this.ResetPW,
            this.ForceReset});
            this.dgvUsers.Location = new System.Drawing.Point(0, 290);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.Size = new System.Drawing.Size(661, 297);
            this.dgvUsers.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(551, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "NOTE: Force reseting a user\'s password will set their password to \"password1\"";
            // 
            // CmdAddUser
            // 
            this.CmdAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CmdAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdAddUser.Location = new System.Drawing.Point(0, 593);
            this.CmdAddUser.Name = "CmdAddUser";
            this.CmdAddUser.Size = new System.Drawing.Size(150, 33);
            this.CmdAddUser.TabIndex = 8;
            this.CmdAddUser.Text = "Add User";
            this.CmdAddUser.UseVisualStyleBackColor = true;
            this.CmdAddUser.Click += new System.EventHandler(this.CmdAddUser_Click);
            // 
            // RemoveUser
            // 
            this.RemoveUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveUser.Location = new System.Drawing.Point(156, 593);
            this.RemoveUser.Name = "RemoveUser";
            this.RemoveUser.Size = new System.Drawing.Size(150, 33);
            this.RemoveUser.TabIndex = 9;
            this.RemoveUser.Text = "Remove User";
            this.RemoveUser.UseVisualStyleBackColor = true;
            this.RemoveUser.Click += new System.EventHandler(this.CmdRemoveUser_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(669, 699);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.MTxtPhone);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.txtWebsite);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.MTxtZip);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.TxtState);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.TxtCity);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.TxtAddress2);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.TxtAddress1);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.TxtName);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.TxtShortName);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.CmdSaveChanges);
            this.tabPage1.Controls.Add(this.cmdDiscardChanges);
            this.tabPage1.Controls.Add(this.RemoveUser);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.CmdAddUser);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dgvUsers);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(661, 665);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Company";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MTxtPhone
            // 
            this.MTxtPhone.Location = new System.Drawing.Point(524, 206);
            this.MTxtPhone.Mask = "(999) 000-0000";
            this.MTxtPhone.Name = "MTxtPhone";
            this.MTxtPhone.Size = new System.Drawing.Size(129, 29);
            this.MTxtPhone.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(461, 209);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 21);
            this.label17.TabIndex = 26;
            this.label17.Text = "Phone:";
            // 
            // txtWebsite
            // 
            this.txtWebsite.Location = new System.Drawing.Point(82, 206);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(373, 29);
            this.txtWebsite.TabIndex = 25;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 209);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 21);
            this.label16.TabIndex = 24;
            this.label16.Text = "Website:";
            // 
            // MTxtZip
            // 
            this.MTxtZip.Location = new System.Drawing.Point(524, 171);
            this.MTxtZip.Mask = "00000";
            this.MTxtZip.Name = "MTxtZip";
            this.MTxtZip.Size = new System.Drawing.Size(129, 29);
            this.MTxtZip.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(443, 174);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 21);
            this.label15.TabIndex = 22;
            this.label15.Text = "Zip Code:";
            // 
            // TxtState
            // 
            this.TxtState.Location = new System.Drawing.Point(365, 171);
            this.TxtState.Name = "TxtState";
            this.TxtState.Size = new System.Drawing.Size(72, 29);
            this.TxtState.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(312, 174);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 21);
            this.label14.TabIndex = 20;
            this.label14.Text = "State:";
            // 
            // TxtCity
            // 
            this.TxtCity.Location = new System.Drawing.Point(54, 171);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(252, 29);
            this.TxtCity.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 21);
            this.label13.TabIndex = 18;
            this.label13.Text = "City:";
            // 
            // TxtAddress2
            // 
            this.TxtAddress2.Location = new System.Drawing.Point(96, 136);
            this.TxtAddress2.Name = "TxtAddress2";
            this.TxtAddress2.Size = new System.Drawing.Size(557, 29);
            this.TxtAddress2.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 21);
            this.label12.TabIndex = 16;
            this.label12.Text = "Address 2:";
            // 
            // TxtAddress1
            // 
            this.TxtAddress1.Location = new System.Drawing.Point(96, 101);
            this.TxtAddress1.Name = "TxtAddress1";
            this.TxtAddress1.Size = new System.Drawing.Size(557, 29);
            this.TxtAddress1.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 21);
            this.label11.TabIndex = 14;
            this.label11.Text = "Address 1:";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(196, 66);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(457, 29);
            this.TxtName.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 21);
            this.label10.TabIndex = 12;
            this.label10.Text = "Legal Name (if different):";
            // 
            // TxtShortName
            // 
            this.TxtShortName.Location = new System.Drawing.Point(140, 31);
            this.TxtShortName.Name = "TxtShortName";
            this.TxtShortName.Size = new System.Drawing.Size(513, 29);
            this.TxtShortName.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 21);
            this.label9.TabIndex = 10;
            this.label9.Text = "Company Name:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(661, 665);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Project";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(207, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "NOT IMPLIMENTED YET";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(661, 665);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tasks";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(218, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "NOT IMPLIMENTED YET";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Location = new System.Drawing.Point(4, 30);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(661, 665);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Quotes";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(218, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "NOT IMPLIMENTED YET";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Location = new System.Drawing.Point(4, 30);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(661, 665);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Clients";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(218, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "NOT IMPLIMENTED YET";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.button1);
            this.tabPage6.Controls.Add(this.label8);
            this.tabPage6.Location = new System.Drawing.Point(4, 30);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(661, 665);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Finances";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 53);
            this.button1.TabIndex = 8;
            this.button1.Text = "Connect to Quickbooks";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(218, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "NOT IMPLIMENTED YET";
            // 
            // UserId
            // 
            this.UserId.HeaderText = "UserId";
            this.UserId.Name = "UserId";
            this.UserId.Visible = false;
            // 
            // PersonName
            // 
            this.PersonName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PersonName.HeaderText = "Name";
            this.PersonName.Name = "PersonName";
            this.PersonName.Width = 77;
            // 
            // User
            // 
            this.User.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.User.HeaderText = "Username";
            this.User.Name = "User";
            this.User.Width = 106;
            // 
            // Admin
            // 
            this.Admin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Admin.HeaderText = "Admin Level";
            this.Admin.Items.AddRange(new object[] {
            "User",
            "Team Leader",
            "Manager",
            "Admin"});
            this.Admin.Name = "Admin";
            this.Admin.Width = 102;
            // 
            // ActiveUser
            // 
            this.ActiveUser.HeaderText = "Active";
            this.ActiveUser.Name = "ActiveUser";
            // 
            // ResetPW
            // 
            this.ResetPW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ResetPW.HeaderText = "Reset Password";
            this.ResetPW.Name = "ResetPW";
            this.ResetPW.Width = 124;
            // 
            // ForceReset
            // 
            this.ForceReset.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ForceReset.HeaderText = "Force PW Reset";
            this.ForceReset.Name = "ForceReset";
            this.ForceReset.Width = 124;
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(669, 699);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminWindow";
            this.Text = "Admin Console";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CmdSaveChanges;
        private System.Windows.Forms.Button cmdDiscardChanges;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CmdAddUser;
        private System.Windows.Forms.Button RemoveUser;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox MTxtPhone;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtWebsite;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox MTxtZip;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtState;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtAddress2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtAddress1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtShortName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewComboBoxColumn Admin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ActiveUser;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ResetPW;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ForceReset;
    }
}