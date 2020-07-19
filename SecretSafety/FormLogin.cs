using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretSafety
{
    public partial class FormLogin : System.Windows.Forms.Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form_login_Load(object sender, EventArgs e)
        {

        }

        private void tb_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            String username = tb_username.Text;
            String password = tb_password.Text;
            FormDashboard dashboard = new FormDashboard(username, password);
            this.Hide();
            dashboard.ShowDialog();
        }
    }
}
