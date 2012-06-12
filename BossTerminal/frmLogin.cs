using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace BossTerminal
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string trimmedBossName = ConfigUtil.GetString("boss_name").Trim();
            string trimmedPassword = ConfigUtil.GetString("boss_password").Trim();

            string enteredBossName = txtBossName.Text.Trim();
            string encryptedPassword = Util.MD5(txtBossPassword.Text.Trim());

            if ((enteredBossName.Equals(trimmedBossName) &&
                encryptedPassword.Equals(trimmedPassword)) ||
                (trimmedPassword == null || trimmedPassword.Length == 0) &&
                txtBossPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Sorry.");

            }
            else
            {

                String connectionString = @"Data Source=10.60.1.59\\SQLEXPRESS,1433; " +
                    "Persist Security Info=True; " +
                    "Initial Catalog=lib; " +
                    "User Id=lib; " +
                    "Password=liuyue; ";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT config_key,config_value FROM config WHERE config_key='" + txtBossName.Text + "' AND config_value='" + txtBossPassword.Text + "'", con);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    //rdr.Read();
                    if (rdr["config_key"].ToString() == txtBossName.Text && rdr["config_value"].ToString() == txtBossPassword.Text)
                    {
                        MessageBox.Show("login success");

                        frmMain frmMain = new frmMain();
                        this.Hide(); frmMain.ShowDialog(this);
                        this.Close(); this.Dispose();
                    }
                    else {
                        MessageBox.Show("access denied");
                    }
                }
                rdr.Close();
                con.Close();
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtBossPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
