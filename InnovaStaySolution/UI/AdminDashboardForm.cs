using BusinessLogic.Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq; // Added for LINQ .Count()
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class AdminDashboardForm : Form
    {
        private Form? activeForm = null;
        private readonly RoomController _roomController; // Added field declaration

        public AdminDashboardForm()
        {
            InitializeComponent();
            _roomController = new RoomController(); // Instantiated controller
            this.WindowState = FormWindowState.Maximized;
        }

        private void ShowDashboardHome()
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }

            lblCurrentActivity.Visible = true;
            dgvCurrentActivity.Visible = true;
            dgvCurrentActivity.BringToFront();

            LoadCurrentActivity();
            LoadDashboardOverview(); // Refreshes card metrics when returning home
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

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

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            ShowDashboardHome();
        }

        private void btnRM_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DesignRoomMaintenanceForm());
        }

        private void btnUM_Click(object sender, EventArgs e)
        {

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

        private void LoadDashboardOverview()
        {
            try
            {
                List<RoomModel> allRooms = _roomController.GetAllRooms();

                if (allRooms != null && allRooms.Count > 0)
                {
                    // Total Rooms
                    lblTotalRooms.Text = allRooms.Count.ToString();

                    // Available Rooms
                    int availableCount = allRooms.Count(r =>
                        string.Equals(r.Status, "Available", StringComparison.OrdinalIgnoreCase));
                    lblAvailable.Text = availableCount.ToString();

                    // Occupied Rooms
                    int occupiedCount = allRooms.Count(r =>
                        string.Equals(r.Status, "Occupied", StringComparison.OrdinalIgnoreCase));
                    lblOccupied.Text = occupiedCount.ToString();

                    // Reservations
                    int reservationCount = allRooms.Count(r =>
                        string.Equals(r.Status, "Reserved", StringComparison.OrdinalIgnoreCase));
                    lblReservations.Text = reservationCount.ToString();
                }
                else
                {
                    lblTotalRooms.Text = "0";
                    lblAvailable.Text = "0";
                    lblOccupied.Text = "0";
                    lblReservations.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load dashboard overview: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminDashboardForm_Load_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ShowDashboardHome();
        }
    }
}