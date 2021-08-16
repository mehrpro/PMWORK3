﻿using System.Data;
using System.Data.SqlClient;

namespace PMWORK.Admin
{
    public class SqlHelper
    {
        private SqlConnection cn;

        public SqlHelper(string connectionString)
        {
            cn = new SqlConnection(connectionString);
        }

        public bool IsConnection
        {
            get
            {
                if (cn.State == ConnectionState.Closed) cn.Open();
                return true;
            }
        }

        
    }
}