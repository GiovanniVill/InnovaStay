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
                if (activeChildForm != null)
                {
                    activeChildForm.Close();
                    activeChildForm.Dispose();
                    activeChildForm = null;
                }

                pnlUserManagement.Controls.Clear();
                pnlUserManagement.Visible = false;

                pnlDashboard.Visible = true;
                pnlDashboard.BringToFront();

                if (lblCurrentActivity != null) lblCurrentActivity.Visible = true;
                if (dgvCurrentActivity != null)
                {
                    dgvCurrentActivity.Visible = true;
                    dgvCurrentActivity.BringToFront();
                }

                LoadCurrentActivity();
                LoadDashboardOverview();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sa pagbalik sa dashboard: " + ex.Message, "Dashboard Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenChildForm(Form childForm)
        {
            try
            {
                if (activeChildForm != null)
                {
                    activeChildForm.Close();
                    activeChildForm.Dispose();
                    activeChildForm = null;
                }

                pnlUserManagement.Controls.Clear();

                activeChildForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;

                pnlDashboard.Visible = false;
                pnlUserManagement.Visible = true;
                pnlUserManagement.BringToFront();

                pnlUserManagement.Controls.Add(childForm);
                childForm.Show();
                childForm.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sa pagbukas ng form: " + ex.Message, "Form Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    lblTotalRooms.Text = allRooms.Count.ToString();

                    int availableCount = allRooms.Count(r =>
                        string.Equals(r.Status, "Available", StringComparison.OrdinalIgnoreCase));
                    lblAvailable.Text = availableCount.ToString();

                    int occupiedCount = allRooms.Count(r =>
                        string.Equals(r.Status, "Occupied", StringComparison.OrdinalIgnoreCase));
                    lblOccupied.Text = occupiedCount.ToString();

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
                MessageBox.Show("Failed to load dashboard overview: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCurrentActivity()
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load current activity: " + ex.Message, "Activity Log Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminDashboardForm_Load_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ShowDashboardHome();
        }
    }
}