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
    public partial class frmCatMan : Form
    {
        const string root = "全部分类";
        public frmCatMan()
        {
            InitializeComponent();
            InitializeTreeViewCategory();
        }
        struct Category
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

        // 获取分类的Id
        private int GetIdByTitle(string title)
        {
            SqlConnection connection = Library.Connection.Instance();
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

        // 判断用户是否选中 TreeView 中的一项
        private bool TreeViewSelected()
        {
            if (tvCategory.SelectedNode == null)
            {
                MessageBox.Show("请选择一个分类！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            return true;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (!TreeViewSelected()) return;
            frmCatNew form = new frmCatNew();
            form.ShowDialog();
            
            string title = form.result;
            if (title == null) return;

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
            SqlConnection connection = Library.Connection.Instance();
            SqlCommand command = new SqlCommand(str, connection);
            command.ExecuteNonQuery();

            MessageBox.Show("添加成功", "添加分类");
            tvCategory.Nodes.Clear();
            InitializeTreeViewCategory();
        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            if (!TreeViewSelected()) return;
            string title = tvCategory.SelectedNode.Text;

            // 不能删除“全部分类”
            if (title == root)
            {
                MessageBox.Show("不能删除“全部分类”。请重新选择一个分类！", 
                    "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            string message = "你确定要删除“" + title + "”吗？";
            const string caption = "删除分类";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            
            int id = GetIdByTitle(title);
            string str;
            str = "DELETE FROM dbo.category WHERE title='" + title + "';";
            Console.Out.WriteLine(str);
            SqlConnection connection = Library.Connection.Instance();
            SqlCommand command = new SqlCommand(str, connection);

            command.ExecuteNonQuery();

            command.Dispose();

            tvCategory.Nodes.Clear();
            InitializeTreeViewCategory();
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            if (!TreeViewSelected()) return;
            string title = tvCategory.SelectedNode.Text;

            // 不能编辑“全部分类”
            if (title == root)
            {
                MessageBox.Show("不能编辑“全部分类”。请重新选择一个分类！",
                    "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            frmCatEdit form = new frmCatEdit(title);
            form.ShowDialog();
            string newTitle = form.newTitle;

            if (newTitle == null) return;

            string str =
                "UPDATE dbo.category SET title='" + newTitle + 
                "' WHERE title='" + title + "';";
            Console.Out.WriteLine(str);

            SqlConnection connection = Library.Connection.Instance();
            SqlCommand command = new SqlCommand(str, connection);
            command.ExecuteNonQuery();
            command.Dispose();

            tvCategory.Nodes.Clear();
            InitializeTreeViewCategory();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
