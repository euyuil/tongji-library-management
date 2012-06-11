using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace ReaderTerminal
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void BookSearch_Load(object sender, EventArgs e)
        {
            cmbSearchType.SelectedIndex = 0;
        }

        private void mnuTerminalExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuReaderLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
        }

        private void txtSearchContent_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnSearch_Click(object sender, EventArgs e)

        {
            SqlCommand cmd;
            SqlDataReader book = null;
            if (cmbSearchType.SelectedItem.ToString().Equals("题名"))
            {
                lstBookResult.Clear();
                String bookName = txtSearchContent.Text;
                string sql =
                    "select * " +
                    "from book " +
                    "where title = @bookName";
                cmd = new SqlCommand(sql, BossTerminal.Connection.Instance());
                cmd.Parameters.AddWithValue("@bookName", bookName);
                book = cmd.ExecuteReader();
            }
            if (cmbSearchType.SelectedItem.ToString().Equals("责任者"))
            {
                lstBookResult.Clear();
                String author = txtSearchContent.Text;
                string sql =
                    "select * " +
                    "from book " +
                    "where author = @author";
                cmd = new SqlCommand(sql, BossTerminal.Connection.Instance());
                cmd.Parameters.AddWithValue("@author", author);
                book = cmd.ExecuteReader();
            }
            if (cmbSearchType.SelectedItem.ToString().Equals("ISBN"))
            {
                lstBookResult.Clear();
                String isbn = txtSearchContent.Text;
                string sql =
                    "select * " +
                    "from book " +
                    "where isbn = @isbn";
                cmd = new SqlCommand(sql, BossTerminal.Connection.Instance());
                cmd.Parameters.AddWithValue("@isbn", isbn);
                book = cmd.ExecuteReader();
            }
            if (cmbSearchType.SelectedItem.ToString().Equals("分类号"))
            {
                lstBookResult.Clear();
                String category_id = txtSearchContent.Text;
                string sql =
                    "select * " +
                    "from book " +
                    "where category_id = @category_id";
                cmd = new SqlCommand(sql, BossTerminal.Connection.Instance());
                cmd.Parameters.AddWithValue("@category_id", category_id);
                book = cmd.ExecuteReader();
            }
            if (cmbSearchType.SelectedItem.ToString().Equals("出版社"))
            {
                lstBookResult.Clear();
                String publisher = txtSearchContent.Text;
                string sql =
                    "select * " +
                    "from book " +
                    "where publisher = @publisher";
                cmd = new SqlCommand(sql, BossTerminal.Connection.Instance());
                cmd.Parameters.AddWithValue("@publisher", publisher);
                book = cmd.ExecuteReader();
            }
            while (book != null && book.Read())
            {
                String[] str = new String[3];
                str[0] = book[0].ToString();
                str[1] = book[1].ToString();
                str[2] = book[2].ToString();
                lstBookResult.View = View.List;
                ListViewItem item = new ListViewItem(str[0] + str[1] +"   "+ str[2]);
                lstBookResult.Items.Add(item);
             }
            book.Close();
        }

        private void lstBookResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstBookResult_DoubleClick(object sender, EventArgs e)
        {
            SqlCommand cmd;
            SqlDataReader book = null;
            String isbn = lstBookResult.SelectedItems[0].Text.ToString();
            isbn = isbn.Substring(0, isbn.IndexOf(" ") + 1);
            string sql =
                "select * " +
                "from book " +
                "where isbn = @isbn";
            cmd = new SqlCommand(sql, BossTerminal.Connection.Instance());
            cmd.Parameters.AddWithValue("@isbn", isbn);
            book = cmd.ExecuteReader();
            String[] str = new String[4];
            if (book != null && book.Read())
            {

                str[0] = book[1].ToString();
                str[1] = book[2].ToString();
                str[2] = book[3].ToString();
                str[3] = book[4].ToString();
                
            }
            else
            {
                MessageBox.Show("错误");
                book.Close();
            }
            book.Close();

            frmBook frmbook = new frmBook(str[0], str[3], str[1], str[2]);
            this.Hide();
            frmbook.ShowDialog();
            this.Show();

        }
    }
}
