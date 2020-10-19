using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace FieldSubmiter
{
    class EMailServerInfo
    {
        public struct GMail
        {
            public static string Host
            {
                get
                {
                    return "smtp.gmail.com";
                }
            }
            public static int Port
            {
                get
                {
                    return 587;
                }
            }
            public static bool EnableSSL
            {
                get
                {
                    return true;
                }
            }

            public SmtpClient GetClientInfo
            {
                get
                {
                    var client = new SmtpClient(Host)
                    {
                        Port = Port,
                        EnableSsl = EnableSSL
                    };
                    return client;
                }
            }
        }

        public struct GoDaddy
        {
            public static string Host
            {
                get
                {
                    return "smtpout.secureserver.net";
                }
            }
            public static int Port
            {
                get
                {
                    return 587;
                }
            }
            public static bool EnableSSL
            {
                get
                {
                    return true;
                }
            }

            public SmtpClient GetClientInfo
            {
                get
                {
                    var client = new SmtpClient(Host)
                    {
                        Port = Port,
                        EnableSsl = EnableSSL
                    };
                    return client;
                }
            }
        }

        public struct Office365
        {
            public static string Host
            {
                get
                {
                    return "smtp.office365.com";
                }
            }
            public static int Port
            {
                get
                {
                    return 587;
                }
            }
            public static bool EnableSSL
            {
                get
                {
                    return true;
                }
            }

            public SmtpClient GetClientInfo
            {
                get
                {
                    var client = new SmtpClient(Host)
                    {
                        Port = Port,
                        EnableSsl = EnableSSL
                    };
                    return client;
                }
            }
        }
    }
}
