namespace Projem
{
    partial class FormUserSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserSettings));
            this.btCreateUser = new System.Windows.Forms.Button();
            this.btDeleteUser = new System.Windows.Forms.Button();
            this.btUpdateUser = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCreateUser
            // 
            this.btCreateUser.BackColor = System.Drawing.Color.SteelBlue;
            this.btCreateUser.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btCreateUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btCreateUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCreateUser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btCreateUser.ForeColor = System.Drawing.Color.White;
            this.btCreateUser.Location = new System.Drawing.Point(105, 40);
            this.btCreateUser.Margin = new System.Windows.Forms.Padding(4);
            this.btCreateUser.Name = "btCreateUser";
            this.btCreateUser.Size = new System.Drawing.Size(191, 26);
            this.btCreateUser.TabIndex = 4;
            this.btCreateUser.Text = "Kullanıcı Ekleme";
            this.btCreateUser.UseVisualStyleBackColor = false;
            this.btCreateUser.Click += new System.EventHandler(this.btCreateUser_Click);
            // 
            // btDeleteUser
            // 
            this.btDeleteUser.BackColor = System.Drawing.Color.SteelBlue;
            this.btDeleteUser.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btDeleteUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btDeleteUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeleteUser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btDeleteUser.Location = new System.Drawing.Point(105, 93);
            this.btDeleteUser.Margin = new System.Windows.Forms.Padding(4);
            this.btDeleteUser.Name = "btDeleteUser";
            this.btDeleteUser.Size = new System.Drawing.Size(191, 26);
            this.btDeleteUser.TabIndex = 5;
            this.btDeleteUser.Text = "Kullanıcı Silme";
            this.btDeleteUser.UseVisualStyleBackColor = false;
            this.btDeleteUser.Click += new System.EventHandler(this.btDeleteUser_Click);
            // 
            // btUpdateUser
            // 
            this.btUpdateUser.BackColor = System.Drawing.Color.SteelBlue;
            this.btUpdateUser.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btUpdateUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btUpdateUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUpdateUser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btUpdateUser.ForeColor = System.Drawing.Color.White;
            this.btUpdateUser.Location = new System.Drawing.Point(105, 144);
            this.btUpdateUser.Margin = new System.Windows.Forms.Padding(4);
            this.btUpdateUser.Name = "btUpdateUser";
            this.btUpdateUser.Size = new System.Drawing.Size(191, 26);
            this.btUpdateUser.TabIndex = 6;
            this.btUpdateUser.Text = "Kullanıcı Güncelleme";
            this.btUpdateUser.UseVisualStyleBackColor = false;
            this.btUpdateUser.Click += new System.EventHandler(this.btUpdateUser_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.SteelBlue;
            this.btExit.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btExit.ForeColor = System.Drawing.Color.White;
            this.btExit.Location = new System.Drawing.Point(337, 182);
            this.btExit.Margin = new System.Windows.Forms.Padding(4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(66, 26);
            this.btExit.TabIndex = 7;
            this.btExit.Text = "Çıkış";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // FormUserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(416, 221);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btUpdateUser);
            this.Controls.Add(this.btDeleteUser);
            this.Controls.Add(this.btCreateUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUserSettings";
            this.Text = "Kullanıcı İşemleri";
            this.Load += new System.EventHandler(this.FormUserSettings_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCreateUser;
        private System.Windows.Forms.Button btDeleteUser;
        private System.Windows.Forms.Button btUpdateUser;
        private System.Windows.Forms.Button btExit;
    }
}