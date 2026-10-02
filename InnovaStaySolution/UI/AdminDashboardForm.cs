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
        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        private void btnRM_Click(object sender, EventArgs e)
        {
            DesignRoomMaintenanceForm roomForm = new DesignRoomMaintenanceForm();
            roomForm.Show();
        }

        private void btnUM_Click(object sender, EventArgs e)
        {
            
        }
    }
}
