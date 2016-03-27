using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BANK
{
    class connection
    {
        //connection string
        private string con = @"server=DESKTOP-B2LHEU9;database=newBank;Trusted_Connection=Yes";

        public SqlConnection connectionOpen()
        {
             SqlConnection connectionOpen = new SqlConnection(con);
             connectionOpen.Open();
             return connectionOpen;
        }


        public SqlCommand cmd()
        {
            SqlConnection connectionOpen = new SqlConnection(con);
            connectionOpen.Open();

            SqlCommand cmd = new SqlCommand();
            cmd = connectionOpen.CreateCommand();
            return cmd;
        }

        public SqlConnection connectionClose()
        {
            SqlConnection connectionClose = new SqlConnection(con);
            connectionClose.Close();
            return connectionClose;
        }
    }
}
