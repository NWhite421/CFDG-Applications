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
    public class Computations
    {
        internal static List<string> controlCodes = new List<string>
        {
            "IRC=",
            "IR=",
            "NL=",
            "NLD=",
            "CM=",
            "PIP=",
            "OM="
        };

        public static string BeautifyPointList(List<string> points)
        {
            string outp = "";
            int curPoint = 0;
            foreach (string point in points)
            {
                int pNumber = int.Parse(point);
                if (curPoint == 0)
                {
                    outp += pNumber;
                    curPoint = pNumber;
                }
                else if (int.Parse(points.Last()) == pNumber)
                {
                    outp += pNumber == curPoint + 1 && outp.Last() != '-' ? "-" : ", ";

                    outp += pNumber;
                }
                else if (pNumber == curPoint + 1)
                {
                    curPoint = pNumber;
                }
                else
                {
                    outp += "-" + curPoint + ", " + pNumber;
                    curPoint = pNumber;
                }
            }
            return outp;
        }

        /// <summary>
        /// Creates a point file from a selected point group.
        /// </summary>
        [CommandMethod("ExportPointGroups")]
        public static void ExportPointGroups()
        {
            Document acDoc = AcApp.DocumentManager.MdiActiveDocument;
            Database acDb = acDoc.Database;
            Editor acEd = acDoc.Editor;
            CivilDocument cApp = Autodesk.Civil.ApplicationServices.CivilApplication.ActiveDocument;

            PointGroupCollection pointGroups;
            ExportPoints form;

            #region Job Number
            var jobNumber = Path.GetFileNameWithoutExtension(acDoc.Name);
            if (jobNumber.Length > 9) jobNumber = jobNumber.Remove(9);
            if (!JobNumber.TryParse(jobNumber))
            {
                acEd.WriteMessage("Job number could not be determined." + Environment.NewLine);
                return;
            }
            string path = JobNumber.GetPath(jobNumber);
            if (!Directory.Exists(path))
            {
                acEd.WriteMessage("Project folder could not be determined." + Environment.NewLine);
            }
            #endregion

            using (Transaction tr = acDb.TransactionManager.StartTransaction())
            {
                pointGroups = cApp.PointGroups;
                form = new ExportPoints(pointGroups, path);
                var fResult = AcApp.ShowModalDialog(form);

                if (fResult == DialogResult.Cancel) { acEd.WriteMessage("\nExport operation cancelled."); return; }
                acEd.WriteMessage("\nExport operation continued.");

                if (!Directory.Exists(form.FolderPath)) { Directory.CreateDirectory(form.FolderPath); }

                string file = form.FolderPath + "\\" + form.FileName.Trim();
                acEd.WriteMessage($"\nWriting {form.PointGroup} points to {file}");

                switch (form.PointGroup.ToLower())
                {
                    case "!all points":
                        {
                            foreach (ObjectId pointId in cApp.CogoPoints)
                            {
                                CogoPoint point = (CogoPoint)pointId.GetObject(OpenMode.ForRead);
                                string pointTxt = $"{point.PointNumber},{Math.Round(point.Northing, 4)},{Math.Round(point.Easting, 4)},{Math.Round(point.Elevation,4)},{point.RawDescription}{Environment.NewLine}";
                                File.AppendAllText(file, pointTxt);
                            }
                            break;
                        }
                    case "!comp points":
                        {
                            foreach (ObjectId pointId in cApp.CogoPoints)
                            {
                                CogoPoint point = (CogoPoint)pointId.GetObject(OpenMode.ForRead);
                                int pnumber = Convert.ToInt32(point.PointNumber);
                                if (pnumber >= 1000 && pnumber < 10000)
                                {
                                    string pointTxt = $"{point.PointNumber},{Math.Round(point.Northing, 4)},{Math.Round(point.Easting, 4)},{Math.Round(point.Elevation, 4)},{point.RawDescription}{Environment.NewLine}";
                                    File.AppendAllText(file, pointTxt);
                                }
                            }
                            break;
                        }
                    case "!control points":
                        {
                            foreach (ObjectId pointId in cApp.CogoPoints)
                            {
                                CogoPoint point = (CogoPoint)pointId.GetObject(OpenMode.ForRead);
                                string description = point.RawDescription;
                                if (controlCodes.Any(s=>description.Contains(s)))
                                {
                                    string pointTxt = $"{point.PointNumber},{Math.Round(point.Northing, 4)},{Math.Round(point.Easting, 4)},{Math.Round(point.Elevation, 4)},{point.RawDescription}{Environment.NewLine}";
                                    File.AppendAllText(file, pointTxt);
                                }
                            }
                            break;
                        }
                    default:
                        {
                            foreach (ObjectId pgId in pointGroups)
                            {
                                PointGroup group = (PointGroup)pgId.GetObject(OpenMode.ForRead);
                                if (group.Name.ToLower() == form.PointGroup.ToLower())
                                {
                                    var cogoPoints = group.GetCogoPoints();
                                    acEd.WriteMessage($"\nPoint Group {form.PointGroup} contains {cogoPoints.Count} points");
                                    foreach (CogoPoint point in cogoPoints)
                                    {
                                        string pointTxt = $"{point.PointNumber},{Math.Round(point.Northing, 4)},{Math.Round(point.Easting, 4)},{Math.Round(point.Elevation, 4)},{point.RawDescription}{Environment.NewLine}";
                                        File.AppendAllText(file, pointTxt);
                                    }
                                }
                            }

                            break;
                        }
                }
                acEd.WriteMessage($"\nPoints exported successfully.");
                form.Dispose();
                tr.Commit();
            };
        }

        /// <summary>
        /// Creates a point group with the proper name that 
        /// </summary>
        [CommandMethod("CreateGroupOfCalcs")]
        public static void GroupCalcPoints()
        {
            Document acDoc = AcApp.DocumentManager.MdiActiveDocument;
            Database acDb = acDoc.Database;
            Editor adEd = acDoc.Editor;
            CivilDocument cApp = Autodesk.Civil.ApplicationServices.CivilApplication.ActiveDocument;

            List<string> points = new List<string> { };
            string pointStr = "";
            string descriptionStr = "";

            //Get the purpose of the points
            PromptStringOptions pStrOpts = new PromptStringOptions("\nEnter the purpose: ")
            {
                AllowSpaces = true
            };
            PromptResult pRlt = adEd.GetString(pStrOpts);

            //If the string was empty (or null somehow)
            if (string.IsNullOrEmpty(pRlt.StringResult)) { adEd.WriteMessage("\nThe string entered was empty, please try again."); return; }
            string purpose = pRlt.StringResult;

            //Selection method
            PromptKeywordOptions pKeyOpts = new PromptKeywordOptions("\nPlease select a method of point selection: ");
            pKeyOpts.Keywords.Add("List");
            pKeyOpts.Keywords.Add("Selection");
            pKeyOpts.Keywords.Add("Descriptions");
            pKeyOpts.Keywords.Default = "List";
            pKeyOpts.AllowNone = true;

            pRlt = adEd.GetKeywords(pKeyOpts);
            string selType = pRlt.StringResult;
            switch (selType)
            {
                case "List":
                    {
                        pStrOpts = new PromptStringOptions("\nEnter the point range using dashes (-) and commas (,): ")
                        {
                            AllowSpaces = true
                        };
                        pRlt = adEd.GetString(pStrOpts);
                        if (string.IsNullOrEmpty(pRlt.StringResult)) { adEd.WriteMessage("\nThe string entered was empty, please try again."); return; }
                        pointStr = pRlt.StringResult;

                        break;
                    }
                case "Selection":
                    {
                        TypedValue[] tvs = new TypedValue[]
                        {
                            new TypedValue((int)DxfCode.Start, "AECC_COGO_POINT")
                        };
                        SelectionFilter selFltr = new SelectionFilter(tvs);
                        PromptSelectionResult acSSPrompt;
                        acSSPrompt = adEd.GetSelection(selFltr);
                        if (acSSPrompt.Status == PromptStatus.Cancel) { adEd.WriteMessage("\nAction aborted."); return; }
                        if (acSSPrompt.Value.Count < 1) { adEd.WriteMessage("\nThe selectiond was empty, please try again."); return; }
                        using (Transaction tr = acDb.TransactionManager.StartTransaction())
                        {
                            foreach (var obj in acSSPrompt.Value.GetObjectIds())
                            {
                                CogoPoint pnt = (CogoPoint)obj.GetObject(OpenMode.ForRead);
                                points.Add(pnt.PointNumber.ToString());
                            }
                            points.Sort();
                        }
                        pointStr = BeautifyPointList(points);
                        break;
                    }
                case "Descriptions":
                    {
                        pStrOpts = new PromptStringOptions("\nEnter the raw descriptions including wildcards (*) and commas (,): ")
                        {
                            AllowSpaces = true
                        };
                        pRlt = adEd.GetString(pStrOpts);
                        if (string.IsNullOrEmpty(pRlt.StringResult)) { adEd.WriteMessage("\nThe string entered was empty, please try again."); return; }
                        descriptionStr = pRlt.StringResult;

                        break;
                    }
                default:
                    {
                        MessageBox.Show($"The selected input for GroupCalc Command was not valid: {pRlt.StringResult}");
                        return;
                    }
            }
            if (string.IsNullOrEmpty(pointStr) && string.IsNullOrEmpty(descriptionStr)) { adEd.WriteMessage("\nNo points were detected");return; }
            using (Transaction tr = acDb.TransactionManager.StartTransaction())
            {
                //Establish points
                string groupName = $"[{DateTime.Now:MM-dd-yyyy}] {purpose.ToUpper()}";

                StandardPointGroupQuery query = new StandardPointGroupQuery();
                if (selType == "Descriptions")
                {
                    query.IncludeRawDescriptions = descriptionStr;
                } else
                {
                    query.IncludeNumbers = pointStr;
                }

                PointGroupCollection pointGroups = cApp.PointGroups;
                if (pointGroups.Contains(groupName))
                {
                    adEd.WriteMessage("\nThe point group already exists, edit the existing group or come up with another name...");
                    return;
                }
                ObjectId groupId = pointGroups.Add(groupName);
                PointGroup group = (PointGroup)groupId.GetObject(OpenMode.ForRead);
                group.SetQuery(query);
                tr.Commit();
            }
            adEd.WriteMessage("\nPoint group created successfully!");
        }
    }
}
