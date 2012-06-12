namespace BossTerminal
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.libraryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libDSlibrary = new BossTerminal.libDSlibrary();
            this.managerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libDataSet = new BossTerminal.libDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.工具TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加图书馆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理员管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.老板BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改账号AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerTableAdapter = new BossTerminal.libDataSetTableAdapters.managerTableAdapter();
            this.libraryTableAdapter = new BossTerminal.libDSlibraryTableAdapters.libraryTableAdapter();
            this.dgvMangers = new System.Windows.Forms.DataGridView();
            this.libraryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new BossTerminal.libDataSetTableAdapters.bookTableAdapter();
            this.managerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.tpgManager = new System.Windows.Forms.TabPage();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.libraryidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.前台服务人员 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libDSlibrary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMangers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tpgManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.前台服务人员.SuspendLayout();
            this.SuspendLayout();
            // 
            // libraryBindingSource
            // 
            this.libraryBindingSource.DataMember = "library";
            this.libraryBindingSource.DataSource = this.libDSlibrary;
            // 
            // libDSlibrary
            // 
            this.libDSlibrary.DataSetName = "libDSlibrary";
            this.libDSlibrary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // managerBindingSource
            // 
            this.managerBindingSource.DataMember = "manager";
            this.managerBindingSource.DataSource = this.libDataSet;
            // 
            // libDataSet
            // 
            this.libDataSet.DataSetName = "libDataSet";
            this.libDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.工具TToolStripMenuItem,
            this.老板BToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(821, 34);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 工具TToolStripMenuItem
            // 
            this.工具TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加图书馆ToolStripMenuItem,
            this.管理员管理ToolStripMenuItem,
            this.退出XToolStripMenuItem});
            this.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem";
            this.工具TToolStripMenuItem.Size = new System.Drawing.Size(80, 28);
            this.工具TToolStripMenuItem.Text = "工具(&T)";
            // 
            // 添加图书馆ToolStripMenuItem
            // 
            this.添加图书馆ToolStripMenuItem.Name = "添加图书馆ToolStripMenuItem";
            this.添加图书馆ToolStripMenuItem.Size = new System.Drawing.Size(170, 28);
            this.添加图书馆ToolStripMenuItem.Text = "添加图书馆";
            this.添加图书馆ToolStripMenuItem.Click += new System.EventHandler(this.添加图书馆ToolStripMenuItem_Click);
            // 
            // 管理员管理ToolStripMenuItem
            // 
            this.管理员管理ToolStripMenuItem.Name = "管理员管理ToolStripMenuItem";
            this.管理员管理ToolStripMenuItem.Size = new System.Drawing.Size(170, 28);
            this.管理员管理ToolStripMenuItem.Text = "添加管理员";
            this.管理员管理ToolStripMenuItem.Click += new System.EventHandler(this.后台管理员管理ToolStripMenuItem_Click);
            // 
            // 退出XToolStripMenuItem
            // 
            this.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem";
            this.退出XToolStripMenuItem.Size = new System.Drawing.Size(170, 28);
            this.退出XToolStripMenuItem.Text = "退出(&X)";
            this.退出XToolStripMenuItem.Click += new System.EventHandler(this.退出XToolStripMenuItem_Click);
            // 
            // 老板BToolStripMenuItem
            // 
            this.老板BToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改账号AToolStripMenuItem,
            this.修改密码PToolStripMenuItem});
            this.老板BToolStripMenuItem.Name = "老板BToolStripMenuItem";
            this.老板BToolStripMenuItem.Size = new System.Drawing.Size(81, 28);
            this.老板BToolStripMenuItem.Text = "老板(&B)";
            // 
            // 修改账号AToolStripMenuItem
            // 
            this.修改账号AToolStripMenuItem.Name = "修改账号AToolStripMenuItem";
            this.修改账号AToolStripMenuItem.Size = new System.Drawing.Size(179, 28);
            this.修改账号AToolStripMenuItem.Text = "修改名称(&N)";
            this.修改账号AToolStripMenuItem.Click += new System.EventHandler(this.修改账号AToolStripMenuItem_Click);
            // 
            // 修改密码PToolStripMenuItem
            // 
            this.修改密码PToolStripMenuItem.Name = "修改密码PToolStripMenuItem";
            this.修改密码PToolStripMenuItem.Size = new System.Drawing.Size(179, 28);
            this.修改密码PToolStripMenuItem.Text = "修改密码(&P)";
            this.修改密码PToolStripMenuItem.Click += new System.EventHandler(this.修改密码PToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于AToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(84, 28);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(141, 28);
            this.关于AToolStripMenuItem.Text = "关于(&A)";
            // 
            // managerTableAdapter
            // 
            this.managerTableAdapter.ClearBeforeFill = true;
            // 
            // libraryTableAdapter
            // 
            this.libraryTableAdapter.ClearBeforeFill = true;
            // 
            // dgvMangers
            // 
            this.dgvMangers.AutoGenerateColumns = false;
            this.dgvMangers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMangers.DataSource = this.managerBindingSource;
            this.dgvMangers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMangers.Location = new System.Drawing.Point(0, 0);
            this.dgvMangers.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMangers.Name = "dgvMangers";
            this.dgvMangers.RowTemplate.Height = 23;
            this.dgvMangers.Size = new System.Drawing.Size(584, 469);
            this.dgvMangers.TabIndex = 1;
            this.dgvMangers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMangers_CellContentClick);
            // 
            // libraryidDataGridViewTextBoxColumn
            // 
            this.libraryidDataGridViewTextBoxColumn.DataPropertyName = "library_id";
            this.libraryidDataGridViewTextBoxColumn.HeaderText = "library_id";
            this.libraryidDataGridViewTextBoxColumn.Name = "libraryidDataGridViewTextBoxColumn";
            // 
            // permissionDataGridViewTextBoxColumn
            // 
            this.permissionDataGridViewTextBoxColumn.DataPropertyName = "permission";
            this.permissionDataGridViewTextBoxColumn.HeaderText = "permission";
            this.permissionDataGridViewTextBoxColumn.Name = "permissionDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "book";
            this.bindingSource1.DataSource = this.libDataSet;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // managerBindingSource1
            // 
            this.managerBindingSource1.DataMember = "manager";
            this.managerBindingSource1.DataSource = this.libDataSet;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.progressBar3);
            this.tabPage2.Controls.Add(this.dataGridView4);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(813, 477);
            this.tabPage2.TabIndex = 7;
            this.tabPage2.Text = "图书馆管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn2,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.libraryBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(0, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 30;
            this.dataGridView4.Size = new System.Drawing.Size(786, 477);
            this.dataGridView4.TabIndex = 3;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(786, 0);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(32, 489);
            this.progressBar3.TabIndex = 4;
            // 
            // tpgManager
            // 
            this.tpgManager.Controls.Add(this.dataGridView1);
            this.tpgManager.Controls.Add(this.progressBar2);
            this.tpgManager.Location = new System.Drawing.Point(4, 28);
            this.tpgManager.Margin = new System.Windows.Forms.Padding(4);
            this.tpgManager.Name = "tpgManager";
            this.tpgManager.Padding = new System.Windows.Forms.Padding(4);
            this.tpgManager.Size = new System.Drawing.Size(813, 477);
            this.tpgManager.TabIndex = 4;
            this.tpgManager.Text = "后台管理员";
            this.tpgManager.UseVisualStyleBackColor = true;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(785, 0);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(32, 489);
            this.progressBar2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.passwordDataGridViewTextBoxColumn1,
            this.permissionDataGridViewTextBoxColumn1,
            this.libraryidDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.managerBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(786, 477);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // libraryidDataGridViewTextBoxColumn1
            // 
            this.libraryidDataGridViewTextBoxColumn1.DataPropertyName = "library_id";
            this.libraryidDataGridViewTextBoxColumn1.HeaderText = "library_id";
            this.libraryidDataGridViewTextBoxColumn1.Name = "libraryidDataGridViewTextBoxColumn1";
            // 
            // permissionDataGridViewTextBoxColumn1
            // 
            this.permissionDataGridViewTextBoxColumn1.DataPropertyName = "permission";
            this.permissionDataGridViewTextBoxColumn1.HeaderText = "permission";
            this.permissionDataGridViewTextBoxColumn1.Name = "permissionDataGridViewTextBoxColumn1";
            // 
            // passwordDataGridViewTextBoxColumn1
            // 
            this.passwordDataGridViewTextBoxColumn1.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn1.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn1.Name = "passwordDataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // 前台服务人员
            // 
            this.前台服务人员.Controls.Add(this.tpgManager);
            this.前台服务人员.Controls.Add(this.tabPage2);
            this.前台服务人员.Dock = System.Windows.Forms.DockStyle.Fill;
            this.前台服务人员.Location = new System.Drawing.Point(0, 34);
            this.前台服务人员.Margin = new System.Windows.Forms.Padding(4);
            this.前台服务人员.Name = "前台服务人员";
            this.前台服务人员.SelectedIndex = 0;
            this.前台服务人员.Size = new System.Drawing.Size(821, 509);
            this.前台服务人员.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 543);
            this.Controls.Add(this.前台服务人员);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "老板管理工具";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libDSlibrary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMangers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tpgManager.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.前台服务人员.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 工具TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 老板BToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改账号AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码PToolStripMenuItem;
        private libDataSet libDataSet;
        private System.Windows.Forms.BindingSource managerBindingSource;
        private libDataSetTableAdapters.managerTableAdapter managerTableAdapter;
        private libDSlibrary libDSlibrary;
        private System.Windows.Forms.BindingSource libraryBindingSource;
        private libDSlibraryTableAdapters.libraryTableAdapter libraryTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem 添加图书馆ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理员管理ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvMangers;
        private System.Windows.Forms.DataGridViewTextBoxColumn libraryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private libDataSetTableAdapters.bookTableAdapter bookTableAdapter;
        private System.Windows.Forms.BindingSource managerBindingSource1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tpgManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn permissionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn libraryidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.TabControl 前台服务人员;
    }
}