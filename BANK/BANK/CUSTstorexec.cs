using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace BANK
{
    class CUSTstorexec
    {
        #region insert
        connection con = new connection();
        customern cust = new customern();

        public void InsertBankCustomer(string firstname, string middle_inital, string lastname, string gender,
            string phone_number, int Cday, string Cmonth, int Cyear, string Account_number, string Account_type,
            string Customer_type, float Balance)
        {
            string strFirstname = firstname;
            string strmiddle_initial = middle_inital;
            string strlastname = lastname;
            string strgender = gender;
            string strphone_number = phone_number;
            int strcday = Cday;
            string strcmonth = Cmonth;
            int strcyear = Cyear;
            string strAccount_number = Account_number;
            string strAccount_type = Account_type;
            string strCustomer_type = Customer_type;
            float strbalance = Balance;


            SqlCommand cmd = con.cmd();
            cmd.CommandText = "EXECUTE AddBankCustomer @firstname,@middle_initial,@lastname,@gender,@phone_number,@Cday,@Cmonth,@Cyear,@Account_number,@Account_type,@Customer_type,@Balance";

            cmd.Parameters.Add("@firstname", System.Data.SqlDbType.VarChar, 200).Value = strFirstname;
            cmd.Parameters.Add("@middle_initial", System.Data.SqlDbType.VarChar, 3).Value = strmiddle_initial;
            cmd.Parameters.Add("@lastname", System.Data.SqlDbType.VarChar, 200).Value = strlastname;
            cmd.Parameters.Add("@gender", System.Data.SqlDbType.VarChar, 200).Value = strgender;
            cmd.Parameters.Add("@phone_number", System.Data.SqlDbType.VarChar, 20).Value = strphone_number;
            cmd.Parameters.Add("@Cday", System.Data.SqlDbType.Int).Value = strcday;
            cmd.Parameters.Add("@Cmonth", System.Data.SqlDbType.VarChar, 20).Value = strcmonth;
            cmd.Parameters.Add("@Cyear", System.Data.SqlDbType.Int).Value = strcyear;
            cmd.Parameters.Add("@Account_number", System.Data.SqlDbType.VarChar, 20).Value = strAccount_number;
            cmd.Parameters.Add("@Account_type", System.Data.SqlDbType.VarChar, 40).Value = strAccount_type;
            cmd.Parameters.Add("@Customer_type", System.Data.SqlDbType.VarChar, 20).Value = strCustomer_type;
            cmd.Parameters.Add("@Balance", System.Data.SqlDbType.Float).Value = strbalance;

            cmd.ExecuteNonQuery();
            con.connectionClose();
        }

        #endregion insert


        #region update
        public void updateCustomer(string firstname, string middle_initial, string surname, int day,
            string month, int year, string phonenumber, string account_number)
        {
            string strfirstname = firstname;
            string strmiddle_initial = middle_initial;
            string strlastname = surname;
            int strcday = day;
            string strcmonth = month;
            int strcyear = year;
            string strphonenumber = phonenumber;
            string strAccountnumber = account_number;

            SqlCommand cmd = con.cmd();
            cmd.CommandText = "EXECUTE updateBankCustomer @firstname,@middle_initial,@lastname, @Cday,@Cmonth,@Cyear,@phone_number,@Account_number";

            cmd.Parameters.Add("@firstname", System.Data.SqlDbType.VarChar, 200).Value = strfirstname;
            cmd.Parameters.Add("@middle_initial", System.Data.SqlDbType.VarChar, 3).Value = strmiddle_initial;
            cmd.Parameters.Add("@lastname", System.Data.SqlDbType.VarChar, 200).Value = strlastname;
            cmd.Parameters.Add("@phone_number", System.Data.SqlDbType.VarChar, 20).Value = strphonenumber;
            cmd.Parameters.Add("@Cday", System.Data.SqlDbType.Int).Value = strcday;
            cmd.Parameters.Add("@Cmonth", System.Data.SqlDbType.VarChar, 20).Value = strcmonth;
            cmd.Parameters.Add("@Cyear", System.Data.SqlDbType.Int).Value = strcyear;
            cmd.Parameters.Add("@Account_number", System.Data.SqlDbType.VarChar, 20).Value = strAccountnumber;

            cmd.ExecuteNonQuery();
            con.connectionClose();
        }
        #endregion update


        #region depositamount

        public void updateBalance(float dpamount, string acctype, string ctype, string accnum)
        {
            float strdpamount = dpamount;
            string strAccounttype = acctype;
            string strctype = ctype;
            string straccnum = accnum;


            SqlCommand cmd = con.cmd();
            cmd.CommandText = "EXECUTE DepositCustomer @Deposit_amount,@Account_type,@Customer_type,@Account_number";

            cmd.Parameters.Add("@Account_type", System.Data.SqlDbType.VarChar, 40).Value = strAccounttype;
            cmd.Parameters.Add("@Customer_type", System.Data.SqlDbType.VarChar, 20).Value = strctype;
            cmd.Parameters.Add("@Account_number", System.Data.SqlDbType.VarChar, 20).Value = straccnum;
            cmd.Parameters.Add("@Deposit_amount", System.Data.SqlDbType.Float).Value = strdpamount;

            cmd.ExecuteNonQuery();
            con.connectionClose();

        }
        #endregion depositamount


        #region withdrawamount
        public void custWithdraw(string Accountnum, float withdrawamount)
        {
            string straccnum = Accountnum;
            float strwithdamount = withdrawamount;


            SqlCommand cmd = con.cmd();
            cmd.CommandText = "EXECUTE custWithdraw @Account_number,@Withdrawamount";

            cmd.Parameters.Add("@Account_number", System.Data.SqlDbType.VarChar, 30).Value = straccnum;
            cmd.Parameters.Add("@Withdrawamount", System.Data.SqlDbType.Float).Value = strwithdamount;

            cmd.ExecuteNonQuery();
            con.connectionClose();
        }
        #endregion withdrawamount


        #region loadlistviewcustomer
        //load customer data into listview lvcustomer
        public void LoadCustomer(ListView lvcustomer)
        {
            lvcustomer.Items.Clear();
            lvcustomer.Columns.Add("Firstname", 100, HorizontalAlignment.Left);
            lvcustomer.Columns.Add("Middle_Initial", 100, HorizontalAlignment.Left);
            lvcustomer.Columns.Add("Lastname", 100, HorizontalAlignment.Left);
            lvcustomer.Columns.Add("Gender", 50, HorizontalAlignment.Left);
            lvcustomer.Columns.Add("Phone_number", 70, HorizontalAlignment.Left);
            lvcustomer.Columns.Add("Cday", 50, HorizontalAlignment.Left);
            lvcustomer.Columns.Add("Cmonth", 70, HorizontalAlignment.Left);
            lvcustomer.Columns.Add("Cyear", 70, HorizontalAlignment.Left);
            lvcustomer.Columns.Add("Account_number", 100, HorizontalAlignment.Left);
            lvcustomer.Columns.Add("Account_type", 100, HorizontalAlignment.Left);
            lvcustomer.Columns.Add("Customer_type", 100, HorizontalAlignment.Left);
            lvcustomer.Columns.Add("Balance", 100, HorizontalAlignment.Left);

            connection con = new connection();
            //close the connection
            con.connectionClose();

            //Query string
            string querycustomer = "SELECT * FROM Customer";

            SqlCommand mySqlCommand = con.cmd();
            mySqlCommand.CommandText = querycustomer;

            SqlDataAdapter _daptCustomer = new SqlDataAdapter();
            _daptCustomer.SelectCommand = mySqlCommand;

            DataSet _dset = new DataSet();
            //filling the dataset
            _daptCustomer.Fill(_dset, "Customer");

            //load data from the dataset into the listview
            //get the table from the data set
            DataTable dtable = _dset.Tables["Customer"];

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];
                //only rows that have not been deleted

                if (drow.RowState != DataRowState.Deleted)
                {
                    //define the list view items
                    ListViewItem lvcustitems = new ListViewItem(drow["firstname"].ToString(), 0);

                    //I added and bound an imagelist to the listview
                    //it has one image with index 0 . This can be ignored
                    //lvcustitems.SubItems.Add(drow["firstname"].ToString());
                    lvcustitems.SubItems.Add(drow["middle_initial"].ToString());
                    lvcustitems.SubItems.Add(drow["lastname"].ToString());
                    lvcustitems.SubItems.Add(drow["gender"].ToString());
                    lvcustitems.SubItems.Add(drow["Phone_number"].ToString());
                    lvcustitems.SubItems.Add(drow["Cday"].ToString());
                    lvcustitems.SubItems.Add(drow["Cmonth"].ToString());
                    lvcustitems.SubItems.Add(drow["Cyear"].ToString());
                    lvcustitems.SubItems.Add(drow["Account_number"].ToString());
                    lvcustitems.SubItems.Add(drow["Account_type"].ToString());
                    lvcustitems.SubItems.Add(drow["Customer_type"].ToString());
                    lvcustitems.SubItems.Add(drow["Balance"].ToString());

                    //add the list items to the listview
                    lvcustomer.Items.Add(lvcustitems);

                }
            }
        }
        #endregion loadlistviewcustomer

        #region totalMoney in bank

        public void totalMoney()
        {
            connection con = new connection();

            SqlCommand cmd = con.cmd();
            cmd.CommandText = "EXECUTE totalMoney";

            cmd.ExecuteNonQuery();
            con.connectionClose();
        }
        #endregion totalMoney in bank

        #region loadlistview totalmoney in bank
        //load the total money in the bank to the listview

        public void loadmoney(ListView lvmoney)
        {
            lvmoney.Items.Clear();

            lvmoney.Columns.Add("Total Money in Bank", 100, HorizontalAlignment.Left);

            connection con = new connection();
            //close the connection
            con.connectionClose();
            //query string;
            string querymoney = "SELECT Balance=(SUM(Balance)) from Customer";

            SqlCommand mySqlCommand = con.cmd();
            mySqlCommand.CommandText = querymoney;

            SqlDataAdapter _daptermoney = new SqlDataAdapter();
            _daptermoney.SelectCommand = mySqlCommand;

            DataSet _dset = new DataSet();
            //fill dataset
            _daptermoney.Fill(_dset, "Customer");

            //load data from the dataset into the listview
            //get the table from the data set
            DataTable dtable = _dset.Tables["Customer"];

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];

                //only row that have not been deleted

                if (drow.RowState != DataRowState.Deleted)
                {
                    //define the list items
                    ListViewItem lvi = new ListViewItem(drow["Balance"].ToString(), 0);
                    lvi.SubItems.Add(drow["Balance"].ToString());

                    //add the list items to the listview
                    lvmoney.Items.Add(lvi);
                }
            }
        }
        #endregion loadlist view with money









        #region customer with highest money in bank
        public void custMaximumMoney()
        {
            connection con = new connection();

            SqlCommand cmd = con.cmd();
            cmd.CommandText = "EXECUTE custMaximumMoney";

            cmd.ExecuteNonQuery();
            con.connectionClose();
        }
        #endregion customer with highest money in the bank


        #region load list view the account with most money
        public void MaximumMoney(ListView lvmoney)
        {
            lvmoney.Items.Clear();

            lvmoney.Columns.Add("Customer with the Highest Balance", 200, HorizontalAlignment.Left);

            connection con = new connection();
            //close the connection
            con.connectionClose();
            //query string;
            string querymoney = "SELECT lastname,firstname,phone_number,Balance from Customer where Balance=(SELECT MAX(Balance) from Customer)";

            SqlCommand mySqlCommand = con.cmd();
            mySqlCommand.CommandText = querymoney;

            SqlDataAdapter _daptermoney = new SqlDataAdapter();
            _daptermoney.SelectCommand = mySqlCommand;

            DataSet _dset = new DataSet();
            //fill dataset
            _daptermoney.Fill(_dset, "Customer");

            //load data from the dataset into the listview
            //get the table from the data set
            DataTable dtable = _dset.Tables["Customer"];

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];

                //only row that have not been deleted

                if (drow.RowState != DataRowState.Deleted)
                {
                    //define the list items
                    ListViewItem lvi = new ListViewItem(drow["firstname"].ToString(), 0);
                    lvi.SubItems.Add(drow["lastname"].ToString());
                    lvi.SubItems.Add(drow["Balance"].ToString());
                    lvi.SubItems.Add(drow["phone_number"].ToString());

                    //add the list items to the listview
                    lvmoney.Items.Add(lvi);
                }
            }
        }

        #endregion account with most money in the bank




        #region customer with highest money in bank
        public void custMinimumMoney()
        {
            connection con = new connection();

            SqlCommand cmd = con.cmd();
            cmd.CommandText = "EXECUTE custMinMoney";

            cmd.ExecuteNonQuery();
            con.connectionClose();
        }
        #endregion customer with highest money in the bank


        #region load list view the account with most money
        public void LMinimumMoney(ListView lvmoney)
        {
            lvmoney.Items.Clear();

            lvmoney.Columns.Add("Customer with the Highest Balance", 200, HorizontalAlignment.Left);

            connection con = new connection();
            //close the connection
            con.connectionClose();
            //query string;
            string querymoney = "SELECT lastname,firstname,phone_number,Balance from Customer where Balance=(SELECT MIN(Balance) from Customer)";

            SqlCommand mySqlCommand = con.cmd();
            mySqlCommand.CommandText = querymoney;

            SqlDataAdapter _daptermoney = new SqlDataAdapter();
            _daptermoney.SelectCommand = mySqlCommand;

            DataSet _dset = new DataSet();
            //fill dataset
            _daptermoney.Fill(_dset, "Customer");

            //load data from the dataset into the listview
            //get the table from the data set
            DataTable dtable = _dset.Tables["Customer"];

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];

                //only row that have not been deleted

                if (drow.RowState != DataRowState.Deleted)
                {
                    //define the list items
                    ListViewItem lvi = new ListViewItem(drow["firstname"].ToString(), 0);
                    lvi.SubItems.Add(drow["lastname"].ToString());
                    lvi.SubItems.Add(drow["Balance"].ToString());
                    lvi.SubItems.Add(drow["phone_number"].ToString());

                    //add the list items to the listview
                    lvmoney.Items.Add(lvi);
                }
            }
        }

        #endregion account with most money in the bank


        #region search for customer by accountnumber
        public void SearchCustomer(ListView lvcustomer, string searchbox)
        {
            lvcustomer.Items.Clear();
            lvcustomer.Columns.Add("Firstname", 100, HorizontalAlignment.Left);
            lvcustomer.Columns.Add("Middle_Initial", 100, HorizontalAlignment.Left);
            lvcustomer.Columns.Add("Lastname", 100, HorizontalAlignment.Left);
            lvcustomer.Columns.Add("Gender", 50, HorizontalAlignment.Left);
            lvcustomer.Columns.Add("Phone_number", 70, HorizontalAlignment.Left);
            lvcustomer.Columns.Add("Cday", 50, HorizontalAlignment.Left);
            lvcustomer.Columns.Add("Cmonth", 70, HorizontalAlignment.Left);
            lvcustomer.Columns.Add("Cyear", 70, HorizontalAlignment.Left);
            lvcustomer.Columns.Add("Account_number", 100, HorizontalAlignment.Left);
            lvcustomer.Columns.Add("Account_type", 100, HorizontalAlignment.Left);
            lvcustomer.Columns.Add("Customer_type", 100, HorizontalAlignment.Left);
            lvcustomer.Columns.Add("Balance", 100, HorizontalAlignment.Left);

            connection con = new connection();
            //close the connection
            con.connectionClose();

            //Query string
            string querycustomer = "SELECT * FROM Customer WHERE Account_number = '" + searchbox + "'";

            SqlCommand mySqlCommand = con.cmd();
            mySqlCommand.CommandText = querycustomer;

            SqlDataAdapter _daptCustomer = new SqlDataAdapter();
            _daptCustomer.SelectCommand = mySqlCommand;

            DataSet _dset = new DataSet();
            //filling the dataset
            _daptCustomer.Fill(_dset, "Customer");

            //load data from the dataset into the listview
            //get the table from the data set
            DataTable dtable = _dset.Tables["Customer"];

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];
                //only rows that have not been deleted

                if (drow.RowState != DataRowState.Deleted)
                {
                    //define the list view items
                    ListViewItem lvcustitems = new ListViewItem(drow["firstname"].ToString(), 0);

                    //I added and bound an imagelist to the listview
                    //it has one image with index 0 . This can be ignored
                    //lvcustitems.SubItems.Add(drow["firstname"].ToString());
                    lvcustitems.SubItems.Add(drow["middle_initial"].ToString());
                    lvcustitems.SubItems.Add(drow["lastname"].ToString());
                    lvcustitems.SubItems.Add(drow["gender"].ToString());
                    lvcustitems.SubItems.Add(drow["Phone_number"].ToString());
                    lvcustitems.SubItems.Add(drow["Cday"].ToString());
                    lvcustitems.SubItems.Add(drow["Cmonth"].ToString());
                    lvcustitems.SubItems.Add(drow["Cyear"].ToString());
                    lvcustitems.SubItems.Add(drow["Account_number"].ToString());
                    lvcustitems.SubItems.Add(drow["Account_type"].ToString());
                    lvcustitems.SubItems.Add(drow["Customer_type"].ToString());
                    lvcustitems.SubItems.Add(drow["Balance"].ToString());

                    //add the list items to the listview
                    lvcustomer.Items.Add(lvcustitems);

                }
            }
        }
        #endregion search for customer by accountnumber



        #region delete customer
        public void DeleteCustomer(string Accountnumber)
        {
            string strAccountnum = Accountnumber;

            connection con = new connection();
            SqlCommand cmd = con.cmd();

            cmd.CommandText = "EXECUTE deleteCustomer @Accountnumber";

            cmd.Parameters.Add("@Accountnumber", System.Data.SqlDbType.NVarChar, 40).Value = strAccountnum;

            cmd.ExecuteNonQuery();
            con.connectionClose();
        }
        #endregion delete customer






        #region view all customers in the bank

        public void loadallcustomer(ListView lvloadall)
        {
            lvloadall.Items.Clear();
            lvloadall.Columns.Add("Firstname", 100, HorizontalAlignment.Left);
            lvloadall.Columns.Add("Middle_Initial", 100, HorizontalAlignment.Left);
            lvloadall.Columns.Add("Lastname", 100, HorizontalAlignment.Left);
            lvloadall.Columns.Add("Gender", 50, HorizontalAlignment.Left);
            lvloadall.Columns.Add("Phone_number", 70, HorizontalAlignment.Left);
            lvloadall.Columns.Add("Cday", 50, HorizontalAlignment.Left);
            lvloadall.Columns.Add("Cmonth", 70, HorizontalAlignment.Left);
            lvloadall.Columns.Add("Cyear", 70, HorizontalAlignment.Left);
            lvloadall.Columns.Add("Account_number", 100, HorizontalAlignment.Left);
            lvloadall.Columns.Add("Account_type", 100, HorizontalAlignment.Left);
            lvloadall.Columns.Add("Customer_type", 100, HorizontalAlignment.Left);

            connection con = new connection();
            //close the connection
            con.connectionClose();

            //Query string
            string allcustomers = "SELECT * from Customer";

            SqlCommand mySqlCommand = con.cmd();
            mySqlCommand.CommandText = allcustomers;

            SqlDataAdapter _daptCustomer = new SqlDataAdapter();
            _daptCustomer.SelectCommand = mySqlCommand;

            DataSet _dset = new DataSet();
            //filling the dataset
            _daptCustomer.Fill(_dset, "Customer");

            //load data from the dataset into the listview
            //get the table from the data set
            DataTable dtable = _dset.Tables["Customer"];

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];
                //only rows that have not been deleted

                if (drow.RowState != DataRowState.Deleted)
                {
                    //define the list view items
                    ListViewItem lvallcustomers = new ListViewItem(drow["firstname"].ToString(), 0);

                    //I added and bound an imagelist to the listview
                    //it has one image with index 0 . This can be ignored
                    //lvcustitems.SubItems.Add(drow["firstname"].ToString());
                    lvallcustomers.SubItems.Add(drow["middle_initial"].ToString());
                    lvallcustomers.SubItems.Add(drow["lastname"].ToString());
                    lvallcustomers.SubItems.Add(drow["gender"].ToString());
                    lvallcustomers.SubItems.Add(drow["Phone_number"].ToString());
                    lvallcustomers.SubItems.Add(drow["Cday"].ToString());
                    lvallcustomers.SubItems.Add(drow["Cmonth"].ToString());
                    lvallcustomers.SubItems.Add(drow["Cyear"].ToString());
                    lvallcustomers.SubItems.Add(drow["Account_number"].ToString());
                    lvallcustomers.SubItems.Add(drow["Account_type"].ToString());
                    lvallcustomers.SubItems.Add(drow["Customer_type"].ToString());

                    //add the list items to the listview
                    lvloadall.Items.Add(lvallcustomers);
                }
            }
        }
        #endregion view all customers in the bank






        #region search for customer by surname
        public void SearchCustomerbylastname(ListView lvloadall, string searchbox)
        {
            lvloadall.Items.Clear();
            lvloadall.Columns.Add("Firstname", 100, HorizontalAlignment.Left);
            lvloadall.Columns.Add("Middle_Initial", 100, HorizontalAlignment.Left);
            lvloadall.Columns.Add("Lastname", 100, HorizontalAlignment.Left);
            lvloadall.Columns.Add("Gender", 50, HorizontalAlignment.Left);
            lvloadall.Columns.Add("Phone_number", 70, HorizontalAlignment.Left);
            lvloadall.Columns.Add("Cday", 50, HorizontalAlignment.Left);
            lvloadall.Columns.Add("Cmonth", 70, HorizontalAlignment.Left);
            lvloadall.Columns.Add("Cyear", 70, HorizontalAlignment.Left);
            lvloadall.Columns.Add("Account_number", 100, HorizontalAlignment.Left);
            lvloadall.Columns.Add("Account_type", 100, HorizontalAlignment.Left);
            lvloadall.Columns.Add("Customer_type", 100, HorizontalAlignment.Left);

            connection con = new connection();
            //close the connection
            con.connectionClose();

            //Query string
            string loadallcustomer = "SELECT * FROM Customer WHERE lastname = '" + searchbox + "'";

            SqlCommand mySqlCommand = con.cmd();
            mySqlCommand.CommandText = loadallcustomer;

            SqlDataAdapter _daptCustomer = new SqlDataAdapter();
            _daptCustomer.SelectCommand = mySqlCommand;

            DataSet _dset = new DataSet();
            //filling the dataset
            _daptCustomer.Fill(_dset, "Customer");

            //load data from the dataset into the listview
            //get the table from the data set
            DataTable dtable = _dset.Tables["Customer"];

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];
                //only rows that have not been deleted

                if (drow.RowState != DataRowState.Deleted)
                {
                    //define the list view items
                    ListViewItem lvloadallcustitems = new ListViewItem(drow["firstname"].ToString(), 0);

                    //I added and bound an imagelist to the listview
                    //it has one image with index 0 . This can be ignored
                    //lvcustitems.SubItems.Add(drow["firstname"].ToString());
                    lvloadallcustitems.SubItems.Add(drow["middle_initial"].ToString());
                    lvloadallcustitems.SubItems.Add(drow["lastname"].ToString());
                    lvloadallcustitems.SubItems.Add(drow["gender"].ToString());
                    lvloadallcustitems.SubItems.Add(drow["Phone_number"].ToString());
                    lvloadallcustitems.SubItems.Add(drow["Cday"].ToString());
                    lvloadallcustitems.SubItems.Add(drow["Cmonth"].ToString());
                    lvloadallcustitems.SubItems.Add(drow["Cyear"].ToString());
                    lvloadallcustitems.SubItems.Add(drow["Account_number"].ToString());
                    lvloadallcustitems.SubItems.Add(drow["Account_type"].ToString());
                    lvloadallcustitems.SubItems.Add(drow["Customer_type"].ToString());

                    //add the list items to the listview
                    lvloadall.Items.Add(lvloadallcustitems);

                }
            }
        }
        #endregion search for customer by surname
    }
}
