using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.PlottingServices;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using MDG.Core;
using AcApp = Autodesk.AutoCAD.ApplicationServices.Application;
using System.IO;

namespace AcC3D_Plug
{
    // TODO: Review and cleanup
    public class ExportCommands
    {
        [CommandMethod("ExportJobAsPDF")]
        static public void ExportPDF()
        {
            var doc = AcApp.DocumentManager.MdiActiveDocument;
            var ed = doc.Editor;
            ExportForm exportForm = new ExportForm();
            var result = AcApp.ShowModalDialog(exportForm);
            if (result == DialogResult.Cancel)
            {
                ed.WriteMessage($"{Environment.NewLine}The operation has been canceled by the user.");
                return;
            }
            int layoutCount = exportForm.SelectedLayouts.Count;
            ed.WriteMessage($"{Environment.NewLine}Number of selected layouts: {layoutCount}");
            if (layoutCount == 0)
            {
                ed.WriteMessage($"{Environment.NewLine}No layouts were detected.");
                return;
            }
            else if (layoutCount == 1)
            {
                if (PlotFactory.ProcessPlotState == ProcessPlotState.NotPlotting)
                {
                    // First we preview...
                    PreviewEndPlotStatus stat;
                    PlotEngine pre = PlotFactory.CreatePreviewEngine((int)PreviewEngineFlags.Plot);
                    using (pre)
                    {
                        stat = PlotOrPreview(pre, true, exportForm.SelectedLayouts[0].BlockTableRecordId, "", "");
                    }
                    if (stat == PreviewEndPlotStatus.Plot)
                    {
                        // And if the user asks, we plot...
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
                            if (!Directory.Exists(path + "\\Submittals"))
                            {
                                Directory.CreateDirectory(path + "\\Submittals");
                            }
                            PlotEngine ple = PlotFactory.CreatePublishEngine();
                            PlotOrPreview(ple, false, exportForm.SelectedLayouts[0].BlockTableRecordId, path + "\\Submittals", jobNumber);
                            ed.WriteMessage($"{Environment.NewLine}Plot created.");
                        }
                        else
                        {
                            ed.WriteMessage("Project folder could not be determined." + Environment.NewLine);
                        }
                    }
                }
                else
                {
                    ed.WriteMessage(
                      "\nAnother plot is in progress."
                    );
                }
            }
            else
            {
                ObjectIdCollection layouts = new ObjectIdCollection();
                foreach (Layout layout in exportForm.SelectedLayouts)
                {
                    layouts.Add(layout.BlockTableRecordId);
                }
                if (PlotFactory.ProcessPlotState == ProcessPlotState.NotPlotting)
                {
                    int layoutNum = 0;
                    bool isFinished = false;
                    bool isReadyForPlot = false;
                    while (!isFinished)
                    {
                        // Create the preview engine with the appropriate
                        // buttons enabled - this depends on which
                        // layout in the list is being previewed
                        PreviewEngineFlags flags = PreviewEngineFlags.Plot;
                        if (layoutNum > 0) flags |= PreviewEngineFlags.PreviousSheet;
                        if (layoutNum < layouts.Count - 1) flags |= PreviewEngineFlags.NextSheet;
                        using (PlotEngine pre = PlotFactory.CreatePreviewEngine((int)flags))
                        {
                            PreviewEndPlotStatus stat =
                              MultiplePlotOrPreview(
                                pre,
                                true,
                                layouts,
                                layoutNum,
                                "",
                                ""
                              );
                            // We're not checking the list bounds for
                            // next/previous as the buttons are only shown
                            // when they can be used
                            if (stat == PreviewEndPlotStatus.Next)
                            {
                                layoutNum++;
                            }
                            else if (stat == PreviewEndPlotStatus.Previous)
                            {
                                layoutNum--;
                            }
                            else if (stat == PreviewEndPlotStatus.Normal || stat == PreviewEndPlotStatus.Cancel)
                            {
                                isFinished = true;
                            }
                            else if (stat == PreviewEndPlotStatus.Plot)
                            {
                                isFinished = true;
                                isReadyForPlot = true;
                            }
                        }
                    }
                    // If the plot button was used to exit the preview...
                    if (isReadyForPlot)
                    {
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
                            if (!Directory.Exists(path + "\\Submittals"))
                            {
                                Directory.CreateDirectory(path + "\\Submittals");
                            }
                            using (PlotEngine ple = PlotFactory.CreatePublishEngine())
                            {
                                PreviewEndPlotStatus stat = MultiplePlotOrPreview(ple, false, layouts, -1, path + "\\Submittals", jobNumber);
                            }
                        }
                    }
                }
                else
                {
                    ed.WriteMessage(
                      "\nAnother plot is in progress."
                    );
                }
            }
            exportForm.Dispose();
        }

        static PreviewEndPlotStatus PlotOrPreview(PlotEngine pe, bool isPreview, ObjectId layout, string dirPath, string jobnumber)
        {
            Document doc = AcApp.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;

            PreviewEndPlotStatus ret = PreviewEndPlotStatus.Cancel;
            using (Transaction tr = db.TransactionManager.StartTransaction())
            {
                // We'll be plotting the current layout
                BlockTableRecord btr = (BlockTableRecord)tr.GetObject(layout, OpenMode.ForRead);
                Layout lo = (Layout)tr.GetObject(btr.LayoutId, OpenMode.ForRead);

                PlotSettings ps = new PlotSettings(lo.ModelType);
                ps.CopyFrom(lo);

                PlotInfo pi = new PlotInfo
                {
                    Layout = btr.LayoutId
                };

                // Make the layout we're plotting current
                LayoutManager.Current.CurrentLayout = lo.LayoutName;
                // We need to link the PlotInfo to the
                // PlotSettings and then validate it
                pi.OverrideSettings = ps;
                PlotInfoValidator piv = new PlotInfoValidator
                {
                    MediaMatchingPolicy = MatchingPolicy.MatchEnabled
                };

                piv.Validate(pi);

                /*
                // We need a PlotInfo object
                // linked to the layout
                PlotInfo pi = new PlotInfo();
                pi.Layout = lo.BlockTableRecordId;

                // We need a PlotSettings object
                // based on the layout settings
                // which we then customize
                PlotSettings ps = new PlotSettings(lo.ModelType);
                ps.CopyFrom(lo);

                // The PlotSettingsValidator helps
                // create a valid PlotSettings object
                PlotSettingsValidator psv = PlotSettingsValidator.Current;
                
                // We need to link the PlotInfo to the
                // PlotSettings and then validate it
                pi.OverrideSettings = ps;
                PlotInfoValidator piv = new PlotInfoValidator();
                piv.MediaMatchingPolicy = MatchingPolicy.MatchEnabled;
                piv.Validate(pi);*/

                // Create a Progress Dialog to provide info
                // and allow thej user to cancel
                PlotProgressDialog ppd = new PlotProgressDialog(isPreview, 1, true);
                using (ppd)
                {
                    ppd.set_PlotMsgString(PlotMessageIndex.DialogTitle, "Custom Preview Progress");
                    ppd.set_PlotMsgString(PlotMessageIndex.SheetName, doc.Name.Substring(doc.Name.LastIndexOf("\\") + 1));
                    ppd.set_PlotMsgString(PlotMessageIndex.CancelJobButtonMessage, "Cancel Job");
                    ppd.set_PlotMsgString(PlotMessageIndex.CancelSheetButtonMessage, "Cancel Sheet");
                    ppd.set_PlotMsgString(PlotMessageIndex.SheetSetProgressCaption, "Sheet Set Progress");
                    ppd.set_PlotMsgString(PlotMessageIndex.SheetProgressCaption, "Sheet Progress");
                    ppd.LowerPlotProgressRange = 0;
                    ppd.UpperPlotProgressRange = 100;
                    ppd.PlotProgressPos = 0;
                    
                    // Let's start the plot/preview, at last
                    ppd.OnBeginPlot();
                    ppd.IsVisible = true;
                    pe.BeginPlot(ppd, null);

                    // We'll be plotting/previewing
                    // a single document
                    string file = dirPath + "\\" + jobnumber + " " + lo.LayoutName + " " + DateTime.Now.ToString("MM-dd-yy");
                    pe.BeginDocument(pi, doc.Name, null, 1,!isPreview, file);
                    
                    // Which contains a single sheet
                    ppd.OnBeginSheet();
                    ppd.LowerSheetProgressRange = 0;
                    ppd.UpperSheetProgressRange = 100;
                    ppd.SheetProgressPos = 0;
                    PlotPageInfo ppi = new PlotPageInfo();
                    pe.BeginPage(ppi, pi, true, null);
                    pe.BeginGenerateGraphics(null);
                    ppd.SheetProgressPos = 50;
                    pe.EndGenerateGraphics(null);
                    
                    // Finish the sheet
                    PreviewEndPlotInfo pepi = new PreviewEndPlotInfo();
                    pe.EndPage(pepi);
                    ret = pepi.Status;
                    ppd.SheetProgressPos = 100;
                    ppd.OnEndSheet();
                    
                    // Finish the document
                    pe.EndDocument(null);
                    
                    // And finish the plot
                    ppd.PlotProgressPos = 100;
                    ppd.OnEndPlot();
                    pe.EndPlot(null);
                }
                // Committing is cheaper than aborting
                tr.Commit();
            }
            return ret;
        }

        static PreviewEndPlotStatus MultiplePlotOrPreview(PlotEngine pe, bool isPreview, ObjectIdCollection layoutSet, int layoutNumIfPreview, string dirPath, string jobnumber)
        {
            Document doc = AcApp.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            PreviewEndPlotStatus ret = PreviewEndPlotStatus.Cancel;
            ObjectIdCollection layoutsToPlot;
            if (isPreview && layoutNumIfPreview >= 0)
            {
                // Preview is really pre-sheet, so we reduce the
                // sheet collection to contain the one we want
                layoutsToPlot = new ObjectIdCollection
                {
                    layoutSet[layoutNumIfPreview]
                };
            }
            else
            {
                // If we're plotting we need all the sheets,                 
                // so copy the ObjectIds across
                ObjectId[] ids = new ObjectId[layoutSet.Count];
                layoutSet.CopyTo(ids, 0);
                layoutsToPlot = new ObjectIdCollection(ids);
            }
            using (Transaction tr = db.TransactionManager.StartTransaction())
            {
                // Create a Progress Dialog to provide info
                // and allow thej user to cancel
                using (PlotProgressDialog ppd = new PlotProgressDialog(isPreview, layoutsToPlot.Count, true))
                {
                    int numSheet = 1;
                    foreach (ObjectId btrId in layoutsToPlot)
                    {
                        BlockTableRecord btr = (BlockTableRecord)tr.GetObject(btrId, OpenMode.ForRead);
                        Layout lo = (Layout)tr.GetObject(btr.LayoutId, OpenMode.ForRead);

                        // We need a PlotSettings object
                        // based on the layout settings
                        // which we then customize
                        PlotSettings ps = new PlotSettings(lo.ModelType);
                        ps.CopyFrom(lo);

                        // The PlotSettingsValidator helps
                        // create a valid PlotSettings object
                        PlotSettingsValidator psv = PlotSettingsValidator.Current;

                        // We need a PlotInfo object
                        // linked to the layout
                        PlotInfo pi = new PlotInfo
                        {
                            Layout = btr.LayoutId
                        };
                        // Make the layout we're plotting current
                        LayoutManager.Current.CurrentLayout = lo.LayoutName;
                        // We need to link the PlotInfo to the
                        // PlotSettings and then validate it
                        pi.OverrideSettings = ps;
                        PlotInfoValidator piv = new PlotInfoValidator
                        {
                            MediaMatchingPolicy = MatchingPolicy.MatchEnabled
                        };
                        piv.Validate(pi);
                        // We set the sheet name per sheet
                        ppd.set_PlotMsgString(PlotMessageIndex.SheetName, doc.Name.Substring(doc.Name.LastIndexOf("\\") + 1) +" - " + lo.LayoutName);
                        if (numSheet == 1)
                        {
                            // All other messages get set once
                            ppd.set_PlotMsgString(PlotMessageIndex.DialogTitle, "Custom Preview Progress");
                            ppd.set_PlotMsgString(PlotMessageIndex.CancelJobButtonMessage, "Cancel Job");
                            ppd.set_PlotMsgString(PlotMessageIndex.CancelSheetButtonMessage, "Cancel Sheet");
                            ppd.set_PlotMsgString(PlotMessageIndex.SheetSetProgressCaption, "Sheet Set Progress");
                            ppd.set_PlotMsgString(PlotMessageIndex.SheetProgressCaption, "Sheet Progress");
                            ppd.LowerPlotProgressRange = 0;
                            ppd.UpperPlotProgressRange = 100;
                            ppd.PlotProgressPos = 0;

                            // Let's start the plot/preview, at last
                            ppd.OnBeginPlot();
                            ppd.IsVisible = true;
                            pe.BeginPlot(ppd, null);

                            // We'll be plotting a single document
                            string file = dirPath + "\\" + jobnumber + " Combined " + DateTime.Now.ToString("MM-dd-yy");
                            pe.BeginDocument(pi, doc.Name, null, 1, !isPreview, file);
                        }

                        // Which may contains multiple sheets
                        ppd.LowerSheetProgressRange = 0;
                        ppd.UpperSheetProgressRange = 100;
                        ppd.SheetProgressPos = 0;
                        PlotPageInfo ppi = new PlotPageInfo();
                        pe.BeginPage(ppi, pi, (numSheet == layoutsToPlot.Count), null);
                        ppd.OnBeginSheet();
                        pe.BeginGenerateGraphics(null);
                        ppd.SheetProgressPos = 50;
                        pe.EndGenerateGraphics(null);

                        // Finish the sheet
                        PreviewEndPlotInfo pepi = new PreviewEndPlotInfo();
                        pe.EndPage(pepi);
                        ret = pepi.Status;
                        ppd.SheetProgressPos = 100;
                        ppd.OnEndSheet();
                        numSheet++;

                        // Update the overall progress
                        ppd.PlotProgressPos +=
                          (100 / layoutsToPlot.Count);
                    }

                    // Finish the document
                    pe.EndDocument(null);

                    // And finish the plot
                    ppd.PlotProgressPos = 100;
                    ppd.OnEndPlot();
                    pe.EndPlot(null);
                }
            }
            return ret;
        }
    }
}