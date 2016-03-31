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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void m(object sender, EventArgs e)
        {
            
        }


        private void button1_Paint(object sender, PaintEventArgs e)
        {

        }

   
        Login lge = new Login();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            lge.Show();
        }

       

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button1, "Move Next Page");
        }

        
    }
}
