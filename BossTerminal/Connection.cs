using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace BossTerminal
{
    class Connection
    {
        private static SqlConnection connection = null;

        public static SqlConnection Instance()
        {
            if (connection == null)
            {
                string connstr =
                    "Data Source=LYVXP\\SQLEXPRESS; " +
                    "Persist Security Info=True; " +
                    "Initial Catalog=libdev; " +
                    "User Id=libdev; " +
                    "Password=test; ";

                connection = new SqlConnection(connstr);
                connection.Open();
            }
            return connection;
        }
    }
}
