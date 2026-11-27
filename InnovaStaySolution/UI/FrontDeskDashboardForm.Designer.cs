namespace UI
{
    partial class FrontDeskDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlSidebar = new Panel();
            btnBilling = new Button();
            lblBrandSubtitle = new Label();
            lblBrand = new Label();
            btnDashboard = new Button();
            btnCreateRes = new Button();
            btnGuestManagement = new Button();
            btnCheckIn = new Button();
            btnOut = new Button();
            btnLogout = new Button();
            panelMainContent = new Panel();
            pnlDashboardWorkspace = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlOccupancyCard = new Panel();
            lblOccupancyTitle = new Label();
            pnlRingCanvas = new Panel();
            lblBookingsWeek = new Label();
            pnlActivityCard = new Panel();
            lblActivityTitle = new Label();
            dgvActivity = new DataGridView();
            colGuestId = new DataGridViewTextBoxColumn();
            colGuestName = new DataGridViewTextBoxColumn();
            colRoom = new DataGridViewTextBoxColumn();
            colCheckIn = new DataGridViewTextBoxColumn();
            colCheckOut = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            pnlSidebar.SuspendLayout();
            panelMainContent.SuspendLayout();
            pnlDashboardWorkspace.SuspendLayout();
            pnlOccupancyCard.SuspendLayout();
            pnlActivityCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActivity).BeginInit();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(238, 236, 203);
            pnlSidebar.Controls.Add(btnBilling);
            pnlSidebar.Controls.Add(lblBrandSubtitle);
            pnlSidebar.Controls.Add(lblBrand);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(btnCreateRes);
            pnlSidebar.Controls.Add(btnGuestManagement);
            pnlSidebar.Controls.Add(btnCheckIn);
            pnlSidebar.Controls.Add(btnOut);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(220, 780);
            pnlSidebar.TabIndex = 0;
            // 
            // btnBilling
            // 
            btnBilling.BackColor = Color.FromArgb(184, 172, 102);
            btnBilling.FlatAppearance.BorderSize = 0;
            btnBilling.FlatStyle = FlatStyle.Flat;
            btnBilling.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnBilling.ForeColor = Color.White;
            btnBilling.Location = new Point(18, 251);
            btnBilling.Name = "btnBilling";
            btnBilling.Size = new Size(184, 42);
            btnBilling.TabIndex = 9;
            btnBilling.Text = "Billing/Payment";
            btnBilling.UseVisualStyleBackColor = false;
            btnBilling.Click += btnBilling_Click;
            // 
            // lblBrandSubtitle
            // 
            lblBrandSubtitle.AutoSize = true;
            lblBrandSubtitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblBrandSubtitle.ForeColor = Color.FromArgb(145, 134, 75);
            lblBrandSubtitle.Location = new Point(22, 60);
            lblBrandSubtitle.Name = "lblBrandSubtitle";
            lblBrandSubtitle.Size = new Size(123, 13);
            lblBrandSubtitle.TabIndex = 8;
            lblBrandSubtitle.Text = "FRONTDESK CONSOLE";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblBrand.ForeColor = Color.FromArgb(145, 134, 75);
            lblBrand.Location = new Point(20, 28);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(149, 30);
            lblBrand.TabIndex = 7;
            lblBrand.Text = "INNOVASTAY";
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(184, 172, 102);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(18, 105);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(184, 42);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnCreateRes
            // 
            btnCreateRes.BackColor = Color.FromArgb(184, 172, 102);
            btnCreateRes.FlatAppearance.BorderSize = 0;
            btnCreateRes.FlatStyle = FlatStyle.Flat;
            btnCreateRes.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCreateRes.ForeColor = Color.White;
            btnCreateRes.Location = new Point(18, 155);
            btnCreateRes.Name = "btnCreateRes";
            btnCreateRes.Size = new Size(184, 42);
            btnCreateRes.TabIndex = 1;
            btnCreateRes.Text = "Create Reservation";
            btnCreateRes.UseVisualStyleBackColor = false;
            btnCreateRes.Click += btnCreateRes_Click;
            // 
            // btnGuestManagement
            // 
            btnGuestManagement.BackColor = Color.FromArgb(184, 172, 102);
            btnGuestManagement.FlatAppearance.BorderSize = 0;
            btnGuestManagement.FlatStyle = FlatStyle.Flat;
            btnGuestManagement.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnGuestManagement.ForeColor = Color.White;
            btnGuestManagement.Location = new Point(18, 203);
            btnGuestManagement.Name = "btnGuestManagement";
            btnGuestManagement.Size = new Size(184, 42);
            btnGuestManagement.TabIndex = 3;
            btnGuestManagement.Text = "Guest Management";
            btnGuestManagement.UseVisualStyleBackColor = false;
            btnGuestManagement.Click += btnGuestManagement_Click;
            // 
            // btnCheckIn
            // 
            btnCheckIn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCheckIn.BackColor = Color.FromArgb(46, 125, 50);
            btnCheckIn.FlatAppearance.BorderSize = 0;
            btnCheckIn.FlatStyle = FlatStyle.Flat;
            btnCheckIn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCheckIn.ForeColor = Color.White;
            btnCheckIn.Location = new Point(18, 615);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(184, 38);
            btnCheckIn.TabIndex = 4;
            btnCheckIn.Text = "Check-In";
            btnCheckIn.UseVisualStyleBackColor = false;
            btnCheckIn.Click += btnCheckIn_Click;
            // 
            // btnOut
            // 
            btnOut.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnOut.BackColor = Color.FromArgb(20, 26, 40);
            btnOut.FlatAppearance.BorderSize = 0;
            btnOut.FlatStyle = FlatStyle.Flat;
            btnOut.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnOut.ForeColor = Color.White;
            btnOut.Location = new Point(18, 660);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(184, 38);
            btnOut.TabIndex = 5;
            btnOut.Text = "Check-Out";
            btnOut.UseVisualStyleBackColor = false;
            btnOut.Click += btnOut_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogout.BackColor = Color.FromArgb(220, 53, 69);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(18, 715);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(184, 42);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panelMainContent
            // 
            panelMainContent.BackColor = Color.FromArgb(244, 245, 247);
            panelMainContent.Controls.Add(pnlDashboardWorkspace);
            panelMainContent.Dock = DockStyle.Fill;
            panelMainContent.Location = new Point(220, 0);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Size = new Size(1084, 780);
            panelMainContent.TabIndex = 1;
            // 
            // pnlDashboardWorkspace
            // 
            pnlDashboardWorkspace.BackColor = Color.FromArgb(244, 245, 247);
            pnlDashboardWorkspace.Controls.Add(lblTitle);
            pnlDashboardWorkspace.Controls.Add(lblSubtitle);
            pnlDashboardWorkspace.Controls.Add(pnlOccupancyCard);
            pnlDashboardWorkspace.Controls.Add(pnlActivityCard);
            pnlDashboardWorkspace.Dock = DockStyle.Fill;
            pnlDashboardWorkspace.Location = new Point(0, 0);
            pnlDashboardWorkspace.Name = "pnlDashboardWorkspace";
            pnlDashboardWorkspace.Padding = new Padding(24);
            pnlDashboardWorkspace.Size = new Size(1084, 780);
            pnlDashboardWorkspace.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(20, 26, 40);
            lblTitle.Location = new Point(24, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(303, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Front Desk Workspace";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSubtitle.ForeColor = Color.FromArgb(145, 134, 75);
            lblSubtitle.Location = new Point(26, 54);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(261, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Live Room Activity & Front Office Tasks";
            // 
            // pnlOccupancyCard
            // 
            pnlOccupancyCard.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlOccupancyCard.BackColor = Color.White;
            pnlOccupancyCard.BorderStyle = BorderStyle.Fixed3D;
            pnlOccupancyCard.Controls.Add(lblOccupancyTitle);
            pnlOccupancyCard.Controls.Add(pnlRingCanvas);
            pnlOccupancyCard.Controls.Add(lblBookingsWeek);
            pnlOccupancyCard.Location = new Point(768, 82);
            pnlOccupancyCard.Name = "pnlOccupancyCard";
            pnlOccupancyCard.Size = new Size(292, 362);
            pnlOccupancyCard.TabIndex = 3;
            // 
            // lblOccupancyTitle
            // 
            lblOccupancyTitle.AutoSize = true;
            lblOccupancyTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblOccupancyTitle.ForeColor = Color.FromArgb(20, 26, 40);
            lblOccupancyTitle.Location = new Point(14, 10);
            lblOccupancyTitle.Name = "lblOccupancyTitle";
            lblOccupancyTitle.Size = new Size(155, 21);
            lblOccupancyTitle.TabIndex = 0;
            lblOccupancyTitle.Text = "Today's Occupancy";
            // 
            // pnlRingCanvas
            // 
            pnlRingCanvas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlRingCanvas.BackColor = Color.White;
            pnlRingCanvas.Location = new Point(14, 38);
            pnlRingCanvas.Name = "pnlRingCanvas";
            pnlRingCanvas.Size = new Size(260, 308);
            pnlRingCanvas.TabIndex = 1;
            // 
            // lblBookingsWeek
            // 
            lblBookingsWeek.AutoSize = true;
            lblBookingsWeek.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBookingsWeek.ForeColor = Color.FromArgb(115, 122, 134);
            lblBookingsWeek.Location = new Point(14, 142);
            lblBookingsWeek.Name = "lblBookingsWeek";
            lblBookingsWeek.Size = new Size(0, 15);
            lblBookingsWeek.TabIndex = 2;
            // 
            // pnlActivityCard
            // 
            pnlActivityCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlActivityCard.BackColor = Color.White;
            pnlActivityCard.BorderStyle = BorderStyle.FixedSingle;
            pnlActivityCard.Controls.Add(lblActivityTitle);
            pnlActivityCard.Controls.Add(dgvActivity);
            pnlActivityCard.Location = new Point(24, 82);
            pnlActivityCard.Name = "pnlActivityCard";
            pnlActivityCard.Size = new Size(730, 672);
            pnlActivityCard.TabIndex = 4;
            // 
            // lblActivityTitle
            // 
            lblActivityTitle.AutoSize = true;
            lblActivityTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblActivityTitle.ForeColor = Color.FromArgb(20, 26, 40);
            lblActivityTitle.Location = new Point(14, 12);
            lblActivityTitle.Name = "lblActivityTitle";
            lblActivityTitle.Size = new Size(217, 21);
            lblActivityTitle.TabIndex = 0;
            lblActivityTitle.Text = "Live Check-In / Out Activity";
            // 
            // dgvActivity
            // 
            dgvActivity.AllowUserToAddRows = false;
            dgvActivity.AllowUserToDeleteRows = false;
            dgvActivity.AllowUserToResizeRows = false;
            dgvActivity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvActivity.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvActivity.BackgroundColor = Color.White;
            dgvActivity.BorderStyle = BorderStyle.None;
            dgvActivity.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvActivity.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(20, 26, 40);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(20, 26, 40);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgvActivity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvActivity.ColumnHeadersHeight = 36;
            dgvActivity.Columns.AddRange(new DataGridViewColumn[] { colGuestId, colGuestName, colRoom, colCheckIn, colCheckOut, colTotal, colStatus });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(28, 34, 46);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(226, 222, 190);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(20, 26, 40);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvActivity.DefaultCellStyle = dataGridViewCellStyle4;
            dgvActivity.EnableHeadersVisualStyles = false;
            dgvActivity.GridColor = Color.FromArgb(240, 242, 245);
            dgvActivity.Location = new Point(14, 44);
            dgvActivity.MultiSelect = false;
            dgvActivity.Name = "dgvActivity";
            dgvActivity.ReadOnly = true;
            dgvActivity.RowHeadersVisible = false;
            dgvActivity.RowTemplate.Height = 38;
            dgvActivity.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvActivity.Size = new Size(700, 612);
            dgvActivity.TabIndex = 1;
            // 
            // colGuestId
            // 
            colGuestId.FillWeight = 55F;
            colGuestId.HeaderText = "Guest ID";
            colGuestId.Name = "colGuestId";
            colGuestId.ReadOnly = true;
            // 
            // colGuestName
            // 
            colGuestName.FillWeight = 95F;
            colGuestName.HeaderText = "Guest Name";
            colGuestName.Name = "colGuestName";
            colGuestName.ReadOnly = true;
            // 
            // colRoom
            // 
            colRoom.FillWeight = 55F;
            colRoom.HeaderText = "Room #";
            colRoom.Name = "colRoom";
            colRoom.ReadOnly = true;
            // 
            // colCheckIn
            // 
            colCheckIn.FillWeight = 85F;
            colCheckIn.HeaderText = "Check-in Date";
            colCheckIn.Name = "colCheckIn";
            colCheckIn.ReadOnly = true;
            // 
            // colCheckOut
            // 
            colCheckOut.FillWeight = 85F;
            colCheckOut.HeaderText = "Check-out Date";
            colCheckOut.Name = "colCheckOut";
            colCheckOut.ReadOnly = true;
            // 
            // colTotal
            // 
            colTotal.FillWeight = 85F;
            colTotal.HeaderText = "Total Amount";
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.FillWeight = 75F;
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // FrontDeskDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 245, 247);
            ClientSize = new Size(1304, 780);
            Controls.Add(panelMainContent);
            Controls.Add(pnlSidebar);
            Name = "FrontDeskDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InnovaStay - Front Desk Dashboard";
            Load += FrontDeskDashboardForm_Load;
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            panelMainContent.ResumeLayout(false);
            pnlDashboardWorkspace.ResumeLayout(false);
            pnlDashboardWorkspace.PerformLayout();
            pnlOccupancyCard.ResumeLayout(false);
            pnlOccupancyCard.PerformLayout();
            pnlActivityCard.ResumeLayout(false);
            pnlActivityCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActivity).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblBrandSubtitle;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnCreateRes;
        private System.Windows.Forms.Button btnGuestManagement;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelMainContent;
        private System.Windows.Forms.Panel pnlDashboardWorkspace;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlOccupancyCard;
        private System.Windows.Forms.Label lblOccupancyTitle;
        private System.Windows.Forms.Panel pnlRingCanvas;
        private System.Windows.Forms.Label lblBookingsWeek;
        private System.Windows.Forms.Panel pnlActivityCard;
        private System.Windows.Forms.Label lblActivityTitle;
        private System.Windows.Forms.DataGridView dgvActivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGuestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGuestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private Button btnBilling;
    }
}