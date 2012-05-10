namespace ReaderTerminal
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
            this.pnlWrapperMain = new System.Windows.Forms.Panel();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tpgBookSearch = new System.Windows.Forms.TabPage();
            this.lstBookResult = new System.Windows.Forms.ListView();
            this.pnlSearchWrapper = new System.Windows.Forms.Panel();
            this.grpBookSearch = new System.Windows.Forms.GroupBox();
            this.pnlSearchBar = new System.Windows.Forms.Panel();
            this.tblSearchBar = new System.Windows.Forms.TableLayoutPanel();
            this.cmbSearchType = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchContent = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.终端TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTerminalExit = new System.Windows.Forms.ToolStripMenuItem();
            this.读者RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReaderLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReaderRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuReaderLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlWrapperMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tpgBookSearch.SuspendLayout();
            this.pnlSearchWrapper.SuspendLayout();
            this.grpBookSearch.SuspendLayout();
            this.pnlSearchBar.SuspendLayout();
            this.tblSearchBar.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWrapperMain
            // 
            this.pnlWrapperMain.Controls.Add(this.tabMain);
            this.pnlWrapperMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWrapperMain.Location = new System.Drawing.Point(0, 25);
            this.pnlWrapperMain.Name = "pnlWrapperMain";
            this.pnlWrapperMain.Padding = new System.Windows.Forms.Padding(7, 0, 5, 6);
            this.pnlWrapperMain.Size = new System.Drawing.Size(464, 257);
            this.pnlWrapperMain.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tpgBookSearch);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(7, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(452, 251);
            this.tabMain.TabIndex = 1;
            // 
            // tpgBookSearch
            // 
            this.tpgBookSearch.Controls.Add(this.lstBookResult);
            this.tpgBookSearch.Controls.Add(this.pnlSearchWrapper);
            this.tpgBookSearch.Location = new System.Drawing.Point(4, 22);
            this.tpgBookSearch.Name = "tpgBookSearch";
            this.tpgBookSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tpgBookSearch.Size = new System.Drawing.Size(444, 225);
            this.tpgBookSearch.TabIndex = 0;
            this.tpgBookSearch.Text = "书籍检索";
            this.tpgBookSearch.UseVisualStyleBackColor = true;
            // 
            // lstBookResult
            // 
            this.lstBookResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBookResult.Location = new System.Drawing.Point(3, 66);
            this.lstBookResult.Name = "lstBookResult";
            this.lstBookResult.Size = new System.Drawing.Size(438, 156);
            this.lstBookResult.TabIndex = 7;
            this.lstBookResult.UseCompatibleStateImageBehavior = false;
            // 
            // pnlSearchWrapper
            // 
            this.pnlSearchWrapper.Controls.Add(this.grpBookSearch);
            this.pnlSearchWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchWrapper.Location = new System.Drawing.Point(3, 3);
            this.pnlSearchWrapper.Name = "pnlSearchWrapper";
            this.pnlSearchWrapper.Padding = new System.Windows.Forms.Padding(8);
            this.pnlSearchWrapper.Size = new System.Drawing.Size(438, 63);
            this.pnlSearchWrapper.TabIndex = 6;
            // 
            // grpBookSearch
            // 
            this.grpBookSearch.Controls.Add(this.pnlSearchBar);
            this.grpBookSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBookSearch.Location = new System.Drawing.Point(8, 8);
            this.grpBookSearch.Name = "grpBookSearch";
            this.grpBookSearch.Size = new System.Drawing.Size(422, 47);
            this.grpBookSearch.TabIndex = 3;
            this.grpBookSearch.TabStop = false;
            this.grpBookSearch.Text = "检索方式及关键字";
            // 
            // pnlSearchBar
            // 
            this.pnlSearchBar.Controls.Add(this.tblSearchBar);
            this.pnlSearchBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchBar.Location = new System.Drawing.Point(3, 17);
            this.pnlSearchBar.Name = "pnlSearchBar";
            this.pnlSearchBar.Size = new System.Drawing.Size(416, 27);
            this.pnlSearchBar.TabIndex = 0;
            // 
            // tblSearchBar
            // 
            this.tblSearchBar.ColumnCount = 3;
            this.tblSearchBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblSearchBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSearchBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblSearchBar.Controls.Add(this.cmbSearchType, 0, 0);
            this.tblSearchBar.Controls.Add(this.btnSearch, 2, 0);
            this.tblSearchBar.Controls.Add(this.txtSearchContent, 1, 0);
            this.tblSearchBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSearchBar.Location = new System.Drawing.Point(0, 0);
            this.tblSearchBar.Name = "tblSearchBar";
            this.tblSearchBar.RowCount = 1;
            this.tblSearchBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSearchBar.Size = new System.Drawing.Size(416, 27);
            this.tblSearchBar.TabIndex = 4;
            // 
            // cmbSearchType
            // 
            this.cmbSearchType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchType.FormattingEnabled = true;
            this.cmbSearchType.Items.AddRange(new object[] {
            "题名",
            "责任者",
            "ISBN",
            "分类号",
            "出版社"});
            this.cmbSearchType.Location = new System.Drawing.Point(3, 3);
            this.cmbSearchType.Name = "cmbSearchType";
            this.cmbSearchType.Size = new System.Drawing.Size(74, 20);
            this.cmbSearchType.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Location = new System.Drawing.Point(339, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 21);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "检索";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearchContent
            // 
            this.txtSearchContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchContent.Location = new System.Drawing.Point(83, 3);
            this.txtSearchContent.Name = "txtSearchContent";
            this.txtSearchContent.Size = new System.Drawing.Size(250, 21);
            this.txtSearchContent.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(444, 225);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.终端TToolStripMenuItem,
            this.读者RToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(464, 25);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // 终端TToolStripMenuItem
            // 
            this.终端TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTerminalExit});
            this.终端TToolStripMenuItem.Name = "终端TToolStripMenuItem";
            this.终端TToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.终端TToolStripMenuItem.Text = "终端(&T)";
            // 
            // mnuTerminalExit
            // 
            this.mnuTerminalExit.Name = "mnuTerminalExit";
            this.mnuTerminalExit.Size = new System.Drawing.Size(116, 22);
            this.mnuTerminalExit.Text = "退出(&X)";
            this.mnuTerminalExit.Click += new System.EventHandler(this.mnuTerminalExit_Click);
            // 
            // 读者RToolStripMenuItem
            // 
            this.读者RToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReaderLogin,
            this.mnuReaderRegister,
            this.toolStripMenuItem1,
            this.mnuReaderLogout});
            this.读者RToolStripMenuItem.Name = "读者RToolStripMenuItem";
            this.读者RToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.读者RToolStripMenuItem.Text = "读者(&R)";
            // 
            // mnuReaderLogin
            // 
            this.mnuReaderLogin.Name = "mnuReaderLogin";
            this.mnuReaderLogin.Size = new System.Drawing.Size(118, 22);
            this.mnuReaderLogin.Text = "登录(&L)";
            this.mnuReaderLogin.Click += new System.EventHandler(this.mnuReaderLogin_Click);
            // 
            // mnuReaderRegister
            // 
            this.mnuReaderRegister.Name = "mnuReaderRegister";
            this.mnuReaderRegister.Size = new System.Drawing.Size(118, 22);
            this.mnuReaderRegister.Text = "注册(&R)";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(115, 6);
            // 
            // mnuReaderLogout
            // 
            this.mnuReaderLogout.Name = "mnuReaderLogout";
            this.mnuReaderLogout.Size = new System.Drawing.Size(118, 22);
            this.mnuReaderLogout.Text = "登出(&O)";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于AToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.关于AToolStripMenuItem.Text = "关于(&A)";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 282);
            this.Controls.Add(this.pnlWrapperMain);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.MinimumSize = new System.Drawing.Size(480, 320);
            this.Name = "frmMain";
            this.Text = "图书馆读者终端";
            this.Load += new System.EventHandler(this.BookSearch_Load);
            this.pnlWrapperMain.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tpgBookSearch.ResumeLayout(false);
            this.pnlSearchWrapper.ResumeLayout(false);
            this.grpBookSearch.ResumeLayout(false);
            this.pnlSearchBar.ResumeLayout(false);
            this.tblSearchBar.ResumeLayout(false);
            this.tblSearchBar.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlWrapperMain;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tpgBookSearch;
        private System.Windows.Forms.ListView lstBookResult;
        private System.Windows.Forms.Panel pnlSearchWrapper;
        private System.Windows.Forms.GroupBox grpBookSearch;
        private System.Windows.Forms.Panel pnlSearchBar;
        private System.Windows.Forms.TableLayoutPanel tblSearchBar;
        private System.Windows.Forms.ComboBox cmbSearchType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchContent;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem 读者RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuReaderLogin;
        private System.Windows.Forms.ToolStripMenuItem mnuReaderRegister;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuReaderLogout;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 终端TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuTerminalExit;


    }
}