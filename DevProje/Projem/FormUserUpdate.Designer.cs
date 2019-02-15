namespace Projem
{
    partial class FormUserUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserUpdate));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgPersonel = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleInitialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yetkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktiflikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m303SalesDBDataSet5 = new Projem.M303SalesDBDataSet5();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btBaglan = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSube = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbKulTip = new System.Windows.Forms.ComboBox();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTel = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbPhone = new System.Windows.Forms.MaskedTextBox();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.rbKadın = new System.Windows.Forms.RadioButton();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKayıtOl = new System.Windows.Forms.Button();
            this.employeesTableAdapter = new Projem.M303SalesDBDataSet5TableAdapters.EmployeesTableAdapter();
            this.m303SalesDBDataSet7 = new Projem.M303SalesDBDataSet7();
            this.citiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citiesTableAdapter = new Projem.M303SalesDBDataSet7TableAdapters.CitiesTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m303SalesDBDataSet5)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m303SalesDBDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(640, 333);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPage1.Controls.Add(this.dgPersonel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(632, 307);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personel Listesi";
            // 
            // dgPersonel
            // 
            this.dgPersonel.AutoGenerateColumns = false;
            this.dgPersonel.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPersonel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleInitialDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.userPassDataGridViewTextBoxColumn,
            this.yetkiDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.cityIDDataGridViewTextBoxColumn,
            this.cinsiyetDataGridViewTextBoxColumn,
            this.aktiflikDataGridViewTextBoxColumn});
            this.dgPersonel.DataSource = this.employeesBindingSource;
            this.dgPersonel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPersonel.Location = new System.Drawing.Point(3, 3);
            this.dgPersonel.Name = "dgPersonel";
            this.dgPersonel.Size = new System.Drawing.Size(626, 301);
            this.dgPersonel.TabIndex = 0;
            this.dgPersonel.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPersonel_CellDoubleClick);
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // middleInitialDataGridViewTextBoxColumn
            // 
            this.middleInitialDataGridViewTextBoxColumn.DataPropertyName = "MiddleInitial";
            this.middleInitialDataGridViewTextBoxColumn.HeaderText = "MiddleInitial";
            this.middleInitialDataGridViewTextBoxColumn.Name = "middleInitialDataGridViewTextBoxColumn";
            this.middleInitialDataGridViewTextBoxColumn.Visible = false;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // userPassDataGridViewTextBoxColumn
            // 
            this.userPassDataGridViewTextBoxColumn.DataPropertyName = "UserPass";
            this.userPassDataGridViewTextBoxColumn.HeaderText = "UserPass";
            this.userPassDataGridViewTextBoxColumn.Name = "userPassDataGridViewTextBoxColumn";
            this.userPassDataGridViewTextBoxColumn.Visible = false;
            // 
            // yetkiDataGridViewTextBoxColumn
            // 
            this.yetkiDataGridViewTextBoxColumn.DataPropertyName = "Yetki";
            this.yetkiDataGridViewTextBoxColumn.HeaderText = "Yetki";
            this.yetkiDataGridViewTextBoxColumn.Name = "yetkiDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // cityIDDataGridViewTextBoxColumn
            // 
            this.cityIDDataGridViewTextBoxColumn.DataPropertyName = "CityID";
            this.cityIDDataGridViewTextBoxColumn.HeaderText = "CityID";
            this.cityIDDataGridViewTextBoxColumn.Name = "cityIDDataGridViewTextBoxColumn";
            // 
            // cinsiyetDataGridViewTextBoxColumn
            // 
            this.cinsiyetDataGridViewTextBoxColumn.DataPropertyName = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.HeaderText = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.Name = "cinsiyetDataGridViewTextBoxColumn";
            // 
            // aktiflikDataGridViewTextBoxColumn
            // 
            this.aktiflikDataGridViewTextBoxColumn.DataPropertyName = "Aktiflik";
            this.aktiflikDataGridViewTextBoxColumn.HeaderText = "Aktiflik";
            this.aktiflikDataGridViewTextBoxColumn.Name = "aktiflikDataGridViewTextBoxColumn";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.m303SalesDBDataSet5;
            // 
            // m303SalesDBDataSet5
            // 
            this.m303SalesDBDataSet5.DataSetName = "M303SalesDBDataSet5";
            this.m303SalesDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPage2.Controls.Add(this.btBaglan);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cbSube);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cbKulTip);
            this.tabPage2.Controls.Add(this.txbPass);
            this.tabPage2.Controls.Add(this.txbUserName);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.maskedTextBox1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.lbTel);
            this.tabPage2.Controls.Add(this.txbEmail);
            this.tabPage2.Controls.Add(this.txbPhone);
            this.tabPage2.Controls.Add(this.rbErkek);
            this.tabPage2.Controls.Add(this.rbKadın);
            this.tabPage2.Controls.Add(this.txbLastName);
            this.tabPage2.Controls.Add(this.txbFirstName);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(632, 307);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Personel Detayı";
            // 
            // btBaglan
            // 
            this.btBaglan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btBaglan.BackColor = System.Drawing.Color.SteelBlue;
            this.btBaglan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btBaglan.BackgroundImage")));
            this.btBaglan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBaglan.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btBaglan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btBaglan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btBaglan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBaglan.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btBaglan.ForeColor = System.Drawing.Color.White;
            this.btBaglan.Image = ((System.Drawing.Image)(resources.GetObject("btBaglan.Image")));
            this.btBaglan.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btBaglan.Location = new System.Drawing.Point(520, 200);
            this.btBaglan.Margin = new System.Windows.Forms.Padding(4);
            this.btBaglan.Name = "btBaglan";
            this.btBaglan.Size = new System.Drawing.Size(100, 100);
            this.btBaglan.TabIndex = 354;
            this.btBaglan.Text = "Güncelle";
            this.btBaglan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btBaglan.UseVisualStyleBackColor = false;
            this.btBaglan.Click += new System.EventHandler(this.btBaglan_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(318, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 353;
            this.label7.Text = "Kullanıcı Adı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(373, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 352;
            this.label6.Text = "Şifre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(423, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 351;
            this.label4.Text = "Şube :";
            // 
            // cbSube
            // 
            this.cbSube.DataSource = this.citiesBindingSource;
            this.cbSube.DisplayMember = "Şube";
            this.cbSube.FormattingEnabled = true;
            this.cbSube.Location = new System.Drawing.Point(478, 101);
            this.cbSube.Name = "cbSube";
            this.cbSube.Size = new System.Drawing.Size(78, 24);
            this.cbSube.TabIndex = 350;
            this.cbSube.ValueMember = "CitiesID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(372, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 349;
            this.label3.Text = "Kullanıcı Tipi :";
            // 
            // cbKulTip
            // 
            this.cbKulTip.FormattingEnabled = true;
            this.cbKulTip.Items.AddRange(new object[] {
            "Yetkili",
            "Çalışan"});
            this.cbKulTip.Location = new System.Drawing.Point(478, 71);
            this.cbKulTip.Name = "cbKulTip";
            this.cbKulTip.Size = new System.Drawing.Size(78, 24);
            this.cbKulTip.TabIndex = 348;
            // 
            // txbPass
            // 
            this.txbPass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txbPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPass.Location = new System.Drawing.Point(424, 38);
            this.txbPass.Margin = new System.Windows.Forms.Padding(4);
            this.txbPass.MaxLength = 10;
            this.txbPass.Name = "txbPass";
            this.txbPass.PasswordChar = '*';
            this.txbPass.Size = new System.Drawing.Size(132, 23);
            this.txbPass.TabIndex = 347;
            // 
            // txbUserName
            // 
            this.txbUserName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txbUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbUserName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbUserName.Location = new System.Drawing.Point(424, 7);
            this.txbUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txbUserName.MaxLength = 10;
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(132, 24);
            this.txbUserName.TabIndex = 346;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(6, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 345;
            this.label9.Text = "Soyadı :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(7, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 344;
            this.label8.Text = "E-Mail :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(25, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 343;
            this.label5.Text = "Adı :";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox1.Enabled = false;
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.maskedTextBox1.Location = new System.Drawing.Point(120, 141);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(85, 22);
            this.maskedTextBox1.TabIndex = 342;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(45, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 341;
            this.label2.Text = "Cinsiyet :";
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Enabled = false;
            this.lbTel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbTel.Location = new System.Drawing.Point(6, 104);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(58, 17);
            this.lbTel.TabIndex = 340;
            this.lbTel.Text = "Tel No :";
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbEmail.Location = new System.Drawing.Point(73, 72);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txbEmail.MaxLength = 50;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(196, 23);
            this.txbEmail.TabIndex = 336;
            this.txbEmail.TextChanged += new System.EventHandler(this.txbEmail_TextChanged);
            // 
            // txbPhone
            // 
            this.txbPhone.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txbPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPhone.Location = new System.Drawing.Point(73, 102);
            this.txbPhone.Mask = "(999) 000-0000";
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(93, 22);
            this.txbPhone.TabIndex = 335;
            this.txbPhone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txbPhone_MaskInputRejected);
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbErkek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbErkek.Location = new System.Drawing.Point(189, 172);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(62, 20);
            this.rbErkek.TabIndex = 339;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // rbKadın
            // 
            this.rbKadın.AutoSize = true;
            this.rbKadın.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKadın.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbKadın.Location = new System.Drawing.Point(120, 172);
            this.rbKadın.Name = "rbKadın";
            this.rbKadın.Size = new System.Drawing.Size(63, 20);
            this.rbKadın.TabIndex = 337;
            this.rbKadın.Text = "Kadın";
            this.rbKadın.UseVisualStyleBackColor = true;
            // 
            // txbLastName
            // 
            this.txbLastName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txbLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbLastName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbLastName.Location = new System.Drawing.Point(73, 39);
            this.txbLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txbLastName.MaxLength = 10;
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(132, 23);
            this.txbLastName.TabIndex = 334;
            // 
            // txbFirstName
            // 
            this.txbFirstName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txbFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbFirstName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbFirstName.Location = new System.Drawing.Point(73, 7);
            this.txbFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txbFirstName.MaxLength = 10;
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(132, 24);
            this.txbFirstName.TabIndex = 333;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(9, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 338;
            this.label1.Text = "Doğum Tarihi :";
            // 
            // btnKayıtOl
            // 
            this.btnKayıtOl.BackColor = System.Drawing.Color.SteelBlue;
            this.btnKayıtOl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKayıtOl.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnKayıtOl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnKayıtOl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnKayıtOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayıtOl.Font = new System.Drawing.Font("Century Gothic", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayıtOl.ForeColor = System.Drawing.Color.White;
            this.btnKayıtOl.Location = new System.Drawing.Point(559, 390);
            this.btnKayıtOl.Margin = new System.Windows.Forms.Padding(4);
            this.btnKayıtOl.Name = "btnKayıtOl";
            this.btnKayıtOl.Size = new System.Drawing.Size(93, 27);
            this.btnKayıtOl.TabIndex = 5;
            this.btnKayıtOl.Text = "Çıkış";
            this.btnKayıtOl.UseVisualStyleBackColor = false;
            this.btnKayıtOl.Click += new System.EventHandler(this.btnKayıtOl_Click);
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // m303SalesDBDataSet7
            // 
            this.m303SalesDBDataSet7.DataSetName = "M303SalesDBDataSet7";
            this.m303SalesDBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // citiesBindingSource
            // 
            this.citiesBindingSource.DataMember = "Cities";
            this.citiesBindingSource.DataSource = this.m303SalesDBDataSet7;
            // 
            // citiesTableAdapter
            // 
            this.citiesTableAdapter.ClearBeforeFill = true;
            // 
            // FormUserUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(664, 430);
            this.Controls.Add(this.btnKayıtOl);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUserUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Güncelleme";
            this.Load += new System.EventHandler(this.FormUserUpdate_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m303SalesDBDataSet5)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m303SalesDBDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgPersonel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.MaskedTextBox txbPhone;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.RadioButton rbKadın;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSube;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbKulTip;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Button btBaglan;
        private System.Windows.Forms.Button btnKayıtOl;
        private M303SalesDBDataSet5 m303SalesDBDataSet5;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private M303SalesDBDataSet5TableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleInitialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yetkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aktiflikDataGridViewTextBoxColumn;
        private M303SalesDBDataSet7 m303SalesDBDataSet7;
        private System.Windows.Forms.BindingSource citiesBindingSource;
        private M303SalesDBDataSet7TableAdapters.CitiesTableAdapter citiesTableAdapter;
    }
}