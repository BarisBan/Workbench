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
            FormNewUser formNewUser = new FormNewUser();
            FormDeleteUser formDeleteUser = new FormDeleteUser();
            FormUserUpdate formUserUpdate = new FormUserUpdate();
            FormMain formMain = new FormMain();
        public FormUserSettings()
        {
            InitializeComponent();
        }

        private void btCreateUser_Click(object sender, EventArgs e)
        {
            formNewUser.Show();
            this.Hide();
        }

        private void btDeleteUser_Click(object sender, EventArgs e)
        {
            formDeleteUser.Show();
            this.Hide();

        }

        private void btUpdateUser_Click(object sender, EventArgs e)
        {
            formUserUpdate.Show(); 
            this.Hide();

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void FormUserSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
