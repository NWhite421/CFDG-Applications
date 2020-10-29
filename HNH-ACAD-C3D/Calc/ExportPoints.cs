using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.Civil.ApplicationServices;
using Autodesk.Civil.DatabaseServices;

namespace AcC3D_Plug
{
    public partial class ExportPoints : Form
    {
        public string FileName { get; set; }
        public string FolderPath { get; set; }
        public string PointGroup { get; set; }

        public ExportPoints(PointGroupCollection PointGroups, string SourceFile)
        {
            InitializeComponent();
            foreach (ObjectId group in PointGroups)
            {
                PointGroup pointGroup = (PointGroup)group.GetObject(OpenMode.ForRead);
                if (pointGroup.Name.ToLower() != "_all points" && pointGroup.Name.ToLower() != "no display") { lbGroups.Items.Add(pointGroup.Name); }
            }

            FolderPath = SourceFile + "\\Comp";

            this.DialogResult = DialogResult.Cancel;
        }

        private string RemoveBraketInfo(string input)
        {
            string outp = "";

            bool isBraketInfo = false;

            foreach (char ch in input.ToCharArray())
            {
                if (ch == '[')
                {
                    isBraketInfo = true;
                }
                else if (ch == ']')
                {
                    isBraketInfo = false;
                }
                else if (!isBraketInfo && ch != '!')
                {
                    outp += ch;
                }
            }

            return outp;
        }

        private void ExportConfirm(object sender, EventArgs e)
        {
            if (lbGroups.SelectedItems.Count < 1) { MessageBox.Show("Please select a point group to export."); return; }

            //Generates a file name
            #region FileName
            if (rbAutoGenName.Checked)
            {
                string pointGroup = RemoveBraketInfo(lbGroups.GetItemText(lbGroups.SelectedItem));
                string date = DateTime.Now.ToString("MM-dd-yy");
                FileName = pointGroup.ToUpper() + " " + date + ".txt";
            }
            else
            {
                if (string.IsNullOrEmpty(txtCustomName.Text))
                {
                    MessageBox.Show("Please enter a custom name.");
                    return;
                }
                FileName = txtCustomName.Text.ToUpper() + ".txt";
            }
            #endregion

            //Generate folder path
            #region FolderPath
            if (rbSetFolder.Checked)
            {
                if (string.IsNullOrEmpty(txtCustomFolder.Text))
                {
                    MessageBox.Show("Please select an export folder.");
                    return;
                }
                FolderPath = txtCustomFolder.Text;
            }
            #endregion

            #region Points
            PointGroup = lbGroups.GetItemText(lbGroups.SelectedItem);
            #endregion

            //TODO: Impliment options
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CheckCustomInput(object sender, EventArgs e)
        {
            var btn = (RadioButton)sender;
            if (btn.Name == rbCustomName.Name)
            {
                txtCustomName.Enabled = rbCustomName.Checked ? true : false;
            }
            if (btn.Name == rbSetFolder.Name)
            {
                txtCustomFolder.Enabled = rbSetFolder.Checked ? true : false;
                cmdBrowseFolder.Enabled = rbSetFolder.Checked ? true : false;
            }
        }

        private void SelectFolder(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog
            {
                ShowNewFolderButton = true,
                Description = "Select export folder:"
            };
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtCustomFolder.Text = dialog.SelectedPath;
                dialog.Dispose();
            }
        }
    }
}
