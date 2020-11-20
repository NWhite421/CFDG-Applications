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
using Microsoft.WindowsAPICodePack.Dialogs;

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

            var PurposeList = Properties.Settings.Default.Purposes.Cast<string>().ToList();
            lbItems.Items.AddRange(PurposeList.ToArray());
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
                TxtEmailDomain, TxtEmailPort, CbxEmailSSL
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
            /*if (RbEmail.Checked && (string.IsNullOrEmpty(TxtEmail.Text) 
                || string.IsNullOrEmpty(TxtEMailPassword.Text) 
                || string.IsNullOrEmpty(TxtReceivers.Text)))
            {
                MessageBox.Show("Fill out all the e-mail settings or configure the E-Mail connection.");
                return;
            }*/
            //TODO: Add TCP Check

            System.Collections.Specialized.StringCollection collection = new System.Collections.Specialized.StringCollection();
            collection.AddRange(lbItems.Items.OfType<string>().ToArray());

            Properties.Settings.Default.Purposes = collection;
            Properties.Settings.Default.EMail = TxtEmail.Text;
            Properties.Settings.Default.Password = TxtEMailPassword.Text;
            Properties.Settings.Default.DestEmail = TxtReceivers.Text;
            Properties.Settings.Default.DefaultSearch = string.IsNullOrEmpty(TxtDefaultSearch.Text) ? "" : TxtDefaultSearch.Text;
            Properties.Settings.Default.Name = TxtFullName.Text;
            Properties.Settings.Default.EMailServerMethod = CbHosts.SelectedIndex;
            Properties.Settings.Default.EMailDomain = (CbHosts.SelectedIndex == 3) ? TxtEmailDomain.Text : "";
            Properties.Settings.Default.EMailPort = (CbHosts.SelectedIndex == 3) ? int.Parse(TxtEmailDomain.Text) : 0;
            Properties.Settings.Default.EMailSSL = CbxEmailSSL.Checked;
            /*Properties.Settings.Default.
            Properties.Settings.Default.*/

            Properties.Settings.Default.Save();

            this.Close();
        }

        private void BrowseForFolder(object sender, EventArgs e)
        {
            var directoryDialog = new CommonOpenFileDialog
            {
                IsFolderPicker = true,
                Title = "Select Folder",
                Multiselect = false,
                AllowNonFileSystemItems = false,
                DefaultDirectory = string.IsNullOrEmpty(TxtDefaultSearch.Text) ? Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) : TxtDefaultSearch.Text
            };
            var dr = directoryDialog.ShowDialog();
            if (dr == CommonFileDialogResult.Cancel) return;
            TxtDefaultSearch.Text = directoryDialog.FileName;
            directoryDialog.Dispose();
        }

        private void onListSelectionChange(object sender, EventArgs e)
        {
            if (lbItems.SelectedItem == null || lbItems.SelectedIndex > lbItems.Items.Count - 1)
            {
                return;
            }
            else
            {
                cmdRemove.Enabled = true;
                cmdMoveUp.Enabled = (lbItems.SelectedIndex == 0) ? false : true;
                cmdMoveDown.Enabled = (lbItems.SelectedIndex == lbItems.Items.Count - 1) ? false : true;
            }
        }

        private void removeDP(object sender, EventArgs e)
        {
            if (lbItems.SelectedItem == null || lbItems.SelectedIndex > lbItems.Items.Count - 1)
            {
                return;
            }

            lbItems.Items.RemoveAt(lbItems.SelectedIndex);
            cmdRemove.Enabled = false;
        }

        private void addDP(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                return;
            }
            lbItems.Items.Add(textBox1.Text);
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void moveItemUp(object sender, EventArgs e)
        {
            MoveItem(-1);
            cmdMoveUp.Enabled = (lbItems.SelectedIndex == 0) ? false : true;
        }

        private void moveItemDown(object sender, EventArgs e)
        {
            MoveItem(1);
            cmdMoveDown.Enabled = (lbItems.SelectedIndex == lbItems.Items.Count - 1) ? false : true;
        }
        public void MoveItem(int direction)
        {
            // Checking selected item
            if (lbItems.SelectedItem == null || lbItems.SelectedIndex > lbItems.Items.Count - 1)
                return; // No selected item - nothing to do

            // Calculate new index using move direction
            int newIndex = lbItems.SelectedIndex + direction;

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= lbItems.Items.Count)
                return; // Index out of range - nothing to do

            object selected = lbItems.SelectedItem;

            // Removing removable element
            lbItems.Items.Remove(selected);
            // Insert it in new position
            lbItems.Items.Insert(newIndex, selected);
            // Restore selection
            lbItems.SetSelected(newIndex, true);
        }
    }
}
