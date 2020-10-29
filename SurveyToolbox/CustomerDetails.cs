using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SurveyToolbox
{
    public partial class CustomerDetails : Form
    {
        private string ClientFile { get; set; }
        private string ClientId { get; set; }
        public CustomerDetails(string Id)
        {
            InitializeComponent();
            ClientFile = Path.GetDirectoryName(Variables.CompanyFile) + "\\SurveyToolbox\\Customers.track";
            XDocument doc = XDocument.Load(ClientFile);
            var Customers = doc.Root.Elements("Customer");
            var Customer = Customers.FirstOrDefault(RId => RId.Attribute("Id").Value == Id);
            if (Customer == null)
            {
                MessageBox.Show("The indicated customer could not be found. Please contact the admin.");
                this.Close();
                return;
            }
            ClientId = Id;
            PopulateClientInfo(Customer);
            ResizeForm(this, new EventArgs());
        }

        private string GetAttributeValue(XElement element, string attribute)
        {
            return element.Attribute(attribute).Value;
        }


        private void GetAttributeValue(XElement element, string attribute, TextBox output)
        {
            output.Text = GetAttributeValue(element, attribute);
        }

        private void GetAttributeValue(XElement element, string attribute, MaskedTextBox output)
        {
            output.Text = GetAttributeValue(element, attribute);
        }

        private void  PopulateClientInfo(XElement Customer)
        {
            #region General Info
            GetAttributeValue(Customer, "Name", TxtName);
            this.Text = "Customer Info: " +TxtName.Text;
            GetAttributeValue(Customer, "Address1", TxtAddress1);
            GetAttributeValue(Customer, "Address2", TxtAddress2);
            GetAttributeValue(Customer, "EMail", TxtEmail);
            GetAttributeValue(Customer, "Phone", TxtPhone);
            string[] address = GetAttributeValue(Customer, "City").Split(',');
            TxtCity.Text = address[0];
            TxtState.Text = address[1];
            TxtZip.Text = address[2];
            string AlertUser = GetAttributeValue(Customer.Element("Notices"), "Alert");
            string FreezeUser = GetAttributeValue(Customer.Element("Notices"), "Frozen");
            if (FreezeUser.ToLower() == "true")
            {
                LblAcntFrozen.Visible = true;
            }
            else if (AlertUser.ToLower() == "true")
            {
                LblAcntAlert.Visible = true;
            }
            #endregion
            #region Notices
            var Notices = Customer.Element("Notices");
            foreach (var element in Notices.Descendants())
            {
                string status = NoticeIntToString(GetAttributeValue(element, "Level"));
                string[] values = new string[]
                {
                    NoticeIntToString(GetAttributeValue(element, "Level")),
                    GetAttributeValue(element, "Issuer"),
                    element.Value.ToUpper()
                };
                var row = dgvAlerts.Rows.Add(values);
                if (status.ToLower() == "freeze")
                {
                    foreach (DataGridViewCell cell in dgvAlerts.Rows[row].Cells)
                    {
                        cell.Style.BackColor = Color.Red;
                    }
                }
                else if (status.ToLower() == "alert")
                {
                    foreach (DataGridViewCell cell in dgvAlerts.Rows[row].Cells)
                    {
                        cell.Style.BackColor = Color.Orange;
                    }
                }
            }
            #endregion
        }

        private string NoticeIntToString(string value)
        {
            switch (value)
            {
                case "0": return "Non-Issue";
                case "1": return "Alert";
                case "2": return "Freeze";
                default: return "Alert";
            }
        }

        private void ResizeForm(object sender, EventArgs e)
        {
            panel1.Height = this.Size.Height-38;
            panel2.Height = this.Size.Height-38;
            panel1.Width = (this.Width - 6) / 2;
            panel2.Width = (this.Width - 6) / 2;
            panel1.Location = new Point(0, 0);
            panel2.Location = new Point(panel1.Location.X + panel1.Width + 2, 0);
        }
    }
}