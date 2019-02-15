namespace Projem
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.btBaglan = new System.Windows.Forms.Button();
            this.btUnut = new System.Windows.Forms.Button();
            this.btnKayıtOl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbUserName
            // 
            this.txbUserName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txbUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbUserName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbUserName.Location = new System.Drawing.Point(13, 13);
            this.txbUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txbUserName.MaxLength = 10;
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(132, 24);
            this.txbUserName.TabIndex = 0;
            this.txbUserName.Text = "Kullanıcı Adı";
            this.txbUserName.TextChanged += new System.EventHandler(this.txbUserName_TextChanged);
            // 
            // txbPass
            // 
            this.txbPass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txbPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPass.Location = new System.Drawing.Point(13, 44);
            this.txbPass.Margin = new System.Windows.Forms.Padding(4);
            this.txbPass.MaxLength = 10;
            this.txbPass.Name = "txbPass";
            this.txbPass.PasswordChar = '*';
            this.txbPass.Size = new System.Drawing.Size(132, 23);
            this.txbPass.TabIndex = 1;
            this.txbPass.Text = "Sifre";
            this.txbPass.TextChanged += new System.EventHandler(this.txbPass_TextChanged);
            // 
            // btBaglan
            // 
            this.btBaglan.BackColor = System.Drawing.Color.SteelBlue;
            this.btBaglan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBaglan.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btBaglan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btBaglan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btBaglan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBaglan.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btBaglan.ForeColor = System.Drawing.Color.White;
            this.btBaglan.Image = ((System.Drawing.Image)(resources.GetObject("btBaglan.Image")));
            this.btBaglan.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btBaglan.Location = new System.Drawing.Point(190, 15);
            this.btBaglan.Margin = new System.Windows.Forms.Padding(4);
            this.btBaglan.Name = "btBaglan";
            this.btBaglan.Size = new System.Drawing.Size(120, 120);
            this.btBaglan.TabIndex = 2;
            this.btBaglan.Text = "  Bağlan";
            this.btBaglan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btBaglan.UseVisualStyleBackColor = false;
            this.btBaglan.Click += new System.EventHandler(this.btBaglan_Click);
            // 
            // btUnut
            // 
            this.btUnut.BackColor = System.Drawing.Color.SteelBlue;
            this.btUnut.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btUnut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btUnut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btUnut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUnut.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btUnut.ForeColor = System.Drawing.Color.White;
            this.btUnut.Location = new System.Drawing.Point(13, 109);
            this.btUnut.Margin = new System.Windows.Forms.Padding(4);
            this.btUnut.Name = "btUnut";
            this.btUnut.Size = new System.Drawing.Size(103, 26);
            this.btUnut.TabIndex = 3;
            this.btUnut.Text = "Şifremi Unuttum";
            this.btUnut.UseVisualStyleBackColor = false;
            this.btUnut.Click += new System.EventHandler(this.btUnut_Click);
            // 
            // btnKayıtOl
            // 
            this.btnKayıtOl.BackColor = System.Drawing.Color.SteelBlue;
            this.btnKayıtOl.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnKayıtOl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnKayıtOl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnKayıtOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayıtOl.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayıtOl.ForeColor = System.Drawing.Color.White;
            this.btnKayıtOl.Location = new System.Drawing.Point(13, 75);
            this.btnKayıtOl.Margin = new System.Windows.Forms.Padding(4);
            this.btnKayıtOl.Name = "btnKayıtOl";
            this.btnKayıtOl.Size = new System.Drawing.Size(103, 26);
            this.btnKayıtOl.TabIndex = 4;
            this.btnKayıtOl.Text = "Kayıt Ol";
            this.btnKayıtOl.UseVisualStyleBackColor = false;
            this.btnKayıtOl.Click += new System.EventHandler(this.btnKayıtOl_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(323, 150);
            this.Controls.Add(this.btnKayıtOl);
            this.Controls.Add(this.btUnut);
            this.Controls.Add(this.btBaglan);
            this.Controls.Add(this.txbPass);
            this.Controls.Add(this.txbUserName);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.Button btUnut;
        private System.Windows.Forms.Button btnKayıtOl;
        private System.Windows.Forms.Button btBaglan;
    }
}