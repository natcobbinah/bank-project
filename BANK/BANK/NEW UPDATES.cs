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
    public partial class NEW_UPDATES : Form
    {
        connection con = new connection();
        CUSTstorexec cust = new CUSTstorexec();
        public NEW_UPDATES()
        {
            InitializeComponent();
                    }
            
                    private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lvtotalmoney.Clear();
            con.connectionOpen();
            cust.totalMoney();
            cust.loadmoney(lvtotalmoney);
         }

        private void button1_Click(object sender, EventArgs e)
        {
        
            con.connectionOpen();
            cust.custMaximumMoney();
            cust.MaximumMoney(lvtotalmoney);
        }

        private void button2_Click(object sender, EventArgs e)
        {
       
            con.connectionOpen();
            cust.custMinimumMoney();
            cust.LMinimumMoney(lvtotalmoney);
        }
    }
}
