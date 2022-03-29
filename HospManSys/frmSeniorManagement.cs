using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospManSys
{
    public partial class frmSeniorManagement : Form
    {
        public frmSeniorManagement()
        {
            InitializeComponent();
        }

        private void btnGenerateFinanceReport_Click(object sender, EventArgs e)
        {
            pbFinanceReport.Visible = true;
            pbPerformanceReport.Visible = false;
        }

        private void btnGeneratePerformanceReport_Click(object sender, EventArgs e)
        {
            pbFinanceReport.Visible = false;
            pbPerformanceReport.Visible = true;
        }
    }
}
