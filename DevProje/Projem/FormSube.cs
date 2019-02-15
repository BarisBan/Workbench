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
    public partial class FormSube : Form
    {
        public FormSube()
        {
            InitializeComponent();
        }

        private void Sube_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'm303SalesDBDataSet9.Cities' table. You can move, or remove it, as needed.
            this.citiesTableAdapter.Fill(this.m303SalesDBDataSet9.Cities);

        }

        private void btOnay_Click(object sender, EventArgs e)
        {
            DialogResult box = MessageBox.Show("Ürünü eklemek istediğinizden emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (box == DialogResult.Yes)
            {
                string sube = txbName.Text;



                SqlConnection connect = new SqlConnection(ConnectionHelper.GetConnectionString());
                connect.Open();

                SqlCommand command = new SqlCommand($"Insert Into Cities values('{sube.Trim()}')", connect);
                command.ExecuteNonQuery();

                DialogResult box1 = MessageBox.Show("Şube Başarıyla Kayıt Edilmiştir.", " Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (box1 == DialogResult.OK)
                {
                    SqlConnection con = new SqlConnection(ConnectionHelper.GetConnectionString());
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter("Select * from Cities ", con);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                    con.Close();

                }
            }
        }        

        private void btSil_Click(object sender, EventArgs e)
        {
            DialogResult box = MessageBox.Show("Şubeyi silmek istediğinizden emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (box == DialogResult.Yes)
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                string ID = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

                SqlConnection connect = new SqlConnection(ConnectionHelper.GetConnectionString());
                connect.Open();

                SqlCommand command = new SqlCommand($"Delete From Cities WHERE CitiesID='{ID.Trim()}'", connect);
                
                command.ExecuteNonQuery();
                connect.Close();

                DialogResult box1 = MessageBox.Show("Ürün Başarıyla Silindi.", " Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (box1 == DialogResult.OK)
                {
                    SqlConnection con = new SqlConnection(ConnectionHelper.GetConnectionString());
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from Cities", con);
                    
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            string sube = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            

            txbName.Text = sube;
            lbUrunName.Text = sube;

            tabControl1.SelectedTab = tabPage2;
        }
    }
}