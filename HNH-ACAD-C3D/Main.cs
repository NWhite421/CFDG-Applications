﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

    public class Commands : IExtensionApplication
    {
        #region INIT AND DEINIT
        /// <summary>
        /// Runs when the plugin is loaded by Autocad. Ran only once.
        /// </summary>
        void IExtensionApplication.Initialize()
        {
            //Add event handler for every drawing opened.
            AcApp.DocumentManager.DocumentCreated += new DocumentCollectionEventHandler(LoadDWG);

            //Add event handler for every drawing closed.
            AcApp.DocumentManager.DocumentDestroyed += new DocumentDestroyedEventHandler(UnLoadDWG);

            //Add event handler when AutoCAD goes idle (removes itself after first run to bypass bullshit).
            Autodesk.AutoCAD.ApplicationServices.Application.Idle += new EventHandler(OnAppLoad);

        }

        /// <summary>
        /// Runs when the Autocad Application executes Idle event handler. Removes itself after first run.
        /// Litterally a copy paste of LoadDWG() with the added benefit of custom tab addition.
        /// </summary>
        public void OnAppLoad(object s, EventArgs e)
        {
            //Add custom ribbon to RibbonControl
            RibbonControl ribbon = ComponentManager.Ribbon;
            if (ribbon != null)
            {
                EstablishTab();
                //Remove this event handler as to not fire again.
                Autodesk.AutoCAD.ApplicationServices.Application.Idle -= OnAppLoad;
            }

            //Log job opening.
            //LogJobOpen();
        }

        /// <summary>
        /// Runs when a new drawing is opened.
        /// </summary>
        public void LoadDWG(object s, DocumentCollectionEventArgs e)
        {
            //Log job opening.
            //LogJobOpen();
            /*if(AcApp.DocumentManager.MdiActiveDocument.IsNamedDrawing)
            {
                AcApp.DocumentManager.MdiActiveDocument.SendStringToExecute("UPDATEPALETTE ", false, false, true);
            }*/
        }

        /// <summary>
        /// Logs to the ActiveDocuments job log that the drawing was opened.
        /// </summary>
        private void LogJobOpen()
        {
            var doc = AcApp.DocumentManager.MdiActiveDocument;
            Editor ed = doc.Editor;
            var jobNumber = Path.GetFileNameWithoutExtension(doc.Name);
            if (jobNumber.Length > 9) jobNumber = jobNumber.Remove(9);
            if (!JobNumber.TryParse(jobNumber))
            {
                ed.WriteMessage("Job number could not be determined." + Environment.NewLine);
                return;
            }

            string name = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            ed.WriteMessage($"Entry added to log for enter: {Environment.NewLine}" +
                $"Name: {name}{Environment.NewLine}" +
                $"Date: {DateTime.Now:MM-dd-yy hh-mm-ss tt}{Environment.NewLine}");
            Logging.LogFileOpen(jobNumber);

        }

        /// <summary>
        /// Runs when a drawing is closed.
        /// </summary>
        public static void UnLoadDWG(object s, DocumentDestroyedEventArgs e)
        {
            var doc = e.FileName;
            var jobNumber = Functions.GetJobNumber(doc);
            if (string.IsNullOrEmpty(jobNumber)) return;
            //Logging.LogFileClose(jobNumber);
        }

        /// <summary>
        /// Fires once when the plugin is unloaded(?)
        /// </summary>
        void IExtensionApplication.Terminate()
        {

        }

        #endregion

        #region RIBBON HANDLING

        /// <summary>
        /// Large placeholder button (vertical)
        /// </summary>
        private readonly RibbonButton ButtonLarge = new RibbonButton
        {
            Text = "PLACEHOLDER",
            ShowImage = true,
            ShowText = true,
            Image = IntFunctions.BitmapToImageSource(Properties.Resources.placeholder_small),
            LargeImage = IntFunctions.BitmapToImageSource(Properties.Resources.placeholder_large),
            Orientation = System.Windows.Controls.Orientation.Vertical,
            Size = RibbonItemSize.Large,
            CommandHandler = new RibbonButtonHandler(),
            CommandParameter = "._PLACEHOLDER ",
        };

        /// <summary>
        /// Small placeholder button (horizontal)
        /// </summary>
        private readonly RibbonButton ButtonSmall = new RibbonButton
        {
            Text = "PLACEHOLDER",
            ShowImage = true,
            ShowText = true,
            Image = IntFunctions.BitmapToImageSource(Properties.Resources.placeholder_small),
            LargeImage = IntFunctions.BitmapToImageSource(Properties.Resources.placeholder_large),
            Orientation = System.Windows.Controls.Orientation.Horizontal,
            Size = RibbonItemSize.Standard,
            CommandHandler = new RibbonButtonHandler(),
            CommandParameter = "._PLACEHOLDER "
        };

        /// <summary>
        /// A command to fill space until an actual command is made.
        /// </summary>
        [CommandMethod("PLACEHOLDER", CommandFlags.Transparent)]
        public void PlaceholderCommand()
        {
            var doc = AcApp.DocumentManager.MdiActiveDocument;
            Editor ed = doc.Editor;
            ed.WriteMessage("Command not implimented yet..." + Environment.NewLine);
        }

        /// <summary>
        /// Create tab and add panels to tab.
        /// </summary>
        [CommandMethod("EstablishTabs")]
        public void EstablishTab()
        {
            //Add Ribbon
            RibbonControl ribbon = ComponentManager.Ribbon;
            if (ribbon != null)
            {
                RibbonTab rtab = ribbon.FindTab("HNHSurvey");
                if (rtab != null)
                {
                    ribbon.Tabs.Remove(rtab);
                }
                rtab = new RibbonTab
                {
                    Title = "H&H Survey",
                    Id = "HNHSurvey"
                };
                ribbon.Tabs.Add(rtab);
                //rtab.Panels.Add(AddImportPanel());
                rtab.Panels.Add(AddProMgmtPanel());
                rtab.Panels.Add(AddCompPanel());
                rtab.Panels.Add(HelpPanel());
                //rtab.Panels.Add(AddExportPanel());
                var doc = AcApp.DocumentManager.MdiActiveDocument;
                Editor ed = doc.Editor;
                ed.WriteMessage("Panel loaded successfully..." + Environment.NewLine);
            }

            //ShowProjectPallete();
        }

        static CustomPaletteSet palette;

        [CommandMethod("ProjectManagementPallete")]
        public void ShowProjectPallete()
        {
            //Add palleteSet
            if (palette == null) palette = new CustomPaletteSet();
            palette.Visible = true;

        }

        public void UpdatePalette(string path)
        {
            
        }

        /// <summary>
        /// Project Management panel creation
        /// </summary>
        /// <returns>Project Management Panel</returns>
        // TODO: Refactor first buttons to copy / clean up.
        public RibbonPanel AddProMgmtPanel()
        {
            RibbonPanelSource rps = new RibbonPanelSource
            {
                Title = "Project Management",
                Name = "Project Management"
            };
            RibbonPanel rp = new RibbonPanel
            {
                Source = rps
            };

            var OpenProjectSplit = new RibbonSplitButton
            {
                Text = "SplitButton",
                CommandHandler = new RibbonButtonHandler(),
                ShowImage = true,
                ShowText = true,
                Image = IntFunctions.BitmapToImageSource(Properties.Resources.placeholder_large),
                LargeImage = IntFunctions.BitmapToImageSource(Properties.Resources.placeholder_large),
                IsSplit = true,
                Size = RibbonItemSize.Large,
                Orientation = System.Windows.Controls.Orientation.Vertical
            };

            RibbonButton OpenProjectFolder = ButtonLarge.Clone() as RibbonButton;
            OpenProjectFolder.Text = $"Open{Environment.NewLine}Project";
            OpenProjectFolder.CommandParameter = "._OpenProjectFolder ";
            OpenProjectFolder.LargeImage = IntFunctions.BitmapToImageSource(Properties.Resources.Goto_Folder);

            RibbonButton OpenCompFolder = ButtonLarge.Clone() as RibbonButton;
            OpenCompFolder.Text = $"Open Comp{Environment.NewLine}Folder";
            OpenCompFolder.CommandParameter = "._OpenCompFolder ";
            OpenCompFolder.LargeImage = IntFunctions.BitmapToImageSource(Properties.Resources.Goto_Folder);

            /*var OpenProFolderBtn = new RibbonButton
            {
                Text = "Open Project Folder",
                ShowImage = true,
                ShowText = true,
                Image = IntFunctions.BitmapToImageSource(Properties.Resources.placeholder_small),
                LargeImage = IntFunctions.BitmapToImageSource(Properties.Resources.Goto_Folder),
                Orientation = System.Windows.Controls.Orientation.Horizontal,
                Size = RibbonItemSize.Standard,
                CommandHandler = new RibbonButtonHandler(),
                CommandParameter = "._OPENPROJECTFOLDER "
            };

            var AddAdtlDocBtn = ButtonLarge.Clone() as RibbonButton;
            AddAdtlDocBtn.Text = $"Add Additional{Environment.NewLine}Info";

            var XrefProjectSplitBtn = new RibbonSplitButton
            {
                Text = "SplitButton",
                CommandHandler = new RibbonButtonHandler(),
                ShowImage = true,
                ShowText = true,
                Image = IntFunctions.BitmapToImageSource(Properties.Resources.placeholder_large),
                LargeImage = IntFunctions.BitmapToImageSource(Properties.Resources.placeholder_large),
                IsSplit = true,
                Size = RibbonItemSize.Large,
                Orientation = System.Windows.Controls.Orientation.Vertical
            };
            var XRefBtn1 = new RibbonButton
            {
                Text = "X-Ref Drawing",
                ShowImage = true,
                ShowText = true,
                Image = IntFunctions.BitmapToImageSource(Properties.Resources.xref_attach),
                LargeImage = IntFunctions.BitmapToImageSource(Properties.Resources.xref_attach),
                Orientation = System.Windows.Controls.Orientation.Horizontal,
                Size = RibbonItemSize.Standard,
                CommandHandler = new RibbonButtonHandler(),
                CommandParameter = "._XREFFROMPROJECT "
            };
            var XRefBtn2 = new RibbonButton
            {
                Text = "From another project",
                ShowImage = true,
                ShowText = true,
                Image = IntFunctions.BitmapToImageSource(Properties.Resources.placeholder_large),
                LargeImage = IntFunctions.BitmapToImageSource(Properties.Resources.xref_find),
                Orientation = System.Windows.Controls.Orientation.Horizontal,
                Size = RibbonItemSize.Standard,
                CommandHandler = new RibbonButtonHandler(),
                CommandParameter = "._XREFFROMANOTHERPROJECT "
            };*/


            //rps.Items.Add(XrefProjectSplitBtn);
            OpenProjectSplit.Items.Add(OpenProjectFolder);
            OpenProjectSplit.Items.Add(OpenCompFolder);
            rps.Items.Add(OpenProjectSplit);

            return rp;
        }

        /// <summary>
        /// Import panel creation
        /// </summary>
        /// <returns>Import panel</returns>
        public RibbonPanel AddImportPanel()
        {
            RibbonPanelSource rps = new RibbonPanelSource
            {
                Title = "Import",
                Name = "Import",
                
            };
            RibbonPanel rp = new RibbonPanel
            {
                Source = rps
            };

            var ImpFieldDataBtn = ButtonLarge.Clone() as RibbonButton;
            ImpFieldDataBtn.Text = $"Import Field{Environment.NewLine}Data";
            ImpFieldDataBtn.Name = "ImportFieldData";
            ImpFieldDataBtn.LargeImage = IntFunctions.BitmapToImageSource(Properties.Resources.Field_Import);
            ImpFieldDataBtn.CommandParameter = "\x03\x03IMPORTJOBDATA ";

            var ImpGeoDataBtn = ButtonLarge.Clone() as RibbonButton;
            ImpGeoDataBtn.Text = $"Import{Environment.NewLine}Geo Data";
            ImpGeoDataBtn.Name = "ImportGeoData";
            ImpGeoDataBtn.CommandParameter = "._mapimport ";

            rps.Items.Add(ImpFieldDataBtn);
            rps.Items.Add(ImpGeoDataBtn);

            return rp;
        }

        public RibbonPanel HelpPanel()
        {
            RibbonPanelSource rps = new RibbonPanelSource
            {
                Title = "Support",
                Name = "Support",

            };
            RibbonPanel rp = new RibbonPanel
            {
                Source = rps
            };

            RibbonButton ReportIssue = ButtonLarge.Clone() as RibbonButton;
            ReportIssue.Text = $"Report{Environment.NewLine}Issue";
            ReportIssue.ShowImage = true;
            ReportIssue.ShowText = true;
            ReportIssue.CommandParameter = "_.OpenHNHTabHelp ";
            ReportIssue.LargeImage = IntFunctions.BitmapToImageSource(Properties.Resources.Help);

            rps.Items.Add(ReportIssue);
            return rp;
        }

        /// <summary>
        /// Computation panel creation
        /// </summary>
        /// <returns>Computations panel</returns>
        public RibbonPanel AddCompPanel()
        {
            RibbonPanelSource rps = new RibbonPanelSource
            {
                Title = "Computations",
                Name = "Computations",

            };
            RibbonPanel rp = new RibbonPanel
            {
                Source = rps
            };

            RibbonButton GroupPoints = ButtonLarge.Clone() as RibbonButton;
            GroupPoints.Text = $"Group Comp{Environment.NewLine}Points";
            GroupPoints.ShowImage = true;
            GroupPoints.ShowText = true;
            GroupPoints.Orientation = System.Windows.Controls.Orientation.Vertical;
            GroupPoints.CommandParameter = "_.CreateGroupOfCalcs ";
            GroupPoints.LargeImage = IntFunctions.BitmapToImageSource(Properties.Resources.Create_PG);

            RibbonButton ExportGroup = ButtonLarge.Clone() as RibbonButton;
            ExportGroup.Text = $"Export Point{Environment.NewLine}Groups";
            ExportGroup.ShowImage = true;
            ExportGroup.ShowText = true;
            ExportGroup.Orientation = System.Windows.Controls.Orientation.Vertical;
            ExportGroup.CommandParameter = "_.ExportPointGroups ";
            ExportGroup.LargeImage = IntFunctions.BitmapToImageSource(Properties.Resources.Export_PG);

            rps.Items.Add(GroupPoints);
            rps.Items.Add(ExportGroup);

            return rp;
        }

        /// <summary>
        /// Export panel creation
        /// </summary>
        /// <returns>Export panel</returns>
        public RibbonPanel AddExportPanel()
        {
            RibbonPanelSource rps = new RibbonPanelSource
            {
                Title = "Export",
                Name = "Export",

            };
            RibbonPanel rp = new RibbonPanel
            {
                Source = rps
            };

            /*var PdfCreationCombo = new RibbonSplitButton
            {
                Text = "SplitButton",
                CommandHandler = new RibbonButtonHandler(),
                ShowImage = true,
                ShowText = true,
                Image = IntFunctions.BitmapToImageSource(Properties.Resources.placeholder_large),
                LargeImage = IntFunctions.BitmapToImageSource(Properties.Resources.placeholder_large),
                IsSplit = true,
                Size = RibbonItemSize.Large,
                Orientation = System.Windows.Controls.Orientation.Vertical
            };*/

            var previewPDFBtn = ButtonLarge.Clone() as RibbonButton;
            previewPDFBtn.Text = "Plot to PDF";
            previewPDFBtn.Name = "Plot to PDF";
            previewPDFBtn.CommandParameter = "._ExportJobAsPDF ";

            /*var plotPDFBtn = ButtonLarge.Clone() as RibbonButton;
            plotPDFBtn.Text = "Plot PDF";
            plotPDFBtn.Name = "Plot PDF";
            plotPDFBtn.CommandParameter = "._PrintPageAsPDF ";*/

            rps.Items.Add(previewPDFBtn);

            return rp;
        }

        #endregion

        #region COMMANDS

        public void AssetTable()
        {
            AssetTableManager dialog = new AssetTableManager();
            dialog.Show();
        }

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

        [CommandMethod("ViewFullAttributes")]
        public static void ViewFullObjectProperties()
        {
            var doc = AcApp.DocumentManager.MdiActiveDocument;
            var ed = doc.Editor;
            var obj = ed.GetEntity("Please select an object");

            ObjectId ent = obj.ObjectId;

            using (Transaction tr = doc.Database.TransactionManager.StartTransaction())
            {
                CogoPoint thing = tr.GetObject(ent, OpenMode.ForRead) as CogoPoint;
            }

        }

        public static List<string> GetPointObjectData()
        {
            var doc = AcApp.DocumentManager.MdiActiveDocument;
            var ed = doc.Editor;
            var peo = new PromptEntityOptions("\nSelect a point: ");
            peo.SetRejectMessage("\nPlease select only a Cogo Point.");
            peo.AddAllowedClass(typeof(CogoPoint), true);
            var obj = ed.GetEntity(peo);

            if (obj.Status == PromptStatus.OK)
            {
                List<string> outp;
                // at this point we know an entity have been selected and it is a Polyline
                using (var tr = doc.Database.TransactionManager.StartTransaction())
                {
                    var cogoP = (CogoPoint)tr.GetObject(obj.ObjectId, OpenMode.ForRead);
                    outp = new List<string> { cogoP.PointNumber.ToString(), cogoP.Northing.ToString(), cogoP.Easting.ToString(), cogoP.Elevation.ToString(), cogoP.RawDescription };
                    tr.Commit();
                }
                return outp;
            }
            return null;
        }

        [CommandMethod("OpenNotesForProject")]
        public static void OpenProjectNotes()
        {
            var doc = AcApp.DocumentManager.MdiActiveDocument;
            Editor ed = doc.Editor;
            var jobNumber = Path.GetFileNameWithoutExtension(doc.Name);
            if (jobNumber.Length > 9) jobNumber = jobNumber.Remove(9);
            if (!JobNumber.TryParse(jobNumber))
            {
                ed.WriteMessage("Job number could not be determined." + Environment.NewLine);
                return;
            }
            string path = JobNumber.GetPath(jobNumber);
            if (Directory.Exists(path))
            {
                Notes noteDiag = new Notes(path);
                AcApp.ShowModelessDialog(noteDiag);
                ed.WriteMessage("Project notes opened." + Environment.NewLine);
            }
            else
            {
                ed.WriteMessage("Project folder could not be determined." + Environment.NewLine);
            }
        }

        [CommandMethod("OpenNotes")]
        public static void OpenNotes()
        {
            Notes noteDiag = new Notes();
            AcApp.ShowModelessDialog(noteDiag);
        }

        [CommandMethod("OpenProjectFolder")]
        public static void OpenProjectFolder()
        {
            var doc = AcApp.DocumentManager.MdiActiveDocument;
            Editor ed = doc.Editor;
            var jobNumber = Path.GetFileNameWithoutExtension(doc.Name);
            if (jobNumber.Length > 9) jobNumber = jobNumber.Remove(9);
            if (!JobNumber.TryParse(jobNumber))
            {
                ed.WriteMessage("Job number could not be determined." + Environment.NewLine);
                return;
            }
            string path = JobNumber.GetPath(jobNumber);
            if (Directory.Exists(path))
            {
                Process.Start(path);
                ed.WriteMessage("Project folder opened." + Environment.NewLine);
            } else
            {
                ed.WriteMessage("Project folder could not be determined." + Environment.NewLine);
            }
        }

        [CommandMethod("OpenCompFolder")]
        public static void OpenCompFolder()
        {
            var doc = AcApp.DocumentManager.MdiActiveDocument;
            Editor ed = doc.Editor;
            var jobNumber = Path.GetFileNameWithoutExtension(doc.Name);
            if (jobNumber.Length > 9) jobNumber = jobNumber.Remove(9);
            if (!JobNumber.TryParse(jobNumber))
            {
                ed.WriteMessage("Job number could not be determined." + Environment.NewLine);
                return;
            }
            string path = JobNumber.GetPath(jobNumber) + "\\Comp";
            if (Directory.Exists(path))
            {
                Process.Start(path);
                ed.WriteMessage("Comp folder opened." + Environment.NewLine);
            }
            else
            {
                ed.WriteMessage("Comp folder could not be determined." + Environment.NewLine);
            }
        }

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

    /// <summary>
    /// RibbonButton click handler.
    /// </summary>
    public class RibbonButtonHandler : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }
