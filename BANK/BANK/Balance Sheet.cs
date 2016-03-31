using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANK
{
    public partial class Reports : Form
    {
        reportloader rptloader = new reportloader();
        public Reports()
        {
            InitializeComponent();
            string query = "SELECT Account_number from Customer";
            rptloader.LoadCustomerOnComboBox(cboCustomer, query, "Account_number");
        }

        private void Balance_Sheet_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rptloader.LoadReport(crystalReportViewer1, cboCustomer.Text);
        }
    }
}
