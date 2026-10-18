using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class AdminDashboardForm : Form
    {
        private Form? activeForm = null;

        public AdminDashboardForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ShowDashboardHome();
        }

        private void ShowDashboardHome()
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }

            // Make sure the default Activity table and label are visible
            lblCurrentActivity.Visible = true;
            dgvCurrentActivity.Visible = true;
            dgvCurrentActivity.BringToFront();

            LoadCurrentActivity();
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            // Hide the default Activity table and label
            lblCurrentActivity.Visible = false;
            dgvCurrentActivity.Visible = false;

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelMainContent.Controls.Add(childForm);
            panelMainContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowDashboardHome();
        }

        private void btnRM_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DesignRoomMaintenanceForm());
        }

        private void btnUM_Click(object sender, EventArgs e)
        {
            // When you are ready for User Management, uncomment and use your form name:
            // OpenChildForm(new UserManagementForm());
        }

        private void LoadCurrentActivity()
        {
            if (dgvCurrentActivity.Columns.Count == 0)
            {
                dgvCurrentActivity.Columns.Add("Time", "Time");
                dgvCurrentActivity.Columns.Add("User", "User");
                dgvCurrentActivity.Columns.Add("Role", "Role");
                dgvCurrentActivity.Columns.Add("Activity", "Activity Description");
            }

            dgvCurrentActivity.Rows.Clear();
            dgvCurrentActivity.Rows.Add(DateTime.Now.ToString("hh:mm tt"), "admin", "Admin", "Logged in to Admin Console");
            dgvCurrentActivity.Rows.Add(DateTime.Now.AddMinutes(-15).ToString("hh:mm tt"), "frontdesk1", "Front Desk", "Checked in guest: Room 204");
            dgvCurrentActivity.Rows.Add(DateTime.Now.AddMinutes(-35).ToString("hh:mm tt"), "admin", "Admin", "Updated Room 102 to Maintenance");
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
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