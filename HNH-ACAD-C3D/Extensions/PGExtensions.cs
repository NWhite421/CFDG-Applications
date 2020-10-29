using System.Linq;
using System.Collections.Generic;
using Autodesk.Civil.DatabaseServices;
using Autodesk.Civil.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace AcC3D_Plug.Extensions
{
    public static class PointGroupExtensions
    {
        public static List<CogoPoint> GetCogoPoints(this PointGroup ptGroup)
        {
            CivilDocument civDoc = CivilApplication.ActiveDocument;
            return (from p in ptGroup.GetPointNumbers()
                    select civDoc.CogoPoints.GetPointByPointNumber(p).GetObject(OpenMode.ForRead) as CogoPoint).ToList();
        }
    }
}
