using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class AdminDashboardForm : Form
    {
        private Form? activeChildForm = null;
        private readonly RoomController _roomController;

        public AdminDashboardForm()
        {
            InitializeComponent();

            _roomController = new RoomController();
            this.WindowState = FormWindowState.Maximized;
            pnlDashboard.Visible = true;
            pnlUserManagement.Visible = false;
        }

        private void ShowDashboardHome()
        {
            try
            {
                // Isara ang kasalukuyang binuksang child form kung mayroon
                if (activeChildForm != null)
                {
                    activeChildForm.Close();
                    activeChildForm.Dispose();
                    activeChildForm = null;
                }

                // Linisin ang user management content panel
                pnlUserManagement.Controls.Clear();
                pnlUserManagement.Visible = false;

                // Ipakita ang dashboard overview panel at mga grid controls
                pnlDashboard.Visible = true;
                pnlDashboard.BringToFront();

                if (lblCurrentActivity != null) lblCurrentActivity.Visible = true;
                if (dgvCurrentActivity != null)
                {
                    dgvCurrentActivity.Visible = true;
                    dgvCurrentActivity.BringToFront();
                }

                // I-refresh ang data
                LoadCurrentActivity();
                LoadDashboardOverview();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error sa pagbalik sa dashboard: " + ex.Message,
                    "Dashboard Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void OpenChildForm(Form childForm)
        {
            try
            {
                // Isara ang dating form kung mayroon
                if (activeChildForm != null)
                {
                    activeChildForm.Close();
                    activeChildForm.Dispose();
                    activeChildForm = null;
                }

                // Linisin ang content panel bago magpasok ng bago
                pnlUserManagement.Controls.Clear();

                // Ihanda ang bagong child form
                activeChildForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;

                // Idagdag at ipakita sa panel
                pnlUserManagement.Controls.Add(childForm);
                pnlDashboard.Visible = false;
                pnlUserManagement.Visible = true;
                pnlUserManagement.BringToFront();

                childForm.Show();
                childForm.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error sa pagbukas ng form: " + ex.Message,
                    "Form Load Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnUM_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserManagementForm());
        }

        private void btnRM_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RoomMaintenanceForm());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowDashboardHome();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "Sigurado ka bang nais mong mag-logout?",
                "Log Out",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                this.Hide();

                LoginForm loginForm = new LoginForm();
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

        private void LoadCurrentActivity()
        {
            try
            {
                // Kung may existing method ka na para dito sa database o controller,
                // dito ito tatawagin para mag-populate ang dgvCurrentActivity.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load current activity: " + ex.Message,
                    "Activity Log Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminDashboardForm_Load_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ShowDashboardHome();
        }
    }
}