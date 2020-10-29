using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.PlottingServices;
using Application = Autodesk.AutoCAD.ApplicationServices.Application;
using System.Windows.Controls;

namespace AcC3D_Plug
{
    public partial class ExportForm : Form
    {
        internal List<Layout> AllLayouts;

        public List<Layout> SelectedLayouts { get; set; }

        public bool PlotInSeperateFiles { get; set; }
        public ExportForm()
        {
            InitializeComponent();
            var doc = Application.DocumentManager.MdiActiveDocument;
            var db = doc.Database;

            if (lbLayouts.Items.Count > 0)
            {
                lbLayouts.Items.Clear();
            }

            AllLayouts = new List<Layout> { };

            using (Transaction tr = db.TransactionManager.StartTransaction())
            {
                DBDictionary layoutDic = tr.GetObject(db.LayoutDictionaryId, OpenMode.ForRead, false) as DBDictionary;
                foreach (DBDictionaryEntry entry in layoutDic)
                {
                    ObjectId layoutID = entry.Value;
                    Layout layout = tr.GetObject(layoutID, OpenMode.ForRead) as Layout;
                    if (layout.LayoutName.ToLower() != "model")
                    {
                        lbLayouts.Items.Add(layout.LayoutName.ToUpper());
                        AllLayouts.Add(layout);
                    }
                }
            }
        }

        private void OnAccept(object sender, EventArgs e)
        {
            if (lbLayouts.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one layout to plot.", "No selection");
                return;
            }
            List<Layout> layouts = new List<Layout> { };
            foreach (string selected in lbLayouts.SelectedItems)
            {
                var layoutObj = AllLayouts.First(name => name.LayoutName.ToUpper() == selected);
                layouts.Add(layoutObj);
            }
            SelectedLayouts = layouts;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void OnCancel(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
