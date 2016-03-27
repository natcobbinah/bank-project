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
   
    public partial class ChangePassword : Form
    {
        connection con = new connection();
        UserEXEC user = new UserEXEC();
         public ChangePassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.connectionOpen();
            if(txtnewpassword.Text == txtconfirmpassword.Text)
            {
                user.changeUserpassword(txtusername.Text, txtnewpassword.Text);
                MessageBox.Show("Password Changed Successfully");
            }
            else
            {
                MessageBox.Show("Passwords do not match");
            }

            
        }

        private void txtconfirmpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
