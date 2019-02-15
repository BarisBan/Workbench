using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projem
{
    public partial class FormDeleteUser : Form
    {
            
        public FormDeleteUser()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            this.Hide();

        }

        private void btSil_Click(object sender, EventArgs e)
        {
            DialogResult box = MessageBox.Show("Kişiyi silmek istediğinizden emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (box == DialogResult.Yes)
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                string ID = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

                SqlConnection connect = new SqlConnection(ConnectionHelper.GetConnectionString());
                connect.Open();

                SqlCommand command = new SqlCommand($"Update Employees Set Aktiflik=0  where EmployeeID ={ID.Trim()}", connect);
                command.ExecuteNonQuery();
                connect.Close();

                DialogResult box1 = MessageBox.Show("Kişi Başarıyla Silindi.", " Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (box1 == DialogResult.OK)
                {
                    SqlConnection con = new SqlConnection(ConnectionHelper.GetConnectionString());
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter("Select * from Employees Where Aktiflik=1", con);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                    con.Close();


                }
            }
            else
            {
                MessageBox.Show("İşlem iptal edildi");
            }
        }

        private void FormDeleteUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'm303SalesDBDataSet6.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.m303SalesDBDataSet6.Employees);

        }
    }
}
