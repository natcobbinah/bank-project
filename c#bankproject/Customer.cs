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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        public void Customer_Load(object sender, EventArgs e)
        {

        }

        public void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        Customer_Information_Form cim = new Customer_Information_Form();
        public void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            cim.Show();

        }

        Update_Customer_Information_Form uci = new Update_Customer_Information_Form();
        public void searchUpdateAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uci.Show();
        }

        public void allCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllCustomers allcust = new AllCustomers();
            allcust.Show();
        }

        User_Form uf = new User_Form();
        public  void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uf.Show();
        }

        Search_or_Update_User_Form souf = new Search_or_Update_User_Form();
        public void searchUpdateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            souf.Show();
        }

        Deposit_Form df = new Deposit_Form();
        public void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            df.Show();
        }

        Withdrawal_Form wf = new Withdrawal_Form();
        public void withdrawalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wf.Show();
        }

        Reports bs = new Reports();
        public void balanceSheetBankStatementToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            bs.Show();
        }

        public void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void changeBackgroundPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Chosen_File = "";

            if (openFD.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Operation Cancelled");
            }
            else
            {
                Chosen_File = openFD.FileName;
                pictureBox1.Image = Image.FromFile(Chosen_File);
            }
            openFD.InitialDirectory = "C:";
            openFD.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFD.FileName = "";
            openFD.Filter = "JPEG Images|*.jpg";


            Chosen_File = openFD.FileName;
        }

        private void viewUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NEW_UPDATES UP = new NEW_UPDATES();
            UP.Show();
        }

       
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword chng = new ChangePassword();
            chng.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login lgin = new Login();
            this.Hide();
            lgin.Show();
        }

        private void allUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllUsers usr = new AllUsers();
            usr.Show();
        }

        private void othersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nEWUPDATESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
