using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;
using Autodesk.Civil.ApplicationServices;
using Autodesk.Civil.DatabaseServices;
using MDG.Core;
using Microsoft.Win32.SafeHandles;
using Autodesk.Windows;
using System.Windows.Input;
using System.Reflection;
using System.Diagnostics;
using Autodesk.AutoCAD.Colors;
using AcApp = Autodesk.AutoCAD.ApplicationServices.Application;

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
            // Add event handler for every drawing opened.
            AcApp.DocumentManager.DocumentCreated += new DocumentCollectionEventHandler(LoadDWG);

            // Add event handler for every drawing closed.
            AcApp.DocumentManager.DocumentDestroyed += new DocumentDestroyedEventHandler(UnLoadDWG);

            // Add event handler when AutoCAD goes idle (removes itself after first run to bypass bullshit).
            Autodesk.AutoCAD.ApplicationServices.Application.Idle += new EventHandler(OnAppLoad);

        }

        /// <summary>
        /// Runs when the Autocad Application executes Idle event handler. Removes itself after first run.
        /// Litterally a copy paste of LoadDWG() with the added benefit of custom tab addition.
        /// </summary>
        public void OnAppLoad(object s, EventArgs e)
        {
            // Add custom ribbon to RibbonControl
            RibbonControl ribbon = ComponentManager.Ribbon;
            if (ribbon != null)
            {
                EstablishTab();
                // Remove this event handler as to not fire again.
                // Ensures that the tab is established on startup, but will not create additional.
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
            //TODO: Impliment logging features and code cleanup.
        }

        /// <summary>
        /// Runs when a drawing is closed.
        /// </summary>
        public static void UnLoadDWG(object s, DocumentDestroyedEventArgs e)
        {
            //TODO: Impliment logging features and code cleanup.
        }

        /// <summary>
        /// Fires once when the plugin is unloaded(? assumes when either plugin crashes or application is closed)
        /// </summary>
        void IExtensionApplication.Terminate()
        {

        }

        #endregion

        #region RIBBON HANDLING

        #region DEFAULT DEFINITIONS
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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0052:Remove unread private members", Justification = "Generic definition for future use")]
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

        #endregion

        #region TAB DEFINITIONS
        /// <summary>
        /// Create tab and add panels to tab.
        /// </summary>
        [CommandMethod("EstablishTabs")]
        public void EstablishTab()
        {
            //Add Ribbon
            RibbonControl ribbon = ComponentManager.Ribbon;

            // If the RibbonControl is established, then initialize our tab.
            if (ribbon != null)
            {
                // If the Ribbon already exists, don't create another.
                RibbonTab rtab = ribbon.FindTab("HNHSurvey");
                if (rtab != null)
                {
                    return;
                }

                rtab = new RibbonTab
                {
                    Title = "H & H Survey",
                    Id = "HNHSurvey"
                };
                rtab.Panels.Add(AddProMgmtPanel()); // Project Management Group
                rtab.Panels.Add(AddCompPanel());    // Computations Group
                rtab.Panels.Add(HelpPanel());       // Help Group

                // Display tab in the RibbonControl for the user.
                ribbon.Tabs.Add(rtab);

                // Let the user know this succeeded.
                AcApp.DocumentManager.MdiActiveDocument.Editor.WriteMessage("Panel loaded successfully..." + Environment.NewLine);
            }

        }

        /// <summary>
        /// Project Management panel creation
        /// </summary>
        /// <returns>Project Management Panel</returns>
        // TODO: Refactor first buttons to copy / clean up.
        public RibbonPanel AddProMgmtPanel()
        {
            // Tab -> RibbonPanels[] -> RibbonPanel -> RibbonPanelSource -> RibbonButton(s)
            // Establish the source control for the panel.
            RibbonPanelSource rps = new RibbonPanelSource
            {
                Title = "Project Management",
                Name = "Project Management"
            };

            // Establish output RibbonPanel
            RibbonPanel rp = new RibbonPanel
            {
                Source = rps
            };

            // Open folders on server for project.
            // Establish the split button control to add options to.
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

            // Establish our individual buttons
            RibbonButton OpenProjectFolder = ButtonLarge.Clone() as RibbonButton;
            OpenProjectFolder.Text = $"Open{Environment.NewLine}Project";
            OpenProjectFolder.CommandParameter = "._OpenProjectFolder ";
            OpenProjectFolder.LargeImage = IntFunctions.BitmapToImageSource(Properties.Resources.Goto_Folder);

            RibbonButton OpenCompFolder = ButtonLarge.Clone() as RibbonButton;
            OpenCompFolder.Text = $"Open Comp{Environment.NewLine}Folder";
            OpenCompFolder.CommandParameter = "._OpenCompFolder ";
            OpenCompFolder.LargeImage = IntFunctions.BitmapToImageSource(Properties.Resources.Goto_Folder, Properties.Resources.overlay_edit);

            RibbonButton OpenSubmittalFolder = ButtonLarge.Clone() as RibbonButton;
            OpenSubmittalFolder.Text = $"Open Submittal{Environment.NewLine}Folder";
            OpenSubmittalFolder.CommandParameter = "._OpenSubmittalFolder ";
            OpenSubmittalFolder.LargeImage = IntFunctions.BitmapToImageSource(Properties.Resources.Goto_Folder, Properties.Resources.overlay_export);

            RibbonButton OpenFieldDataFolder = ButtonLarge.Clone() as RibbonButton;
            OpenFieldDataFolder.Text = $"Open Field{Environment.NewLine}Data Folder";
            OpenFieldDataFolder.CommandParameter = "._OpenFieldDataFolder ";
            OpenFieldDataFolder.LargeImage = IntFunctions.BitmapToImageSource(Properties.Resources.Goto_Folder, Properties.Resources.overlay_field);

            // Add our individual buttons to the split button container
            OpenProjectSplit.Items.Add(OpenProjectFolder);
            OpenProjectSplit.Items.Add(OpenCompFolder);
            OpenProjectSplit.Items.Add(OpenFieldDataFolder);
            OpenProjectSplit.Items.Add(OpenSubmittalFolder);

            // Add our split button to the RibbonPanelSource
            rps.Items.Add(OpenProjectSplit);

            // Return the RibbonPanel
            return rp;
        }

        /// <summary>
        /// Help panel creation
        /// </summary>
        /// <returns>Help panel</returns>
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
            GroupPoints.CommandParameter = "_.CreateGroupOfCalcs ";
            GroupPoints.LargeImage = IntFunctions.BitmapToImageSource(Properties.Resources.Create_PG);

            RibbonButton ExportGroup = ButtonLarge.Clone() as RibbonButton;
            ExportGroup.Text = $"Export Point{Environment.NewLine}Groups";
            ExportGroup.CommandParameter = "_.ExportPointGroups ";
            ExportGroup.LargeImage = IntFunctions.BitmapToImageSource(Properties.Resources.Export_PG);

            rps.Items.Add(GroupPoints);
            rps.Items.Add(ExportGroup);

            return rp;
        }

        #endregion

        #endregion

        #region PALLETE HANDLING


        //static CustomPaletteSet palette;

        //[CommandMethod("ProjectManagementPallete")]
        //public void ShowProjectPallete()
        //{
        //    //Add palleteSet
        //    if (palette == null) palette = new CustomPaletteSet();
        //    palette.Visible = true;

        //}

        #endregion

        #region COMMANDS



        #endregion

    }

    // RibbonButton Event Handlers
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
            // Grab the command associated with the button
            RibbonButton cmd = parameter as RibbonButton;

            Document dwg = AcApp.DocumentManager.MdiActiveDocument;

            // Send the command to the application in the current document
            dwg.SendStringToExecute(cmd.CommandParameter as string, true, false, true);

        }
    }

    // FIX: Maybe impliment the C3D version because I am retarded
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

        public Point3d Coordinate
        {
            get
            {
                return new Point3d(Easting, Northing, Elevation);
            }
        }

        public string Decsription { get; set; }
    }

    //For sidebar implimentation (at some point)
    //public class CustomPaletteSet : PaletteSet
    //{
    //    public CustomPaletteSet()
    //        : base("Project Information", "ProjectManagementPallete", new Guid("9CF9996E-7D0E-4886-8FFA-16604ED9D419"))
    //    {
    //        Style = PaletteSetStyles.ShowAutoHideButton |
    //                PaletteSetStyles.ShowCloseButton |
    //                PaletteSetStyles.ShowPropertiesMenu;

    //        MinimumSize = new System.Drawing.Size(300,300);

    //        Add("Tab", new ProjectInformation());
    //    }
    //}
}
