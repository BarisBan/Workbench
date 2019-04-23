namespace BookProject.Views.Member.MemberView
{
    partial class MemberPage
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
            this.gbCategories = new System.Windows.Forms.GroupBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.dgvBookList = new System.Windows.Forms.DataGridView();
            this.gbBookList = new System.Windows.Forms.GroupBox();
            this.gbAutors = new System.Windows.Forms.GroupBox();
            this.cbAutors = new System.Windows.Forms.ComboBox();
            this.txbBookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbShopCart = new System.Windows.Forms.GroupBox();
            this.dgvShopCart = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.gbBookSearch = new System.Windows.Forms.GroupBox();
            this.gbCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            this.gbBookList.SuspendLayout();
            this.gbAutors.SuspendLayout();
            this.gbShopCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShopCart)).BeginInit();
            this.gbBookSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCategories
            // 
            this.gbCategories.Controls.Add(this.cbCategory);
            this.gbCategories.Location = new System.Drawing.Point(12, 12);
            this.gbCategories.Name = "gbCategories";
            this.gbCategories.Size = new System.Drawing.Size(137, 59);
            this.gbCategories.TabIndex = 1;
            this.gbCategories.TabStop = false;
            this.gbCategories.Text = "Categories";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(6, 19);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 21);
            this.cbCategory.TabIndex = 2;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dgvBookList
            // 
            this.dgvBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookList.Location = new System.Drawing.Point(6, 19);
            this.dgvBookList.Name = "dgvBookList";
            this.dgvBookList.ReadOnly = true;
            this.dgvBookList.Size = new System.Drawing.Size(447, 167);
            this.dgvBookList.TabIndex = 2;
            this.dgvBookList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBookList_CellDoubleClick);
            // 
            // gbBookList
            // 
            this.gbBookList.Controls.Add(this.dgvBookList);
            this.gbBookList.Location = new System.Drawing.Point(8, 160);
            this.gbBookList.Name = "gbBookList";
            this.gbBookList.Size = new System.Drawing.Size(467, 207);
            this.gbBookList.TabIndex = 3;
            this.gbBookList.TabStop = false;
            this.gbBookList.Text = "Book List";
            // 
            // gbAutors
            // 
            this.gbAutors.Controls.Add(this.cbAutors);
            this.gbAutors.Location = new System.Drawing.Point(155, 12);
            this.gbAutors.Name = "gbAutors";
            this.gbAutors.Size = new System.Drawing.Size(137, 59);
            this.gbAutors.TabIndex = 5;
            this.gbAutors.TabStop = false;
            this.gbAutors.Text = "Autors";
            // 
            // cbAutors
            // 
            this.cbAutors.FormattingEnabled = true;
            this.cbAutors.Location = new System.Drawing.Point(6, 19);
            this.cbAutors.Name = "cbAutors";
            this.cbAutors.Size = new System.Drawing.Size(121, 21);
            this.cbAutors.TabIndex = 2;
            this.cbAutors.SelectedIndexChanged += new System.EventHandler(this.cbAutors_SelectedIndexChanged);
            // 
            // txbBookName
            // 
            this.txbBookName.Location = new System.Drawing.Point(30, 32);
            this.txbBookName.Name = "txbBookName";
            this.txbBookName.Size = new System.Drawing.Size(131, 20);
            this.txbBookName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Book Name";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(173, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gbShopCart
            // 
            this.gbShopCart.Controls.Add(this.dgvShopCart);
            this.gbShopCart.Location = new System.Drawing.Point(557, 12);
            this.gbShopCart.Name = "gbShopCart";
            this.gbShopCart.Size = new System.Drawing.Size(200, 209);
            this.gbShopCart.TabIndex = 9;
            this.gbShopCart.TabStop = false;
            this.gbShopCart.Text = "Shopping Cart";
            // 
            // dgvShopCart
            // 
            this.dgvShopCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShopCart.Location = new System.Drawing.Point(6, 19);
            this.dgvShopCart.Name = "dgvShopCart";
            this.dgvShopCart.ReadOnly = true;
            this.dgvShopCart.Size = new System.Drawing.Size(188, 184);
            this.dgvShopCart.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(676, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Buy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // gbBookSearch
            // 
            this.gbBookSearch.Controls.Add(this.label1);
            this.gbBookSearch.Controls.Add(this.txbBookName);
            this.gbBookSearch.Controls.Add(this.btnSearch);
            this.gbBookSearch.Location = new System.Drawing.Point(8, 77);
            this.gbBookSearch.Name = "gbBookSearch";
            this.gbBookSearch.Size = new System.Drawing.Size(284, 77);
            this.gbBookSearch.TabIndex = 11;
            this.gbBookSearch.TabStop = false;
            this.gbBookSearch.Text = "Book Search";
            // 
            // MemberPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 391);
            this.Controls.Add(this.gbBookSearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbShopCart);
            this.Controls.Add(this.gbAutors);
            this.Controls.Add(this.gbBookList);
            this.Controls.Add(this.gbCategories);
            this.Name = "MemberPage";
            this.Text = "MemberPage";
            this.Load += new System.EventHandler(this.MemberPage_Load);
            this.gbCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            this.gbBookList.ResumeLayout(false);
            this.gbAutors.ResumeLayout(false);
            this.gbShopCart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShopCart)).EndInit();
            this.gbBookSearch.ResumeLayout(false);
            this.gbBookSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbCategories;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.DataGridView dgvBookList;
        private System.Windows.Forms.GroupBox gbBookList;
        private System.Windows.Forms.GroupBox gbAutors;
        private System.Windows.Forms.ComboBox cbAutors;
        private System.Windows.Forms.TextBox txbBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbShopCart;
        private System.Windows.Forms.DataGridView dgvShopCart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbBookSearch;
    }
}