using MDG.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SurveyToolbox
{
    public partial class ProjectViewer : Form
    {
        internal string ProjectNumber { get; set; }
        internal string ProjectFile { get; set; }

        public ProjectViewer(string jobNumber)
        {
            InitializeComponent();
            string path = JobNumber.GetPath(jobNumber);
            ProjectFile = path + @"\Information.job";
            if (!File.Exists(ProjectFile))
            {
                //TODO: Add option to create a project file
                MessageBox.Show("No job file was found. Cannot open project.");
                this.Close();
                return;
            }
            lblJobNumber.Text = $"Project: {jobNumber}";
            ProjectNumber = jobNumber;
            this.Text = jobNumber;
            UpdateNotes();
        }

        private void OpenFolder(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string path = JobNumber.GetPath(ProjectNumber);
            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("The folder could not be located.", "Error");
                return;
            }
            Process.Start(path);
        }

        private void UpdateNotes()
        {
            XDocument document = XDocument.Load(ProjectFile);
            foreach (var element in document.Root.Element("Log").Descendants())
            {
                switch(element.Attribute("Type").Value)
                {
                    case "Note":
                        {
                            if (!cbNotes.Checked) break;
                            if (element.Attribute("Redacted").Value == "true")
                            {
                                RTxtLog.SelectionColor = Color.Red;
                                RTxtLog.SelectedText = $"[{element.Attribute("Date").Value} {element.Attribute("User").Value}]: [REDACTED]{Environment.NewLine}";
                            }
                            else
                            {
                                RTxtLog.SelectionColor = Color.Red;
                                RTxtLog.SelectedText = $"[{element.Attribute("Date").Value} {element.Attribute("User").Value}]: {element.Value}{Environment.NewLine}";
                            }
                            
                            break;
                        }
                }
            }
        }
    }
}
