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
    public partial class Search_or_Update_User_Form : Form
    {
        connection con = new connection();
        UserEXEC user = new UserEXEC();

        string strformat;
        public Search_or_Update_User_Form()
        {
            InitializeComponent();
            strformat = "dddd , MMMM d, yyyy h:mm:ss tt";
            lblTime.Text = DateTime.Now.ToString(strformat);
            lblTime.TextAlign = ContentAlignment.MiddleCenter;

            Timer t = new Timer();
            t.Interval = 1000;
            t.Start();
            t.Tick += new EventHandler(lblTime_Click);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void txtB_Leave(object sender, EventArgs e)
        {
         if(txtusername.Text=="")
            {
                MessageBox.Show("You can't leave this field blank");
                txtusername.Focus();
            }   
        }

        private void l(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if(textBox2.Text == "")
            {
                MessageBox.Show("You can't leave this field blank");
                textBox2.Focus();
            }
        }

       

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_or_Update_User_Form_Load(object sender, EventArgs e)
        {
            con.connectionOpen();
            user.LoadBankUser(lvuser);
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString(strformat);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.connectionOpen();

            int day = Convert.ToInt32(cboday.Text);
            int year = Convert.ToInt32(cboyear.Text);
            int areacode = Convert.ToInt32(cboareacode.Text);
           

            user.updateBankUser(txtfirstname.Text, cbomdinit.Text, txtlastname.Text, day, cbomonth.Text, year, areacode, txtnumber.Text, txtaddress.Text, txtusername.Text);

            MessageBox.Show("user details updated successfully");
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void cboareacode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lvuser.Clear();
            string strSearch = txtusername.Text;
            con.connectionOpen();
            user.searchUser(lvuser, strSearch);
        }
    }
}
