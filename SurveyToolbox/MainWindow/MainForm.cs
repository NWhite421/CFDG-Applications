using MDG.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SurveyToolbox
{
    public partial class MainForm : Form
    {
        bool WatcherEnabled;
        bool TableRequiresUpdate;

        /// <summary>
        /// Establishes basic required variables that other methods rely on.
        /// </summary>
        private void FirstRun()
        {
            string configFile = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Melbourne Design Group\Survey Toolbox\appconfig.config";
            if (File.Exists(configFile))
            {
                foreach (string line in File.ReadAllLines(configFile))
                {
                    string[] parts = line.Split('=');
                    switch (parts[0])
                    {
                        case "MasterJobTracker": { Variables.MasterJobFile = parts[1]; break; }
                        case "DefaultDirectory": { Variables.DefaultDirectory = parts[1]; break; }
                        case "CompanyDatabase": { Variables.CompanyFile = parts[1]; break; }
                    }
                }
            }
        }

        /// <summary>
        /// The entry method. Calls login window and (if needed password reset) then opens if successful.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            FirstRun();
#if !DEBUG
            this.Hide();
            LoginForm form = new LoginForm();
            var ret = form.ShowDialog();
            if (ret == DialogResult.Cancel)
            {
                form.Dispose();
                MessageBox.Show("Login cancelled, application exiting.");
                CloseForm(this, new EventArgs());
                return;
            }
            else
            {
                Variables.CurrentUser = form.UserInformation;
                if (Variables.CurrentUser.RequireUpdate)
                {
                    ResetPassword form2 = new ResetPassword();
                    ret = form2.ShowDialog();
                    if (ret == DialogResult.Cancel)
                    {
                        form2.Dispose();
                        MessageBox.Show("Login cancelled, application exiting.");
                        CloseForm(this, new EventArgs());
                        return;
                    }
                    Variables.CurrentUser.RequireUpdate = false;
                    form2.Dispose();
                }
                form.Dispose();
                this.Show();
#else
            Variables.CurrentUser = new UserInformation
            {
                DisplayName = "Debug User",
                Username = "debug",
                AdminLevel = AdminLevel.Admin,
                RequireUpdate = false
            };
#endif

                WatcherEnabled = true;
                TableRequiresUpdate = true;
                Task.Run(() => WatchFile());
                UpdateProjectList();
                SetMenuOptions();
                var hour = int.Parse(DateTime.Now.ToString("HH"));
                if (hour >= 0 && hour < 12) { lblGreeting.Text = "Good Morning, " + Variables.CurrentUser.DisplayName + 
                    "\nAccess Level: " + Variables.CurrentUser.AdminLevel.ToString().Replace("_"," "); }
                else if (hour >= 12 && hour < 18) { lblGreeting.Text = "Good Afternoon, " + Variables.CurrentUser.DisplayName + 
                    "\nAccess Level: " + Variables.CurrentUser.AdminLevel.ToString().Replace("_", " "); }
                else { lblGreeting.Text = "Good Evening, " + Variables.CurrentUser.DisplayName + 
                    "\nAccess Level: " + Variables.CurrentUser.AdminLevel.ToString().Replace("_", " "); }
                this.Text = "Project Management Suite V" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
#if DEBUG
                this.Text += " [DEBUG]";
#endif
#if !DEBUG
            }
#endif
        }


        private void SetMenuOptions()
        {
            foreach (var item in MSMain.Items)
            {
                MenuInteration((ToolStripMenuItem)item);
            }
        }

        private void MenuInteration(ToolStripMenuItem item)
        {
            int userlevel = (int)Variables.CurrentUser.AdminLevel;
            if (string.IsNullOrEmpty((string)item.Tag)) return;
            var level = int.Parse((string)item.Tag);

            if (userlevel < level) { item.Visible = false; return; }
            if (userlevel >= level)
            {
                if (item.HasDropDownItems)
                {
                    foreach (var subItem in item.DropDownItems)
                    {
                        MenuInteration((ToolStripMenuItem)subItem);
                    }
                }
            }
        }

        /// <summary>
        /// Stops the watcher before closing.
        /// </summary>
        private void CloseForm(object s, EventArgs e)
        {
            WatcherEnabled = false;
            this.Close();
        }

        /// <summary>
        /// Updates the project list with revised information.
        /// </summary>
        public void UpdateProjectList()
        {
            if (InvokeRequired)
            {
                // Dispatch to correct thread, use BeginInvoke if you don't need
                // caller thread until operation completes
                Invoke(new MethodInvoker(UpdateProjectList));
            }
            else
            {
                if (!TableRequiresUpdate) return;
                if (dgvProjects.Rows.Count > 0)
                {
                    dgvProjects.Rows.Clear();
                }
                try
                {
                    XDocument doc = XDocument.Load(Variables.MasterJobFile);
                    foreach (XElement job in doc.Root.Element("Projects").Descendants())
                    {
                        string[] info = new string[]
                        {
                    job.Attribute("Number").Value,
                    job.Attribute("Name").Value,
                    job.Attribute("Address").Value,
                    job.Attribute("City").Value,
                    job.Attribute("Due").Value,
                    job.Attribute("Status").Value,
                    job.Attribute("Tasks").Value,
                        };
                        dgvProjects.Rows.Add(info);
                    }
                    TableRequiresUpdate = false;
                    return;
                }
                catch
                {

                }
            }
        }

        /// <summary>
        /// Envokes the UpdateProjectList on the correct thread.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="e"></param>
        private void UpdateProjectList(object s, FileSystemEventArgs e)
        {
            TableRequiresUpdate = true;
            this.BeginInvoke(new MethodInvoker(UpdateProjectList));
            return;
        }

        /// <summary>
        /// Watch the masterfile
        /// </summary>
        /// <returns></returns>
        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        public async Task WatchFile()
        {
            string path = Path.GetDirectoryName(Variables.MasterJobFile);
            string file = Path.GetFileName(Variables.MasterJobFile);
            using (FileSystemWatcher watcher = new FileSystemWatcher())
            {
                watcher.Path = path;
                watcher.Filter = file;
                watcher.NotifyFilter = NotifyFilters.LastWrite;
                watcher.Changed += UpdateProjectList;
                watcher.EnableRaisingEvents = true;
                while (WatcherEnabled) ;
            }
        }

        private void OpenAdminConsole(object sender, EventArgs e)
        {
            AdminWindow wind = new AdminWindow();
            wind.ShowDialog();
            wind.Dispose();
        }

        private void OpenManagementOptions(object sender, EventArgs e)
        {
            AdminWindow window = new AdminWindow("projects");
            window.ShowDialog();
            window.Close();
        }

        private void OnCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var rows = dgvProjects.SelectedRows;
            if (rows.Count == 0) return;

            var row = rows[0];
            string jobNumber = row.Cells[0].Value.ToString();
            if (JobNumber.TryParse(jobNumber))
            {
                ProjectViewer viewer = new ProjectViewer(jobNumber);
                viewer.Show();
            }
        }

        private void OpenCustomerInfo(object sender, EventArgs e)
        {
            var btn = (ToolStripMenuItem)sender;
            var name = btn.Text;
            CustomerDetails details;
            if (name.ToLower()== "individual")
            {
                details = new CustomerDetails("201002123601");
            }
            else
            {
                details = new CustomerDetails("201002123632");
            }
            details.Show();
        }
    }
}
