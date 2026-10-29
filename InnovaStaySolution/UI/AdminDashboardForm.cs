<<<<<<< HEAD
﻿using System;
=======
﻿using BusinessLogic.Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq; // Added for LINQ .Count()
using System.Text;
>>>>>>> main
using System.Windows.Forms;

namespace UI
{
    public partial class AdminDashboardForm : Form
    {
<<<<<<< HEAD
        private Form activeChildForm = null;
=======
        private Form? activeForm = null;
        private readonly RoomController _roomController; // Added field declaration
>>>>>>> main

        public AdminDashboardForm()
        {
            InitializeComponent();
<<<<<<< HEAD

=======
            _roomController = new RoomController(); // Instantiated controller
>>>>>>> main
            this.WindowState = FormWindowState.Maximized;

<<<<<<< HEAD
            // Ipakita ang Dashboard sa unang pagbukas.
            pnlDashboard.Visible = true;
            pnlUserManagement.Visible = false;
=======
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
>>>>>>> main
        }

        private void OpenChildForm(Form childForm)
        {
            try
            {
                // Isara ang dating form kung mayroon.
                if (activeChildForm != null)
                {
                    activeChildForm.Close();
                    activeChildForm.Dispose();
                    activeChildForm = null;
                }

                // Linisin ang content panel.
                pnlUserManagement.Controls.Clear();

                // Ihanda ang bagong child form.
                activeChildForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;

                // Idagdag ang child form sa content panel.
                pnlUserManagement.Controls.Add(childForm);

                // Itago ang Dashboard at ipakita ang content panel.
                pnlDashboard.Visible = false;
                pnlUserManagement.Visible = true;
                pnlUserManagement.BringToFront();

                // Ipakita ang child form.
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

        private void ShowDashboardHome()
        {
            try
            {
                // Isara ang kasalukuyang child form.
                if (activeChildForm != null)
                {
                    activeChildForm.Close();
                    activeChildForm.Dispose();
                    activeChildForm = null;
                }

                // Linisin ang content panel.
                pnlUserManagement.Controls.Clear();
                pnlUserManagement.Visible = false;

                // Ipakita muli ang Dashboard.
                pnlDashboard.Visible = true;
                pnlDashboard.BringToFront();
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
<<<<<<< HEAD
=======

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
>>>>>>> main
    }
}