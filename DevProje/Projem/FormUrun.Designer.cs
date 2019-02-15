namespace Projem
{
    partial class FormUrun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUrun));
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m303SalesDBDataSet8 = new Projem.M303SalesDBDataSet8();
            this.btnKayıtOl = new System.Windows.Forms.Button();
            this.productsTableAdapter = new Projem.M303SalesDBDataSet8TableAdapters.ProductsTableAdapter();
            this.tabUrunIslem = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageUrun = new System.Windows.Forms.TabPage();
            this.productIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btBaglan = new System.Windows.Forms.Button();
            this.btSil = new System.Windows.Forms.Button();
            this.btOnay = new System.Windows.Forms.Button();
            this.lbUrunName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m303SalesDBDataSet8)).BeginInit();
            this.tabUrunIslem.SuspendLayout();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageUrun.SuspendLayout();
            this.SuspendLayout();
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.m303SalesDBDataSet8;
            // 
            // m303SalesDBDataSet8
            // 
            this.m303SalesDBDataSet8.DataSetName = "M303SalesDBDataSet8";
            this.m303SalesDBDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnKayıtOl
            // 
            this.btnKayıtOl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKayıtOl.BackColor = System.Drawing.Color.SteelBlue;
            this.btnKayıtOl.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnKayıtOl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnKayıtOl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnKayıtOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayıtOl.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayıtOl.ForeColor = System.Drawing.Color.White;
            this.btnKayıtOl.Location = new System.Drawing.Point(321, 260);
            this.btnKayıtOl.Margin = new System.Windows.Forms.Padding(4);
            this.btnKayıtOl.Name = "btnKayıtOl";
            this.btnKayıtOl.Size = new System.Drawing.Size(103, 26);
            this.btnKayıtOl.TabIndex = 6;
            this.btnKayıtOl.Text = "Çıkış";
            this.btnKayıtOl.UseVisualStyleBackColor = false;
            this.btnKayıtOl.Click += new System.EventHandler(this.btnKayıtOl_Click);
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tabUrunIslem
            // 
            this.tabUrunIslem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabUrunIslem.Controls.Add(this.lbUrunName);
            this.tabUrunIslem.Controls.Add(this.label4);
            this.tabUrunIslem.Controls.Add(this.btOnay);
            this.tabUrunIslem.Controls.Add(this.btSil);
            this.tabUrunIslem.Controls.Add(this.btBaglan);
            this.tabUrunIslem.Controls.Add(this.txbPrice);
            this.tabUrunIslem.Controls.Add(this.txbName);
            this.tabUrunIslem.Controls.Add(this.label2);
            this.tabUrunIslem.Controls.Add(this.label1);
            this.tabUrunIslem.Location = new System.Drawing.Point(4, 22);
            this.tabUrunIslem.Name = "tabUrunIslem";
            this.tabUrunIslem.Padding = new System.Windows.Forms.Padding(3);
            this.tabUrunIslem.Size = new System.Drawing.Size(408, 208);
            this.tabUrunIslem.TabIndex = 1;
            this.tabUrunIslem.Text = "Ürün İşlemleri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ürün Adı :";
            // 
            // txbName
            // 
            this.txbName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbName.Location = new System.Drawing.Point(97, 7);
            this.txbName.Margin = new System.Windows.Forms.Padding(4);
            this.txbName.MaxLength = 10;
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(132, 24);
            this.txbName.TabIndex = 6;
            this.txbName.TextChanged += new System.EventHandler(this.txbNewFirstName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(43, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fiyat :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txbPrice
            // 
            this.txbPrice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txbPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPrice.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPrice.Location = new System.Drawing.Point(97, 39);
            this.txbPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txbPrice.MaxLength = 10;
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(132, 24);
            this.txbPrice.TabIndex = 8;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageUrun);
            this.tabControl.Controls.Add(this.tabUrunIslem);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(416, 234);
            this.tabControl.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.productsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(402, 202);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tabPageUrun
            // 
            this.tabPageUrun.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPageUrun.Controls.Add(this.dataGridView1);
            this.tabPageUrun.Location = new System.Drawing.Point(4, 22);
            this.tabPageUrun.Name = "tabPageUrun";
            this.tabPageUrun.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUrun.Size = new System.Drawing.Size(408, 208);
            this.tabPageUrun.TabIndex = 0;
            this.tabPageUrun.Text = "Ürünler";
            // 
            // productIDDataGridViewTextBoxColumn1
            // 
            this.productIDDataGridViewTextBoxColumn1.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn1.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn1.Name = "productIDDataGridViewTextBoxColumn1";
            this.productIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            // 
            // btBaglan
            // 
            this.btBaglan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btBaglan.BackColor = System.Drawing.Color.SteelBlue;
            this.btBaglan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btBaglan.BackgroundImage")));
            this.btBaglan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btBaglan.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btBaglan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btBaglan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btBaglan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBaglan.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btBaglan.ForeColor = System.Drawing.Color.White;
            this.btBaglan.Image = ((System.Drawing.Image)(resources.GetObject("btBaglan.Image")));
            this.btBaglan.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btBaglan.Location = new System.Drawing.Point(156, 101);
            this.btBaglan.Margin = new System.Windows.Forms.Padding(4);
            this.btBaglan.Name = "btBaglan";
            this.btBaglan.Size = new System.Drawing.Size(100, 100);
            this.btBaglan.TabIndex = 355;
            this.btBaglan.Text = "Güncelle";
            this.btBaglan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btBaglan.UseVisualStyleBackColor = false;
            this.btBaglan.Click += new System.EventHandler(this.btBaglan_Click);
            // 
            // btSil
            // 
            this.btSil.BackColor = System.Drawing.Color.SteelBlue;
            this.btSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSil.BackgroundImage")));
            this.btSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btSil.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btSil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSil.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btSil.ForeColor = System.Drawing.Color.White;
            this.btSil.Image = ((System.Drawing.Image)(resources.GetObject("btSil.Image")));
            this.btSil.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btSil.Location = new System.Drawing.Point(301, 101);
            this.btSil.Margin = new System.Windows.Forms.Padding(4);
            this.btSil.Name = "btSil";
            this.btSil.Size = new System.Drawing.Size(100, 100);
            this.btSil.TabIndex = 356;
            this.btSil.Text = "Sil";
            this.btSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSil.UseVisualStyleBackColor = false;
            this.btSil.Click += new System.EventHandler(this.btSil_Click);
            // 
            // btOnay
            // 
            this.btOnay.BackColor = System.Drawing.Color.SteelBlue;
            this.btOnay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btOnay.BackgroundImage")));
            this.btOnay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btOnay.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btOnay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btOnay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btOnay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOnay.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btOnay.ForeColor = System.Drawing.Color.White;
            this.btOnay.Image = ((System.Drawing.Image)(resources.GetObject("btOnay.Image")));
            this.btOnay.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btOnay.Location = new System.Drawing.Point(7, 101);
            this.btOnay.Margin = new System.Windows.Forms.Padding(4);
            this.btOnay.Name = "btOnay";
            this.btOnay.Size = new System.Drawing.Size(100, 100);
            this.btOnay.TabIndex = 357;
            this.btOnay.Text = "Ekle";
            this.btOnay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btOnay.UseVisualStyleBackColor = false;
            this.btOnay.Click += new System.EventHandler(this.btOnay_Click);
            // 
            // lbUrunName
            // 
            this.lbUrunName.AutoSize = true;
            this.lbUrunName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbUrunName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbUrunName.Location = new System.Drawing.Point(315, 26);
            this.lbUrunName.Name = "lbUrunName";
            this.lbUrunName.Size = new System.Drawing.Size(0, 17);
            this.lbUrunName.TabIndex = 359;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(298, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 358;
            this.label4.Text = "Secili Ürün";
            // 
            // FormUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(444, 299);
            this.Controls.Add(this.btnKayıtOl);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUrun";
            this.Text = "Ürün Bilgisi";
            this.Load += new System.EventHandler(this.FormUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m303SalesDBDataSet8)).EndInit();
            this.tabUrunIslem.ResumeLayout(false);
            this.tabUrunIslem.PerformLayout();
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageUrun.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnKayıtOl;
        private M303SalesDBDataSet8 m303SalesDBDataSet8;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private M303SalesDBDataSet8TableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.TabPage tabUrunIslem;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageUrun;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btBaglan;
        private System.Windows.Forms.Button btSil;
        private System.Windows.Forms.Button btOnay;
        private System.Windows.Forms.Label lbUrunName;
        private System.Windows.Forms.Label label4;
    }
}