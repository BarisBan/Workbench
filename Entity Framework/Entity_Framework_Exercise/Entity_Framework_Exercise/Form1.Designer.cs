namespace Entity_Framework_Exercise
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSorgu1 = new System.Windows.Forms.Button();
            this.btnSorgu2 = new System.Windows.Forms.Button();
            this.btnSorgu3 = new System.Windows.Forms.Button();
            this.btnSorgu4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 174);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSorgu1
            // 
            this.btnSorgu1.Location = new System.Drawing.Point(12, 192);
            this.btnSorgu1.Name = "btnSorgu1";
            this.btnSorgu1.Size = new System.Drawing.Size(75, 23);
            this.btnSorgu1.TabIndex = 1;
            this.btnSorgu1.Text = "Sorgu 1";
            this.btnSorgu1.UseVisualStyleBackColor = true;
            this.btnSorgu1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSorgu2
            // 
            this.btnSorgu2.Location = new System.Drawing.Point(93, 192);
            this.btnSorgu2.Name = "btnSorgu2";
            this.btnSorgu2.Size = new System.Drawing.Size(75, 23);
            this.btnSorgu2.TabIndex = 2;
            this.btnSorgu2.Text = "Sorgu 2";
            this.btnSorgu2.UseVisualStyleBackColor = true;
            this.btnSorgu2.Click += new System.EventHandler(this.btnSorgu2_Click);
            // 
            // btnSorgu3
            // 
            this.btnSorgu3.Location = new System.Drawing.Point(174, 192);
            this.btnSorgu3.Name = "btnSorgu3";
            this.btnSorgu3.Size = new System.Drawing.Size(75, 23);
            this.btnSorgu3.TabIndex = 3;
            this.btnSorgu3.Text = "Sorgu 3";
            this.btnSorgu3.UseVisualStyleBackColor = true;
            this.btnSorgu3.Click += new System.EventHandler(this.btnSorgu3_Click);
            // 
            // btnSorgu4
            // 
            this.btnSorgu4.Location = new System.Drawing.Point(255, 192);
            this.btnSorgu4.Name = "btnSorgu4";
            this.btnSorgu4.Size = new System.Drawing.Size(75, 23);
            this.btnSorgu4.TabIndex = 4;
            this.btnSorgu4.Text = "Sorgu 4";
            this.btnSorgu4.UseVisualStyleBackColor = true;
            this.btnSorgu4.Click += new System.EventHandler(this.btnSorgu4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSorgu4);
            this.Controls.Add(this.btnSorgu3);
            this.Controls.Add(this.btnSorgu2);
            this.Controls.Add(this.btnSorgu1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSorgu1;
        private System.Windows.Forms.Button btnSorgu2;
        private System.Windows.Forms.Button btnSorgu3;
        private System.Windows.Forms.Button btnSorgu4;
    }
}

