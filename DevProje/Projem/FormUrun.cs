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
    public partial class FormUrun : Form
    {

        public FormUrun()
        {
            InitializeComponent();
        }

        private void btnKayıtOl_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void FormUrun_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'm303SalesDBDataSet8.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.m303SalesDBDataSet8.Products);

        }

        private void txbNewFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            string urun = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            string fiyat = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            txbName.Text = urun;
            txbPrice.Text = fiyat;

            tabControl.SelectedTab = tabUrunIslem;
            lbUrunName.Text = urun;
        }

        private void btSil_Click(object sender, EventArgs e)
        {
            DialogResult box = MessageBox.Show("Ürün silmek istediğinizden emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (box == DialogResult.Yes)
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                string ID = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

                SqlConnection connect = new SqlConnection(ConnectionHelper.GetConnectionString());
                connect.Open();

                SqlCommand command = new SqlCommand("Update Products Set Stock=0 WHERE ProductID=" + ID.Trim(), connect);
                command.ExecuteNonQuery();
                connect.Close();

                DialogResult box1 = MessageBox.Show("Ürün Başarıyla Silindi.", " Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (box1 == DialogResult.OK)
                {
                    SqlConnection con = new SqlConnection(ConnectionHelper.GetConnectionString());
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter("Select * from Products Where Stock = '1'", con);

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

        private void btBaglan_Click(object sender, EventArgs e)
        {
            DialogResult box = MessageBox.Show("Ürünü güncellemek istediğinizden emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (box == DialogResult.Yes)
            {
                string urun = txbName.Text;
                string fiyat = txbPrice.Text;

                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                string ID = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

                SqlConnection connect = new SqlConnection(ConnectionHelper.GetConnectionString());
                connect.Open();

                SqlCommand command = new SqlCommand($"Update Products Set Name='{urun.Trim()}',Price='{fiyat.Trim()}' Where ProductID={ID.Trim()}", connect);

                command.ExecuteNonQuery();

                connect.Close();

                DialogResult box1 = MessageBox.Show("Ürün Başarıyla Güncellendi.", " Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (box1 == DialogResult.OK)
                {
                    SqlConnection con = new SqlConnection(ConnectionHelper.GetConnectionString());
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter("Select * from Products Where Stock = '1'", con);

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

        private void btOnay_Click(object sender, EventArgs e)
        {
            DialogResult box = MessageBox.Show("Ürünü eklemek istediğinizden emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (box == DialogResult.Yes)
            {
                string urun = txbName.Text;
                string fiyat = txbPrice.Text;


                SqlConnection connect = new SqlConnection(ConnectionHelper.GetConnectionString());
                connect.Open();

                SqlCommand command = new SqlCommand($"Insert Into Products values('{urun.Trim()}','{fiyat.Trim()}')", connect);
                command.ExecuteNonQuery();

                DialogResult box1 = MessageBox.Show("Ürün Başarıyla Kayıt Edilmiştir.", " Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (box1 == DialogResult.OK)
                {
                    SqlConnection con = new SqlConnection(ConnectionHelper.GetConnectionString());
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter("Select * from Products Where Stock = '1'", con);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                    con.Close();

                }
            }


        }
    }
}
