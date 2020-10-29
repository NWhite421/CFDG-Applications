using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDG.Core;
using System.IO;
using Autodesk.AutoCAD;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.Windows;
using Autodesk.Civil.ApplicationServices;
using Autodesk.Civil.DatabaseServices;
using Autodesk.Civil.Settings;
using Autodesk.Civil.Runtime;
using MDG.Core;
using Microsoft.Win32.SafeHandles;
using Autodesk.Windows;
using System.ComponentModel;
using System.Windows.Input;
using AcApp = Autodesk.AutoCAD.ApplicationServices.Application;
using System.Reflection;
using System.Diagnostics;
using Autodesk.AutoCAD.Colors;
using System.Windows.Media;
using System.Drawing;
using System.Windows.Media.Imaging;
using Autodesk.AutoCAD.Ribbon;
using System.Windows;
using Autodesk.AutoCAD.GraphicsInterface;

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
            var edi = doc.Editor;
            var jobNumber = Path.GetFileNameWithoutExtension(doc.Name);
            if (jobNumber.Length > 9) jobNumber = jobNumber.Remove(9);
            lblJobNumber.Text = jobNumber;
        }
    }
}
