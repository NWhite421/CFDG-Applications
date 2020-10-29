using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyToolbox
{
    public class UserInformation
    {
        /// <summary>
        /// The full name of the user.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// the username of the account
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// The admin level (0:Basic; 1:Manager; 2:Admin)
        /// </summary>
        public AdminLevel AdminLevel { get; set; }

        /// <summary>
        /// Determines if the user's password requires an update.
        /// </summary>
        public bool RequireUpdate { get; set; }
    }

    public enum AdminLevel
    {
        User = 0,
        Team_Leader = 1,
        Manager = 2,
        Admin = 3
    }

    public class Variables
    {
        /// <summary>
        /// The current user's information
        /// </summary>
        public static UserInformation CurrentUser { get; set; }

        /// <summary>
        /// The master job file location
        /// </summary>
        public static string MasterJobFile { get; set; }

        public static string CompanyFile { get; set; }

        /// <summary>
        /// The default project directory
        /// </summary>
        public static string DefaultDirectory { get; set; }
    }
}
