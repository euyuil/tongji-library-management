using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BossTerminal
{
    public partial class frmAddLib : Form
    {
        public frmAddLib()
        {
            InitializeComponent();
        }

        private void frmAddLib_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAddLib fm = new frmAddLib();
            this.Close();
        }
    }
}