#pragma warning disable CS0067 //command is never used
        public event EventHandler CanExecuteChanged;
#pragma warning restore CS0067

        public void Execute(object parameter)

        {
            RibbonButton cmd = parameter as RibbonButton;

            Document dwg = AcApp.DocumentManager.MdiActiveDocument;

            dwg.SendStringToExecute(cmd.CommandParameter as string, true, false, true);

        }
    }

    public class Functions
    {
        public static string GetJobNumber(Document document)
        {
            var jobNumber = Path.GetFileNameWithoutExtension(document.Name);
            if (jobNumber.Length > 9) jobNumber = jobNumber.Remove(9);
            if (!JobNumber.TryParse(jobNumber))
            {
                return "";
            }
            return jobNumber;
        }

        public static string GetJobNumber(string document)
        {
            var jobNumber = Path.GetFileNameWithoutExtension(document);
            if (jobNumber.Length > 9) jobNumber = jobNumber.Remove(9);
            if (!JobNumber.TryParse(jobNumber))
            {
                return "";
            }
            return jobNumber;
        }
    }

    /// <summary>
    /// A point object because I want to
    /// </summary>
    class C3DPoint : IDisposable
    {
        private bool _disposed = false;

#pragma warning disable IDE0044 // Add readonly modifier
        private SafeHandle _safeHandle = new SafeFileHandle(IntPtr.Zero, true);
#pragma warning restore IDE0044 // Add readonly modifier

        public void Dispose() => Dispose(true);

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                // Dispose managed state (managed objects).
                _safeHandle?.Dispose();
            }

            _disposed = true;
        }

        public uint PointNumber { get; set; }
        public double Northing { get; set; }
        public double Easting { get; set; }
        public double Elevation { get; set; }

        public Point3d Coordinate { get {
                return new Point3d(Easting, Northing, Elevation);
            }
        }

        public string Decsription { get; set; }
    }

    //For sidebar implimentation (at some point)
    public class CustomPaletteSet : PaletteSet
    {
        public CustomPaletteSet()
            : base("Project Information", "ProjectManagementPallete", new Guid("9CF9996E-7D0E-4886-8FFA-16604ED9D419"))
        {
            Style = PaletteSetStyles.ShowAutoHideButton |
                    PaletteSetStyles.ShowCloseButton |
                    PaletteSetStyles.ShowPropertiesMenu;

            MinimumSize = new System.Drawing.Size(300,300);

            Add("Tab", new ProjectInformation());
        }
    }
}