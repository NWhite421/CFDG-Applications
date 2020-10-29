using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using AcC3D_Plug.Extensions;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Runtime;
using Autodesk.Civil.ApplicationServices;
using Autodesk.Civil.DatabaseServices;
using MDG.Core;
using AcApp = Autodesk.AutoCAD.ApplicationServices.Application;

namespace AcC3D_Plug
{
    public class HelpTab
    {

        /// <summary>
        /// Creates a point group with the proper name that 
        /// </summary>
        [CommandMethod("OpenHNHTabHelp")]
        public static void GroupCalcPoints()
        {
            var acEd = AcApp.DocumentManager.MdiActiveDocument.Editor;
            acEd.WriteMessage("\nStill trying to impliment, which is bad if you're seeing this.");
        }
    }
}
