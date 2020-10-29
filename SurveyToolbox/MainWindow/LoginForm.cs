using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SurveyToolbox
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public UserInformation UserInformation { get; set; }

        private void button2_Click(object sender, EventArgs e)
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

        private void Login(object sender, EventArgs e)
        {
            /*if (txtUsername.Text == "")
            {
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    UTF8Encoding utf8 = new UTF8Encoding();
                    byte[] data = md5.ComputeHash(utf8.GetBytes(txtPassword.Text));
                    Debug.WriteLine(Convert.ToBase64String(data));
                    return;
                }
            }*/

            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                lblError.Visible = true;
                return;
            }
            XDocument doc = XDocument.Load(Variables.CompanyFile);
            var Users = doc.Root.Element("Users").Descendants();
            XElement loginInfo = Users.Where(un => un.Attribute("Username").Value.ToLower() == txtUsername.Text.ToLower()).FirstOrDefault();
            if (loginInfo == null)
            {
                lblError.Visible = true;
                return;
            }
            string pwH = getHashCode(txtPassword.Text);
            if (pwH == loginInfo.Value)
            {
                if (loginInfo.Attribute("Active").Value.ToLower() == "false")
                {
                    MessageBox.Show("Your account has been deactived. Please contact an administrator for assistance.", "Account not active.");
                    return;
                }
                UserInformation = new UserInformation
                {
                    DisplayName = loginInfo.Attribute("Name").Value,
                    Username = loginInfo.Attribute("Username").Value,
                    AdminLevel = (AdminLevel)int.Parse(loginInfo.Attribute("Admin").Value),
                    RequireUpdate = bool.Parse(loginInfo.Attribute("RequireUpdate").Value)
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                lblError.Visible = true;
                return;
            }
        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }
    }
}
