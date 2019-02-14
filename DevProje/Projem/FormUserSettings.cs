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
    public partial class FormUserSettings : Form
    {
        public FormUserSettings()
        {
            InitializeComponent();
        }

        private void btCreateUser_Click(object sender, EventArgs e)
        {
            FormNewUser formNewUser = new FormNewUser();
            formNewUser.Show();
            this.Hide();
        }

        private void btDeleteUser_Click(object sender, EventArgs e)
        {
            FormDeleteUser formDeleteUser = new FormDeleteUser();
            formDeleteUser.Show();
            this.Hide();

        }

        private void btUpdateUser_Click(object sender, EventArgs e)
        {
            FormUserUpdate formUserUpdate = new FormUserUpdate();
            formUserUpdate.Show();
            this.Hide();

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
