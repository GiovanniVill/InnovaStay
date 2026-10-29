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
        private Form? activeForm = null;

        public FrontDeskDashboardForm()
        {
            InitializeComponent();
        }

        private void FrontDeskDashboardForm_Load(object sender, EventArgs e)
        {
            LoadDashboardOverview();
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelMainContent.Controls.Add(childForm);
            panelMainContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void LoadDashboardOverview()
        {
            // Close active child form to return to the dashboard overview cards
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadDashboardOverview();
        }

        private void btnCreateRes_Click(object sender, EventArgs e)
        {
            // Opens the Create Reservation form as a modal dialog
            using (var form = new CreateReservationForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadDashboardOverview();
                }
            }
        }

        private void btnGuestManagement_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GuestManagementForm());
        }

        private void btnBP_Click(object sender, EventArgs e)
        {
            // Billing / Payment click handler
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

        private void btnOut_Click(object sender, EventArgs e)
        {
            using (var checkOutForm = new CheckOutForm())
            {
                if (checkOutForm.ShowDialog() == DialogResult.OK)
                {
                    LoadDashboardOverview();
                }
            }
        }
    }
}