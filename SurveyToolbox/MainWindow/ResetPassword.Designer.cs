namespace SurveyToolbox
{
    partial class ResetPassword
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblError2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your password has been marked to be reset. Please enter a new password below. The" +
    "re is a minimum of eight (8) characters required.\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password:";
            // 
            // txtPassword1
            // 
            this.txtPassword1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword1.Location = new System.Drawing.Point(12, 106);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.PasswordChar = '*';
            this.txtPassword1.Size = new System.Drawing.Size(395, 29);
            this.txtPassword1.TabIndex = 2;
            this.txtPassword1.Leave += new System.EventHandler(this.OnPasswordLeave);
            // 
            // txtPassword2
            // 
            this.txtPassword2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword2.Location = new System.Drawing.Point(12, 162);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.PasswordChar = '*';
            this.txtPassword2.Size = new System.Drawing.Size(395, 29);
            this.txtPassword2.TabIndex = 4;
            this.txtPassword2.Leave += new System.EventHandler(this.OnPasswordLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Confirm Password:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(307, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "CONFIRM";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.SystemColors.Window;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Location = new System.Drawing.Point(12, 219);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(100, 33);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "CANCEL";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(12, 195);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(179, 21);
            this.lblError.TabIndex = 7;
            this.lblError.Text = "Passwords do not match";
            this.lblError.Visible = false;
            // 
            // lblError2
            // 
            this.lblError2.AutoSize = true;
            this.lblError2.ForeColor = System.Drawing.Color.Red;
            this.lblError2.Location = new System.Drawing.Point(133, 82);
            this.lblError2.Name = "lblError2";
            this.lblError2.Size = new System.Drawing.Size(210, 21);
            this.lblError2.TabIndex = 8;
            this.lblError2.Text = "Password is not long enough";
            this.lblError2.Visible = false;
            // 
            // ResetPassword
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 264);
            this.Controls.Add(this.lblError2);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPassword";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblError2;
    }
}