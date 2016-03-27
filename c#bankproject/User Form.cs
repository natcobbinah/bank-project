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
    public partial class User_Form : Form
    {
        connection con = new connection();
        UserEXEC user = new UserEXEC();
        string strformat;
        public User_Form()
        {
            InitializeComponent();
            strformat = "dddd , MMMM d, yyyy h:mm:ss tt";
            lblTime.Text = DateTime.Now.ToString(strformat);
            lblTime.TextAlign = ContentAlignment.MiddleCenter;

            Timer t = new Timer();
            t.Interval = 1000;
            t.Start();
            t.Tick += new EventHandler(label10_Click);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            //////if(textBox1.Text == "")
            //////{
            //////    MessageBox.Show("You can't leave this field blank");
            //////    textBox1.Focus();
            //////}
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            //if(txtBusername.Text == "")
            //{
            //    MessageBox.Show("You can't leave this field blank");
            //}
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
        //    if(txtBpassword.Text == "")
        //    {
        //        MessageBox.Show("You can't leave this field blank");
        //    }
        }

        private void User_Form_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        

        private void label10_Click(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString(strformat);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.connectionOpen();

            int day = Convert.ToInt32(txtBday.Text);
            int year = Convert.ToInt32(txtByear.Text);

            user.InsertBankUser(txtfirstname.Text,txtmiddinit.Text,txtlastname.Text,txtgender.Text,day,txtBmonth.Text,year,txtBtype.Text,txtBareacode.Text,txtnumber.Text,txtBaddress.Text,txtBusername.Text,txtBpassword.Text);

            MessageBox.Show("Employee details inserted successfully");
        }
    }
}
