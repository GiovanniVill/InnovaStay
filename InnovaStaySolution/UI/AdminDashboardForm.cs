using System;
using System.Windows.Forms;

namespace UI
{
    public partial class AdminDashboardForm : Form
    {
        private Form activeChildForm = null;

        public AdminDashboardForm()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            // Ipakita ang Dashboard sa unang pagbukas.
            pnlDashboard.Visible = true;
            pnlUserManagement.Visible = false;
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
    }
}