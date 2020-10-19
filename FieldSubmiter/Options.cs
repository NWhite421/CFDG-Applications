using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            LoadSettings();
        }

        void LoadSettings()
        {
            TxtFullName.Text = Properties.Settings.Default.Name;
            TxtDefaultSearch.Text = string.IsNullOrEmpty(Properties.Settings.Default.DefaultSearch) ? "" : Properties.Settings.Default.DefaultSearch;


            CbHosts.SelectedIndex = Properties.Settings.Default.EMailServerMethod;
            UpdateEMailSettings(this, new EventArgs());
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
                        TxtEmailSSL.Checked = EMailServerInfo.GMail.EnableSSL;
                        break;
                    }
                case 1:
                    {
                        TxtEmailDomain.Text = EMailServerInfo.GoDaddy.Host;
                        TxtEmailPort.Text = EMailServerInfo.GoDaddy.Port.ToString();
                        TxtEmailSSL.Checked = EMailServerInfo.GoDaddy.EnableSSL;
                        break;
                    }
                case 2:
                    {
                        TxtEmailDomain.Text = EMailServerInfo.Office365.Host;
                        TxtEmailPort.Text = EMailServerInfo.Office365.Port.ToString();
                        TxtEmailSSL.Checked = EMailServerInfo.Office365.EnableSSL;
                        break;
                    }
                default:
                    {
                        TxtEmailDomain.Text = Properties.Settings.Default.EMailDomain;
                        TxtEmailPort.Text = Properties.Settings.Default.EMailPort.ToString();
                        TxtEmailSSL.Checked = Properties.Settings.Default.EMailSSL;
                        TxtEmailDomain.Enabled = true;
                        TxtEmailPort.Enabled = true;
                        TxtEmailSSL.Enabled = true;
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
                TxtEmailDomain, TxtEmailPort, TxtEmailSSL, TxtTCPIP, TxtTCPPort, RbTCPConnection
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
    }
}
