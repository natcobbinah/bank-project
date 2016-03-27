using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace BANK
{
    class UserEXEC
    {
        #region insert
        connection con = new connection();
        customern cust = new customern();

        public void InsertBankUser(string firstname, string middle_inital, string lastname, string gender,
            int Bday, string Bmonth, int Byear, string Btype, string Bareacode, string Bnumber, string Baddress, string Busername, string Bpassword)
        {
            string strFirstname = firstname;
            string strmiddle_initial = middle_inital;
            string strlastname = lastname;
            string strgender = gender;
            int strbd = Bday;
            string strbmonth = Bmonth;
            int strbyear = Byear;
            string strbtype = Btype;
            string strbareacode = Bareacode;
            string strbnumber = Bnumber;
            string strbaddress = Baddress;
            string strbusername = Busername;
            string strbpassword = Bpassword;





            SqlCommand cmd = con.cmd();
            cmd.CommandText = "EXECUTE AddBankUser @firstname,@middle_initial,@lastname,@gender,@Bday,@Bmonth,@Byear,@Btype,@Bareacode,@Bnumber,@Baddress,@Busername,@Bpassword";

            cmd.Parameters.Add("@firstname", System.Data.SqlDbType.VarChar, 200).Value = strFirstname;
            cmd.Parameters.Add("@middle_initial", System.Data.SqlDbType.VarChar, 3).Value = strmiddle_initial;
            cmd.Parameters.Add("@lastname", System.Data.SqlDbType.VarChar, 200).Value = strlastname;
            cmd.Parameters.Add("@gender", System.Data.SqlDbType.VarChar, 200).Value = strgender;
            cmd.Parameters.Add("@Bday", System.Data.SqlDbType.Int, 20).Value = strbd;
            cmd.Parameters.Add("@Bmonth", System.Data.SqlDbType.VarChar, 20).Value = strbmonth;
            cmd.Parameters.Add("@Byear", System.Data.SqlDbType.Int).Value = strbyear;
            cmd.Parameters.Add("@Btype", System.Data.SqlDbType.VarChar, 20).Value = strbtype;
            cmd.Parameters.Add("@Bareacode", System.Data.SqlDbType.VarChar, 40).Value = strbareacode;
            cmd.Parameters.Add("@Bnumber", System.Data.SqlDbType.VarChar, 20).Value = strbnumber;
            cmd.Parameters.Add("@Baddress", System.Data.SqlDbType.VarChar).Value = strbaddress;
            cmd.Parameters.Add("@Busername", System.Data.SqlDbType.VarChar).Value = strbusername;
            cmd.Parameters.Add("@Bpassword", System.Data.SqlDbType.VarChar).Value = strbpassword;

            cmd.ExecuteNonQuery();
            con.connectionClose();
        }

        #endregion insert


        #region update
        public void updateBankUser(string firstname, string middle_initial, string lastname, int day, string month, int year,
            int areacode, string number, string address, string username)
        {
            string strfirstname = firstname;
            string strmiddle_initial = middle_initial;
            string strlastname = lastname;
            int strday = day;
            string strmonth = month;
            int stryear = year;
            int strareacode = areacode;
            string strnumber = number;
            string straddress = address;
            string strusername = username;

            SqlCommand cmd = con.cmd();
            cmd.CommandText = "EXECUTE updateBankUser @firstname,@middle_initial,@lastname,@Bday,@Bmonth,@Byear,@Bareacode,@Bnumber,@Baddress,@Busername";

            cmd.Parameters.Add("@firstname", System.Data.SqlDbType.VarChar, 200).Value = strfirstname;
            cmd.Parameters.Add("@middle_initial", System.Data.SqlDbType.VarChar, 3).Value = strmiddle_initial;
            cmd.Parameters.Add("@lastname", System.Data.SqlDbType.VarChar, 200).Value = strlastname;
            cmd.Parameters.Add("@Bday", System.Data.SqlDbType.Int, 20).Value = strday;
            cmd.Parameters.Add("@Bmonth", System.Data.SqlDbType.VarChar, 20).Value = strmonth;
            cmd.Parameters.Add("@Byear", System.Data.SqlDbType.Int).Value = year;
            cmd.Parameters.Add("@Bareacode", System.Data.SqlDbType.Int, 40).Value = areacode;
            cmd.Parameters.Add("@Bnumber", System.Data.SqlDbType.VarChar, 40).Value = number;
            cmd.Parameters.Add("@Baddress", System.Data.SqlDbType.VarChar, 100).Value = address;
            cmd.Parameters.Add("@Busername", System.Data.SqlDbType.VarChar, 40).Value = username;

            cmd.ExecuteNonQuery();
            con.connectionClose();
        }

        #endregion update user


        #region loadlistviewBankUser
        //load customer data into listview lvcustomer
        public void LoadBankUser(ListView lvuser)
        {
            lvuser.Items.Clear();
            lvuser.Columns.Add("Firstname", 100, HorizontalAlignment.Left);
            lvuser.Columns.Add("Middle_Initial", 100, HorizontalAlignment.Left);
            lvuser.Columns.Add("Lastname", 100, HorizontalAlignment.Left);
            lvuser.Columns.Add("Gender", 50, HorizontalAlignment.Left);
            lvuser.Columns.Add("Day", 50, HorizontalAlignment.Left);
            lvuser.Columns.Add("Month", 70, HorizontalAlignment.Left);
            lvuser.Columns.Add("Year", 70, HorizontalAlignment.Left);
            lvuser.Columns.Add("Type", 100, HorizontalAlignment.Left);
            lvuser.Columns.Add("AreaCode", 100, HorizontalAlignment.Left);
            lvuser.Columns.Add("Phone_Number", 100, HorizontalAlignment.Left);
            lvuser.Columns.Add("Address", 100, HorizontalAlignment.Left);
            lvuser.Columns.Add("Username", 100, HorizontalAlignment.Left);
            lvuser.Columns.Add("Password", 100, HorizontalAlignment.Left);

            connection con = new connection();
            //close the connection
            con.connectionClose();

            //Query string
            string queryuser = "SELECT * FROM BankUser";

            SqlCommand mySqlCommand = con.cmd();
            mySqlCommand.CommandText = queryuser;

            SqlDataAdapter _daptUser = new SqlDataAdapter();
            _daptUser.SelectCommand = mySqlCommand;

            DataSet _dset = new DataSet();
            //filling the dataset
            _daptUser.Fill(_dset, "BankUser");

            //load data from the dataset into the listview
            //get the table from the data set
            DataTable dtable = _dset.Tables["BankUser"];

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];
                //only rows that have not been deleted

                if (drow.RowState != DataRowState.Deleted)
                {
                    //define the list view items
                    ListViewItem lvuseritems = new ListViewItem(drow["firstname"].ToString(), 0);

                    //I added and bound an imagelist to the listview
                    //it has one image with index 0 . This can be ignored
                    //lvcustitems.SubItems.Add(drow["firstname"].ToString());
                    lvuseritems.SubItems.Add(drow["middle_Initial"].ToString());
                    lvuseritems.SubItems.Add(drow["lastname"].ToString());
                    lvuseritems.SubItems.Add(drow["gender"].ToString());
                    lvuseritems.SubItems.Add(drow["Bday"].ToString());
                    lvuseritems.SubItems.Add(drow["Bmomth"].ToString());
                    lvuseritems.SubItems.Add(drow["Byear"].ToString());
                    lvuseritems.SubItems.Add(drow["Btype"].ToString());
                    lvuseritems.SubItems.Add(drow["Bareacode"].ToString());
                    lvuseritems.SubItems.Add(drow["Bnumber"].ToString());
                    lvuseritems.SubItems.Add(drow["Baddress"].ToString());
                    lvuseritems.SubItems.Add(drow["Busername"].ToString());
                    lvuseritems.SubItems.Add(drow["Bpassword"].ToString());

                    //add the list items to the listview
                    lvuser.Items.Add(lvuseritems);

                }
            }
        }
        #endregion loadlistviewcustomer


        #region search for user by username
        public void searchUser(ListView lvuser, string searchbox)
        {
            lvuser.Items.Clear();
            lvuser.Columns.Add("Firstname", 100, HorizontalAlignment.Left);
            lvuser.Columns.Add("Middle_Initial", 100, HorizontalAlignment.Left);
            lvuser.Columns.Add("Lastname", 100, HorizontalAlignment.Left);
            lvuser.Columns.Add("Gender", 50, HorizontalAlignment.Left);
            lvuser.Columns.Add("Day", 50, HorizontalAlignment.Left);
            lvuser.Columns.Add("Month", 70, HorizontalAlignment.Left);
            lvuser.Columns.Add("Year", 70, HorizontalAlignment.Left);
            lvuser.Columns.Add("Type", 100, HorizontalAlignment.Left);
            lvuser.Columns.Add("AreaCode", 100, HorizontalAlignment.Left);
            lvuser.Columns.Add("Phone_Number", 100, HorizontalAlignment.Left);
            lvuser.Columns.Add("Address", 100, HorizontalAlignment.Left);
            lvuser.Columns.Add("Username", 100, HorizontalAlignment.Left);
            lvuser.Columns.Add("Password", 100, HorizontalAlignment.Left);

            connection con = new connection();
            //close the connection
            con.connectionClose();

            //Query string
            string queryuser = "SELECT * FROM BankUser WHERE  Busername = '" + searchbox + "'";

            SqlCommand mySqlCommand = con.cmd();
            mySqlCommand.CommandText = queryuser;

            SqlDataAdapter _daptUser = new SqlDataAdapter();
            _daptUser.SelectCommand = mySqlCommand;

            DataSet _dset = new DataSet();
            //filling the dataset
            _daptUser.Fill(_dset, "BankUser");

            //load data from the dataset into the listview
            //get the table from the data set
            DataTable dtable = _dset.Tables["BankUser"];

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];
                //only rows that have not been deleted

                if (drow.RowState != DataRowState.Deleted)
                {
                    //define the list view items
                    ListViewItem lvuseritems = new ListViewItem(drow["firstname"].ToString(), 0);

                    //I added and bound an imagelist to the listview
                    //it has one image with index 0 . This can be ignored
                    //lvcustitems.SubItems.Add(drow["firstname"].ToString());
                    lvuseritems.SubItems.Add(drow["middle_Initial"].ToString());
                    lvuseritems.SubItems.Add(drow["lastname"].ToString());
                    lvuseritems.SubItems.Add(drow["gender"].ToString());
                    lvuseritems.SubItems.Add(drow["Bday"].ToString());
                    lvuseritems.SubItems.Add(drow["Bmomth"].ToString());
                    lvuseritems.SubItems.Add(drow["Byear"].ToString());
                    lvuseritems.SubItems.Add(drow["Btype"].ToString());
                    lvuseritems.SubItems.Add(drow["Bareacode"].ToString());
                    lvuseritems.SubItems.Add(drow["Bnumber"].ToString());
                    lvuseritems.SubItems.Add(drow["Baddress"].ToString());
                    lvuseritems.SubItems.Add(drow["Busername"].ToString());
                    lvuseritems.SubItems.Add(drow["Bpassword"].ToString());

                    //add the list items to the listview
                    lvuser.Items.Add(lvuseritems);

                }
            }
        }
        #endregion search for user by username


        #region login verification
        public void validatelogin(string username, string userpassword)
        {
            string struname = username;
            string strupass = userpassword;

            SqlCommand cmd = con.cmd();

            cmd.CommandText = "EXECUTE LoginAccessuser @username, @upassword";

            cmd.Parameters.Add("@username", System.Data.SqlDbType.NVarChar, 20).Value = struname;
            cmd.Parameters.Add("@upassword", System.Data.SqlDbType.NVarChar, 20).Value = strupass;

            cmd.ExecuteNonQuery();
            con.connectionClose();
        }

        #endregion login verification

        #region change password
        public void changeUserpassword(string username, string password)
        {
            string struname = username;
            string strpassword = password;

            SqlCommand cmd = con.cmd();
            cmd.CommandText = "EXECUTE changepassword @username,@upassword";

            cmd.Parameters.Add("@username", System.Data.SqlDbType.NVarChar, 20).Value = struname;
            cmd.Parameters.Add("@upassword", System.Data.SqlDbType.NVarChar, 20).Value = strpassword;

            cmd.ExecuteNonQuery();
            con.connectionClose();
        }
        #endregion change password





        #region showall users

        public void showallbankusers(ListView lvuser)
        {
            lvuser.Items.Clear();
            lvuser.Columns.Add("Firstname", 100, HorizontalAlignment.Left);
            lvuser.Columns.Add("Middle_Initial", 100, HorizontalAlignment.Left);
            lvuser.Columns.Add("Lastname", 100, HorizontalAlignment.Left);
            lvuser.Columns.Add("Gender", 50, HorizontalAlignment.Left);
            lvuser.Columns.Add("Day", 50, HorizontalAlignment.Left);
            lvuser.Columns.Add("Month", 70, HorizontalAlignment.Left);
            lvuser.Columns.Add("Year", 70, HorizontalAlignment.Left);
            lvuser.Columns.Add("Type", 100, HorizontalAlignment.Left);
            lvuser.Columns.Add("AreaCode", 100, HorizontalAlignment.Left);
            lvuser.Columns.Add("Phone_Number", 100, HorizontalAlignment.Left);
            lvuser.Columns.Add("Address", 100, HorizontalAlignment.Left);

            connection con = new connection();
            //close the connection
            con.connectionClose();

            //Query string
            string queryuser = "SELECT * FROM BankUser";

            SqlCommand mySqlCommand = con.cmd();
            mySqlCommand.CommandText = queryuser;

            SqlDataAdapter _daptUser = new SqlDataAdapter();
            _daptUser.SelectCommand = mySqlCommand;

            DataSet _dset = new DataSet();
            //filling the dataset
            _daptUser.Fill(_dset, "BankUser");

            //load data from the dataset into the listview
            //get the table from the data set
            DataTable dtable = _dset.Tables["BankUser"];

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];
                //only rows that have not been deleted

                if (drow.RowState != DataRowState.Deleted)
                {
                    //define the list view items
                    ListViewItem lvuseritems = new ListViewItem(drow["firstname"].ToString(), 0);

                    //I added and bound an imagelist to the listview
                    //it has one image with index 0 . This can be ignored
                    //lvcustitems.SubItems.Add(drow["firstname"].ToString());
                    lvuseritems.SubItems.Add(drow["middle_Initial"].ToString());
                    lvuseritems.SubItems.Add(drow["lastname"].ToString());
                    lvuseritems.SubItems.Add(drow["gender"].ToString());
                    lvuseritems.SubItems.Add(drow["Bday"].ToString());
                    lvuseritems.SubItems.Add(drow["Bmomth"].ToString());
                    lvuseritems.SubItems.Add(drow["Byear"].ToString());
                    lvuseritems.SubItems.Add(drow["Btype"].ToString());
                    lvuseritems.SubItems.Add(drow["Bareacode"].ToString());
                    lvuseritems.SubItems.Add(drow["Bnumber"].ToString());
                    lvuseritems.SubItems.Add(drow["Baddress"].ToString());

                    //add the list items to the listview
                    lvuser.Items.Add(lvuseritems);


                }
            }
        }
        #endregion showall users







        #region search for user by surname
        public void searchUserbysurname(ListView lvuser, string searchbox)
        {
            lvuser.Items.Clear();
            lvuser.Columns.Add("Firstname", 100, HorizontalAlignment.Left);
            lvuser.Columns.Add("Middle_Initial", 100, HorizontalAlignment.Left);
            lvuser.Columns.Add("Lastname", 100, HorizontalAlignment.Left);
            lvuser.Columns.Add("Gender", 50, HorizontalAlignment.Left);
            lvuser.Columns.Add("Day", 50, HorizontalAlignment.Left);
            lvuser.Columns.Add("Month", 70, HorizontalAlignment.Left);
            lvuser.Columns.Add("Year", 70, HorizontalAlignment.Left);
            lvuser.Columns.Add("Type", 100, HorizontalAlignment.Left);
            lvuser.Columns.Add("AreaCode", 100, HorizontalAlignment.Left);
            lvuser.Columns.Add("Phone_Number", 100, HorizontalAlignment.Left);
            lvuser.Columns.Add("Address", 100, HorizontalAlignment.Left);

            connection con = new connection();
            //close the connection
            con.connectionClose();

            //Query string
            string queryuser = "SELECT * FROM BankUser WHERE  lastname= '" + searchbox + "'";

            SqlCommand mySqlCommand = con.cmd();
            mySqlCommand.CommandText = queryuser;

            SqlDataAdapter _daptUser = new SqlDataAdapter();
            _daptUser.SelectCommand = mySqlCommand;

            DataSet _dset = new DataSet();
            //filling the dataset
            _daptUser.Fill(_dset, "BankUser");

            //load data from the dataset into the listview
            //get the table from the data set
            DataTable dtable = _dset.Tables["BankUser"];

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];
                //only rows that have not been deleted

                if (drow.RowState != DataRowState.Deleted)
                {
                    //define the list view items
                    ListViewItem lvuseritems = new ListViewItem(drow["firstname"].ToString(), 0);

                    //I added and bound an imagelist to the listview
                    //it has one image with index 0 . This can be ignored
                    //lvcustitems.SubItems.Add(drow["firstname"].ToString());
                    lvuseritems.SubItems.Add(drow["middle_Initial"].ToString());
                    lvuseritems.SubItems.Add(drow["lastname"].ToString());
                    lvuseritems.SubItems.Add(drow["gender"].ToString());
                    lvuseritems.SubItems.Add(drow["Bday"].ToString());
                    lvuseritems.SubItems.Add(drow["Bmomth"].ToString());
                    lvuseritems.SubItems.Add(drow["Byear"].ToString());
                    lvuseritems.SubItems.Add(drow["Btype"].ToString());
                    lvuseritems.SubItems.Add(drow["Bareacode"].ToString());
                    lvuseritems.SubItems.Add(drow["Bnumber"].ToString());
                    lvuseritems.SubItems.Add(drow["Baddress"].ToString());
                    lvuseritems.SubItems.Add(drow["Busername"].ToString());
                    lvuseritems.SubItems.Add(drow["Bpassword"].ToString());

                    //add the list items to the listview
                    lvuser.Items.Add(lvuseritems);

                }
            }
        }
        #endregion search for user by surname
    }
}
