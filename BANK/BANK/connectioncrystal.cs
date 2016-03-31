using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BANK
{
    class connectioncrystal
    {
        private string strcon = ConfigurationManager.ConnectionStrings["newBank"].ToString();

        public SqlConnection connectionOpen()
        {
            SqlConnection connectionOpen = new SqlConnection(strcon);
            connectionOpen.Open();
            return connectionOpen;
        }

        public SqlCommand cmd()
        {
            SqlConnection connectionOpen = new SqlConnection(strcon);
            connectionOpen.Open();

            SqlCommand cmd = new SqlCommand();
            cmd = connectionOpen.CreateCommand();
            return cmd;
        }


        public SqlConnection connectionClose()
        {
            SqlConnection connectionClose = new SqlConnection(strcon);
            connectionClose.Close();
            return connectionClose;
        }
    }
}
