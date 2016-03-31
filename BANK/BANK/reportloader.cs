using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CrystalDecisions.Windows.Forms;
using System.Windows.Forms;

namespace BANK
{
    class reportloader
    {
        connectioncrystal con = new connectioncrystal();
        //method to load reports

        #region LoadReport
        public void LoadReport(CrystalReportViewer rptviewer, string Account_number)
        {
            reportCustomer rpt = new reportCustomer();
            //close the connection
            con.connectionClose();

            SqlCommand cmd = con.cmd();
            SqlDataAdapter _dapter = new SqlDataAdapter();
            _dapter.SelectCommand = new SqlCommand();
            _dapter.SelectCommand = cmd;

            cmd.CommandText = "EXECUTE reportCustomer @Account_number";
            cmd.Parameters.Add("@Account_number", System.Data.SqlDbType.NVarChar).Value = Account_number;

            DataSet dset = new DataSet();
            _dapter.Fill(dset, "DataTable1");


            //source codes for subreport
            SqlCommand cmdsub = con.cmd();
            DataSet dSetSub = new DataSet();
            SqlDataAdapter dasub = new SqlDataAdapter();
            dasub.SelectCommand = cmdsub;

            cmdsub.CommandText = "EXECUTE reportSubCustomers @Account_number";
            cmdsub.Parameters.Add("@Account_number", System.Data.SqlDbType.NVarChar).Value = Account_number;

            dasub.Fill(dSetSub, "SubDataTable");
            //Array index[0] indicates first subreport. [1] indicates second report etc.
           
            rpt.SetDataSource(dset);
           // rpt.Subreports[0].SetDataSource(dSetSub);

            rptviewer.ReportSource = rpt;

        }

        #endregion LoadReport


        //fill the combobox with Account_numbers
        #region LoadCombo
        public void LoadCustomerOnComboBox(ComboBox cboCode,string Query,string Displaymember)
        {
            try
            {
                con.connectionClose();
                cboCode.DataSource = null;

                SqlCommand cmd = con.cmd();
                SqlDataAdapter dApter = new SqlDataAdapter();
                dApter.SelectCommand = new SqlCommand();
                dApter.SelectCommand = cmd;


                cmd.CommandText = Query;
                DataSet dset = new DataSet();
                DataSet dsetSub = new DataSet();
                dApter.Fill(dset);
                dApter.Fill(dsetSub);

                cboCode.DataSource = dset.Tables[0];
                cboCode.DataSource = dsetSub.Tables[0];
                cboCode.DisplayMember = Displaymember;

                cboCode.Refresh();
                con.connectionClose();
            }
            catch(SqlException e)
            {
                MessageBox.Show("Error has occured\n" + e.Message);
            }
        }
        #endregion LoadCombo
    }
}
