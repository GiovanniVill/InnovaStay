using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class FrontDeskDashboardForm : Form
    {
        private Form? activeForm = null;
        private readonly DashboardController _dashboardController;

        public FrontDeskDashboardForm()
        {
            InitializeComponent();
            _dashboardController = new DashboardController();
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
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }

            try
            {
                DashboardSummary data = _dashboardController.GetFrontDeskDashboardData();

                lblCheckInCount.Text = data.ExpectedArrivals.ToString();
                lblCheckOutCount.Text = data.ExpectedDepartures.ToString();
                lblOccupiedCount.Text = data.OccupiedRooms.ToString();
                lblAvailableRooms.Text = data.AvailableRooms.ToString();

                dgvFrontDeskSchedule.DataSource = data.ScheduleTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load dashboard: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadDashboardOverview();
        }

        private void btnCreateRes_Click(object sender, EventArgs e)
        {
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
            // Billing / Payment handler
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Sigurado ka bang nais mong mag-logout?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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