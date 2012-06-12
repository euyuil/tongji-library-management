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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string usrCredentialNumber = txtCreatialnumber.Text;
            string usrCredentialType = "idcard";
            string usrName = txtName.Text;
            string usrPassword = txtPsw.Text;
            bool gender = true;
            bool doif = false;
            bool available = true;
            DateTime time = System.DateTime.Now;
            DateTime expireTime = time; expireTime.AddYears(1);
            string usrPhone = txtPhoneNum.Text;
            string usrPassword2 = txtPsdc.Text;
            string usrMail = txtMail.Text;
            if (!usrPassword.Equals(usrPassword2))
            {
                MessageBox.Show("两次密码不一致，请重新输入");
                doif = true;
            }
            else doif = false;
            string sql =
                "insert into reader (name, password, gender, credential_type, credential_number, telephone, register_time, expire_time, available) " +
                "values (@name, @password, @gender, @credential_type, @credential_number, @telephone, @register_time, @expire_time, @available)";
            if (!doif)
            {
                SqlCommand cmd = new SqlCommand(sql, Library.Connection.Instance());
                cmd.Parameters.AddWithValue("@name", usrName);
                cmd.Parameters.AddWithValue("@password", usrPassword);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@credential_type", usrCredentialType);
                cmd.Parameters.AddWithValue("@credential_number", usrCredentialNumber);
                cmd.Parameters.AddWithValue("@telephone", usrPhone);
                cmd.Parameters.AddWithValue("@register_time", time);
                cmd.Parameters.AddWithValue("@expire_time", expireTime);
                cmd.Parameters.AddWithValue("@available", available);

                if (cmd.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("用户名已被注册。");
                }
                if (cmd.ExecuteNonQuery() != 0)
                {
                    this.Close();
                    MessageBox.Show("注册成功");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void usrName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
