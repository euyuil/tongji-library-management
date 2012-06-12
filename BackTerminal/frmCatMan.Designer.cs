namespace BackTerminal
{
    partial class frmCatMan
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
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnRemoveCategory = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tvCategory = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddCategory.Location = new System.Drawing.Point(3, 12);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(97, 26);
            this.btnAddCategory.TabIndex = 8;
            this.btnAddCategory.Text = "增加分类";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemoveCategory.Location = new System.Drawing.Point(3, 76);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(97, 26);
            this.btnRemoveCategory.TabIndex = 9;
            this.btnRemoveCategory.Text = "删除分类";
            this.btnRemoveCategory.UseVisualStyleBackColor = true;
            this.btnRemoveCategory.Click += new System.EventHandler(this.btnRemoveCategory_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonClose.Location = new System.Drawing.Point(3, 224);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(97, 26);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "确定";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditCategory.Location = new System.Drawing.Point(3, 44);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(97, 26);
            this.btnEditCategory.TabIndex = 11;
            this.btnEditCategory.Text = "编辑分类";
            this.btnEditCategory.UseVisualStyleBackColor = true;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.btnRemoveCategory);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnEditCategory);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnAddCategory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(278, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3, 12, 6, 12);
            this.panel1.Size = new System.Drawing.Size(106, 262);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(97, 6);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(97, 6);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(6);
            this.panel4.Size = new System.Drawing.Size(278, 262);
            this.panel4.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tvCategory);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(266, 250);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "分类";
            // 
            // tvCategory
            // 
            this.tvCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvCategory.Location = new System.Drawing.Point(6, 20);
            this.tvCategory.Name = "tvCategory";
            this.tvCategory.ShowRootLines = false;
            this.tvCategory.Size = new System.Drawing.Size(254, 224);
            this.tvCategory.TabIndex = 6;
            // 
            // frmCatMan
            // 
            this.AcceptButton = this.buttonClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "frmCatMan";
            this.Text = "分类管理";
            this.Load += new System.EventHandler(this.frmCatMan_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnRemoveCategory;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView tvCategory;
    }
}