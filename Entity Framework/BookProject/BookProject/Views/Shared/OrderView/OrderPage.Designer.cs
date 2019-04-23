namespace BookProject.Views.Admin.OrderView
{
    partial class OrderPage
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
            this.dgvBooklist = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooklist)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooklist
            // 
            this.dgvBooklist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooklist.Location = new System.Drawing.Point(12, 237);
            this.dgvBooklist.Name = "dgvBooklist";
            this.dgvBooklist.ReadOnly = true;
            this.dgvBooklist.Size = new System.Drawing.Size(776, 201);
            this.dgvBooklist.TabIndex = 0;
            // 
            // OrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvBooklist);
            this.Name = "OrderPage";
            this.Text = "OrderPage";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooklist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBooklist;
    }
}