using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BackTerminal
{
    public partial class frmCatEdit : Form
    {
        public string newTitle = null;
        public frmCatEdit(string str)
        {
            InitializeComponent();
            this.Text = "编辑分类：" + str;
            this.textBox.Text = str;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.textBox.Text.Length == 0)
            {
                MessageBox.Show("分类名不能为空",
                    "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.DialogResult = DialogResult.None;
            }
            else
                newTitle = this.textBox.Text;            
        }
    }
}
