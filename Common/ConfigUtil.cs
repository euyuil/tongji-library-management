using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Library
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

            SqlCommand cmd = new SqlCommand(sql, Library.Connection.Instance());
            cmd.Parameters.AddWithValue("@config_key", key);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                object objrslt = reader.GetValue(0);
                if (objrslt is string)
                    result = (string) objrslt;
            }
            reader.Close();
            return result;
        }
    }
}
