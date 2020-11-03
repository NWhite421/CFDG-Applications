using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;
using Autodesk.Civil.ApplicationServices;
using Autodesk.Civil.DatabaseServices;
using MDG.Core;
using System.Reflection;
using System.Diagnostics;
using Autodesk.AutoCAD.Colors;
using AcApp = Autodesk.AutoCAD.ApplicationServices.Application;

namespace AcC3D_Plug
{
    public class ProjectManagement
    {
        #region IMPORT JOB DATA
        // TODO: Adjust
        [CommandMethod("ImportJobData")]
        public static void ImportJobPoints()
        {
            var doc = AcApp.DocumentManager.MdiActiveDocument;
            Editor ed = doc.Editor;
            Database db = doc.Database;

            var jobNumber = Functions.GetJobNumber(doc);
            SelectionForm form = new SelectionForm(jobNumber);
            var ret = AcApp.ShowModalDialog(form);
            if (ret == DialogResult.Cancel)
            {
                ed.WriteMessage("Job import canceled by user.");
                return;
            }
            else
            {

                ed.WriteMessage($"Import Job list: Count - {form.SelectedFiles.Count} | Filtered - {form.FilterPoints} | X-ref attach - {form.AttachXref}" + Environment.NewLine);
                List<List<C3DPoint>> pointList = IntFunctions.ProcessFiles(form.SelectedFiles);

                //Actually do the things
                using (Transaction trans = ed.Document.Database.TransactionManager.StartTransaction())
                {

                    List<CogoPoint> existingPoints = new List<CogoPoint> { };
                    CogoPointCollection cogoPoints = CivilApplication.ActiveDocument.CogoPoints;
                    foreach (var cogoPointObj in cogoPoints)
                    {
                        CogoPoint cogoPointItem = cogoPointObj.GetObject(OpenMode.ForWrite) as CogoPoint;
                        existingPoints.Add(cogoPointItem);
                    }

                    string confirmed = "";

                    for (int i = 0; i < pointList.Count; i++)
                    {
                        var points = pointList[i];
                        int pointcount = 0;
                        foreach (var newPoint in points)
                        {
                            if (existingPoints.Where(pn => pn.PointNumber == newPoint.PointNumber).Count() == 0)
                            {
                                Point3d point = newPoint.Coordinate;
                                ObjectId pointId = cogoPoints.Add(point, false);
                                CogoPoint cogop = pointId.GetObject(OpenMode.ForWrite) as CogoPoint;
                                cogop.PointNumber = newPoint.PointNumber;
                                cogop.RawDescription = newPoint.Decsription;
                                cogop.StyleId = ObjectId.Null;
                                cogop.LabelStyleId = ObjectId.Null;
                                existingPoints.Add(cogop);
                                confirmed += $"{newPoint.PointNumber}, ";
                                pointcount++;
                            }
                            else
                            {
                                /*if (points.Where(pn => pn.RawDescription == (string)newPoint[4]).Count() == 0)
                                {
                                    MessageBox.Show("A point with a conflicting point number was detected. You can renumber this.");
                                }
                                else
                                {
                                    MessageBox.Show("A point with a conflicting point number and description was detected. Ingoring a duplicate point");
                                }*/
                            }
                        }
                        //TODO: Add more fuctionality to point group.

                        string filename = Path.GetFileNameWithoutExtension(form.SelectedFiles[i]);
                        ed.WriteMessage($"Successfully imported {pointcount} points." + Environment.NewLine);
                        if (form.AttachXref)
                        {
                            string folder = Path.GetDirectoryName(form.SelectedFiles[i]);
                            string CADFile = Path.Combine(folder, filename + ".dwg");
                            if (File.Exists(Path.Combine(folder, filename + ".dwg")))
                            {
                                //Getting the layer object
                                LayerTable lt = (LayerTable)trans.GetObject(db.LayerTableId, OpenMode.ForWrite);
                                if (!lt.Has("G-HH-XREF"))
                                {
                                    LayerTableRecord ltr = new LayerTableRecord
                                    {
                                        Name = "G-HH-XREF",
                                        Color = Autodesk.AutoCAD.Colors.Color.FromColorIndex(ColorMethod.ByAci, 7),
                                        IsFrozen = false,
                                        ViewportVisibilityDefault = true
                                    };

                                    ObjectId ltId = lt.Add(ltr);
                                    trans.AddNewlyCreatedDBObject(ltr, true);
                                }

                                var xId = db.AttachXref(CADFile, filename);
                                if (xId.IsValid)
                                {
                                    var btr = (BlockTableRecord)trans.GetObject(db.CurrentSpaceId, OpenMode.ForWrite);
                                    var br = new BlockReference(Point3d.Origin, xId)
                                    {
                                        Layer = "G-HH-XREF"
                                    };
                                    btr.AppendEntity(br);
                                    trans.AddNewlyCreatedDBObject(br, true);
                                }
                            }
                            ed.WriteMessage($"Successfully attached {filename} CAD file." + Environment.NewLine);
                        }
                    }

                    PointGroupCollection pointGroups = CivilApplication.ActiveDocument.PointGroups;
                    string groupName = "Group Import " + DateTime.Now.ToString("MM-dd-yy");
                    if (!pointGroups.Contains(groupName))
                    {
                        ObjectId pointGroup = pointGroups.Add(groupName);
                        StandardPointGroupQuery query = new StandardPointGroupQuery
                        {
                            IncludeNumbers = confirmed
                        };
                        PointGroup group = (PointGroup)pointGroup.GetObject(OpenMode.ForWrite);
                        group.SetQuery(query);
                    }
                    /*foreach (var newPoint in newPoints)
                    {
                        if (points.Where(pn => pn.PointNumber == (uint)newPoint[0]).Count() == 0)
                        {
                            Point3d point = new Point3d((double)newPoint[2], (double)newPoint[1], (double)newPoint[3]);
                            ObjectId pointId = cogoPoints.Add(point, false);
                            CogoPoint cogop = pointId.GetObject(OpenMode.ForWrite) as CogoPoint;
                            cogop.PointNumber = (uint)newPoint[0];
                            cogop.RawDescription = (string)newPoint[4];
                            points.Add(cogop);
                        }
                        else
                        {
                            if (points.Where(pn => pn.RawDescription == (string)newPoint[4]).Count() == 0)
                            {
                                MessageBox.Show("A point with a conflicting point number was detected. You can renumber this.");
                            }
                            else
                            {
                                MessageBox.Show("A point with a conflicting point number and description was detected. Ingoring a duplicate point");
                            }
                        }
                    }*/
                    object acad = AcApp.AcadApplication;
                    acad.GetType().InvokeMember("ZoomExtents", BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, acad, null);
                    trans.Commit();
                }
            }

            Logging.LogEntry(jobNumber, "POINT IMPORT", "Points were added to drawing.");

            form.Dispose();
            ed.Regen();
        }

