using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BackTerminal
{
    public partial class frmBookNew : Form
    {
        const string root = "全部分类";
        struct Category
        {
            public int id;
            public String title;
            public int parent_id;
        }
        public frmBookNew()
        {
            InitializeComponent();
            InitializeTreeViewCategory();
        }

        private TreeNode NodeFromKey(string key)
        {
            return tvCategory.Nodes.Find(key, true)[0];
        }

        private void InitializeTreeViewCategory()
        {
            SqlConnection connection = Library.Connection.Instance();
            string queryString = "SELECT * FROM dbo.category ORDER BY parent_id, title;";
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader reader = command.ExecuteReader();

            tvCategory.Nodes.Add(root);

            while (reader.Read())
            {
                Category cat;
                cat.id = (int)reader["id"];
                cat.title = (String)reader["title"];
                cat.parent_id = 0;
                if (!(reader["parent_id"] is DBNull))
                    cat.parent_id = (int)reader["parent_id"];
                if (cat.parent_id == 0)
                {
                    tvCategory.Nodes[0].Nodes.Add(cat.id.ToString(), cat.title);
                }
                else
                {
                    NodeFromKey(cat.parent_id.ToString()).Nodes.Add(cat.id.ToString(), cat.title);
                }
                Console.Out.WriteLine(cat.title);
            }
            reader.Close();
            tvCategory.ExpandAll();
        }
    }
}
