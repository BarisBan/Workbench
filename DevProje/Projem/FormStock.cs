using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projem
{
    public partial class FormStock : Form
    {
        public FormStock()
        {
            InitializeComponent();
        }

        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
            Helper.OpenNewFormMain();
            this.Close();
        }
    }
}