        #endregion

        #region OPEN SERVER FOLDERS

        /// <summary>
        /// Opens the specified folder of the active drawing's project.
        /// </summary>
        /// <param name="option">The sub-folder to open.</param>
        private static void OpenFolder(string option)
        {
            var doc = AcApp.DocumentManager.MdiActiveDocument;
            Editor ed = doc.Editor;
            
            // determines the job number of the active drawing.
            var jobNumber = Functions.GetJobNumber(doc);
            if (string.IsNullOrEmpty(jobNumber))
                return;

            // Gets the base path of the project and exits if it doesn't exist.
            string jobPath = JobNumber.GetPath(jobNumber);

            // determine the path
            switch (option.ToLower())
            {
                case "comp":
                    {
                        jobPath += @"\Comp";
                        break;
                    }
                case "submittal":
                    {
                        jobPath += @"\Submittal";
                        break;
                    }
                case "fielddata": 
                    {
                        jobPath += @"\Field Data";
                        break;
                    }
                default:
                    break;
            }

            if (!Directory.Exists(jobPath))
            {
                ed.WriteMessage("\nProject folder was not found." + Environment.NewLine);
                return;
            }

            Process.Start(jobPath);
        }

        /// <summary>
        /// Open the active drawing's project folder.
        /// </summary>
        [CommandMethod("OpenProjectFolder")]
        public static void OpenProjectFolder()
        {
            OpenFolder("");
        }

        /// <summary>
        /// Open the active drawing's project computations folder.
        /// </summary>
        [CommandMethod("OpenCompFolder")]
        public static void OpenCompFolder()
        {
            OpenFolder("comp");
        }

        /// <summary>
        /// Open the active drawing's project submittals folder.
        /// </summary>
        [CommandMethod("OpenSubmittalFolder")]
        public static void OpenSubmittalFolder()
        {
            OpenFolder("submittal");
        }

        /// <summary>
        /// Open the active drawing's project submittals folder.
        /// </summary>
        [CommandMethod("OpenFieldDataFolder")]
        public static void OpenFieldDataFolder()
        {
            OpenFolder("fielddata");
        }

        #endregion

        #region XREF HELPERS

