using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BackTerminal
{
    public partial class frmCatNew : Form
    {
        public string result = null;
        // returns the category name.
        public frmCatNew()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length == 0)
            {
                MessageBox.Show("分类不能为空，请重新输入！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.DialogResult = DialogResult.None;
            }
            else if (textBox.Text.Length > 50)
            {
                MessageBox.Show("分类名的长度不能超过50",
                    "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.DialogResult = DialogResult.None;
            }
            else result = textBox.Text;            
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
