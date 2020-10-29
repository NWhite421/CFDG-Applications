using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurveyToolbox
{
    public partial class NewUser : Form
    {
        public UserInformation UserInformation { get; internal set; }

        public NewUser()
        {
            InitializeComponent();
            cbUserRole.SelectedIndex = 0;
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtFullName_Leave(object sender, EventArgs e)
        {
            var name = txtFullName.Text.Split(' ');
            if (name.Length == 1) return;
            for (int i = 0; i < name.Length - 1; i++)
            {
                txtUsername.Text += char.ToLower(name[i][0]);
            }
            txtUsername.Text += name[name.Length-1].ToLower();
        }

        private void CmdCreate_Click(object sender, EventArgs e)
        {
            UserInformation = new UserInformation
            {
                DisplayName = txtFullName.Text,
                Username = txtUsername.Text,
                AdminLevel = (AdminLevel)cbUserRole.SelectedIndex,
                RequireUpdate = true
            };
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
