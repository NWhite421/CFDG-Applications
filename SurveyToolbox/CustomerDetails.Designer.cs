namespace SurveyToolbox
{
    partial class CustomerDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAddress1 = new System.Windows.Forms.TextBox();
            this.TxtAddress2 = new System.Windows.Forms.TextBox();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.TxtState = new System.Windows.Forms.TextBox();
            this.TxtZip = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CmdGenerateReport = new System.Windows.Forms.Button();
            this.CmdGenerateFullReport = new System.Windows.Forms.Button();
            this.CmdSaveandClose = new System.Windows.Forms.Button();
            this.CmdClosewithoutSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvReps = new System.Windows.Forms.DataGridView();
            this.RName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAlerts = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.LblAcntFrozen = new System.Windows.Forms.Label();
            this.CmdRDelete = new System.Windows.Forms.Button();
            this.CmdREdit = new System.Windows.Forms.Button();
            this.CmdRAdd = new System.Windows.Forms.Button();
            this.LblAcntAlert = new System.Windows.Forms.Label();
            this.NLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIssued = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NClear = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CmdRNewAlert = new System.Windows.Forms.Button();
            this.dgvProjects = new System.Windows.Forms.DataGridView();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvQuotes = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.LblIncomeTotal = new System.Windows.Forms.Label();
            this.LblReceivedFunds = new System.Windows.Forms.Label();
            this.LblOutstandingFunds = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlerts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.CmdRNewAlert);
            this.panel1.Controls.Add(this.CmdRAdd);
            this.panel1.Controls.Add(this.CmdREdit);
            this.panel1.Controls.Add(this.CmdRDelete);
            this.panel1.Controls.Add(this.dgvAlerts);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dgvReps);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TxtPhone);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtEmail);
            this.panel1.Controls.Add(this.TxtZip);
            this.panel1.Controls.Add(this.TxtState);
            this.panel1.Controls.Add(this.TxtCity);
            this.panel1.Controls.Add(this.TxtAddress2);
            this.panel1.Controls.Add(this.TxtAddress1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LblAcntAlert);
            this.panel1.Controls.Add(this.LblAcntFrozen);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 689);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.CmdClosewithoutSave);
            this.panel2.Controls.Add(this.CmdSaveandClose);
            this.panel2.Controls.Add(this.CmdGenerateFullReport);
            this.panel2.Controls.Add(this.CmdGenerateReport);
            this.panel2.Location = new System.Drawing.Point(565, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(606, 689);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // TxtName
            // 
            this.TxtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtName.Location = new System.Drawing.Point(71, 12);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(482, 29);
            this.TxtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mailing Address:";
            // 
            // TxtAddress1
            // 
            this.TxtAddress1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAddress1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAddress1.Location = new System.Drawing.Point(71, 82);
            this.TxtAddress1.Name = "TxtAddress1";
            this.TxtAddress1.Size = new System.Drawing.Size(482, 29);
            this.TxtAddress1.TabIndex = 4;
            // 
            // TxtAddress2
            // 
            this.TxtAddress2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAddress2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAddress2.Location = new System.Drawing.Point(71, 117);
            this.TxtAddress2.Name = "TxtAddress2";
            this.TxtAddress2.Size = new System.Drawing.Size(482, 29);
            this.TxtAddress2.TabIndex = 5;
            // 
            // TxtCity
            // 
            this.TxtCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCity.Location = new System.Drawing.Point(71, 152);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(243, 29);
            this.TxtCity.TabIndex = 6;
            // 
            // TxtState
            // 
            this.TxtState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtState.Location = new System.Drawing.Point(320, 152);
            this.TxtState.Name = "TxtState";
            this.TxtState.Size = new System.Drawing.Size(65, 29);
            this.TxtState.TabIndex = 7;
            // 
            // TxtZip
            // 
            this.TxtZip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtZip.Location = new System.Drawing.Point(391, 152);
            this.TxtZip.Name = "TxtZip";
            this.TxtZip.Size = new System.Drawing.Size(162, 29);
            this.TxtZip.TabIndex = 8;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEmail.Location = new System.Drawing.Point(71, 187);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(297, 29);
            this.TxtEmail.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "EMail:";
            // 
            // TxtPhone
            // 
            this.TxtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPhone.Location = new System.Drawing.Point(437, 187);
            this.TxtPhone.Mask = "(999) 000-0000";
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(116, 29);
            this.TxtPhone.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Phone:";
            // 
            // CmdGenerateReport
            // 
            this.CmdGenerateReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CmdGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdGenerateReport.Location = new System.Drawing.Point(3, 618);
            this.CmdGenerateReport.Name = "CmdGenerateReport";
            this.CmdGenerateReport.Size = new System.Drawing.Size(193, 32);
            this.CmdGenerateReport.TabIndex = 13;
            this.CmdGenerateReport.Text = "Generate Simple Report";
            this.CmdGenerateReport.UseVisualStyleBackColor = true;
            // 
            // CmdGenerateFullReport
            // 
            this.CmdGenerateFullReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CmdGenerateFullReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdGenerateFullReport.Location = new System.Drawing.Point(3, 654);
            this.CmdGenerateFullReport.Name = "CmdGenerateFullReport";
            this.CmdGenerateFullReport.Size = new System.Drawing.Size(193, 32);
            this.CmdGenerateFullReport.TabIndex = 14;
            this.CmdGenerateFullReport.Text = "Generate Full Report";
            this.CmdGenerateFullReport.UseVisualStyleBackColor = true;
            // 
            // CmdSaveandClose
            // 
            this.CmdSaveandClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdSaveandClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdSaveandClose.Location = new System.Drawing.Point(410, 618);
            this.CmdSaveandClose.Name = "CmdSaveandClose";
            this.CmdSaveandClose.Size = new System.Drawing.Size(193, 32);
            this.CmdSaveandClose.TabIndex = 15;
            this.CmdSaveandClose.Text = "Save Changes and Close";
            this.CmdSaveandClose.UseVisualStyleBackColor = true;
            // 
            // CmdClosewithoutSave
            // 
            this.CmdClosewithoutSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdClosewithoutSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdClosewithoutSave.Location = new System.Drawing.Point(410, 654);
            this.CmdClosewithoutSave.Name = "CmdClosewithoutSave";
            this.CmdClosewithoutSave.Size = new System.Drawing.Size(193, 32);
            this.CmdClosewithoutSave.TabIndex = 16;
            this.CmdClosewithoutSave.Text = "Close without Saving";
            this.CmdClosewithoutSave.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(3, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "REPRESENTATIVES";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.LblOutstandingFunds);
            this.panel3.Controls.Add(this.LblReceivedFunds);
            this.panel3.Controls.Add(this.LblIncomeTotal);
            this.panel3.Controls.Add(this.dgvQuotes);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.dgvInvoices);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.dgvProjects);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 609);
            this.panel3.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "RELATED PROJECTS";
            // 
            // dgvReps
            // 
            this.dgvReps.AllowUserToAddRows = false;
            this.dgvReps.AllowUserToDeleteRows = false;
            this.dgvReps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RName,
            this.RTitle,
            this.REmail,
            this.RPhone,
            this.RNotes});
            this.dgvReps.Location = new System.Drawing.Point(3, 243);
            this.dgvReps.Name = "dgvReps";
            this.dgvReps.ReadOnly = true;
            this.dgvReps.RowHeadersVisible = false;
            this.dgvReps.Size = new System.Drawing.Size(550, 171);
            this.dgvReps.TabIndex = 14;
            // 
            // RName
            // 
            this.RName.HeaderText = "Name";
            this.RName.Name = "RName";
            this.RName.ReadOnly = true;
            // 
            // RTitle
            // 
            this.RTitle.HeaderText = "Title";
            this.RTitle.Name = "RTitle";
            this.RTitle.ReadOnly = true;
            // 
            // REmail
            // 
            this.REmail.HeaderText = "EMail";
            this.REmail.Name = "REmail";
            this.REmail.ReadOnly = true;
            // 
            // RPhone
            // 
            this.RPhone.HeaderText = "Phone";
            this.RPhone.Name = "RPhone";
            this.RPhone.ReadOnly = true;
            // 
            // RNotes
            // 
            this.RNotes.HeaderText = "Notes";
            this.RNotes.Name = "RNotes";
            this.RNotes.ReadOnly = true;
            // 
            // dgvAlerts
            // 
            this.dgvAlerts.AllowUserToAddRows = false;
            this.dgvAlerts.AllowUserToDeleteRows = false;
            this.dgvAlerts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAlerts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvAlerts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlerts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NLevel,
            this.NIssued,
            this.NNote,
            this.NClear});
            this.dgvAlerts.Location = new System.Drawing.Point(3, 475);
            this.dgvAlerts.Name = "dgvAlerts";
            this.dgvAlerts.ReadOnly = true;
            this.dgvAlerts.RowHeadersVisible = false;
            this.dgvAlerts.Size = new System.Drawing.Size(550, 162);
            this.dgvAlerts.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(3, 451);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "NOTICES && ALERTS";
            // 
            // LblAcntFrozen
            // 
            this.LblAcntFrozen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblAcntFrozen.AutoSize = true;
            this.LblAcntFrozen.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAcntFrozen.ForeColor = System.Drawing.Color.Red;
            this.LblAcntFrozen.Location = new System.Drawing.Point(347, 43);
            this.LblAcntFrozen.Name = "LblAcntFrozen";
            this.LblAcntFrozen.Size = new System.Drawing.Size(206, 30);
            this.LblAcntFrozen.TabIndex = 17;
            this.LblAcntFrozen.Text = "ACCOUNT FROZEN";
            this.LblAcntFrozen.Visible = false;
            // 
            // CmdRDelete
            // 
            this.CmdRDelete.Enabled = false;
            this.CmdRDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdRDelete.Location = new System.Drawing.Point(223, 416);
            this.CmdRDelete.Name = "CmdRDelete";
            this.CmdRDelete.Size = new System.Drawing.Size(104, 32);
            this.CmdRDelete.TabIndex = 18;
            this.CmdRDelete.Text = "Delete";
            this.CmdRDelete.UseVisualStyleBackColor = true;
            // 
            // CmdREdit
            // 
            this.CmdREdit.Enabled = false;
            this.CmdREdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdREdit.Location = new System.Drawing.Point(113, 416);
            this.CmdREdit.Name = "CmdREdit";
            this.CmdREdit.Size = new System.Drawing.Size(104, 32);
            this.CmdREdit.TabIndex = 19;
            this.CmdREdit.Text = "Modify";
            this.CmdREdit.UseVisualStyleBackColor = true;
            // 
            // CmdRAdd
            // 
            this.CmdRAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdRAdd.Location = new System.Drawing.Point(3, 416);
            this.CmdRAdd.Name = "CmdRAdd";
            this.CmdRAdd.Size = new System.Drawing.Size(104, 32);
            this.CmdRAdd.TabIndex = 20;
            this.CmdRAdd.Text = "New";
            this.CmdRAdd.UseVisualStyleBackColor = true;
            // 
            // LblAcntAlert
            // 
            this.LblAcntAlert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblAcntAlert.AutoSize = true;
            this.LblAcntAlert.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAcntAlert.ForeColor = System.Drawing.Color.Orange;
            this.LblAcntAlert.Location = new System.Drawing.Point(364, 43);
            this.LblAcntAlert.Name = "LblAcntAlert";
            this.LblAcntAlert.Size = new System.Drawing.Size(189, 30);
            this.LblAcntAlert.TabIndex = 21;
            this.LblAcntAlert.Text = "ACCOUNT ALERT";
            this.LblAcntAlert.Visible = false;
            // 
            // NLevel
            // 
            this.NLevel.HeaderText = "Level";
            this.NLevel.Name = "NLevel";
            this.NLevel.ReadOnly = true;
            // 
            // NIssued
            // 
            this.NIssued.HeaderText = "Issued";
            this.NIssued.Name = "NIssued";
            this.NIssued.ReadOnly = true;
            // 
            // NNote
            // 
            this.NNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Courier New", 11F);
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NNote.DefaultCellStyle = dataGridViewCellStyle4;
            this.NNote.HeaderText = "Note";
            this.NNote.Name = "NNote";
            this.NNote.ReadOnly = true;
            // 
            // NClear
            // 
            this.NClear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.NClear.HeaderText = "Clear Note";
            this.NClear.Name = "NClear";
            this.NClear.ReadOnly = true;
            this.NClear.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NClear.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.NClear.Width = 109;
            // 
            // CmdRNewAlert
            // 
            this.CmdRNewAlert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdRNewAlert.Location = new System.Drawing.Point(3, 641);
            this.CmdRNewAlert.Name = "CmdRNewAlert";
            this.CmdRNewAlert.Size = new System.Drawing.Size(104, 32);
            this.CmdRNewAlert.TabIndex = 22;
            this.CmdRNewAlert.Text = "New";
            this.CmdRNewAlert.UseVisualStyleBackColor = true;
            // 
            // dgvProjects
            // 
            this.dgvProjects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjects.Location = new System.Drawing.Point(3, 28);
            this.dgvProjects.Name = "dgvProjects";
            this.dgvProjects.Size = new System.Drawing.Size(594, 150);
            this.dgvProjects.TabIndex = 15;
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Location = new System.Drawing.Point(3, 203);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.Size = new System.Drawing.Size(594, 150);
            this.dgvInvoices.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(3, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "RELATED INVOICES";
            // 
            // dgvQuotes
            // 
            this.dgvQuotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuotes.Location = new System.Drawing.Point(3, 378);
            this.dgvQuotes.Name = "dgvQuotes";
            this.dgvQuotes.Size = new System.Drawing.Size(594, 150);
            this.dgvQuotes.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(3, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "RELATED QUOTES";
            // 
            // LblIncomeTotal
            // 
            this.LblIncomeTotal.AutoSize = true;
            this.LblIncomeTotal.Location = new System.Drawing.Point(3, 531);
            this.LblIncomeTotal.Name = "LblIncomeTotal";
            this.LblIncomeTotal.Size = new System.Drawing.Size(117, 21);
            this.LblIncomeTotal.TabIndex = 20;
            this.LblIncomeTotal.Text = "Invoiced Funds:";
            // 
            // LblReceivedFunds
            // 
            this.LblReceivedFunds.AutoSize = true;
            this.LblReceivedFunds.Location = new System.Drawing.Point(3, 552);
            this.LblReceivedFunds.Name = "LblReceivedFunds";
            this.LblReceivedFunds.Size = new System.Drawing.Size(121, 21);
            this.LblReceivedFunds.TabIndex = 21;
            this.LblReceivedFunds.Text = "Received Funds:";
            // 
            // LblOutstandingFunds
            // 
            this.LblOutstandingFunds.AutoSize = true;
            this.LblOutstandingFunds.Location = new System.Drawing.Point(3, 573);
            this.LblOutstandingFunds.Name = "LblOutstandingFunds";
            this.LblOutstandingFunds.Size = new System.Drawing.Size(145, 21);
            this.LblOutstandingFunds.TabIndex = 22;
            this.LblOutstandingFunds.Text = "Outstanding Funds:";
            // 
            // CustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1171, 689);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1100, 500);
            this.Name = "CustomerDetails";
            this.Text = "Customer Information";
            this.Resize += new System.EventHandler(this.ResizeForm);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlerts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtAddress2;
        private System.Windows.Forms.TextBox TxtAddress1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtZip;
        private System.Windows.Forms.TextBox TxtState;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox TxtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Button CmdGenerateFullReport;
        private System.Windows.Forms.Button CmdGenerateReport;
        private System.Windows.Forms.Button CmdClosewithoutSave;
        private System.Windows.Forms.Button CmdSaveandClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvReps;
        private System.Windows.Forms.DataGridViewTextBoxColumn RName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn REmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn RPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn RNotes;
        private System.Windows.Forms.DataGridView dgvAlerts;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblAcntFrozen;
        private System.Windows.Forms.Button CmdRAdd;
        private System.Windows.Forms.Button CmdREdit;
        private System.Windows.Forms.Button CmdRDelete;
        private System.Windows.Forms.Label LblAcntAlert;
        private System.Windows.Forms.DataGridViewTextBoxColumn NLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIssued;
        private System.Windows.Forms.DataGridViewTextBoxColumn NNote;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NClear;
        private System.Windows.Forms.Button CmdRNewAlert;
        private System.Windows.Forms.DataGridView dgvQuotes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvProjects;
        private System.Windows.Forms.Label LblOutstandingFunds;
        private System.Windows.Forms.Label LblReceivedFunds;
        private System.Windows.Forms.Label LblIncomeTotal;
    }
}