namespace Projem
{
    partial class FormStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStock));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageUrun = new System.Windows.Forms.TabPage();
            this.tabPageEkle = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPageGuncelle = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnKayıtOl = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageUrun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageUrun);
            this.tabControl.Controls.Add(this.tabPageEkle);
            this.tabControl.Controls.Add(this.tabPageGuncelle);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(702, 292);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageUrun
            // 
            this.tabPageUrun.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPageUrun.Controls.Add(this.dataGridView1);
            this.tabPageUrun.Location = new System.Drawing.Point(4, 22);
            this.tabPageUrun.Name = "tabPageUrun";
            this.tabPageUrun.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUrun.Size = new System.Drawing.Size(688, 294);
            this.tabPageUrun.TabIndex = 0;
            this.tabPageUrun.Text = "Ürünler";
            // 
            // tabPageEkle
            // 
            this.tabPageEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPageEkle.Location = new System.Drawing.Point(4, 22);
            this.tabPageEkle.Name = "tabPageEkle";
            this.tabPageEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEkle.Size = new System.Drawing.Size(688, 294);
            this.tabPageEkle.TabIndex = 1;
            this.tabPageEkle.Text = "Ekle ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(682, 288);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPageGuncelle
            // 
            this.tabPageGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPageGuncelle.Location = new System.Drawing.Point(4, 22);
            this.tabPageGuncelle.Name = "tabPageGuncelle";
            this.tabPageGuncelle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGuncelle.Size = new System.Drawing.Size(688, 294);
            this.tabPageGuncelle.TabIndex = 2;
            this.tabPageGuncelle.Text = "Güncelle";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(694, 266);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Sil";
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
            this.btnKayıtOl.Location = new System.Drawing.Point(607, 318);
            this.btnKayıtOl.Margin = new System.Windows.Forms.Padding(4);
            this.btnKayıtOl.Name = "btnKayıtOl";
            this.btnKayıtOl.Size = new System.Drawing.Size(103, 26);
            this.btnKayıtOl.TabIndex = 6;
            this.btnKayıtOl.Text = "Çıkış";
            this.btnKayıtOl.UseVisualStyleBackColor = false;
            this.btnKayıtOl.Click += new System.EventHandler(this.btnKayıtOl_Click);
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(726, 357);
            this.Controls.Add(this.btnKayıtOl);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStock";
            this.Text = "Stock Durumu";
            this.tabControl.ResumeLayout(false);
            this.tabPageUrun.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageUrun;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPageEkle;
        private System.Windows.Forms.TabPage tabPageGuncelle;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnKayıtOl;
    }
}