using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MDG.Core;

namespace AcC3D_Plug
{
    class Logging
    {
        private static bool EstablishC3DLog(string jobNumber)
        {
            FileStream fileStream;
            string path = JobNumber.GetPath(jobNumber);
            if (string.IsNullOrEmpty(path))
            {
                return false;
            }
            path += "\\autocad_log.log";
            if (File.Exists(path)) return true;
            try
            {
                fileStream = File.Create(path);
                fileStream.Close();
                File.SetAttributes(path, File.GetAttributes(path) | FileAttributes.Hidden);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void LogEntry(string jobNumber, string title, string body)
        {
            if (!EstablishC3DLog(jobNumber)) return;
            string path = JobNumber.GetPath(jobNumber) + "\\autocad_log.log";
            string message = $"ENTRY||{title}||{body}";
            File.AppendAllLines(path, new List<string> { message });

        }

        public  static void LogFileOpen(string jobNumber)
        {
            if (!EstablishC3DLog(jobNumber)) return;
            string path = JobNumber.GetPath(jobNumber) + "\\autocad_log.log";
            string name = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string logEntry = $"OPEN||{name}||{DateTime.Now}";
            File.AppendAllLines(path, new List<string> { logEntry });
        }
        public static void LogFileClose(string jobNumber)
        {
            if (!EstablishC3DLog(jobNumber)) return;
            string path = JobNumber.GetPath(jobNumber) + "\\autocad_log.log";
            string logEntry = $"CLOSE||{DateTime.Now}";
            File.AppendAllLines(path, new List<string> { logEntry });
        }
    }
}
