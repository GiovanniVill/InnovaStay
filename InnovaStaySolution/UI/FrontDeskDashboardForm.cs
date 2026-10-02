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
    }
}
