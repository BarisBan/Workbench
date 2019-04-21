using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookProject.Views.Member.MemberView
{
    public partial class MemberPage : Form
    {
        public MemberPage()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sepettekileri onaylıyor musunuz?", "???", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }   
        private void DgvBookList_MouseHover(object sender, EventArgs e)
        {
            ToolTip info = new ToolTip();
            info.SetToolTip(dgvBookList, "Çift tıklama ile sepete at.");
        }

        private void DgvBookList_MouseClick(object sender, MouseEventArgs e)
        {
            ToolTip info = new ToolTip();
            info.SetToolTip(dgvBookList, "Çift tıklama ile sepete at.");
        }

        private void DgvBookList_MouseDown(object sender, MouseEventArgs e)
        {
            ToolTip info = new ToolTip();
            info.SetToolTip(dgvBookList, "Çift tıklama ile sepete at.");
        }

        private void DgvBookList_MouseEnter(object sender, EventArgs e)
        {
            ToolTip info = new ToolTip();
            info.SetToolTip(dgvBookList, "Çift tıklama ile sepete at.");
        }

        private void DgvBookList_MouseLeave(object sender, EventArgs e)
        {
            ToolTip info = new ToolTip();
            info.SetToolTip(dgvBookList, "Çift tıklama ile sepete at.");
        }

        private void DgvBookList_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip info = new ToolTip();
            info.SetToolTip(dgvBookList, "Çift tıklama ile sepete at.");
        }

        private void DgvBookList_MouseUp(object sender, MouseEventArgs e)
        {
            ToolTip info = new ToolTip();
            info.SetToolTip(dgvBookList, "Çift tıklama ile sepete at.");
        }
    }
}
