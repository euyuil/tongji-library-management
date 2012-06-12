using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace BossTerminal
{
    public partial class frmPassword : Form
    {
        public frmPassword()
        {
            InitializeComponent();
        }

        private void frmPassword_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPassword fm = new frmPassword();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)                                     //////////////修改密码检查
        {
            if (textBox1.Text.Trim().Length == 0 || textBox2.Text.Trim().Length == 0 || textBox3.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入完整！");
                return;
            }

            if (textBox1.Text.Trim() != textBox2.Text.Trim())
            {
                MessageBox.Show("两次密码输入不一致！");
                return;
            }


           String connectionString = @"Data Source=10.60.1.59\\SQLEXPRESS,1433; " +
                    "Persist Security Info=True; " +
                    "Initial Catalog=lib; " +
                    "User Id=lib; " +
                    "Password=liuyue; "; 

           SqlConnection conn = new SqlConnection(connectionString);

           DataTable dt = new DataTable();
           
           String sql = "SELECT * FROM config where 帐号=and 密码 =" + textBox3.Text.Trim();

           try
           {
               SqlDataAdapter da = new SqlDataAdapter(sql, conn);
               da.Fill(dt);
           }
           catch (Exception Err)
           {
               MessageBox.Show(Err.Message);
           }

           if (dt.Rows.Count == 0)
           {
               MessageBox.Show("旧密码输入错误！");

               dt.Dispose();
           }
           else
           {
               sql = "UPDATE Config set 密码 ='" + textBox2.Text.Trim() + "where 帐号=@name";

               SqlCommand cmd = new SqlCommand();
               cmd.CommandText = sql;
               cmd.Connection = conn;
               try
               {
                   conn.Open();
                   cmd.ExecuteNonQuery();
               }
               catch (SqlException err)
               {
                   MessageBox.Show("更新出现异常！");
               }
               finally
               {
                   conn.Close();
               }

               MessageBox.Show("密码更新成功！");

           }
       }
        }
        }
    


