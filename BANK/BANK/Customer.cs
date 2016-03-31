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

       
        public void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Customer_Information_Form cim = new Customer_Information_Form())
            {
                cim.ShowDialog();
                cim.Dispose();
            }
            

        }

       
        public void searchUpdateAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Update_Customer_Information_Form uci = new Update_Customer_Information_Form())
            {
                uci.ShowDialog();
                uci.Dispose();
            }
            
        }

        public void allCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AllCustomers allcust = new AllCustomers())
            {
                allcust.ShowDialog();
                allcust.Dispose();
            }
                
        }

        
        public  void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (User_Form uf = new User_Form())
            {
                uf.ShowDialog();
                uf.Dispose();
            }
            
        }

        
        public void searchUpdateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Search_or_Update_User_Form souf = new Search_or_Update_User_Form())
            {
                souf.ShowDialog();
                souf.Dispose();

            }
            
        }

      
        public void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Deposit_Form df = new Deposit_Form())
            {
                df.ShowDialog();
                df.Dispose();
            }
           
        }

       
        public void withdrawalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Withdrawal_Form wf = new Withdrawal_Form())
            {
                wf.ShowDialog();
                wf.Dispose();
            }
           
        }

       
        public void balanceSheetBankStatementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Reports bs = new Reports())
            {
                bs.ShowDialog();
                bs.Dispose();

            }
           
        }

        public void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }

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
            using (NEW_UPDATES UP = new NEW_UPDATES())
            {
                UP.ShowDialog();
                UP.Dispose();
            }
                
        }

       
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (ChangePassword chng = new ChangePassword())
            {
                chng.ShowDialog();
                chng.Dispose();
            }
               
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Really Logout?","Close section", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Login lgin = new Login();
                this.Hide();
                lgin.Show();
            }
        }
          

        private void allUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AllUsers usr = new AllUsers())
            {
                usr.ShowDialog();
                usr.Dispose();
            }
                
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
