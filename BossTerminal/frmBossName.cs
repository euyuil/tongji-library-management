using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BossTerminal
{
    public partial class frmBossName : Form
    {
        public frmBossName()
        {
            InitializeComponent();
        }

        private void frmbossname_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmBossName fm = new frmBossName();
            this.Close();
        }
    }
}
