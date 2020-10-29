using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MDG.Core
{
    public class Paths
    {
        #region INTERNAL FUNCTIONS
        private static bool EstablishParent(string ChildDirectory)
        {
            string parentDirectory = Directory.GetParent(ChildDirectory).FullName;
            if (Directory.Exists(parentDirectory))
            {
                return true;
            }
            else
            {
                try
                {
                    if (EstablishParent(parentDirectory))
                    {
                        Directory.CreateDirectory(parentDirectory);
                        return true;
                    }
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }
        #endregion

        #region CONSTANTS

        /// <summary>
        /// The localappdata path for the project.
        /// </summary>
        public static string LocalAppDataPath
        {
            get
            {
                string localappdata = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(localappdata, Options.General.Company, Options.General.ProjectName);
            }
        }
        
        /// <summary>
        /// The roamingappdata path for the project.
        /// </summary>
        public static string AppDataPath
        {
            get
            {
                string localappdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                return Path.Combine(localappdata, Options.General.Company, Options.General.ProjectName);
            }
        }

        /// <summary>
        /// The MyDocuments path for the project.
        /// </summary>
        public static string DocumentsPath
        {
            get
            {
                string localappdata = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                return Path.Combine(localappdata, Options.General.Company, Options.General.ProjectName);
            }
        }

        public static string ExecutablePath
        {
            get
            {
                return new FileInfo(Assembly.GetCallingAssembly().Location).Directory.ToString();
            }
        }

        #endregion

        #region METHODS
        /// <summary>
        /// Replaces illegal characters in file name to be in conformance. Also replaces variables.
        /// </summary>
        /// <param name="Input">String to file path to validate.</param>
        /// <returns>Validated and correct path.</returns>
        public static string ValidateFilePath(string Input)
        {
            string parent = Directory.GetParent(Input).FullName;
            string fileName = Path.GetFileNameWithoutExtension(Input);
            string extent = Path.GetExtension(Input);

            fileName = fileName.Replace("\\", "-")
                    .Replace("\\", "-")
                    .Replace("/", "-")
                    .Replace("\"", "-")
                    .Replace("*", "-")
                    .Replace("<", "-")
                    .Replace(">", "-")
                    .Replace("|", "-")
                    .Replace(":", "-");

            string nFileName = Path.Combine(parent, fileName + extent);
            int iteration = 0;
            while (File.Exists(nFileName))
            {
                nFileName = Path.Combine(parent, fileName + $" ({iteration + 1})" + extent);
                iteration++;
            }

            return ReplaceVariables(nFileName);
        }

        /// <summary>
        /// Replaces the variables in a string with their dynamic counterpart.
        /// </summary>
        /// <param name="Input">String to replace variables in.</param>
        /// <returns>String with updated variables.</returns>
        public static string ReplaceVariables(string Input)
        {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            var dateCurrent = DateTime.Now;
            string dateFull = dateCurrent.ToString("MM-dd-yy hh-mm-ss tt");
            string dateShort = dateCurrent.ToString("MM-dd-yy");
            string time = dateCurrent.ToString("hh-mm-ss");

            string outp = Input.Replace("$LocalAppData$", localAppData)
                .Replace("$AppData$", appData)
                .Replace("$ProjectName$", Options.General.ProjectName)
                .Replace("$DateFull$", dateFull)
                .Replace("$DateShort$", dateShort)
                .Replace("$Time$", time);

            return outp;
        }

        public static void EstablishDirectory(string DirPath)
        {
            string parentDirectory = Directory.GetParent(DirPath).FullName;
            if (Directory.Exists(DirPath)) return;
            if (Directory.Exists(parentDirectory))
            {
                Directory.CreateDirectory(DirPath);
                return;
            }
            else
            {
                EstablishParent(parentDirectory);
                Directory.CreateDirectory(DirPath);
                return;
            }
        }
        #endregion
    }
}
