using System;
using System.Windows.Forms;
using Autodesk.AutoCAD.Runtime;
using AcApp = Autodesk.AutoCAD.ApplicationServices.Application;
using System.IO;

namespace AcC3D_Plug
{
    public partial class ProjectInformation : UserControl
    {
        public ProjectInformation()
        {
            InitializeComponent();

            UpdateProjectInfo();
        }

        [CommandMethod("UPDATEPALETTE")]
        private void UpdateProjectInfo()
        {
            var doc = AcApp.DocumentManager.MdiActiveDocument;
            var jobNumber = Path.GetFileNameWithoutExtension(doc.Name);
            if (jobNumber.Length > 9) jobNumber = jobNumber.Remove(9);
            lblJobNumber.Text = jobNumber;
        }
    }
}
