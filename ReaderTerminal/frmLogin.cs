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
    public partial class frmLogin : Form
    {
        public static int readerId;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string strName = txtName.Text;
            string strPasw = txtPassword.Text;
            string sql =
                "select id " +
                "from reader " +
                "where name = @strName and password = @strPasw";
            SqlCommand cmd = new SqlCommand(sql, Library.Connection.Instance());
            cmd.Parameters.AddWithValue("@strName", strName);
            cmd.Parameters.AddWithValue("@strPasw", strPasw);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int id = reader.GetInt32(0);
                frmMain main = new frmMain();
                this.Hide();
                readerId = id;

                reader.Close();

                main.ShowDialog();
            }
            else
            {
                MessageBox.Show("你的账号或密码错误。");
                reader.Close();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegister frm = new frmRegister();
            frm.ShowDialog();
            this.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
