using System;
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
using Autodesk.Civil.ApplicationServices;
using Autodesk.Civil.DatabaseServices;
using Autodesk.Civil.Settings;
using MDG.Core;
using Microsoft.Win32.SafeHandles;
using Autodesk.Windows;
using System.ComponentModel;
using System.Windows.Input;
using AcApp = Autodesk.AutoCAD.ApplicationServices.Application;
using System.Reflection;
using System.Diagnostics;
using Autodesk.AutoCAD.Colors;
using System.Windows.Media.Imaging;
using System.Drawing;
using System.Drawing.Imaging;

namespace AcC3D_Plug
{
    class IntFunctions
    {
        public static BitmapImage BitmapToImageSource(Bitmap bitmap)
        {
            using (MemoryStream memory = new MemoryStream()) 
            {
                bitmap.Save(memory, ImageFormat.Png);
                memory.Position = 0;
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memory;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();

                return bitmapImage;
            }
        }

        
        public static BitmapImage BitmapToImageSource(params Bitmap[] bitmaps)
        {
            if (bitmaps.Length == 0)
                return new BitmapImage();
            int width = bitmaps.Max(map => map.Width);
            int height = bitmaps.Max(map => map.Height);
            Bitmap result = new Bitmap(width,height);
            using (Graphics g = Graphics.FromImage(result))
            {
                foreach (Bitmap map in bitmaps)
                {
                    g.DrawImage(map, System.Drawing.Point.Empty);
                }
            }
            return BitmapToImageSource(result);
        }


        public static List<List<C3DPoint>> ProcessFiles(List<string> Files)
        {
            List<List<C3DPoint>> points = new List<List<C3DPoint>> { };

            foreach (string file in Files)
            {
                List<C3DPoint> filePoints = new List<C3DPoint> { };
                foreach (string line in File.ReadAllLines(file))
                {
                    string[] parts = line.Split(',');
                    if (uint.TryParse(parts[0], out uint number))
                    {
                        C3DPoint point = new C3DPoint
                        {
                            PointNumber = number,
                            Northing = double.Parse(parts[1]),
                            Easting = double.Parse(parts[2]),
                            Elevation = double.Parse(parts[3]),
                            Decsription = parts[4].Replace("=", " ")
                        };
                        filePoints.Add(point);
                        point.Dispose();
                    }
                    else
                    {
                    }
                }
                points.Add(filePoints);
            }

            return points;
        }
    }
    class ACadFunctions
    {

    }
}
