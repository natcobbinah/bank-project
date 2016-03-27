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
   public partial class Withdrawal_Form : Form
    {
        connection con = new connection();
        CUSTstorexec cust = new CUSTstorexec();
        
        public Withdrawal_Form()
        {
            InitializeComponent();
        }

        private void lbTime_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.connectionOpen();

            float withdrawamount = float.Parse(txtwithamount.Text);

            cust.custWithdraw(txtaccnum.Text, withdrawamount);

            MessageBox.Show("Withdrawal successfully completed");
        }

        private void Withdrawal_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
