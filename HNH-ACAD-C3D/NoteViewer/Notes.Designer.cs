namespace AcC3D_Plug
{
    partial class Notes
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
            this.TxtJob = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmdChangeJob = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtEntry = new System.Windows.Forms.TextBox();
            this.CmdRedact = new System.Windows.Forms.Button();
            this.CmdAddNote = new System.Windows.Forms.Button();
            this.CmdExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtJob
            // 
            this.TxtJob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtJob.Location = new System.Drawing.Point(115, 12);
            this.TxtJob.Name = "TxtJob";
            this.TxtJob.Size = new System.Drawing.Size(110, 26);
            this.TxtJob.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Job Number:";
            // 
            // CmdChangeJob
            // 
            this.CmdChangeJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdChangeJob.Location = new System.Drawing.Point(231, 12);
            this.CmdChangeJob.Name = "CmdChangeJob";
            this.CmdChangeJob.Size = new System.Drawing.Size(53, 26);
            this.CmdChangeJob.TabIndex = 2;
            this.CmdChangeJob.Text = "GO";
            this.CmdChangeJob.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Source,
            this.Note});
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(710, 319);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellClick);
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 67;
            // 
            // Source
            // 
            this.Source.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Source.HeaderText = "Writer";
            this.Source.Name = "Source";
            this.Source.ReadOnly = true;
            this.Source.Width = 75;
            // 
            // Note
            // 
            this.Note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // TxtEntry
            // 
            this.TxtEntry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtEntry.BackColor = System.Drawing.Color.LightGray;
            this.TxtEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEntry.Location = new System.Drawing.Point(12, 401);
            this.TxtEntry.Multiline = true;
            this.TxtEntry.Name = "TxtEntry";
            this.TxtEntry.Size = new System.Drawing.Size(591, 48);
            this.TxtEntry.TabIndex = 4;
            // 
            // CmdRedact
            // 
            this.CmdRedact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CmdRedact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdRedact.Location = new System.Drawing.Point(12, 369);
            this.CmdRedact.Name = "CmdRedact";
            this.CmdRedact.Size = new System.Drawing.Size(107, 26);
            this.CmdRedact.TabIndex = 5;
            this.CmdRedact.Text = "UNREDACT";
            this.CmdRedact.UseVisualStyleBackColor = true;
            this.CmdRedact.Visible = false;
            // 
            // CmdAddNote
            // 
            this.CmdAddNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdAddNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdAddNote.Location = new System.Drawing.Point(609, 401);
            this.CmdAddNote.Name = "CmdAddNote";
            this.CmdAddNote.Size = new System.Drawing.Size(113, 48);
            this.CmdAddNote.TabIndex = 6;
            this.CmdAddNote.Text = "ADD NOTE";
            this.CmdAddNote.UseVisualStyleBackColor = true;
            this.CmdAddNote.Click += new System.EventHandler(this.AddNoteToFile);
            // 
            // CmdExport
            // 
            this.CmdExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CmdExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdExport.Location = new System.Drawing.Point(625, 369);
            this.CmdExport.Name = "CmdExport";
            this.CmdExport.Size = new System.Drawing.Size(97, 26);
            this.CmdExport.TabIndex = 7;
            this.CmdExport.Text = "EXPORT";
            this.CmdExport.UseVisualStyleBackColor = true;
            this.CmdExport.Visible = false;
            this.CmdExport.Click += new System.EventHandler(this.ExportNotes);
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.CmdExport);
            this.Controls.Add(this.CmdAddNote);
            this.Controls.Add(this.CmdRedact);
            this.Controls.Add(this.TxtEntry);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CmdChangeJob);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtJob);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "Notes";
            this.Text = "Notes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtJob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CmdChangeJob;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Source;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.TextBox TxtEntry;
        private System.Windows.Forms.Button CmdRedact;
        private System.Windows.Forms.Button CmdAddNote;
        private System.Windows.Forms.Button CmdExport;
    }
}