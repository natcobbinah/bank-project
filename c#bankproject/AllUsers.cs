using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BANK
{
    public partial class AllUsers : Form
    {
        UserEXEC user = new UserEXEC();
        connection con = new connection();
        public AllUsers()
        {
            InitializeComponent();
        }

       

        private void AllUsers_Load(object sender, EventArgs e)
        {
            con.connectionOpen();
            user.showallbankusers(lvallusers);
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            lvallusers.Clear();
            string search = txtSearchuser.Text;
            con.connectionOpen();
            user.searchUserbysurname(lvallusers, search);
        }
    }
}
