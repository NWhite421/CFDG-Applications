using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Autodesk.AutoCAD;
using Autodesk.AutoCAD.ApplicationServices;
using MDG.Core;
using AcApp = Autodesk.AutoCAD.ApplicationServices.Application;

namespace AcC3D_Plug
{
    class Functions
    {
        public static string GetJobNumber(Document document)
        {
            var jobNumber = Path.GetFileNameWithoutExtension(document.Name);
            return Parse(jobNumber);
        }

        public static string GetJobNumber(string document)
        {
            var jobNumber = Path.GetFileNameWithoutExtension(document);
            return Parse(jobNumber);
        }

        /// <summary>
        /// Parses a file name to determine if the job number is in the filename.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private static string Parse(string fileName)
        {
            var match = Regex.Match(fileName, @"(\d{2}|\d{4})(-\d{2}-\d{3})|(\d{7,9})");
            if (match.Success)
            {
                return match.Value;
            }
            return "";
        }
    }
}
