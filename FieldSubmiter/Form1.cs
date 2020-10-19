﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wyDay.Controls;
using System.IO;
using System.Text.RegularExpressions;

namespace FieldSubmiter
{
    public partial class MainForm : Form
    { 
        List<string> JobNumbers { get; set; }
        List<string> Files { get; set; }

        public MainForm()
        {
            InitializeComponent();

            AutoUpdater.UpdateAvailable +=
                new EventHandler(UpdateAvailable);
            AutoUpdater.CheckingFailed +=
                new FailHandler(UpdateCheckFailed);

            if (!AutoUpdater.ClosingForInstall)
            {
                LoadSettings();
            }
        }

        void UpdateCheckFailed(object s, FailArgs e)
        {
            LblStatus.Text = "ERROR: Failed to check.";
        }

        void UpdateAvailable(object s, EventArgs e)
        {
            MessageBox.Show("Test Dialog");
        }

        void LoadSettings()
        {
            //Populate the purpose list
            var PurposeList = Properties.Settings.Default.Purposes.Cast<string>().ToList();
            CbPurpose.Items.AddRange(PurposeList.ToArray());

            //Add version to title
            string version = "v" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Major.ToString() + "." +
                System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString();
#if DEBUG
            version += " [debug]";
#endif
            this.Text += " " + version;

            //Enable sorting of the lists
            LbNumbers.Sorted = true;
            LbFiles.Sorted = true;

            //Establish internal lists
            JobNumbers = new List<string> { };
            Files = new List<string> { };
        }

        private void AutoUpdate_ClosingAborted(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void CheckForUpdates(object sender, EventArgs e)
        {
            AutoUpdater.ForceCheckForUpdate();
        }

        private void OnNumberChanged(object sender, EventArgs e)
        {
            CmdAddNumber.Enabled = Regex.IsMatch(TxtNumber.Text, @"\d{2}-\d{2}-\d{3}");
        }

        private void RemoveValue(object sender, EventArgs e)
        {
            var list = (Button)sender;
            switch (list.Name)
            {
                case "CmdRemoveNumber":
                    {
                        ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(LbNumbers);
                        selectedItems = LbNumbers.SelectedItems;


                        if (LbNumbers.SelectedIndex == -1) return;
                        for (int i = selectedItems.Count - 1; i >= 0; i--)
                        {
                            string number = LbNumbers.GetItemText(selectedItems[i]);
                            LbNumbers.Items.Remove(selectedItems[i]);
                            JobNumbers.Remove(number);
                        }


                        CmdRemoveNumber.Enabled = false;

                        return;
                    }
                case "CmdRemoveFiles":
                    {
                        ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(LbFiles);
                        selectedItems = LbFiles.SelectedItems;


                        if (LbFiles.SelectedIndex == -1) return;
                        for (int i = selectedItems.Count - 1; i >= 0; i--)
                        {
                            string number = LbFiles.GetItemText(selectedItems[i]);
                            LbFiles.Items.Remove(selectedItems[i]);
                            Files.Remove(Files.First(f => f.Contains(number)));
                        }

                        CmdRemoveFiles.Enabled = false;

                        return;
                    }
            }
        }

        private void AddValue(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            switch (btn.Name)
            {
                case "CmdAddNumber":
                    {
                        if (!Regex.IsMatch(TxtNumber.Text, @"\d{2}-\d{2}-\d{3}")) return; //When the user hits enter and bypasses the button.
                        LbNumbers.Items.Add(TxtNumber.Text);
                        JobNumbers.Add(TxtNumber.Text);
                        CmdAddNumber.Enabled = false;
                        return;
                    }

                case "CmdAddFiles":
                    {

                        string baseDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                        if (!string.IsNullOrEmpty(Properties.Settings.Default.DefaultSearch))
                            baseDir = Properties.Settings.Default.DefaultSearch;

                        OpenFileDialog dialog = new OpenFileDialog
                        {
                            Title = "Select files",
                            Multiselect = true,
                            InitialDirectory = baseDir
                        };

                        var dr = dialog.ShowDialog();

                        if (dr == DialogResult.Cancel) return;

                        foreach(string file in dialog.FileNames)
                        {
                            LbFiles.Items.Add(Path.GetFileName(file));
                            Files.Add(file);
                        }

                        return;
                    }
            }
        }

        private void OnSelectionChange(object sender, EventArgs e)
        {
            var btn = (ListBox)sender;
            switch (btn.Name)
            {
                case "LbNumbers":
                    {
                        CmdRemoveNumber.Enabled = (LbNumbers.SelectedItems.Count > 0);

                        return;
                    }
                case "LbFiles":
                    {
                        CmdRemoveFiles.Enabled = (LbFiles.SelectedItems.Count > 0);

                        return;
                    }
            }
        }

        private void TxtNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                AddValue(CmdAddNumber, new EventArgs());
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            options.ShowDialog();
            options.Dispose();
        }
    }
}