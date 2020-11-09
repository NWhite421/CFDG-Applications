using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AcC3D_Plug.Extensions;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;
using Autodesk.Civil.ApplicationServices;
using Autodesk.Civil.DatabaseServices;
using MDG.Core;
using AcApp = Autodesk.AutoCAD.ApplicationServices.Application;

namespace AcC3D_Plug
{
    public partial class CogoPointEditor : Form
    {
        enum ElevationStatus
        {
            Automatic,
            Manual,
            Surface
        }

        enum DescriptionStatus
        {
            Automatic,
            Manual
        }
        
        

        public double Elevation
        {
            get
            {
                return Decimal.ToDouble(NVElevation.Value);
            }
        }

        public string RawDescription
        {
            get
            {
                return TxtDescription.Text;
            }
        }

        public void Incriment()
        {
            NVPointNumber.Value += 1;
        }

        public CogoPointEditor()
        {
            InitializeComponent();
        }
    }
}