        // FIX: Refactor
        public static void AttachXRef(string Filename)
        {
            var doc = AcApp.DocumentManager.MdiActiveDocument;

            if (doc == null) return;

            var db = doc.Database;
            var ed = doc.Editor;
            try
            {
                using (Transaction tr = db.TransactionManager.StartTransaction())
                {
                    //Establish layer if it doesn't exist
                    LayerTable lt = (LayerTable)tr.GetObject(db.LayerTableId, OpenMode.ForWrite);
                    if (!lt.Has("G-HH-XREF"))
                    {
                        LayerTableRecord ltr = new LayerTableRecord
                        {
                            Name = "G-HH-XREF",
                            Color = Autodesk.AutoCAD.Colors.Color.FromColorIndex(ColorMethod.ByAci, 7),
                            IsFrozen = false,
                            ViewportVisibilityDefault = true
                        };
                        lt.Add(ltr);
                        tr.AddNewlyCreatedDBObject(ltr, true);
                        ed.WriteMessage($"{Environment.NewLine}XREF Layer created.");
                    }

                    var xId = db.AttachXref(Filename, Path.GetFileNameWithoutExtension(Filename));
                    if (xId.IsValid)
                    {
                        var btr = (BlockTableRecord)tr.GetObject(db.CurrentSpaceId, OpenMode.ForWrite);
                        var br = new BlockReference(Point3d.Origin, xId)
                        {
                            Layer = "G-HH-XREF"
                        };
                        tr.AddNewlyCreatedDBObject(br, true);
                        btr.AppendEntity(br);
                    }


                    ed.WriteMessage(

                      "External reference {0}attached at origin.",

                      xId.IsValid ? "" : "not "

                    );


                    tr.Commit();
                    ed.Regen();
                }
            }
            catch
            {

            }

            // Logging.LogEntry(jobNumber, "XREF ATTACH", "Attached X-Ref to drawing.");
        }

        // FIX: Refactor and unify with similar functions.
        [CommandMethod("XREFFROMPROJECT")]
        public static void XrefDwg()
        {
            var doc = AcApp.DocumentManager.MdiActiveDocument;

            if (doc == null) return;

            var ed = doc.Editor;

            var jobNumber = Path.GetFileNameWithoutExtension(doc.Name);
            if (jobNumber.Length > 9) jobNumber = jobNumber.Remove(9);
            if (!JobNumber.TryParse(jobNumber))
            {
                ed.WriteMessage("Job number could not be determined. Use the regular X-Ref command instead." + Environment.NewLine);
                return;
            }
            string path = JobNumber.GetPath(jobNumber);
            if (!Directory.Exists(path))
            {
                ed.WriteMessage("The job folder could not be located, please verify that the job number is correct." + Environment.NewLine);
                return;
            }

            Autodesk.AutoCAD.Windows.OpenFileDialog ofd = new Autodesk.AutoCAD.Windows.OpenFileDialog(
                "Please select a file to x-ref",
                path,
                "dwg",
                "DwgFileToLink",
                Autodesk.AutoCAD.Windows.OpenFileDialog.OpenFileDialogFlags.DefaultIsFolder
                );
            DialogResult pr = ofd.ShowDialog();

            if (pr == DialogResult.OK && !string.IsNullOrEmpty(ofd.Filename))
            {
                AttachXRef(ofd.Filename);
            }


            doc.Dispose();
        }

        // FIX: Refactor and unify with similar functions.
        [CommandMethod("XREFFROMANOTHERPROJECT")]
        public static void XrefDwgFromAnother()
        {
            var doc = AcApp.DocumentManager.MdiActiveDocument;

            if (doc == null) return;

            var ed = doc.Editor;

            GetJobNumber form1 = new GetJobNumber();
            var f1r = AcApp.ShowModalDialog(form1);

            if (f1r == DialogResult.Cancel)
            {
                ed.WriteMessage("No job number could be determined. Exiting." + Environment.NewLine);
                return;
            }

            ed.WriteMessage($"Going to job number {form1.Value}." + Environment.NewLine);

            Autodesk.AutoCAD.Windows.OpenFileDialog ofd = new Autodesk.AutoCAD.Windows.OpenFileDialog(
                "Please select a file to x-ref",
                JobNumber.GetPath(form1.Value),
                "dwg",
                "DwgFileToLink",
                Autodesk.AutoCAD.Windows.OpenFileDialog.OpenFileDialogFlags.DefaultIsFolder
                );

            var pr = ofd.ShowDialog();

            if (pr == DialogResult.OK && !string.IsNullOrEmpty(ofd.Filename))
            {
                AttachXRef(ofd.Filename);
            }

            form1.Dispose();
            doc.Dispose();
        }

        #endregion
    }
}
