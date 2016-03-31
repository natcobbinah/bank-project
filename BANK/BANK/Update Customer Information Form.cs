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
    public partial class Update_Customer_Information_Form : Form
    {
        connection con = new connection();
        CUSTstorexec cust = new CUSTstorexec();

        string strformat;
        public Update_Customer_Information_Form()
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




        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Update_Customer_Information_Form_Load(object sender, EventArgs e)
        {
            con.connectionOpen();
            cust.LoadCustomer(lvcustomer);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString(strformat);
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            con.connectionOpen();
            if ((txtFirstname.Text =="") && (txtAccount.Text =="") && (cboDay.Text=="")&&(cboYear.Text==""))
            {
                MessageBox.Show(("Please fill in Required Details"));
            }

            else
            {
                int day = Convert.ToInt32(cboDay.Text);
                int year = Convert.ToInt32(cboYear.Text);

                cust.updateCustomer(txtFirstname.Text, txtmidinit.Text, txtSurname.Text, day, cboMonth.Text, year, txtPhone.Text, txtAccount.Text);
                MessageBox.Show("updation successfully done");
            }

           
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void lvcustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            lvcustomer.Clear();
            string strSearch = txtAccount.Text;
            con.connectionOpen();
            cust.SearchCustomer(lvcustomer, strSearch);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.connectionOpen();
            if (txtAccount.Text == "")
            {
                MessageBox.Show("Please Enter Account Number");
            }
            else
            {
                if (MessageBox.Show("Do you want to delete Customer?", "Delete Customer", MessageBoxButtons.OKCancel) ==
                    DialogResult.OK)

                {
                    cust.DeleteCustomer(txtAccount.Text);
                    MessageBox.Show("Customer deleted successfully");
                }
            }

        }

        private void lvcustomer_DockChanged(object sender, EventArgs e)
        {

        }

        private void lvcustomer_DoubleClick(object sender, EventArgs e)
        {
            con.connectionOpen();
            SqlCommand cmd = con.cmd();
            cmd.Connection = con.connectionOpen();
            string query = "select Account_number,firstname,middle_initial,lastname,Cday,Cmonth,Cyear,phone_number from Customer where Account_number ='" + lvcustomer.FocusedItem.Text + "'";

            cmd.CommandText = query;
            con.connectionOpen();

            SqlDataReader mySqlDataReader = cmd.ExecuteReader();
            while (mySqlDataReader.Read())
            {
                txtAccount.Text = mySqlDataReader["Account_number"].ToString();
                txtFirstname.Text = mySqlDataReader["firstname"].ToString();
                txtmidinit.Text = mySqlDataReader["middle_initial"].ToString();
                txtSurname.Text = mySqlDataReader["lastname"].ToString();
                cboDay.Text = mySqlDataReader["Cday"].ToString();
                cboMonth.Text = mySqlDataReader["Cmonth"].ToString();
                cboYear.Text = mySqlDataReader["Cyear"].ToString();
                txtPhone.Text = mySqlDataReader["phone_number"].ToString();
            }
            mySqlDataReader.Close();
        }
    }
}