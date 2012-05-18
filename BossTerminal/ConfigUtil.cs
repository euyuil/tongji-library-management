using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace BossTerminal
{
    class ConfigUtil
    {
        public static string GetString(string key)
        {
            string sql =
                "select config_value " +
                "from config " +
                "where config_key = @config_key";
            string result = null;

            SqlCommand cmd = new SqlCommand(sql, Connection.Instance());
            cmd.Parameters.AddWithValue("@config_key", key);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
                result = reader.GetString(0);
            reader.Close();
            return result;
        }
    }
}
