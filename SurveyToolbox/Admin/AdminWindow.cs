using System;
using System.Data;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SurveyToolbox
{
    public partial class AdminWindow : Form
    {
        string defaultPassword = "fGoYCzaJagqMAnh+6vsOTA==";

        private string IntToValue(int input)
        {
            switch (input)
            {
                case 0: return "User";
                case 1: return "Team Leader";
                case 2: return "Manager";
                case 3: return "Admin";
                default: return "User";
            }
        }
        private int ValueToInt(string input)
        {
            switch (input)
            {
                case "User": return 0;
                case "Team Leader": return 1;
                case "Manager": return 2;
                case "Admin": return 3;
                default: return 0;
            }
        }

        public AdminWindow()
        {
            InitializeComponent();
            PopulateEmployeeList();


            XDocument doc = XDocument.Load(Variables.CompanyFile);
            var company = doc.Root.Element("Company");
            TxtName.Text = company.Element("Name").Value;
            TxtShortName.Text = company.Element("ShortName").Value;
            TxtAddress1.Text = company.Element("Address1").Value;
            TxtAddress2.Text = company.Element("Address2").Value;
            TxtCity.Text = company.Element("City").Value;
            TxtState.Text = company.Element("State").Value;
            MTxtZip.Text = company.Element("ZIP").Value;
            txtWebsite.Text = company.Element("Website").Value;
            MTxtPhone.Text = company.Element("Phone").Value;
        }

        public AdminWindow (string SelectedTab)
        {
            InitializeComponent();
            PopulateEmployeeList();
            switch (SelectedTab.ToLower())
            {
                case "projects": { tabControl1.SelectedIndex = 1; return; }
            }
        }

        private void PopulateEmployeeList()
        {
            XDocument doc = XDocument.Load(Variables.CompanyFile);
            foreach (XElement user in doc.Root.Element("Users").Descendants())
            {
                var row = dgvUsers.Rows.Add();
                dgvUsers.Rows[row].Cells[0].Value = user.Attribute("Id").Value;
                dgvUsers.Rows[row].Cells[1].Value = user.Attribute("Name").Value;
                dgvUsers.Rows[row].Cells[2].Value = user.Attribute("Username").Value;
                dgvUsers.Rows[row].Cells[3].Value = IntToValue(int.Parse(user.Attribute("Admin").Value));
                dgvUsers.Rows[row].Cells[4].Value = bool.Parse(user.Attribute("Active").Value);
                dgvUsers.Rows[row].Cells[5].Value = bool.Parse(user.Attribute("RequireUpdate").Value);
            }
        }

        private void cmdDiscardChanges_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmdSaveChanges_Click(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load(Variables.CompanyFile);
            var users = doc.Root.Element("Users").Descendants();

            foreach (DataGridViewRow row in dgvUsers.Rows)
            {
                XElement userInfo = users.Where(x => x.Attribute("Id").Value == row.Cells[0].Value.ToString()).FirstOrDefault();
                if (userInfo != null)
                {
                    userInfo.Attribute("Name").Value = row.Cells[1].Value.ToString();
                    userInfo.Attribute("Username").Value = row.Cells[2].Value.ToString();
                    userInfo.Attribute("Admin").Value = ValueToInt(row.Cells[3].Value.ToString()).ToString();
                    userInfo.Attribute("RequireUpdate").Value = row.Cells[5].Value.ToString();
                    userInfo.Attribute("Active").Value = row.Cells[4].Value.ToString();
                    if (row.Cells[5].Value != null && row.Cells[5].Value.ToString().ToLower() == "true") { userInfo.Value = defaultPassword; };
                }
                else
                {
                    XElement newUser = new XElement("User",
                        new XAttribute("Id", row.Cells[0].Value),
                        new XAttribute("Name", row.Cells[1].Value),
                        new XAttribute("Username", row.Cells[2].Value),
                        new XAttribute("Admin", ValueToInt(row.Cells[3].Value.ToString())),
                        new XAttribute("RequireUpdate", row.Cells[5].Value),
                        new XAttribute("Active", row.Cells[4].Value),
                        defaultPassword
                    );
                    doc.Root.Element("Users").Add(newUser);
                }
            }

            var company = doc.Root.Element("Company");
            company.Element("Name").Value = TxtName.Text;
            company.Element("ShortName").Value = TxtShortName.Text;
            company.Element("Address1").Value = TxtAddress1.Text;
            company.Element("Address2").Value = TxtAddress2.Text;
            company.Element("City").Value = TxtCity.Text;
            company.Element("State").Value = TxtState.Text;
            company.Element("ZIP").Value = MTxtZip.Text;
            company.Element("Website").Value = txtWebsite.Text;
            company.Element("Phone").Value = MTxtPhone.Text;

            doc.Save(Variables.CompanyFile);
            this.Close();
        }

        private void CmdAddUser_Click(object sender, EventArgs e)
        {
            NewUser user = new NewUser();
            var ret = user.ShowDialog();
            if (ret == DialogResult.Cancel) return;
            var info = user.UserInformation;
            var row = dgvUsers.Rows.Add();
            dgvUsers.Rows[row].Cells[0].Value = DateTime.Now.ToString("MMddyyHHmm");
            dgvUsers.Rows[row].Cells[1].Value = info.DisplayName;
            dgvUsers.Rows[row].Cells[2].Value = info.Username;
            dgvUsers.Rows[row].Cells[3].Value = IntToValue((int)info.AdminLevel);
            dgvUsers.Rows[row].Cells[4].Value = "True";
            dgvUsers.Rows[row].Cells[5].Value = info.RequireUpdate.ToString();
            dgvUsers.Rows[row].Cells[5].ReadOnly = true;
            dgvUsers.Rows[row].Cells[6].Value = "True";
            dgvUsers.Rows[row].Cells[6].ReadOnly = true;

        }

        private void CmdRemoveUser_Click(object sender, EventArgs e)
        {
            var cells = dgvUsers.SelectedCells;
            if (cells.Count == 0) return;
            var cell = cells[0];
            var row = dgvUsers.Rows[cell.RowIndex];

            string name, id;
            name = row.Cells[1].Value.ToString();
            id = row.Cells[0].Value.ToString();
            var ret = MessageBox.Show($"Are you sure you want to delete {name} ({id}) from the database?\n\nTHIS ACTION CANNOT BE UNDONE", "Confirm deletion", MessageBoxButtons.YesNo);
            if (ret == DialogResult.No) return;

            XDocument doc = XDocument.Load(Variables.CompanyFile);
            var user = doc.Root.Element("Users").Descendants().Where(x => x.Attribute("Id").Value == id).FirstOrDefault();
            if (user == null)
            {
                MessageBox.Show("No user was found by tht ID, please contact IT");
                return;
            }
            user.Remove();
            doc.Save(Variables.CompanyFile);
            dgvUsers.Rows.Remove(row);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            string text = btn.Text;
        }
    }
}
