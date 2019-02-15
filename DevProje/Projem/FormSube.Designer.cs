namespace Projem
{
    partial class FormSube
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSube));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.citiesIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.şubeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m303SalesDBDataSet9 = new Projem.M303SalesDBDataSet9();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btOnay = new System.Windows.Forms.Button();
            this.btSil = new System.Windows.Forms.Button();
            this.lbUrunName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.citiesTableAdapter = new Projem.M303SalesDBDataSet9TableAdapters.CitiesTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m303SalesDBDataSet9)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(436, 234);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(428, 208);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Şubeler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.citiesIDDataGridViewTextBoxColumn,
            this.şubeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.citiesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(422, 202);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // citiesIDDataGridViewTextBoxColumn
            // 
            this.citiesIDDataGridViewTextBoxColumn.DataPropertyName = "CitiesID";
            this.citiesIDDataGridViewTextBoxColumn.HeaderText = "CitiesID";
            this.citiesIDDataGridViewTextBoxColumn.Name = "citiesIDDataGridViewTextBoxColumn";
            this.citiesIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // şubeDataGridViewTextBoxColumn
            // 
            this.şubeDataGridViewTextBoxColumn.DataPropertyName = "Şube";
            this.şubeDataGridViewTextBoxColumn.HeaderText = "Şube";
            this.şubeDataGridViewTextBoxColumn.Name = "şubeDataGridViewTextBoxColumn";
            // 
            // citiesBindingSource
            // 
            this.citiesBindingSource.DataMember = "Cities";
            this.citiesBindingSource.DataSource = this.m303SalesDBDataSet9;
            // 
            // m303SalesDBDataSet9
            // 
            this.m303SalesDBDataSet9.DataSetName = "M303SalesDBDataSet9";
            this.m303SalesDBDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.btOnay);
            this.tabPage2.Controls.Add(this.btSil);
            this.tabPage2.Controls.Add(this.lbUrunName);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txbName);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(428, 208);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Şube İşlemler";
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
            this.btOnay.Location = new System.Drawing.Point(9, 101);
            this.btOnay.Margin = new System.Windows.Forms.Padding(4);
            this.btOnay.Name = "btOnay";
            this.btOnay.Size = new System.Drawing.Size(100, 100);
            this.btOnay.TabIndex = 368;
            this.btOnay.Text = "Ekle";
            this.btOnay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btOnay.UseVisualStyleBackColor = false;
            this.btOnay.Click += new System.EventHandler(this.btOnay_Click);
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
            this.btSil.Location = new System.Drawing.Point(321, 101);
            this.btSil.Margin = new System.Windows.Forms.Padding(4);
            this.btSil.Name = "btSil";
            this.btSil.Size = new System.Drawing.Size(100, 100);
            this.btSil.TabIndex = 367;
            this.btSil.Text = "Sil";
            this.btSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSil.UseVisualStyleBackColor = false;
            this.btSil.Click += new System.EventHandler(this.btSil_Click);
            // 
            // lbUrunName
            // 
            this.lbUrunName.AutoSize = true;
            this.lbUrunName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbUrunName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbUrunName.Location = new System.Drawing.Point(300, 26);
            this.lbUrunName.Name = "lbUrunName";
            this.lbUrunName.Size = new System.Drawing.Size(0, 17);
            this.lbUrunName.TabIndex = 365;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(283, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 364;
            this.label4.Text = "Secili Şube";
            // 
            // txbName
            // 
            this.txbName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbName.Location = new System.Drawing.Point(82, 7);
            this.txbName.Margin = new System.Windows.Forms.Padding(4);
            this.txbName.MaxLength = 10;
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(132, 24);
            this.txbName.TabIndex = 360;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 361;
            this.label1.Text = "Şube Adı :";
            // 
            // citiesTableAdapter
            // 
            this.citiesTableAdapter.ClearBeforeFill = true;
            // 
            // FormSube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(460, 323);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSube";
            this.Text = "Sube";
            this.Load += new System.EventHandler(this.Sube_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m303SalesDBDataSet9)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private M303SalesDBDataSet9 m303SalesDBDataSet9;
        private System.Windows.Forms.BindingSource citiesBindingSource;
        private M303SalesDBDataSet9TableAdapters.CitiesTableAdapter citiesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn citiesIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn şubeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbUrunName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btOnay;
        private System.Windows.Forms.Button btSil;
    }
}