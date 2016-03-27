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
    public partial class Login : Form
    {
        connection con = new connection();
        UserEXEC user = new UserEXEC();
        Customer cm = new Customer();
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            con.connectionOpen();
            if(txtpassword.TextLength == 10)
            {
                cm.accountToolStripMenuItem.Enabled = false;
                cm.transactionsToolStripMenuItem.Enabled = false;
                cm.viewToolStripMenuItem.Enabled = false;


                user.validatelogin(txtusername.Text, txtpassword.Text);
                MessageBox.Show("Login successful: WELCOME MANAGER");
                this.Hide();
                cm.Show();
            }

            else if(txtpassword.TextLength == 8)
            {
                cm.accountToolStripMenuItem.Enabled = false;
                cm.userToolStripMenuItem.Enabled = false;
                cm.nEWUPDATESToolStripMenuItem.Enabled = false;

                user.validatelogin(txtusername.Text, txtpassword.Text);
                MessageBox.Show("Login successful: WELCOME CASHIER");
                this.Hide();
                cm.Show();
            }

            else if(txtpassword.TextLength ==6)
            { 
                cm.userToolStripMenuItem.Enabled = false;
                cm.transactionsToolStripMenuItem.Enabled = false;
                cm.nEWUPDATESToolStripMenuItem.Enabled = false;
                cm.viewToolStripMenuItem.Enabled = false;

                user.validatelogin(txtusername.Text, txtpassword.Text);
                MessageBox.Show("Login successful:WELCOME PERSONNEL MANAGER");
                this.Hide();
                cm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Password:TryAgain");
            }


           

        }
    }
}
