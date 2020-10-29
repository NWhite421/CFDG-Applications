namespace AcC3D_Plug
{
    partial class SendReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendReport));
            this.lblInfo = new System.Windows.Forms.Label();
            this.LblPCInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CmdSend = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(12, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(551, 59);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = resources.GetString("lblInfo.Text");
            // 
            // LblPCInfo
            // 
            this.LblPCInfo.Location = new System.Drawing.Point(12, 68);
            this.LblPCInfo.Name = "LblPCInfo";
            this.LblPCInfo.Size = new System.Drawing.Size(551, 65);
            this.LblPCInfo.TabIndex = 1;
            this.LblPCInfo.Text = "OS: {OS}\r\nACAD VERSION: {ACVERSION}\r\nPLUGIN VERSION: {PVERSION}";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Additional Information:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 153);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(551, 131);
            this.textBox1.TabIndex = 3;
            // 
            // CmdSend
            // 
            this.CmdSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdSend.Location = new System.Drawing.Point(481, 290);
            this.CmdSend.Name = "CmdSend";
            this.CmdSend.Size = new System.Drawing.Size(82, 30);
            this.CmdSend.TabIndex = 4;
            this.CmdSend.Text = "Send";
            this.CmdSend.UseVisualStyleBackColor = true;
            // 
            // CmdCancel
            // 
            this.CmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdCancel.Location = new System.Drawing.Point(12, 290);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(82, 30);
            this.CmdCancel.TabIndex = 5;
            this.CmdCancel.Text = "Cancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            // 
            // SendReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(575, 329);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.CmdSend);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblPCInfo);
            this.Controls.Add(this.lblInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SendReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label LblPCInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button CmdSend;
        private System.Windows.Forms.Button CmdCancel;
    }
}