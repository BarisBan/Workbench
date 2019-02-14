namespace Projem
{
    partial class FormForgetMyPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForgetMyPassword));
            this.txbforgetmypass = new System.Windows.Forms.TextBox();
            this.btBaglan = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbforgetmypass
            // 
            this.txbforgetmypass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txbforgetmypass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbforgetmypass.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbforgetmypass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbforgetmypass.Location = new System.Drawing.Point(37, 24);
            this.txbforgetmypass.Margin = new System.Windows.Forms.Padding(4);
            this.txbforgetmypass.MaxLength = 50;
            this.txbforgetmypass.Name = "txbforgetmypass";
            this.txbforgetmypass.Size = new System.Drawing.Size(257, 24);
            this.txbforgetmypass.TabIndex = 1;
            this.txbforgetmypass.Text = "Email Adresinizi Giriniz";
            // 
            // btBaglan
            // 
            this.btBaglan.BackColor = System.Drawing.Color.SteelBlue;
            this.btBaglan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btBaglan.BackgroundImage")));
            this.btBaglan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBaglan.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btBaglan.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btBaglan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btBaglan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btBaglan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBaglan.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btBaglan.ForeColor = System.Drawing.Color.White;
            this.btBaglan.Image = ((System.Drawing.Image)(resources.GetObject("btBaglan.Image")));
            this.btBaglan.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btBaglan.Location = new System.Drawing.Point(104, 65);
            this.btBaglan.Margin = new System.Windows.Forms.Padding(4);
            this.btBaglan.Name = "btBaglan";
            this.btBaglan.Size = new System.Drawing.Size(120, 120);
            this.btBaglan.TabIndex = 11;
            this.btBaglan.Text = " Kurtarma Şifresi Gönder";
            this.btBaglan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btBaglan.UseVisualStyleBackColor = false;
            this.btBaglan.Click += new System.EventHandler(this.btBaglan_Click);
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
            this.btnExit.Location = new System.Drawing.Point(265, 191);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 26);
            this.btnExit.TabIndex = 334;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormForgetMyPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(324, 219);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btBaglan);
            this.Controls.Add(this.txbforgetmypass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormForgetMyPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifremi Unuttum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbforgetmypass;
        private System.Windows.Forms.Button btBaglan;
        private System.Windows.Forms.Button btnExit;
    }
}