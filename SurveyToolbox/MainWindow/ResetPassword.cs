using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SurveyToolbox
{
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void OnPasswordLeave(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;
            if (box.Name == txtPassword1.Name)
            {
                if (txtPassword1.Text.Length < 8) { lblError2.Visible = true; } else { lblError2.Visible = false; }
            }
            if (string.IsNullOrEmpty(txtPassword1.Text) || string.IsNullOrEmpty(txtPassword2.Text)) return;
            if (txtPassword1.Text != txtPassword2.Text) { lblError.Visible = true; } else { lblError.Visible = false; }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private string getHashCode(string value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));

                return (Convert.ToBase64String(data));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword1.Text) || string.IsNullOrEmpty(txtPassword2.Text)) return;
            if (txtPassword1.Text != txtPassword2.Text) return;

            XDocument doc = XDocument.Load(Variables.CompanyFile);
            var Users = doc.Root.Element("Users").Descendants();
            XElement loginInfo = Users.Where(un => un.Attribute("Username").Value == Variables.CurrentUser.Username).First();
            if (loginInfo == null)
            {
                lblError.Visible = true;
                return;
            }
            loginInfo.Value = getHashCode(txtPassword1.Text);
            loginInfo.Attribute("RequireUpdate").Value = "false";
            doc.Save(Variables.CompanyFile);
            MessageBox.Show("Your password has been successfully reset!", "Success");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
