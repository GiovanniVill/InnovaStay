using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class FrontDeskDashboardForm : Form
    {
        public FrontDeskDashboardForm()
        {
            InitializeComponent();
        }

        private void btnBP_Click(object sender, EventArgs e)
        {

        }

        private void btnGuestManagement_Click(object sender, EventArgs e)
        {
            GuestManagementForm guestForm = new GuestManagementForm();
            guestForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                this.Hide();
                var loginForm = new LoginForm();
                loginForm.FormClosed += (s, args) => this.Close();
                loginForm.Show();
            }
        }
    }
}
