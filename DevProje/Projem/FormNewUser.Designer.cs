namespace Projem
{
    partial class FormNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewUser));
            this.lbTel = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbPhone = new System.Windows.Forms.MaskedTextBox();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.rbKadın = new System.Windows.Forms.RadioButton();
            this.btOnay = new System.Windows.Forms.Button();
            this.txbNewLastName = new System.Windows.Forms.TextBox();
            this.txbNewFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNewPass = new System.Windows.Forms.TextBox();
            this.txbNewUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKulTip = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSube = new System.Windows.Forms.ComboBox();
            this.citiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m303SalesDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m303SalesDBDataSet = new Projem.M303SalesDBDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.mtbDogum = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btSil = new System.Windows.Forms.Button();
            this.citiesTableAdapter = new Projem.M303SalesDBDataSetTableAdapters.CitiesTableAdapter();
            this.m303SalesDBDataSet1 = new Projem.M303SalesDBDataSet1();
            this.newUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newUserTableAdapter = new Projem.M303SalesDBDataSet1TableAdapters.NewUserTableAdapter();
            this.m303SalesDBDataSet2 = new Projem.M303SalesDBDataSet2();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new Projem.M303SalesDBDataSet2TableAdapters.EmployeesTableAdapter();
            this.m303SalesDBDataSet3 = new Projem.M303SalesDBDataSet3();
            this.employeesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter1 = new Projem.M303SalesDBDataSet3TableAdapters.EmployeesTableAdapter();
            this.m303SalesDBDataSet4 = new Projem.M303SalesDBDataSet4();
            this.newUserBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.newUserTableAdapter1 = new Projem.M303SalesDBDataSet4TableAdapters.NewUserTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.newUserIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleInitialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yetkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m303SalesDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m303SalesDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m303SalesDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m303SalesDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m303SalesDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m303SalesDBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newUserBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Enabled = false;
            this.lbTel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbTel.Location = new System.Drawing.Point(9, 108);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(58, 17);
            this.lbTel.TabIndex = 320;
            this.lbTel.Text = "Tel No :";
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbEmail.Enabled = false;
            this.txbEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbEmail.Location = new System.Drawing.Point(76, 76);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txbEmail.MaxLength = 50;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(232, 23);
            this.txbEmail.TabIndex = 310;
            // 
            // txbPhone
            // 
            this.txbPhone.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txbPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPhone.Enabled = false;
            this.txbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPhone.Location = new System.Drawing.Point(76, 106);
            this.txbPhone.Mask = "(999) 000-0000";
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(93, 22);
            this.txbPhone.TabIndex = 309;
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Enabled = false;
            this.rbErkek.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbErkek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbErkek.Location = new System.Drawing.Point(483, 42);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(62, 20);
            this.rbErkek.TabIndex = 314;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // rbKadın
            // 
            this.rbKadın.AutoSize = true;
            this.rbKadın.Enabled = false;
            this.rbKadın.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKadın.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbKadın.Location = new System.Drawing.Point(414, 42);
            this.rbKadın.Name = "rbKadın";
            this.rbKadın.Size = new System.Drawing.Size(63, 20);
            this.rbKadın.TabIndex = 312;
            this.rbKadın.Text = "Kadın";
            this.rbKadın.UseVisualStyleBackColor = true;
            // 
            // btOnay
            // 
            this.btOnay.BackColor = System.Drawing.Color.SteelBlue;
            this.btOnay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btOnay.BackgroundImage")));
            this.btOnay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btOnay.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btOnay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btOnay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btOnay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOnay.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btOnay.ForeColor = System.Drawing.Color.White;
            this.btOnay.Image = ((System.Drawing.Image)(resources.GetObject("btOnay.Image")));
            this.btOnay.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btOnay.Location = new System.Drawing.Point(586, 140);
            this.btOnay.Margin = new System.Windows.Forms.Padding(4);
            this.btOnay.Name = "btOnay";
            this.btOnay.Size = new System.Drawing.Size(100, 100);
            this.btOnay.TabIndex = 318;
            this.btOnay.Text = "Onayla";
            this.btOnay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btOnay.UseVisualStyleBackColor = false;
            this.btOnay.Click += new System.EventHandler(this.btOnay_Click);
            // 
            // txbNewLastName
            // 
            this.txbNewLastName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txbNewLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNewLastName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbNewLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbNewLastName.Location = new System.Drawing.Point(76, 43);
            this.txbNewLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txbNewLastName.MaxLength = 10;
            this.txbNewLastName.Name = "txbNewLastName";
            this.txbNewLastName.Size = new System.Drawing.Size(132, 23);
            this.txbNewLastName.TabIndex = 308;
            // 
            // txbNewFirstName
            // 
            this.txbNewFirstName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txbNewFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNewFirstName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbNewFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbNewFirstName.Location = new System.Drawing.Point(76, 11);
            this.txbNewFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txbNewFirstName.MaxLength = 10;
            this.txbNewFirstName.Name = "txbNewFirstName";
            this.txbNewFirstName.Size = new System.Drawing.Size(132, 24);
            this.txbNewFirstName.TabIndex = 307;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(303, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 313;
            this.label1.Text = "Doğum Tarihi :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbNewPass
            // 
            this.txbNewPass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txbNewPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNewPass.Enabled = false;
            this.txbNewPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbNewPass.Location = new System.Drawing.Point(115, 211);
            this.txbNewPass.Margin = new System.Windows.Forms.Padding(4);
            this.txbNewPass.MaxLength = 10;
            this.txbNewPass.Name = "txbNewPass";
            this.txbNewPass.PasswordChar = '*';
            this.txbNewPass.Size = new System.Drawing.Size(132, 23);
            this.txbNewPass.TabIndex = 316;
            // 
            // txbNewUserName
            // 
            this.txbNewUserName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txbNewUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNewUserName.Enabled = false;
            this.txbNewUserName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbNewUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbNewUserName.Location = new System.Drawing.Point(115, 180);
            this.txbNewUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txbNewUserName.MaxLength = 10;
            this.txbNewUserName.Name = "txbNewUserName";
            this.txbNewUserName.Size = new System.Drawing.Size(132, 24);
            this.txbNewUserName.TabIndex = 315;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(339, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 321;
            this.label2.Text = "Cinsiyet :";
            // 
            // cbKulTip
            // 
            this.cbKulTip.FormattingEnabled = true;
            this.cbKulTip.Items.AddRange(new object[] {
            "Yetkili",
            "Personel"});
            this.cbKulTip.Location = new System.Drawing.Point(414, 181);
            this.cbKulTip.Name = "cbKulTip";
            this.cbKulTip.Size = new System.Drawing.Size(78, 21);
            this.cbKulTip.TabIndex = 322;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(308, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 323;
            this.label3.Text = "Kullanıcı Tipi :";
            // 
            // cbSube
            // 
            this.cbSube.DataSource = this.citiesBindingSource;
            this.cbSube.DisplayMember = "Şube";
            this.cbSube.FormattingEnabled = true;
            this.cbSube.Location = new System.Drawing.Point(414, 208);
            this.cbSube.Name = "cbSube";
            this.cbSube.Size = new System.Drawing.Size(78, 21);
            this.cbSube.TabIndex = 324;
            this.cbSube.ValueMember = "CitiesID";
            // 
            // citiesBindingSource
            // 
            this.citiesBindingSource.DataMember = "Cities";
            this.citiesBindingSource.DataSource = this.m303SalesDBDataSetBindingSource;
            // 
            // m303SalesDBDataSetBindingSource
            // 
            this.m303SalesDBDataSetBindingSource.DataSource = this.m303SalesDBDataSet;
            this.m303SalesDBDataSetBindingSource.Position = 0;
            // 
            // m303SalesDBDataSet
            // 
            this.m303SalesDBDataSet.DataSetName = "M303SalesDBDataSet";
            this.m303SalesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(359, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 325;
            this.label4.Text = "Şube :";
            // 
            // mtbDogum
            // 
            this.mtbDogum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mtbDogum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbDogum.Enabled = false;
            this.mtbDogum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtbDogum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mtbDogum.Location = new System.Drawing.Point(414, 11);
            this.mtbDogum.Mask = "00/00/0000";
            this.mtbDogum.Name = "mtbDogum";
            this.mtbDogum.Size = new System.Drawing.Size(93, 22);
            this.mtbDogum.TabIndex = 327;
            this.mtbDogum.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(28, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 328;
            this.label5.Text = "Adı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(64, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 329;
            this.label6.Text = "Şifre :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(9, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 330;
            this.label7.Text = "Kullanıcı Adı :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(10, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 331;
            this.label8.Text = "E-Mail :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(9, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 332;
            this.label9.Text = "Soyadı :";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(584, 419);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 26);
            this.btnExit.TabIndex = 333;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btSil
            // 
            this.btSil.BackColor = System.Drawing.Color.SteelBlue;
            this.btSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSil.BackgroundImage")));
            this.btSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSil.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btSil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSil.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btSil.ForeColor = System.Drawing.Color.White;
            this.btSil.Image = ((System.Drawing.Image)(resources.GetObject("btSil.Image")));
            this.btSil.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btSil.Location = new System.Drawing.Point(587, 13);
            this.btSil.Margin = new System.Windows.Forms.Padding(4);
            this.btSil.Name = "btSil";
            this.btSil.Size = new System.Drawing.Size(100, 100);
            this.btSil.TabIndex = 334;
            this.btSil.Text = "Sil";
            this.btSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSil.UseVisualStyleBackColor = false;
            this.btSil.Click += new System.EventHandler(this.btSil_Click);
            // 
            // citiesTableAdapter
            // 
            this.citiesTableAdapter.ClearBeforeFill = true;
            // 
            // m303SalesDBDataSet1
            // 
            this.m303SalesDBDataSet1.DataSetName = "M303SalesDBDataSet1";
            this.m303SalesDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newUserBindingSource
            // 
            this.newUserBindingSource.DataMember = "NewUser";
            this.newUserBindingSource.DataSource = this.m303SalesDBDataSet1;
            // 
            // newUserTableAdapter
            // 
            this.newUserTableAdapter.ClearBeforeFill = true;
            // 
            // m303SalesDBDataSet2
            // 
            this.m303SalesDBDataSet2.DataSetName = "M303SalesDBDataSet2";
            this.m303SalesDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.m303SalesDBDataSet2;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // m303SalesDBDataSet3
            // 
            this.m303SalesDBDataSet3.DataSetName = "M303SalesDBDataSet3";
            this.m303SalesDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource1
            // 
            this.employeesBindingSource1.DataMember = "Employees";
            this.employeesBindingSource1.DataSource = this.m303SalesDBDataSet3;
            // 
            // employeesTableAdapter1
            // 
            this.employeesTableAdapter1.ClearBeforeFill = true;
            // 
            // m303SalesDBDataSet4
            // 
            this.m303SalesDBDataSet4.DataSetName = "M303SalesDBDataSet4";
            this.m303SalesDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newUserBindingSource1
            // 
            this.newUserBindingSource1.DataMember = "NewUser";
            this.newUserBindingSource1.DataSource = this.m303SalesDBDataSet4;
            // 
            // newUserTableAdapter1
            // 
            this.newUserTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.newUserIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleInitialDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.userPassDataGridViewTextBoxColumn,
            this.yetkiDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.cinsiyetDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.newUserBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(7, 247);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(679, 165);
            this.dataGridView1.TabIndex = 335;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // newUserIDDataGridViewTextBoxColumn
            // 
            this.newUserIDDataGridViewTextBoxColumn.DataPropertyName = "NewUserID";
            this.newUserIDDataGridViewTextBoxColumn.HeaderText = "NewUserID";
            this.newUserIDDataGridViewTextBoxColumn.Name = "newUserIDDataGridViewTextBoxColumn";
            this.newUserIDDataGridViewTextBoxColumn.ReadOnly = true;
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
            // cinsiyetDataGridViewTextBoxColumn
            // 
            this.cinsiyetDataGridViewTextBoxColumn.DataPropertyName = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.HeaderText = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.Name = "cinsiyetDataGridViewTextBoxColumn";
            // 
            // FormNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(694, 448);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btSil);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mtbDogum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbSube);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbKulTip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTel);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbPhone);
            this.Controls.Add(this.rbErkek);
            this.Controls.Add(this.rbKadın);
            this.Controls.Add(this.btOnay);
            this.Controls.Add(this.txbNewLastName);
            this.Controls.Add(this.txbNewFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbNewPass);
            this.Controls.Add(this.txbNewUserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNewUser";
            this.Text = "Kullanıcı Ekleme";
            this.Load += new System.EventHandler(this.FormNewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m303SalesDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m303SalesDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m303SalesDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m303SalesDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m303SalesDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m303SalesDBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newUserBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.MaskedTextBox txbPhone;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.RadioButton rbKadın;
        private System.Windows.Forms.Button btOnay;
        private System.Windows.Forms.TextBox txbNewLastName;
        private System.Windows.Forms.TextBox txbNewFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNewPass;
        private System.Windows.Forms.TextBox txbNewUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKulTip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSube;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtbDogum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btSil;
        private System.Windows.Forms.BindingSource m303SalesDBDataSetBindingSource;
        private M303SalesDBDataSet m303SalesDBDataSet;
        private System.Windows.Forms.BindingSource citiesBindingSource;
        private M303SalesDBDataSetTableAdapters.CitiesTableAdapter citiesTableAdapter;
        private M303SalesDBDataSet1 m303SalesDBDataSet1;
        private System.Windows.Forms.BindingSource newUserBindingSource;
        private M303SalesDBDataSet1TableAdapters.NewUserTableAdapter newUserTableAdapter;
        private M303SalesDBDataSet2 m303SalesDBDataSet2;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private M303SalesDBDataSet2TableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private M303SalesDBDataSet3 m303SalesDBDataSet3;
        private System.Windows.Forms.BindingSource employeesBindingSource1;
        private M303SalesDBDataSet3TableAdapters.EmployeesTableAdapter employeesTableAdapter1;
        private M303SalesDBDataSet4 m303SalesDBDataSet4;
        private System.Windows.Forms.BindingSource newUserBindingSource1;
        private M303SalesDBDataSet4TableAdapters.NewUserTableAdapter newUserTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn newUserIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleInitialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yetkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
    }
}