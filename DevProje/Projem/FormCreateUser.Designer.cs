namespace Projem
{
    partial class FormCreateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateUser));
            this.txbNewPass = new System.Windows.Forms.TextBox();
            this.txbNewUserName = new System.Windows.Forms.TextBox();
            this.txbCheck = new System.Windows.Forms.TextBox();
            this.dtNewBirth = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNewLastName = new System.Windows.Forms.TextBox();
            this.txbNewFirstName = new System.Windows.Forms.TextBox();
            this.btBaglan = new System.Windows.Forms.Button();
            this.rbKadın = new System.Windows.Forms.RadioButton();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.citiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m303SalesDBDataSet = new Projem.M303SalesDBDataSet();
            this.citiesTableAdapter = new Projem.M303SalesDBDataSetTableAdapters.CitiesTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.txbPhone = new System.Windows.Forms.MaskedTextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lbTel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m303SalesDBDataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbNewPass
            // 
            this.txbNewPass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txbNewPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNewPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbNewPass.Location = new System.Drawing.Point(13, 219);
            this.txbNewPass.Margin = new System.Windows.Forms.Padding(4);
            this.txbNewPass.MaxLength = 10;
            this.txbNewPass.Name = "txbNewPass";
            this.txbNewPass.Size = new System.Drawing.Size(132, 23);
            this.txbNewPass.TabIndex = 8;
            this.txbNewPass.Text = "Şifre";
            // 
            // txbNewUserName
            // 
            this.txbNewUserName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txbNewUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNewUserName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbNewUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbNewUserName.Location = new System.Drawing.Point(13, 188);
            this.txbNewUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txbNewUserName.MaxLength = 10;
            this.txbNewUserName.Name = "txbNewUserName";
            this.txbNewUserName.Size = new System.Drawing.Size(132, 24);
            this.txbNewUserName.TabIndex = 7;
            this.txbNewUserName.Text = "Kullanıcı Adı";
            // 
            // txbCheck
            // 
            this.txbCheck.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txbCheck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCheck.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbCheck.Location = new System.Drawing.Point(13, 250);
            this.txbCheck.Margin = new System.Windows.Forms.Padding(4);
            this.txbCheck.MaxLength = 10;
            this.txbCheck.Name = "txbCheck";
            this.txbCheck.Size = new System.Drawing.Size(132, 23);
            this.txbCheck.TabIndex = 9;
            this.txbCheck.Text = "Şifre Tekrar";
            // 
            // dtNewBirth
            // 
            this.dtNewBirth.CalendarFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtNewBirth.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtNewBirth.CalendarMonthBackground = System.Drawing.Color.DeepSkyBlue;
            this.dtNewBirth.CalendarTitleBackColor = System.Drawing.SystemColors.ControlLight;
            this.dtNewBirth.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDark;
            this.dtNewBirth.Location = new System.Drawing.Point(288, 12);
            this.dtNewBirth.Name = "dtNewBirth";
            this.dtNewBirth.Size = new System.Drawing.Size(136, 20);
            this.dtNewBirth.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(177, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Doğum Tarihi :";
            // 
            // txbNewLastName
            // 
            this.txbNewLastName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txbNewLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNewLastName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbNewLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbNewLastName.Location = new System.Drawing.Point(13, 44);
            this.txbNewLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txbNewLastName.MaxLength = 10;
            this.txbNewLastName.Name = "txbNewLastName";
            this.txbNewLastName.Size = new System.Drawing.Size(132, 23);
            this.txbNewLastName.TabIndex = 1;
            this.txbNewLastName.Text = "Soyadınız";
            // 
            // txbNewFirstName
            // 
            this.txbNewFirstName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txbNewFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNewFirstName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbNewFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbNewFirstName.Location = new System.Drawing.Point(13, 13);
            this.txbNewFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txbNewFirstName.MaxLength = 10;
            this.txbNewFirstName.Name = "txbNewFirstName";
            this.txbNewFirstName.Size = new System.Drawing.Size(132, 24);
            this.txbNewFirstName.TabIndex = 0;
            this.txbNewFirstName.Text = "Adınız";
            // 
            // btBaglan
            // 
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
            this.btBaglan.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btBaglan.Location = new System.Drawing.Point(304, 153);
            this.btBaglan.Margin = new System.Windows.Forms.Padding(4);
            this.btBaglan.Name = "btBaglan";
            this.btBaglan.Size = new System.Drawing.Size(120, 120);
            this.btBaglan.TabIndex = 17;
            this.btBaglan.Text = "Kayıt Ol";
            this.btBaglan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btBaglan.UseVisualStyleBackColor = false;
            this.btBaglan.Click += new System.EventHandler(this.btBaglan_Click);
            // 
            // rbKadın
            // 
            this.rbKadın.AutoSize = true;
            this.rbKadın.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKadın.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbKadın.Location = new System.Drawing.Point(191, 44);
            this.rbKadın.Name = "rbKadın";
            this.rbKadın.Size = new System.Drawing.Size(63, 20);
            this.rbKadın.TabIndex = 5;
            this.rbKadın.Text = "Kadın";
            this.rbKadın.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbErkek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbErkek.Location = new System.Drawing.Point(260, 44);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(62, 20);
            this.rbErkek.TabIndex = 6;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Checked = true;
            this.rbNone.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbNone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbNone.Location = new System.Drawing.Point(329, 44);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(60, 20);
            this.rbNone.TabIndex = 300;
            this.rbNone.TabStop = true;
            this.rbNone.Text = "None";
            this.rbNone.UseVisualStyleBackColor = true;
            this.rbNone.Visible = false;
            // 
            // citiesBindingSource
            // 
            this.citiesBindingSource.DataMember = "Cities";
            this.citiesBindingSource.DataSource = this.m303SalesDBDataSet;
            // 
            // m303SalesDBDataSet
            // 
            this.m303SalesDBDataSet.DataSetName = "M303SalesDBDataSet";
            this.m303SalesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // citiesTableAdapter
            // 
            this.citiesTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(644, 25);
            this.fillByToolStrip.TabIndex = 303;
            this.fillByToolStrip.Text = "fillByToolStrip";
            this.fillByToolStrip.Visible = false;
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // txbPhone
            // 
            this.txbPhone.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txbPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPhone.Location = new System.Drawing.Point(73, 75);
            this.txbPhone.Mask = "(999) 000-0000";
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(93, 22);
            this.txbPhone.TabIndex = 304;
            this.txbPhone.Text = "5";
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbEmail.Location = new System.Drawing.Point(13, 106);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txbEmail.MaxLength = 50;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(224, 23);
            this.txbEmail.TabIndex = 305;
            this.txbEmail.Text = "Email Adresiniz";
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbTel.Location = new System.Drawing.Point(10, 77);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(57, 17);
            this.lbTel.TabIndex = 306;
            this.lbTel.Text = "Tel NO:";
            this.lbTel.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormCreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(440, 284);
            this.Controls.Add(this.lbTel);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbPhone);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.rbNone);
            this.Controls.Add(this.rbErkek);
            this.Controls.Add(this.rbKadın);
            this.Controls.Add(this.btBaglan);
            this.Controls.Add(this.txbNewLastName);
            this.Controls.Add(this.txbNewFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtNewBirth);
            this.Controls.Add(this.txbCheck);
            this.Controls.Add(this.txbNewPass);
            this.Controls.Add(this.txbNewUserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCreateUser";
            this.Text = "Şube";
            this.Load += new System.EventHandler(this.FormCreateUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m303SalesDBDataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNewPass;
        private System.Windows.Forms.TextBox txbNewUserName;
        private System.Windows.Forms.TextBox txbCheck;
        private System.Windows.Forms.DateTimePicker dtNewBirth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNewLastName;
        private System.Windows.Forms.TextBox txbNewFirstName;
        private System.Windows.Forms.Button btBaglan;
        private System.Windows.Forms.RadioButton rbKadın;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.RadioButton rbNone;
        private M303SalesDBDataSet m303SalesDBDataSet;
        private System.Windows.Forms.BindingSource citiesBindingSource;
        private M303SalesDBDataSetTableAdapters.CitiesTableAdapter citiesTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.MaskedTextBox txbPhone;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lbTel;
    }
}