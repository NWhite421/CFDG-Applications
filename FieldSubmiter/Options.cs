using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FieldSubmiter
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
            LoadSettings(true);
        }

        public Options(bool AutoAllowChange)
        {
            InitializeComponent();
            if (!AutoAllowChange)
            {
                LoadSettings(AutoAllowChange);
            }
        }

        void LoadSettings(bool InitialLock)
        {
            TxtFullName.Text = Properties.Settings.Default.Name;
            TxtDefaultSearch.Text = string.IsNullOrEmpty(Properties.Settings.Default.DefaultSearch) ? "" : Properties.Settings.Default.DefaultSearch;

            RbTCPConnection.Checked = Properties.Settings.Default.SendMethod; //Property false: EMail ; Proeprty true: TCP

            TxtEmail.Text = Properties.Settings.Default.EMail;
            TxtEMailPassword.Text = Properties.Settings.Default.Password;
            TxtReceivers.Text = Properties.Settings.Default.DestEmail;

            CbHosts.SelectedIndex = Properties.Settings.Default.EMailServerMethod;
            UpdateEMailSettings(this, new EventArgs());

            //TODO: Impliment TCP Options when I can.
            if (!InitialLock)
            {
                AllowEdit(this, new EventArgs());
            }
        }

        void UpdateEMailSettings(object s, EventArgs e)
        {
            var selection = CbHosts.SelectedIndex;
            switch (selection)
            {
                case 0:
                    {
                        TxtEmailDomain.Text = EMailServerInfo.GMail.Host;
                        TxtEmailPort.Text = EMailServerInfo.GMail.Port.ToString();
                        CbxEmailSSL.Checked = EMailServerInfo.GMail.EnableSSL;
                        break;
                    }
                case 1:
                    {
                        TxtEmailDomain.Text = EMailServerInfo.GoDaddy.Host;
                        TxtEmailPort.Text = EMailServerInfo.GoDaddy.Port.ToString();
                        CbxEmailSSL.Checked = EMailServerInfo.GoDaddy.EnableSSL;
                        break;
                    }
                case 2:
                    {
                        TxtEmailDomain.Text = EMailServerInfo.Office365.Host;
                        TxtEmailPort.Text = EMailServerInfo.Office365.Port.ToString();
                        CbxEmailSSL.Checked = EMailServerInfo.Office365.EnableSSL;
                        break;
                    }
                default:
                    {
                        TxtEmailDomain.Text = Properties.Settings.Default.EMailDomain;
                        TxtEmailPort.Text = Properties.Settings.Default.EMailPort.ToString();
                        CbxEmailSSL.Checked = Properties.Settings.Default.EMailSSL;
                        TxtEmailDomain.Enabled = true;
                        TxtEmailPort.Enabled = true;
                        CbxEmailSSL.Enabled = true;
                        break;
                    }
            }
        }

        private void AllowEdit(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Editing any of these options will have a high probablity of fucking something up. Unless you know what \"TCP\" and \"Port\" means, don't touch this.",
                "Confirm edit", MessageBoxButtons.OKCancel);
            if (confirm == DialogResult.Cancel) return;
            Control[] blacklist = new Control[]
            {
                TxtEmailDomain, TxtEmailPort, CbxEmailSSL, TxtTCPIP, TxtTCPPort, RbTCPConnection
            };

            foreach (Control ctrl in this.Controls )
            {
                if (!blacklist.Contains(ctrl))
                    ctrl.Enabled = true;
                if (ctrl.GetType() == typeof(GroupBox))
                {
                    var gb = (GroupBox)ctrl;
                    foreach (Control sc in gb.Controls)
                    {
                        if (!blacklist.Contains(sc))
                            sc.Enabled = true;
                    }
                }
            }
        }

        private void CmdDiscardChanges_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmdApplyChanges_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtFullName.Text))
            {
                MessageBox.Show("Put your full name.");
                return;
            }
            if (RbEmail.Checked && (string.IsNullOrEmpty(TxtEmail.Text) 
                || string.IsNullOrEmpty(TxtEMailPassword.Text) 
                || string.IsNullOrEmpty(TxtReceivers.Text)))
            {
                MessageBox.Show("Fill out all the e-mail settings or configure TCP connection.");
                return;
            }
            //TODO: Add TCP Check

            Properties.Settings.Default.EMail = TxtEmail.Text;
            Properties.Settings.Default.Password = TxtEMailPassword.Text;
            Properties.Settings.Default.DestEmail = TxtReceivers.Text;
            Properties.Settings.Default.DefaultSearch = string.IsNullOrEmpty(TxtDefaultSearch.Text) ? "" : TxtDefaultSearch.Text;
            Properties.Settings.Default.Name = TxtFullName.Text;
            Properties.Settings.Default.SendMethod = !RbEmail.Checked; //Property false: EMail ; Proeprty true: TCP
            Properties.Settings.Default.EMailServerMethod = CbHosts.SelectedIndex;
            Properties.Settings.Default.EMailDomain = (CbHosts.SelectedIndex == 3) ? TxtEmailDomain.Text : "";
            Properties.Settings.Default.EMailPort = (CbHosts.SelectedIndex == 3) ? int.Parse(TxtEmailDomain.Text) : 0;
            Properties.Settings.Default.EMailSSL = CbxEmailSSL.Checked;
            /*Properties.Settings.Default.
            Properties.Settings.Default.*/

            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
