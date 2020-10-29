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

namespace AcC3D_Plug
{
    public partial class NoteExporter : Form
    {
        internal string basePath;

        public NoteExporter(string path)
        {
            InitializeComponent();
            basePath = path;
            TxtFolderLoc.Enabled = false;
            TxtFileName.Enabled = false;
            button1.Enabled = false;
            LblAutomaticName.Text = $"Note Export {DateTime.Now:MM-dd-yy hh-mm-ss tt}";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                TxtFolderLoc.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                TxtFolderLoc.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                TxtFileName.Enabled = true;
            }
            else
            {
                TxtFileName.Enabled = false;
            }
        }

        private void CloseForm(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BrowseSaveLocation(object sender, EventArgs e)
        {
            FolderBrowserDialog browserDialog = new FolderBrowserDialog
            {
                ShowNewFolderButton = true
            };
            var result = browserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                TxtFolderLoc.Text = browserDialog.SelectedPath;
            }
        }

        private void ExportNotes(object s, EventArgs e)
        {
            List<List<string>> lines = new List<List<string>> { };
            XDocument doc = XDocument.Load(basePath);
            XElement NoteElement = doc.Root.Element("Notes");
            foreach (var node in NoteElement.Descendants())
            {
                List<string> parts = new List<string> { };
                parts.Add(node.Attribute("Date").Value);
                parts.Add(node.Attribute("User").Value);
                parts.Add(node.Attribute("Redacted").Value);
                parts.Add(node.Value);
                lines.Add(parts);
            }

            string folder, file;
            if(rbOutputProjectFolder.Checked)
            {
                folder = Path.GetDirectoryName(basePath);
            }
            else
            {
                if (string.IsNullOrEmpty(TxtFolderLoc.Text))
                {
                    MessageBox.Show("Please select or enter a folder.");
                    return;
                }
                folder = TxtFolderLoc.Text;
            }

            if (radioButton3.Checked)
            {
                file = LblAutomaticName.Text;
            }
            else
            {
                if (string.IsNullOrEmpty(TxtFileName.Text))
                {
                    MessageBox.Show("Please select or enter a file name.");
                    return;
                }
                file = TxtFileName.Text;
            }

            if (radioButton5.Checked) { 
                file += ".txt";

                File.AppendAllText(Path.Combine(folder, file), $"Compiled on {DateTime.Now:MM/dd/yyyy HH:mm:ss}{Environment.NewLine}");
                foreach (var line in lines)
                {
                    if (line[2].ToUpper() == "TRUE")
                    {
                        File.AppendAllText(Path.Combine(folder, file), $"[{line[0]} {line[1]}]--REDACTED--{Environment.NewLine}");
                    }
                    else
                    {
                        File.AppendAllText(Path.Combine(folder, file), $"[{line[0]} {line[1]}]: {line[3]}{Environment.NewLine}");
                    }
                }
            } else { 
                file += ".csv";

                File.AppendAllText(Path.Combine(folder, file), "Date,Computer\\User,Redacted,Comment" + Environment.NewLine);
                foreach (var line in lines)
                {
                    File.AppendAllText(Path.Combine(folder, file), string.Join(",", line) + Environment.NewLine);
                }
            }
            DialogResult result = MessageBox.Show("File created successfully. Open the cotaining folder?", "Task Complete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Process.Start(folder);
            }
        }
    }
}
