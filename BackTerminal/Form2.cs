using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace BackTerminal
{
    public partial class Form2 : Form
    {
        const string root = "全部分类";
        public Form2()
        {
            InitializeComponent();
            InitializeTreeViewCategory();
        }
        public struct Category
        {
            public int id;
            public String title;
            public int parent_id;
        }
        private TreeNode NodeFromKey(string key)
        {
            //return tvCategory.Nodes.IndexOfKey(key);
            return tvCategory.Nodes.Find(key, true)[0];
        }
        private void InitializeTreeViewCategory()
        {
            SqlConnection connection = Connection.Instance();
            string queryString = "SELECT * FROM dbo.category ORDER BY parent_id;";
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
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int GetIdByTitle(string title)
        {
            SqlConnection connection = Connection.Instance();
            string queryString = "SELECT id FROM dbo.category WHERE title='"+title+"';";
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader reader = command.ExecuteReader();

            int id = 0;
            while (reader.Read())
            {
                id = (int)reader["id"];
                break;
            }
            reader.Close();
            return id;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string title = Form4.ShowNewCategoryDialog();
            string parentTitle = tvCategory.SelectedNode.Text;
            string str;
            Console.Out.Write(parentTitle);
            if (parentTitle == root)
            {
                str = "INSERT INTO dbo.category (title, parent_id) VALUES('" + title + "',NULL);";
            }
            else
            {
                int id = GetIdByTitle(parentTitle);
                str = "INSERT INTO dbo.category (title, parent_id) VALUES('" + title + "'," + id + ");";
            }
            SqlConnection connection = Connection.Instance();
            SqlCommand command = new SqlCommand(str, connection);
            command.ExecuteNonQuery();

            tvCategory.Nodes.Clear();
            InitializeTreeViewCategory();
        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            string title = tvCategory.SelectedNode.Text;
            int id = GetIdByTitle(title);
            string str = "SELECT * FROM dbo.category WHERE parent_id=" + id + ";";
            Console.Out.WriteLine(str);
            SqlConnection connection = Connection.Instance();
            SqlCommand command = new SqlCommand(str, connection);
            SqlDataReader reader = command.ExecuteReader();

            // Don't delete if the item has children.
            bool skip = false;
            while (reader.Read())
            {
                skip = true;
            }

            reader.Close();

            if (skip) return;

            str = "DELETE FROM dbo.category WHERE title='"+title+"';";
            Console.Out.WriteLine(str);
            command = new SqlCommand(str, connection);
            command.ExecuteNonQuery();

            command.Dispose();

            tvCategory.Nodes.Clear();
            InitializeTreeViewCategory();
        }
    }
}
