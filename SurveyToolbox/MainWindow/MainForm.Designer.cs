namespace SurveyToolbox
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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.CmdOpenJob = new System.Windows.Forms.Button();
            this.GrpToDo = new System.Windows.Forms.GroupBox();
            this.dgvProjects = new System.Windows.Forms.DataGridView();
            this.ProNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tasks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CmdApplyFilter = new System.Windows.Forms.Button();
            this.CmdClear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.MSMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MSC_Projects = new System.Windows.Forms.ToolStripMenuItem();
            this.MSC_Projects_Management = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MSC_Quotes = new System.Windows.Forms.ToolStripMenuItem();
            this.MSC_Clients = new System.Windows.Forms.ToolStripMenuItem();
            this.MSC_Finance = new System.Windows.Forms.ToolStripMenuItem();
            this.MSC_Schedule = new System.Windows.Forms.ToolStripMenuItem();
            this.MSC_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.openAdminPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CmdAdvanced = new System.Windows.Forms.Button();
            this.dCustomerWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.individualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            this.MSMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Open a Project:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox1.Location = new System.Drawing.Point(125, 31);
            this.maskedTextBox1.Mask = "00-00-000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(110, 24);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // CmdOpenJob
            // 
            this.CmdOpenJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdOpenJob.Location = new System.Drawing.Point(241, 30);
            this.CmdOpenJob.Name = "CmdOpenJob";
            this.CmdOpenJob.Size = new System.Drawing.Size(65, 25);
            this.CmdOpenJob.TabIndex = 2;
            this.CmdOpenJob.Text = "OPEN";
            this.CmdOpenJob.UseVisualStyleBackColor = true;
            // 
            // GrpToDo
            // 
            this.GrpToDo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpToDo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GrpToDo.Location = new System.Drawing.Point(907, 12);
            this.GrpToDo.Name = "GrpToDo";
            this.GrpToDo.Size = new System.Drawing.Size(237, 512);
            this.GrpToDo.TabIndex = 3;
            this.GrpToDo.TabStop = false;
            this.GrpToDo.Text = "To-Do List";
            // 
            // dgvProjects
            // 
            this.dgvProjects.AllowUserToAddRows = false;
            this.dgvProjects.AllowUserToDeleteRows = false;
            this.dgvProjects.AllowUserToResizeRows = false;
            this.dgvProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProjects.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvProjects.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProNum,
            this.ProName,
            this.Address,
            this.City,
            this.DueDate,
            this.Status,
            this.Tasks});
            this.dgvProjects.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProjects.Location = new System.Drawing.Point(12, 166);
            this.dgvProjects.Name = "dgvProjects";
            this.dgvProjects.ReadOnly = true;
            this.dgvProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjects.ShowEditingIcon = false;
            this.dgvProjects.Size = new System.Drawing.Size(889, 358);
            this.dgvProjects.TabIndex = 4;
            this.dgvProjects.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellDoubleClick);
            // 
            // ProNum
            // 
            this.ProNum.HeaderText = "Project #";
            this.ProNum.Name = "ProNum";
            this.ProNum.ReadOnly = true;
            // 
            // ProName
            // 
            this.ProName.HeaderText = "Name";
            this.ProName.Name = "ProName";
            this.ProName.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // DueDate
            // 
            this.DueDate.HeaderText = "DueDate";
            this.DueDate.Name = "DueDate";
            this.DueDate.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Tasks
            // 
            this.Tasks.HeaderText = "Tasks";
            this.Tasks.Name = "Tasks";
            this.Tasks.ReadOnly = true;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox2.Location = new System.Drawing.Point(12, 105);
            this.maskedTextBox2.Mask = "00-00-000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(82, 24);
            this.maskedTextBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Project #:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(100, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 24);
            this.textBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Project Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Address:";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(241, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 24);
            this.textBox2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "City:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(382, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 25);
            this.comboBox1.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(509, 104);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 25);
            this.comboBox2.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(506, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Status:";
            // 
            // CmdApplyFilter
            // 
            this.CmdApplyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdApplyFilter.Location = new System.Drawing.Point(12, 135);
            this.CmdApplyFilter.Name = "CmdApplyFilter";
            this.CmdApplyFilter.Size = new System.Drawing.Size(82, 25);
            this.CmdApplyFilter.TabIndex = 18;
            this.CmdApplyFilter.Text = "APPLY";
            this.CmdApplyFilter.UseVisualStyleBackColor = true;
            // 
            // CmdClear
            // 
            this.CmdClear.Enabled = false;
            this.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdClear.Location = new System.Drawing.Point(100, 135);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(82, 25);
            this.CmdClear.TabIndex = 19;
            this.CmdClear.Text = "CLEAR";
            this.CmdClear.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "Project Filter";
            // 
            // lblGreeting
            // 
            this.lblGreeting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGreeting.Location = new System.Drawing.Point(627, 30);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(274, 40);
            this.lblGreeting.TabIndex = 21;
            this.lblGreeting.Text = "Testj\r\nTestj";
            this.lblGreeting.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MSMain
            // 
            this.MSMain.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.MSMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.MSC_Projects,
            this.MSC_Quotes,
            this.MSC_Clients,
            this.MSC_Finance,
            this.MSC_Schedule,
            this.MSC_Admin});
            this.MSMain.Location = new System.Drawing.Point(0, 0);
            this.MSMain.Name = "MSMain";
            this.MSMain.Size = new System.Drawing.Size(1156, 28);
            this.MSMain.TabIndex = 22;
            this.MSMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportLogToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Tag = "0";
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportLogToolStripMenuItem
            // 
            this.exportLogToolStripMenuItem.Name = "exportLogToolStripMenuItem";
            this.exportLogToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.exportLogToolStripMenuItem.Tag = "0";
            this.exportLogToolStripMenuItem.Text = "Export Log";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.exitToolStripMenuItem.Tag = "0";
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.CloseForm);
            // 
            // MSC_Projects
            // 
            this.MSC_Projects.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSC_Projects_Management,
            this.newProjectToolStripMenuItem,
            this.openProjectToolStripMenuItem});
            this.MSC_Projects.Name = "MSC_Projects";
            this.MSC_Projects.Size = new System.Drawing.Size(73, 24);
            this.MSC_Projects.Tag = "0";
            this.MSC_Projects.Text = "Projects";
            // 
            // MSC_Projects_Management
            // 
            this.MSC_Projects_Management.Name = "MSC_Projects_Management";
            this.MSC_Projects_Management.Size = new System.Drawing.Size(222, 24);
            this.MSC_Projects_Management.Tag = "3";
            this.MSC_Projects_Management.Text = "Management Options";
            this.MSC_Projects_Management.Click += new System.EventHandler(this.OpenManagementOptions);
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.newProjectToolStripMenuItem.Tag = "2";
            this.newProjectToolStripMenuItem.Text = "New Project";
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.openProjectToolStripMenuItem.Tag = "1";
            this.openProjectToolStripMenuItem.Text = "Open Project";
            // 
            // MSC_Quotes
            // 
            this.MSC_Quotes.Name = "MSC_Quotes";
            this.MSC_Quotes.Size = new System.Drawing.Size(68, 24);
            this.MSC_Quotes.Tag = "2";
            this.MSC_Quotes.Text = "Quotes";
            // 
            // MSC_Clients
            // 
            this.MSC_Clients.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dCustomerWindowToolStripMenuItem});
            this.MSC_Clients.Name = "MSC_Clients";
            this.MSC_Clients.Size = new System.Drawing.Size(65, 24);
            this.MSC_Clients.Tag = "2";
            this.MSC_Clients.Text = "Clients";
            // 
            // MSC_Finance
            // 
            this.MSC_Finance.Name = "MSC_Finance";
            this.MSC_Finance.Size = new System.Drawing.Size(77, 24);
            this.MSC_Finance.Tag = "2";
            this.MSC_Finance.Text = "Finances";
            // 
            // MSC_Schedule
            // 
            this.MSC_Schedule.Name = "MSC_Schedule";
            this.MSC_Schedule.Size = new System.Drawing.Size(81, 24);
            this.MSC_Schedule.Tag = "1";
            this.MSC_Schedule.Text = "Schedule";
            // 
            // MSC_Admin
            // 
            this.MSC_Admin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openAdminPanelToolStripMenuItem});
            this.MSC_Admin.Name = "MSC_Admin";
            this.MSC_Admin.Size = new System.Drawing.Size(65, 24);
            this.MSC_Admin.Tag = "3";
            this.MSC_Admin.Text = "Admin";
            // 
            // openAdminPanelToolStripMenuItem
            // 
            this.openAdminPanelToolStripMenuItem.Name = "openAdminPanelToolStripMenuItem";
            this.openAdminPanelToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.openAdminPanelToolStripMenuItem.Text = "Open Admin Panel";
            this.openAdminPanelToolStripMenuItem.Click += new System.EventHandler(this.OpenAdminConsole);
            // 
            // CmdAdvanced
            // 
            this.CmdAdvanced.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdAdvanced.Location = new System.Drawing.Point(636, 103);
            this.CmdAdvanced.Name = "CmdAdvanced";
            this.CmdAdvanced.Size = new System.Drawing.Size(102, 25);
            this.CmdAdvanced.TabIndex = 23;
            this.CmdAdvanced.Text = "ADVANCED";
            this.CmdAdvanced.UseVisualStyleBackColor = true;
            // 
            // dCustomerWindowToolStripMenuItem
            // 
            this.dCustomerWindowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.individualToolStripMenuItem,
            this.companyToolStripMenuItem});
            this.dCustomerWindowToolStripMenuItem.Name = "dCustomerWindowToolStripMenuItem";
            this.dCustomerWindowToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.dCustomerWindowToolStripMenuItem.Tag = "2";
            this.dCustomerWindowToolStripMenuItem.Text = "[D] Customer Window";
            // 
            // individualToolStripMenuItem
            // 
            this.individualToolStripMenuItem.Name = "individualToolStripMenuItem";
            this.individualToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.individualToolStripMenuItem.Tag = "0";
            this.individualToolStripMenuItem.Text = "Individual";
            this.individualToolStripMenuItem.Click += new System.EventHandler(this.OpenCustomerInfo);
            // 
            // companyToolStripMenuItem
            // 
            this.companyToolStripMenuItem.Name = "companyToolStripMenuItem";
            this.companyToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.companyToolStripMenuItem.Tag = "0";
            this.companyToolStripMenuItem.Text = "Company";
            this.companyToolStripMenuItem.Click += new System.EventHandler(this.OpenCustomerInfo);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1156, 536);
            this.Controls.Add(this.CmdAdvanced);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.CmdApplyFilter);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.dgvProjects);
            this.Controls.Add(this.GrpToDo);
            this.Controls.Add(this.CmdOpenJob);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MSMain);
            this.Font = new System.Drawing.Font("Arial", 11F);
            this.MainMenuStrip = this.MSMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(970, 550);
            this.Name = "MainForm";
            this.Text = "Project Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).EndInit();
            this.MSMain.ResumeLayout(false);
            this.MSMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button CmdOpenJob;
        private System.Windows.Forms.GroupBox GrpToDo;
        private System.Windows.Forms.DataGridView dgvProjects;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button CmdApplyFilter;
        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tasks;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.MenuStrip MSMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MSC_Projects;
        private System.Windows.Forms.ToolStripMenuItem MSC_Quotes;
        private System.Windows.Forms.ToolStripMenuItem MSC_Clients;
        private System.Windows.Forms.ToolStripMenuItem MSC_Admin;
        private System.Windows.Forms.ToolStripMenuItem openAdminPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MSC_Projects_Management;
        private System.Windows.Forms.ToolStripMenuItem MSC_Finance;
        private System.Windows.Forms.ToolStripMenuItem MSC_Schedule;
        private System.Windows.Forms.Button CmdAdvanced;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dCustomerWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem individualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyToolStripMenuItem;
    }
}

