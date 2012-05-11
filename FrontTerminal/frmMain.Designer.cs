namespace FrontTerminal
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlWrapper = new System.Windows.Forms.Panel();
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tbpRental = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlRentalInfo = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlReaderInfo = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbpReader = new System.Windows.Forms.TabPage();
            this.pnlReaderWrapper = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pnlReaderResult = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pnlReaderCond = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbpLost = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.终端TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tbpRude = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.pnlWrapper.SuspendLayout();
            this.tbcMain.SuspendLayout();
            this.tbpRental.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlRentalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlReaderInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbpReader.SuspendLayout();
            this.pnlReaderWrapper.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.pnlReaderResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.pnlReaderCond.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tbpLost.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tbpRude.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlWrapper
            // 
            this.pnlWrapper.Controls.Add(this.tbcMain);
            this.pnlWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWrapper.Location = new System.Drawing.Point(0, 25);
            this.pnlWrapper.Name = "pnlWrapper";
            this.pnlWrapper.Padding = new System.Windows.Forms.Padding(8, 0, 6, 7);
            this.pnlWrapper.Size = new System.Drawing.Size(635, 378);
            this.pnlWrapper.TabIndex = 15;
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tbpRental);
            this.tbcMain.Controls.Add(this.tbpReader);
            this.tbcMain.Controls.Add(this.tbpRude);
            this.tbcMain.Controls.Add(this.tbpLost);
            this.tbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMain.Location = new System.Drawing.Point(8, 0);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(621, 371);
            this.tbcMain.TabIndex = 0;
            // 
            // tbpRental
            // 
            this.tbpRental.Controls.Add(this.groupBox2);
            this.tbpRental.Controls.Add(this.pnlReaderInfo);
            this.tbpRental.Location = new System.Drawing.Point(4, 22);
            this.tbpRental.Name = "tbpRental";
            this.tbpRental.Padding = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.tbpRental.Size = new System.Drawing.Size(613, 345);
            this.tbpRental.TabIndex = 0;
            this.tbpRental.Text = "借书还书登记";
            this.tbpRental.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnlRentalInfo);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(605, 284);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "读者借书信息";
            // 
            // pnlRentalInfo
            // 
            this.pnlRentalInfo.Controls.Add(this.dataGridView1);
            this.pnlRentalInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRentalInfo.Location = new System.Drawing.Point(3, 17);
            this.pnlRentalInfo.Name = "pnlRentalInfo";
            this.pnlRentalInfo.Padding = new System.Windows.Forms.Padding(5, 0, 5, 6);
            this.pnlRentalInfo.Size = new System.Drawing.Size(599, 264);
            this.pnlRentalInfo.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(5, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(589, 258);
            this.dataGridView1.TabIndex = 1;
            // 
            // pnlReaderInfo
            // 
            this.pnlReaderInfo.Controls.Add(this.groupBox1);
            this.pnlReaderInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReaderInfo.Location = new System.Drawing.Point(3, 3);
            this.pnlReaderInfo.Name = "pnlReaderInfo";
            this.pnlReaderInfo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pnlReaderInfo.Size = new System.Drawing.Size(605, 55);
            this.pnlReaderInfo.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 50);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "读者基本信息";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(424, 21);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "读者性别";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(244, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "读者姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "读者编号";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            // 
            // tbpReader
            // 
            this.tbpReader.Controls.Add(this.pnlReaderWrapper);
            this.tbpReader.Location = new System.Drawing.Point(4, 22);
            this.tbpReader.Name = "tbpReader";
            this.tbpReader.Padding = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.tbpReader.Size = new System.Drawing.Size(613, 345);
            this.tbpReader.TabIndex = 1;
            this.tbpReader.Text = "读者信息管理";
            this.tbpReader.UseVisualStyleBackColor = true;
            // 
            // pnlReaderWrapper
            // 
            this.pnlReaderWrapper.Controls.Add(this.groupBox4);
            this.pnlReaderWrapper.Controls.Add(this.pnlReaderCond);
            this.pnlReaderWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReaderWrapper.Location = new System.Drawing.Point(3, 3);
            this.pnlReaderWrapper.Name = "pnlReaderWrapper";
            this.pnlReaderWrapper.Size = new System.Drawing.Size(605, 339);
            this.pnlReaderWrapper.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pnlReaderResult);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 45);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(605, 294);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "读者搜索结果";
            // 
            // pnlReaderResult
            // 
            this.pnlReaderResult.Controls.Add(this.dataGridView2);
            this.pnlReaderResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReaderResult.Location = new System.Drawing.Point(3, 17);
            this.pnlReaderResult.Name = "pnlReaderResult";
            this.pnlReaderResult.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.pnlReaderResult.Size = new System.Drawing.Size(599, 274);
            this.pnlReaderResult.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(597, 274);
            this.dataGridView2.TabIndex = 0;
            // 
            // pnlReaderCond
            // 
            this.pnlReaderCond.Controls.Add(this.groupBox3);
            this.pnlReaderCond.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReaderCond.Location = new System.Drawing.Point(0, 0);
            this.pnlReaderCond.Name = "pnlReaderCond";
            this.pnlReaderCond.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pnlReaderCond.Size = new System.Drawing.Size(605, 45);
            this.pnlReaderCond.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(605, 40);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "读者查询条件";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "不限",
            "男",
            "女"});
            this.comboBox1.Location = new System.Drawing.Point(200, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "性别";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(59, 14);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "姓名(&N)";
            // 
            // tbpLost
            // 
            this.tbpLost.Controls.Add(this.dataGridView4);
            this.tbpLost.Location = new System.Drawing.Point(4, 22);
            this.tbpLost.Name = "tbpLost";
            this.tbpLost.Size = new System.Drawing.Size(613, 345);
            this.tbpLost.TabIndex = 3;
            this.tbpLost.Text = "书籍遗失登记";
            this.tbpLost.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.终端TToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(635, 25);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 终端TToolStripMenuItem
            // 
            this.终端TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出XToolStripMenuItem});
            this.终端TToolStripMenuItem.Name = "终端TToolStripMenuItem";
            this.终端TToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.终端TToolStripMenuItem.Text = "终端(&T)";
            // 
            // 退出XToolStripMenuItem
            // 
            this.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem";
            this.退出XToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.退出XToolStripMenuItem.Text = "退出(&X)";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(0, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 23;
            this.dataGridView4.Size = new System.Drawing.Size(613, 345);
            this.dataGridView4.TabIndex = 2;
            // 
            // tbpRude
            // 
            this.tbpRude.Controls.Add(this.dataGridView3);
            this.tbpRude.Location = new System.Drawing.Point(4, 22);
            this.tbpRude.Name = "tbpRude";
            this.tbpRude.Size = new System.Drawing.Size(613, 345);
            this.tbpRude.TabIndex = 2;
            this.tbpRude.Text = "超期读者管理";
            this.tbpRude.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(613, 345);
            this.dataGridView3.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 403);
            this.Controls.Add(this.pnlWrapper);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "图书馆前台服务终端";
            this.pnlWrapper.ResumeLayout(false);
            this.tbcMain.ResumeLayout(false);
            this.tbpRental.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.pnlRentalInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlReaderInfo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbpReader.ResumeLayout(false);
            this.pnlReaderWrapper.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.pnlReaderResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.pnlReaderCond.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tbpLost.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tbpRude.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlWrapper;
        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tbpRental;
        private System.Windows.Forms.TabPage tbpReader;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 终端TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出XToolStripMenuItem;
        private System.Windows.Forms.TabPage tbpLost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel pnlRentalInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlReaderInfo;
        private System.Windows.Forms.Panel pnlReaderWrapper;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel pnlReaderCond;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlReaderResult;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TabPage tbpRude;
        private System.Windows.Forms.DataGridView dataGridView3;

    }
}

