using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDG.Core;

namespace AcC3D_Plug
{
    public partial class GetJobNumber : Form
    {
        public string Value { get; set; }
        public string Path { get; set; }

        public GetJobNumber()
        {
            InitializeComponent();
            Value = "";
            Path = "";
            this.DialogResult = DialogResult.Cancel;
        }

        private void OnAccept(object s, EventArgs e)
        {
            string jobNo = maskedTextBox1.Text;
            if (!JobNumber.TryParse(jobNo, out string jobNoFormated, JobNumberFormats.ShortHyphan))
            {
                LblError.Visible = true;
                return;
            }

            string path = JobNumber.GetPath(jobNoFormated);

            if (string.IsNullOrEmpty(JobNumber.GetPath(jobNoFormated)))
            {
                LblError.Visible = true;
                return;
            }
            Value = jobNoFormated;
            Path = path;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void OnCancel(object s, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
