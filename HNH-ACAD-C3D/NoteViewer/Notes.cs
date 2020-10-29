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
using System.Xml.Linq;

namespace AcC3D_Plug
{
    public partial class Notes : Form
    {
        string file;
        private void EstablishFile(string path)
        {
            XElement baseXml = new XElement("Information",
                new XElement("Notes"),
                new XElement("Events"));
            baseXml.Save(path);
            File.SetAttributes(path, File.GetAttributes(path) | FileAttributes.Hidden);
        }

        private void UpdateNoteView()
        {
            if (dataGridView1.Rows.Count != 0)
            {
                dataGridView1.Rows.Clear();
            }

            XDocument doc = XDocument.Load(file);
            XElement NoteElement = doc.Root.Element("Notes");
            foreach (var node in NoteElement.Descendants())
            {
                List<string> parts = new List<string> { };
                parts.Add(node.Attribute("Date").Value);
                parts.Add(node.Attribute("User").Value);
                parts.Add(node.Attribute("Redacted").Value);
                parts.Add(node.Value);
                bool.TryParse(parts[2], out bool redacted);
                if (redacted)
                {
                    string newPart = $"[REDACTED]{parts[3]}[REDACTED]";
                    parts[3] = newPart;
                }
                dataGridView1.Rows.Add(parts[0], parts[1], parts[3]);
            }
        }

        public Notes(string jobPath)
        {
            InitializeComponent();
            TxtJob.Text = "AutoCAD Project";
            TxtJob.Enabled = false;
            CmdChangeJob.Enabled = false;
            CmdExport.Visible = true;
            CmdExport.Enabled = true;
            string JobFile = jobPath + "\\Information.job";
            if (!File.Exists(JobFile))
            {
                EstablishFile(JobFile);
            }
            file = JobFile;
            UpdateNoteView();
        }

        public Notes()
        {
            InitializeComponent();
        }

        private void AddNoteToFile(object sender, EventArgs e)
        {
            XElement note = new XElement("Note",
                new XAttribute("Date", DateTime.Now.ToString()),
                new XAttribute("User", System.Security.Principal.WindowsIdentity.GetCurrent().Name),
                new XAttribute("Redacted", false),
                TxtEntry.Text
                );

            XDocument doc = XDocument.Load(file);
            XElement NoteElement = doc.Root.Element("Notes");
            NoteElement.Add(note);
            FileInfo fileInfo = new FileInfo(file);
            fileInfo.Attributes &= ~FileAttributes.Hidden;
            doc.Save(file);
            fileInfo.Attributes |= FileAttributes.Hidden;
            TxtEntry.Text = "";
            UpdateNoteView();
        }

        private void ExportNotes(object sender, EventArgs e)
        {
            NoteExporter note = new NoteExporter(file);
            note.ShowDialog();
        }

        private void OnCellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rows = dataGridView1.SelectedRows;
            if (rows.Count != 1)
            {
                CmdRedact.Visible = false;
                return;
            }
            var row = rows[0];
            if (row.Cells[2].Value.ToString().Contains("REDACTED"))
            {
                CmdRedact.Text = "UNREDACT";
            }
            else
            {
                CmdRedact.Text = "REDACT";
            }
            CmdRedact.Visible = true;
        }
    }
}
