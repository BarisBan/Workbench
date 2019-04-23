namespace BookProject.Views.Admin.CategoryView
{
    partial class CategoryPage
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
            this.grpCategoryAdd = new System.Windows.Forms.GroupBox();
            this.btnCategoryAdd = new System.Windows.Forms.Button();
            this.txtCategoryDiscriptionAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategoryAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpCategoryList = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpCategoryUpdate = new System.Windows.Forms.GroupBox();
            this.btnCategoryUpdate = new System.Windows.Forms.Button();
            this.txtCategoryDiscriptionUpdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCategoryUpdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpCategoryDelete = new System.Windows.Forms.GroupBox();
            this.btnCategoryDelete = new System.Windows.Forms.Button();
            this.txtCategoryDelete = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpCategoryAdd.SuspendLayout();
            this.grpCategoryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpCategoryUpdate.SuspendLayout();
            this.grpCategoryDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCategoryAdd
            // 
            this.grpCategoryAdd.Controls.Add(this.btnCategoryAdd);
            this.grpCategoryAdd.Controls.Add(this.txtCategoryDiscriptionAdd);
            this.grpCategoryAdd.Controls.Add(this.label2);
            this.grpCategoryAdd.Controls.Add(this.txtCategoryAdd);
            this.grpCategoryAdd.Controls.Add(this.label1);
            this.grpCategoryAdd.Location = new System.Drawing.Point(12, 12);
            this.grpCategoryAdd.Name = "grpCategoryAdd";
            this.grpCategoryAdd.Size = new System.Drawing.Size(272, 227);
            this.grpCategoryAdd.TabIndex = 0;
            this.grpCategoryAdd.TabStop = false;
            this.grpCategoryAdd.Text = "Category Add";
            // 
            // btnCategoryAdd
            // 
            this.btnCategoryAdd.Location = new System.Drawing.Point(182, 165);
            this.btnCategoryAdd.Name = "btnCategoryAdd";
            this.btnCategoryAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCategoryAdd.TabIndex = 4;
            this.btnCategoryAdd.Text = "Submit";
            this.btnCategoryAdd.UseVisualStyleBackColor = true;
            this.btnCategoryAdd.Click += new System.EventHandler(this.btnCategoryAdd_Click);
            // 
            // txtCategoryDiscriptionAdd
            // 
            this.txtCategoryDiscriptionAdd.Location = new System.Drawing.Point(78, 54);
            this.txtCategoryDiscriptionAdd.Multiline = true;
            this.txtCategoryDiscriptionAdd.Name = "txtCategoryDiscriptionAdd";
            this.txtCategoryDiscriptionAdd.Size = new System.Drawing.Size(142, 105);
            this.txtCategoryDiscriptionAdd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description :";
            // 
            // txtCategoryAdd
            // 
            this.txtCategoryAdd.Location = new System.Drawing.Point(78, 28);
            this.txtCategoryAdd.Name = "txtCategoryAdd";
            this.txtCategoryAdd.Size = new System.Drawing.Size(142, 20);
            this.txtCategoryAdd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // grpCategoryList
            // 
            this.grpCategoryList.Controls.Add(this.dataGridView1);
            this.grpCategoryList.Location = new System.Drawing.Point(12, 245);
            this.grpCategoryList.Name = "grpCategoryList";
            this.grpCategoryList.Size = new System.Drawing.Size(784, 178);
            this.grpCategoryList.TabIndex = 1;
            this.grpCategoryList.TabStop = false;
            this.grpCategoryList.Text = "CategoryText";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(769, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // grpCategoryUpdate
            // 
            this.grpCategoryUpdate.Controls.Add(this.btnCategoryUpdate);
            this.grpCategoryUpdate.Controls.Add(this.txtCategoryDiscriptionUpdate);
            this.grpCategoryUpdate.Controls.Add(this.label3);
            this.grpCategoryUpdate.Controls.Add(this.txtCategoryUpdate);
            this.grpCategoryUpdate.Controls.Add(this.label4);
            this.grpCategoryUpdate.Location = new System.Drawing.Point(290, 12);
            this.grpCategoryUpdate.Name = "grpCategoryUpdate";
            this.grpCategoryUpdate.Size = new System.Drawing.Size(272, 227);
            this.grpCategoryUpdate.TabIndex = 5;
            this.grpCategoryUpdate.TabStop = false;
            this.grpCategoryUpdate.Text = "Category Update";
            // 
            // btnCategoryUpdate
            // 
            this.btnCategoryUpdate.Location = new System.Drawing.Point(182, 165);
            this.btnCategoryUpdate.Name = "btnCategoryUpdate";
            this.btnCategoryUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnCategoryUpdate.TabIndex = 4;
            this.btnCategoryUpdate.Text = "Submit";
            this.btnCategoryUpdate.UseVisualStyleBackColor = true;
            this.btnCategoryUpdate.Click += new System.EventHandler(this.btnCategoryUpdate_Click);
            // 
            // txtCategoryDiscriptionUpdate
            // 
            this.txtCategoryDiscriptionUpdate.Location = new System.Drawing.Point(78, 54);
            this.txtCategoryDiscriptionUpdate.Multiline = true;
            this.txtCategoryDiscriptionUpdate.Name = "txtCategoryDiscriptionUpdate";
            this.txtCategoryDiscriptionUpdate.Size = new System.Drawing.Size(142, 105);
            this.txtCategoryDiscriptionUpdate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description :";
            // 
            // txtCategoryUpdate
            // 
            this.txtCategoryUpdate.Location = new System.Drawing.Point(78, 28);
            this.txtCategoryUpdate.Name = "txtCategoryUpdate";
            this.txtCategoryUpdate.Size = new System.Drawing.Size(142, 20);
            this.txtCategoryUpdate.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name :";
            // 
            // grpCategoryDelete
            // 
            this.grpCategoryDelete.Controls.Add(this.btnCategoryDelete);
            this.grpCategoryDelete.Controls.Add(this.txtCategoryDelete);
            this.grpCategoryDelete.Controls.Add(this.label6);
            this.grpCategoryDelete.Location = new System.Drawing.Point(568, 12);
            this.grpCategoryDelete.Name = "grpCategoryDelete";
            this.grpCategoryDelete.Size = new System.Drawing.Size(228, 70);
            this.grpCategoryDelete.TabIndex = 6;
            this.grpCategoryDelete.TabStop = false;
            this.grpCategoryDelete.Text = "Category Delete";
            // 
            // btnCategoryDelete
            // 
            this.btnCategoryDelete.Location = new System.Drawing.Point(144, 26);
            this.btnCategoryDelete.Name = "btnCategoryDelete";
            this.btnCategoryDelete.Size = new System.Drawing.Size(75, 23);
            this.btnCategoryDelete.TabIndex = 4;
            this.btnCategoryDelete.Text = "Submit";
            this.btnCategoryDelete.UseVisualStyleBackColor = true;
            this.btnCategoryDelete.Click += new System.EventHandler(this.btnCategoryDelete_Click);
            // 
            // txtCategoryDelete
            // 
            this.txtCategoryDelete.Location = new System.Drawing.Point(78, 28);
            this.txtCategoryDelete.Name = "txtCategoryDelete";
            this.txtCategoryDelete.Size = new System.Drawing.Size(60, 20);
            this.txtCategoryDelete.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Category ID :";
            // 
            // CategoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(805, 446);
            this.Controls.Add(this.grpCategoryDelete);
            this.Controls.Add(this.grpCategoryUpdate);
            this.Controls.Add(this.grpCategoryList);
            this.Controls.Add(this.grpCategoryAdd);
            this.Name = "CategoryPage";
            this.Text = "Category Page";
            this.Load += new System.EventHandler(this.CategoryPage_Load);
            this.grpCategoryAdd.ResumeLayout(false);
            this.grpCategoryAdd.PerformLayout();
            this.grpCategoryList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpCategoryUpdate.ResumeLayout(false);
            this.grpCategoryUpdate.PerformLayout();
            this.grpCategoryDelete.ResumeLayout(false);
            this.grpCategoryDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCategoryAdd;
        private System.Windows.Forms.TextBox txtCategoryDiscriptionAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCategoryAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCategoryAdd;
        private System.Windows.Forms.GroupBox grpCategoryList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpCategoryUpdate;
        private System.Windows.Forms.Button btnCategoryUpdate;
        private System.Windows.Forms.TextBox txtCategoryDiscriptionUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCategoryUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpCategoryDelete;
        private System.Windows.Forms.Button btnCategoryDelete;
        private System.Windows.Forms.TextBox txtCategoryDelete;
        private System.Windows.Forms.Label label6;
    }
}