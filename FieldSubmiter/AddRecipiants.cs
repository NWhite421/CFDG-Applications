using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FieldSubmiter
{
    public partial class AddRecipiants : Form
    {
        public List<string> EmailAddresses { get; set; }

        public AddRecipiants()
        {
            InitializeComponent();
            EmailAddresses = new List<string> { };
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
