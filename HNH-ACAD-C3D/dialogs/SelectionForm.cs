using Autodesk.AutoCAD.Windows.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDG.Core;
using System.Diagnostics;

namespace AcC3D_Plug
{
    public enum PointGroupHandle
    {
        ImportEvent,
        PointGroup,
        Custom,
        None
    }
    public partial class SelectionForm : Form
    {
        public SelectionForm()
        {
            InitializeComponent();
        }

        internal string FolderPath { get; set; }

        internal List<string> Files { get; set; }

        public List<string> SelectedFiles { get; set; }
        public bool FilterPoints { get; set; }
        public bool AttachXref { get; set; }

        public PointGroupHandle PointGroupHandler { get; set; }
        public string CustomPointGroupName { get; set; }



#pragma warning disable IDE1006 // Naming Styles
        private void handleLinkAction(object s, LinkLabelLinkClickedEventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            Process.Start(FolderPath);
        }

        public SelectionForm(string JobNu)
        {
            InitializeComponent();
            string jobPath = JobNumber.GetPath(JobNu);
            if (string.IsNullOrEmpty(jobPath) || !Directory.Exists(jobPath))
            {
                MessageBox.Show("Job folder does not exist, please save the file before trying to import field data.");
                this.DialogResult = DialogResult.Cancel;
                this.Close();
                return;
            }
            if (!Directory.Exists(jobPath + @"\\Field Data"))
            {
                MessageBox.Show("No field data folder was detected, please check to ensure data is present.");
                this.DialogResult = DialogResult.Cancel;
                this.Close();
                return;
            }
            LblJobNumber.Text = JobNumber.Parse(JobNu, JobNumberFormats.ShortHyphan);
            FolderPath = jobPath + @"\\Field Data";
            Files = new List<string> { };
            foreach (string file in Directory.GetFiles(FolderPath))
            {
                if (Path.GetExtension(file).ToLower() == ".txt")
                {
                    string fileName = Path.GetFileNameWithoutExtension(file);
                    string name = fileName.Remove(0, 10);
                    name = name.Remove(name.Length - 12, 12);
                    string date = DateTime.Parse(fileName.Remove(0, fileName.Length - 9)).ToString("MM/dd/yy");
                    int pointCount = File.ReadAllLines(file).Length;
                    DGVFiles.Rows.Add("", name, date, pointCount);
                    Files.Add(file);
                }
            }
        }

        private void AcceptImport(object sender, EventArgs e)
        {
            if (DGVFiles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select at least one row to import.");
                return;
            }
            FilterPoints = CbPerformRepeatFiltering.Checked;
            AttachXref = CbXrefAssociatedCADFile.Checked;
            SelectedFiles = new List<string> { };
            foreach (DataGridViewRow row in DGVFiles.SelectedRows)
            {
                SelectedFiles.Add(Files[DGVFiles.Rows.IndexOf(row)]);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void OnCustomNameCheckChange(object sender, EventArgs e)
        {
            if (rbCustom.Checked)
            {
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
            }
        }
    }
}
