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
    public partial class AllCustomers : Form
    {
        CUSTstorexec cust = new CUSTstorexec();
        connection con = new connection();
        public AllCustomers()
        {
            InitializeComponent();
        }

        private void AllCustomers_Load(object sender, EventArgs e)
        {
            con.connectionOpen();
            cust.loadallcustomer(lvallcustomers);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lvallcustomers.Clear();
            string search = txtSearchCustomer.Text;
            con.connectionOpen();
            cust.SearchCustomerbylastname(lvallcustomers, search);
        }
    }
}
