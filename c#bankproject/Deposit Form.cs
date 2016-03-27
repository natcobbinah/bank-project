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
    public partial class Deposit_Form : Form
    {
        connection con = new connection();
        CUSTstorexec cust = new CUSTstorexec();

        string strformat;
        public Deposit_Form()
        {
            InitializeComponent();

            strformat = "dddd, MMMM d,yyyy h:mm:ss tt";
            labTime.Text = DateTime.Now.ToString(strformat);
            labTime.TextAlign = ContentAlignment.MiddleCenter;

            Timer t = new Timer();
            t.Interval = 1000; // 1 seconds
            t.Start();
            t.Tick += new EventHandler(labTime_Click);
        }

        private void labTime_Click(object sender, EventArgs e)
        {
            labTime.Text = DateTime.Now.ToString(strformat);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.connectionOpen();

            float dpamount = float.Parse(txtdpamount.Text);

            cust.updateBalance(dpamount,cboactype.Text, cbocusttype.Text, txtaccnum.Text);

            MessageBox.Show("update succesful");
        }
    }
}
