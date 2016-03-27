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
    public partial class Customer_Information_Form : Form
    {
        connection con = new connection();
        CUSTstorexec cust = new CUSTstorexec();

        string strformat;
        public Customer_Information_Form()
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

        private void Customer_Information_Form_Load(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString(strformat);
        }

        //private void button3_Click(object sender, EventArgs e)
        //{

            
        //    //openFD.Title = "Insert Image";
        //    //openFD.FileName = "";
        //    //openFD.Filter = "JPEG Images|*.jpg| GIF Images|*.gif| TIFF Images|*.tiff| PNG Images|*.png";
        //    //String Chosen_File = "";
        //    //Chosen_File = openFD.FileName;
        //    //pictureBox2.Image = Image.FromFile(Chosen_File);

        //    //if (openFD.ShowDialog() == DialogResult.Cancel)
        //    //{
        //    //    MessageBox.Show("Picture not Uploaded");
        //    //}
        //    //else
        //    //{
        //    //    MessageBox.Show("Upload Successful");
        //    //}

        //    //openFD.ShowDialog(); 


        //}

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            int day = Convert.ToInt32(cboDay.Text);
            int year = Convert.ToInt32(cboYear.Text);
            float balance = float.Parse(txtBalance.Text);
            

            cust.InsertBankCustomer(txtfirstname.Text,txtComboBox.Text,txtlastname.Text,txtgender.Text,txtPhone.Text,day,cboMonth.Text,year,txtAccountNumber.Text,cboTypeAccount.Text,cboTypeCustomer.Text,balance);
            MessageBox.Show("Customer details inserted successfully");

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
