using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BackTerminal
{
    public partial class Form4 : Form
    {
        // returns the category name.
        public static string ShowNewCategoryDialog()
        {
            string result = null;
            Form4 form = new Form4();
            form.ShowDialog();
            result = form.textBox.Text;
            form.Dispose();
            return result;
        }

        public Form4()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
        }
    }
}
