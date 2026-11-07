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
            System.Windows.Forms.DataGridViewCellStyle dgvHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvRowStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblBrandSubtitle = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnCreateRes = new System.Windows.Forms.Button();
            this.btnBP = new System.Windows.Forms.Button();
            this.btnGuestManagement = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelMainContent = new System.Windows.Forms.Panel();
            this.pnlDashboardWorkspace = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlTimelineCard = new System.Windows.Forms.Panel();
            this.lblTimelineTitle = new System.Windows.Forms.Label();
            this.lblTimelineSub = new System.Windows.Forms.Label();
            this.pnlTimelineCanvas = new System.Windows.Forms.Panel();
            this.pnlOccupancyCard = new System.Windows.Forms.Panel();
            this.lblOccupancyTitle = new System.Windows.Forms.Label();
            this.pnlRingCanvas = new System.Windows.Forms.Panel();
            this.lblBookingsWeek = new System.Windows.Forms.Label();
            this.pnlBarCanvas = new System.Windows.Forms.Panel();
            this.pnlActivityCard = new System.Windows.Forms.Panel();
            this.lblActivityTitle = new System.Windows.Forms.Label();
            this.dgvActivity = new System.Windows.Forms.DataGridView();
            this.colGuestId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGuestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlQueueCard = new System.Windows.Forms.Panel();
            this.lblQueueTitle = new System.Windows.Forms.Label();
            this.pnlQueueItem1 = new System.Windows.Forms.Panel();
            this.lblQ1Title = new System.Windows.Forms.Label();
            this.lblQ1Time = new System.Windows.Forms.Label();
            this.pnlQueueItem2 = new System.Windows.Forms.Panel();
            this.lblQ2Title = new System.Windows.Forms.Label();
            this.lblQ2Time = new System.Windows.Forms.Label();
            this.pnlQueueItem3 = new System.Windows.Forms.Panel();
            this.lblQ3Title = new System.Windows.Forms.Label();
            this.lblQ3Time = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.panelMainContent.SuspendLayout();
            this.pnlDashboardWorkspace.SuspendLayout();
            this.pnlTimelineCard.SuspendLayout();
            this.pnlOccupancyCard.SuspendLayout();
            this.pnlActivityCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).BeginInit();
            this.pnlQueueCard.SuspendLayout();
            this.pnlQueueItem1.SuspendLayout();
            this.pnlQueueItem2.SuspendLayout();
            this.pnlQueueItem3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(236)))), ((int)(((byte)(203)))));
            this.pnlSidebar.Controls.Add(this.lblBrandSubtitle);
            this.pnlSidebar.Controls.Add(this.lblBrand);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.btnCreateRes);
            this.pnlSidebar.Controls.Add(this.btnBP);
            this.pnlSidebar.Controls.Add(this.btnGuestManagement);
            this.pnlSidebar.Controls.Add(this.btnCheckIn);
            this.pnlSidebar.Controls.Add(this.btnOut);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(220, 780);
            this.pnlSidebar.TabIndex = 0;
            // 
            // lblBrandSubtitle
            // 
            this.lblBrandSubtitle.AutoSize = true;
            this.lblBrandSubtitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblBrandSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(134)))), ((int)(((byte)(75)))));
            this.lblBrandSubtitle.Location = new System.Drawing.Point(22, 60);
            this.lblBrandSubtitle.Name = "lblBrandSubtitle";
            this.lblBrandSubtitle.Size = new System.Drawing.Size(122, 13);
            this.lblBrandSubtitle.TabIndex = 8;
            this.lblBrandSubtitle.Text = "FRONTDESK CONSOLE";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(134)))), ((int)(((byte)(75)))));
            this.lblBrand.Location = new System.Drawing.Point(20, 28);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(157, 30);
            this.lblBrand.TabIndex = 7;
            this.lblBrand.Text = "INNOVASTAY";
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(172)))), ((int)(((byte)(102)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(18, 105);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(184, 42);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnCreateRes
            // 
            this.btnCreateRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(172)))), ((int)(((byte)(102)))));
            this.btnCreateRes.FlatAppearance.BorderSize = 0;
            this.btnCreateRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateRes.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCreateRes.ForeColor = System.Drawing.Color.White;
            this.btnCreateRes.Location = new System.Drawing.Point(18, 155);
            this.btnCreateRes.Name = "btnCreateRes";
            this.btnCreateRes.Size = new System.Drawing.Size(184, 42);
            this.btnCreateRes.TabIndex = 1;
            this.btnCreateRes.Text = "Create Reservation";
            this.btnCreateRes.UseVisualStyleBackColor = false;
            this.btnCreateRes.Click += new System.EventHandler(this.btnCreateRes_Click);
            // 
            // btnBP
            // 
            this.btnBP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(172)))), ((int)(((byte)(102)))));
            this.btnBP.FlatAppearance.BorderSize = 0;
            this.btnBP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBP.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnBP.ForeColor = System.Drawing.Color.White;
            this.btnBP.Location = new System.Drawing.Point(18, 205);
            this.btnBP.Name = "btnBP";
            this.btnBP.Size = new System.Drawing.Size(184, 42);
            this.btnBP.TabIndex = 2;
            this.btnBP.Text = "Billing/Payment";
            this.btnBP.UseVisualStyleBackColor = false;
            this.btnBP.Click += new System.EventHandler(this.btnBP_Click);
            // 
            // btnGuestManagement
            // 
            this.btnGuestManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(172)))), ((int)(((byte)(102)))));
            this.btnGuestManagement.FlatAppearance.BorderSize = 0;
            this.btnGuestManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuestManagement.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnGuestManagement.ForeColor = System.Drawing.Color.White;
            this.btnGuestManagement.Location = new System.Drawing.Point(18, 255);
            this.btnGuestManagement.Name = "btnGuestManagement";
            this.btnGuestManagement.Size = new System.Drawing.Size(184, 42);
            this.btnGuestManagement.TabIndex = 3;
            this.btnGuestManagement.Text = "Guest Management";
            this.btnGuestManagement.UseVisualStyleBackColor = false;
            this.btnGuestManagement.Click += new System.EventHandler(this.btnGuestManagement_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnCheckIn.FlatAppearance.BorderSize = 0;
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnCheckIn.Location = new System.Drawing.Point(18, 615);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(184, 38);
            this.btnCheckIn.TabIndex = 4;
            this.btnCheckIn.Text = "Check-In";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnOut
            // 
            this.btnOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.btnOut.FlatAppearance.BorderSize = 0;
            this.btnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOut.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnOut.ForeColor = System.Drawing.Color.White;
            this.btnOut.Location = new System.Drawing.Point(18, 660);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(184, 38);
            this.btnOut.TabIndex = 5;
            this.btnOut.Text = "Check-Out";
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(18, 715);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(184, 42);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelMainContent
            // 
            this.panelMainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.panelMainContent.Controls.Add(this.pnlDashboardWorkspace);
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContent.Location = new System.Drawing.Point(220, 0);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Size = new System.Drawing.Size(1084, 780);
            this.panelMainContent.TabIndex = 1;
            // 
            // pnlDashboardWorkspace
            // 
            this.pnlDashboardWorkspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.pnlDashboardWorkspace.Controls.Add(this.lblTitle);
            this.pnlDashboardWorkspace.Controls.Add(this.lblSubtitle);
            this.pnlDashboardWorkspace.Controls.Add(this.pnlTimelineCard);
            this.pnlDashboardWorkspace.Controls.Add(this.pnlOccupancyCard);
            this.pnlDashboardWorkspace.Controls.Add(this.pnlActivityCard);
            this.pnlDashboardWorkspace.Controls.Add(this.pnlQueueCard);
            this.pnlDashboardWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboardWorkspace.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboardWorkspace.Name = "pnlDashboardWorkspace";
            this.pnlDashboardWorkspace.Padding = new System.Windows.Forms.Padding(24);
            this.pnlDashboardWorkspace.Size = new System.Drawing.Size(1084, 780);
            this.pnlDashboardWorkspace.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.lblTitle.Location = new System.Drawing.Point(24, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(298, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Front Desk Workspace";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(134)))), ((int)(((byte)(75)))));
            this.lblSubtitle.Location = new System.Drawing.Point(26, 54);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(262, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Live Room Activity & Front Office Tasks";
            // 
            // pnlTimelineCard
            // 
            this.pnlTimelineCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTimelineCard.BackColor = System.Drawing.Color.White;
            this.pnlTimelineCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTimelineCard.Controls.Add(this.lblTimelineTitle);
            this.pnlTimelineCard.Controls.Add(this.lblTimelineSub);
            this.pnlTimelineCard.Controls.Add(this.pnlTimelineCanvas);
            this.pnlTimelineCard.Location = new System.Drawing.Point(24, 82);
            this.pnlTimelineCard.Name = "pnlTimelineCard";
            this.pnlTimelineCard.Size = new System.Drawing.Size(730, 290);
            this.pnlTimelineCard.TabIndex = 2;
            // 
            // lblTimelineTitle
            // 
            this.lblTimelineTitle.AutoSize = true;
            this.lblTimelineTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTimelineTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.lblTimelineTitle.Location = new System.Drawing.Point(14, 10);
            this.lblTimelineTitle.Name = "lblTimelineTitle";
            this.lblTimelineTitle.Size = new System.Drawing.Size(181, 21);
            this.lblTimelineTitle.TabIndex = 0;
            this.lblTimelineTitle.Text = "Rooms & Reservations";
            // 
            // lblTimelineSub
            // 
            this.lblTimelineSub.AutoSize = true;
            this.lblTimelineSub.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTimelineSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(122)))), ((int)(((byte)(134)))));
            this.lblTimelineSub.Location = new System.Drawing.Point(15, 34);
            this.lblTimelineSub.Name = "lblTimelineSub";
            this.lblTimelineSub.Size = new System.Drawing.Size(222, 15);
            this.lblTimelineSub.TabIndex = 1;
            this.lblTimelineSub.Text = "Interactive Rooms Availability Timeline";
            // 
            // pnlTimelineCanvas
            // 
            this.pnlTimelineCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTimelineCanvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.pnlTimelineCanvas.Location = new System.Drawing.Point(14, 58);
            this.pnlTimelineCanvas.Name = "pnlTimelineCanvas";
            this.pnlTimelineCanvas.Size = new System.Drawing.Size(700, 218);
            this.pnlTimelineCanvas.TabIndex = 2;
            // 
            // pnlOccupancyCard
            // 
            this.pnlOccupancyCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOccupancyCard.BackColor = System.Drawing.Color.White;
            this.pnlOccupancyCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOccupancyCard.Controls.Add(this.lblOccupancyTitle);
            this.pnlOccupancyCard.Controls.Add(this.pnlRingCanvas);
            this.pnlOccupancyCard.Controls.Add(this.lblBookingsWeek);
            this.pnlOccupancyCard.Controls.Add(this.pnlBarCanvas);
            this.pnlOccupancyCard.Location = new System.Drawing.Point(768, 82);
            this.pnlOccupancyCard.Name = "pnlOccupancyCard";
            this.pnlOccupancyCard.Size = new System.Drawing.Size(292, 290);
            this.pnlOccupancyCard.TabIndex = 3;
            // 
            // lblOccupancyTitle
            // 
            this.lblOccupancyTitle.AutoSize = true;
            this.lblOccupancyTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblOccupancyTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.lblOccupancyTitle.Location = new System.Drawing.Point(14, 10);
            this.lblOccupancyTitle.Name = "lblOccupancyTitle";
            this.lblOccupancyTitle.Size = new System.Drawing.Size(155, 21);
            this.lblOccupancyTitle.TabIndex = 0;
            this.lblOccupancyTitle.Text = "Today\'s Occupancy";
            // 
            // pnlRingCanvas
            // 
            this.pnlRingCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRingCanvas.BackColor = System.Drawing.Color.White;
            this.pnlRingCanvas.Location = new System.Drawing.Point(14, 38);
            this.pnlRingCanvas.Name = "pnlRingCanvas";
            this.pnlRingCanvas.Size = new System.Drawing.Size(262, 95);
            this.pnlRingCanvas.TabIndex = 1;
            // 
            // lblBookingsWeek
            // 
            this.lblBookingsWeek.AutoSize = true;
            this.lblBookingsWeek.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBookingsWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(122)))), ((int)(((byte)(134)))));
            this.lblBookingsWeek.Location = new System.Drawing.Point(14, 142);
            this.lblBookingsWeek.Name = "lblBookingsWeek";
            this.lblBookingsWeek.Size = new System.Drawing.Size(117, 15);
            this.lblBookingsWeek.TabIndex = 2;
            this.lblBookingsWeek.Text = "Bookings this week";
            // 
            // pnlBarCanvas
            // 
            this.pnlBarCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBarCanvas.BackColor = System.Drawing.Color.White;
            this.pnlBarCanvas.Location = new System.Drawing.Point(14, 165);
            this.pnlBarCanvas.Name = "pnlBarCanvas";
            this.pnlBarCanvas.Size = new System.Drawing.Size(262, 110);
            this.pnlBarCanvas.TabIndex = 3;
            // 
            // pnlActivityCard
            // 
            this.pnlActivityCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlActivityCard.BackColor = System.Drawing.Color.White;
            this.pnlActivityCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActivityCard.Controls.Add(this.lblActivityTitle);
            this.pnlActivityCard.Controls.Add(this.dgvActivity);
            this.pnlActivityCard.Location = new System.Drawing.Point(24, 386);
            this.pnlActivityCard.Name = "pnlActivityCard";
            this.pnlActivityCard.Size = new System.Drawing.Size(730, 368);
            this.pnlActivityCard.TabIndex = 4;
            // 
            // lblActivityTitle
            // 
            this.lblActivityTitle.AutoSize = true;
            this.lblActivityTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblActivityTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.lblActivityTitle.Location = new System.Drawing.Point(14, 12);
            this.lblActivityTitle.Name = "lblActivityTitle";
            this.lblActivityTitle.Size = new System.Drawing.Size(223, 21);
            this.lblActivityTitle.TabIndex = 0;
            this.lblActivityTitle.Text = "Live Check-In / Out Activity";
            // 
            // dgvActivity
            // 
            this.dgvActivity.AllowUserToAddRows = false;
            this.dgvActivity.AllowUserToDeleteRows = false;
            this.dgvActivity.AllowUserToResizeRows = false;
            this.dgvActivity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActivity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActivity.BackgroundColor = System.Drawing.Color.White;
            this.dgvActivity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvActivity.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvActivity.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvHeaderStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvHeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            dgvHeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dgvHeaderStyle.ForeColor = System.Drawing.Color.White;
            dgvHeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            dgvHeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvActivity.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
            this.dgvActivity.ColumnHeadersHeight = 36;
            this.dgvActivity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGuestId,
            this.colGuestName,
            this.colRoom,
            this.colCheckIn,
            this.colCheckOut,
            this.colTotal,
            this.colStatus});
            dgvRowStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvRowStyle.BackColor = System.Drawing.Color.White;
            dgvRowStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dgvRowStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            dgvRowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(222)))), ((int)(((byte)(190)))));
            dgvRowStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.dgvActivity.DefaultCellStyle = dgvRowStyle;
            this.dgvActivity.EnableHeadersVisualStyles = false;
            this.dgvActivity.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.dgvActivity.Location = new System.Drawing.Point(14, 44);
            this.dgvActivity.MultiSelect = false;
            this.dgvActivity.Name = "dgvActivity";
            this.dgvActivity.ReadOnly = true;
            this.dgvActivity.RowHeadersVisible = false;
            this.dgvActivity.RowTemplate.Height = 38;
            this.dgvActivity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActivity.Size = new System.Drawing.Size(700, 308);
            this.dgvActivity.TabIndex = 1;
            // 
            // colGuestId
            // 
            this.colGuestId.FillWeight = 55F;
            this.colGuestId.HeaderText = "Guest ID";
            this.colGuestId.Name = "colGuestId";
            this.colGuestId.ReadOnly = true;
            // 
            // colGuestName
            // 
            this.colGuestName.FillWeight = 95F;
            this.colGuestName.HeaderText = "Guest Name";
            this.colGuestName.Name = "colGuestName";
            this.colGuestName.ReadOnly = true;
            // 
            // colRoom
            // 
            this.colRoom.FillWeight = 55F;
            this.colRoom.HeaderText = "Room #";
            this.colRoom.Name = "colRoom";
            this.colRoom.ReadOnly = true;
            // 
            // colCheckIn
            // 
            this.colCheckIn.FillWeight = 85F;
            this.colCheckIn.HeaderText = "Check-in Date";
            this.colCheckIn.Name = "colCheckIn";
            this.colCheckIn.ReadOnly = true;
            // 
            // colCheckOut
            // 
            this.colCheckOut.FillWeight = 85F;
            this.colCheckOut.HeaderText = "Check-out Date";
            this.colCheckOut.Name = "colCheckOut";
            this.colCheckOut.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.FillWeight = 85F;
            this.colTotal.HeaderText = "Total Amount";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.FillWeight = 75F;
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // pnlQueueCard
            // 
            this.pnlQueueCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlQueueCard.BackColor = System.Drawing.Color.White;
            this.pnlQueueCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQueueCard.Controls.Add(this.lblQueueTitle);
            this.pnlQueueCard.Controls.Add(this.pnlQueueItem1);
            this.pnlQueueItem2.SuspendLayout();
            this.pnlQueueCard.Controls.Add(this.pnlQueueItem2);
            this.pnlQueueItem3.SuspendLayout();
            this.pnlQueueCard.Controls.Add(this.pnlQueueItem3);
            this.pnlQueueCard.Location = new System.Drawing.Point(768, 386);
            this.pnlQueueCard.Name = "pnlQueueCard";
            this.pnlQueueCard.Size = new System.Drawing.Size(292, 368);
            this.pnlQueueCard.TabIndex = 5;
            // 
            // lblQueueTitle
            // 
            this.lblQueueTitle.AutoSize = true;
            this.lblQueueTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblQueueTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.lblQueueTitle.Location = new System.Drawing.Point(14, 12);
            this.lblQueueTitle.Name = "lblQueueTitle";
            this.lblQueueTitle.Size = new System.Drawing.Size(115, 21);
            this.lblQueueTitle.TabIndex = 0;
            this.lblQueueTitle.Text = "Action Queue";
            // 
            // pnlQueueItem1
            // 
            this.pnlQueueItem1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlQueueItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.pnlQueueItem1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQueueItem1.Controls.Add(this.lblQ1Title);
            this.pnlQueueItem1.Controls.Add(this.lblQ1Time);
            this.pnlQueueItem1.Location = new System.Drawing.Point(14, 46);
            this.pnlQueueItem1.Name = "pnlQueueItem1";
            this.pnlQueueItem1.Size = new System.Drawing.Size(262, 60);
            this.pnlQueueItem1.TabIndex = 1;
            // 
            // lblQ1Title
            // 
            this.lblQ1Title.AutoSize = true;
            this.lblQ1Title.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblQ1Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.lblQ1Title.Location = new System.Drawing.Point(10, 10);
            this.lblQ1Title.Name = "lblQ1Title";
            this.lblQ1Title.Size = new System.Drawing.Size(126, 17);
            this.lblQ1Title.TabIndex = 0;
            this.lblQ1Title.Text = "Turnover room 103";
            // 
            // lblQ1Time
            // 
            this.lblQ1Time.AutoSize = true;
            this.lblQ1Time.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblQ1Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(122)))), ((int)(((byte)(134)))));
            this.lblQ1Time.Location = new System.Drawing.Point(10, 32);
            this.lblQ1Time.Name = "lblQ1Time";
            this.lblQ1Time.Size = new System.Drawing.Size(176, 13);
            this.lblQ1Time.TabIndex = 1;
            this.lblQ1Time.Text = "Cleaning required • 2 hours ago";
            // 
            // pnlQueueItem2
            // 
            this.pnlQueueItem2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlQueueItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.pnlQueueItem2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQueueItem2.Controls.Add(this.lblQ2Title);
            this.pnlQueueItem2.Controls.Add(this.lblQ2Time);
            this.pnlQueueItem2.Location = new System.Drawing.Point(14, 116);
            this.pnlQueueItem2.Name = "pnlQueueItem2";
            this.pnlQueueItem2.Size = new System.Drawing.Size(262, 60);
            this.pnlQueueItem2.TabIndex = 2;
            // 
            // lblQ2Title
            // 
            this.lblQ2Title.AutoSize = true;
            this.lblQ2Title.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblQ2Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.lblQ2Title.Location = new System.Drawing.Point(10, 10);
            this.lblQ2Title.Name = "lblQ2Title";
            this.lblQ2Title.Size = new System.Drawing.Size(155, 17);
            this.lblQ2Title.TabIndex = 0;
            this.lblQ2Title.Text = "Processing Check-Out";
            // 
            // lblQ2Time
            // 
            this.lblQ2Time.AutoSize = true;
            this.lblQ2Time.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblQ2Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(122)))), ((int)(((byte)(134)))));
            this.lblQ2Time.Location = new System.Drawing.Point(10, 32);
            this.lblQ2Time.Name = "lblQ2Time";
            this.lblQ2Time.Size = new System.Drawing.Size(183, 13);
            this.lblQ2Time.TabIndex = 1;
            this.lblQ2Time.Text = "Check-Out pending • 5 hours ago";
            // 
            // pnlQueueItem3
            // 
            this.pnlQueueItem3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlQueueItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.pnlQueueItem3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQueueItem3.Controls.Add(this.lblQ3Title);
            this.pnlQueueItem3.Controls.Add(this.lblQ3Time);
            this.pnlQueueItem3.Location = new System.Drawing.Point(14, 186);
            this.pnlQueueItem3.Name = "pnlQueueItem3";
            this.pnlQueueItem3.Size = new System.Drawing.Size(262, 60);
            this.pnlQueueItem3.TabIndex = 3;
            // 
            // lblQ3Title
            // 
            this.lblQ3Title.AutoSize = true;
            this.lblQ3Title.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblQ3Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.lblQ3Title.Location = new System.Drawing.Point(10, 10);
            this.lblQ3Title.Name = "lblQ3Title";
            this.lblQ3Title.Size = new System.Drawing.Size(161, 17);
            this.lblQ3Title.TabIndex = 0;
            this.lblQ3Title.Text = "Keycard Reset: Room 105";
            // 
            // lblQ3Time
            // 
            this.lblQ3Time.AutoSize = true;
            this.lblQ3Time.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblQ3Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(122)))), ((int)(((byte)(134)))));
            this.lblQ3Time.Location = new System.Drawing.Point(10, 32);
            this.lblQ3Time.Name = "lblQ3Time";
            this.lblQ3Time.Size = new System.Drawing.Size(183, 13);
            this.lblQ3Time.TabIndex = 1;
            this.lblQ3Time.Text = "Front Desk Request • 7 hours ago";
            // 
            // FrontDeskDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1304, 780);
            this.Controls.Add(this.panelMainContent);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "FrontDeskDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InnovaStay - Front Desk Dashboard";
            this.Load += new System.EventHandler(this.FrontDeskDashboardForm_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.panelMainContent.ResumeLayout(false);
            this.pnlDashboardWorkspace.ResumeLayout(false);
            this.pnlDashboardWorkspace.PerformLayout();
            this.pnlTimelineCard.ResumeLayout(false);
            this.pnlTimelineCard.PerformLayout();
            this.pnlOccupancyCard.ResumeLayout(false);
            this.pnlOccupancyCard.PerformLayout();
            this.pnlActivityCard.ResumeLayout(false);
            this.pnlActivityCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).EndInit();
            this.pnlQueueCard.ResumeLayout(false);
            this.pnlQueueCard.PerformLayout();
            this.pnlQueueItem1.ResumeLayout(false);
            this.pnlQueueItem1.PerformLayout();
            this.pnlQueueItem2.ResumeLayout(false);
            this.pnlQueueItem2.PerformLayout();
            this.pnlQueueItem3.ResumeLayout(false);
            this.pnlQueueItem3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblBrandSubtitle;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnCreateRes;
        private System.Windows.Forms.Button btnBP;
        private System.Windows.Forms.Button btnGuestManagement;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelMainContent;
        private System.Windows.Forms.Panel pnlDashboardWorkspace;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlTimelineCard;
        private System.Windows.Forms.Label lblTimelineTitle;
        private System.Windows.Forms.Label lblTimelineSub;
        private System.Windows.Forms.Panel pnlTimelineCanvas;
        private System.Windows.Forms.Panel pnlOccupancyCard;
        private System.Windows.Forms.Label lblOccupancyTitle;
        private System.Windows.Forms.Panel pnlRingCanvas;
        private System.Windows.Forms.Label lblBookingsWeek;
        private System.Windows.Forms.Panel pnlBarCanvas;
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
        private System.Windows.Forms.Panel pnlQueueCard;
        private System.Windows.Forms.Label lblQueueTitle;
        private System.Windows.Forms.Panel pnlQueueItem1;
        private System.Windows.Forms.Label lblQ1Title;
        private System.Windows.Forms.Label lblQ1Time;
        private System.Windows.Forms.Panel pnlQueueItem2;
        private System.Windows.Forms.Label lblQ2Title;
        private System.Windows.Forms.Label lblQ2Time;
        private System.Windows.Forms.Panel pnlQueueItem3;
        private System.Windows.Forms.Label lblQ3Title;
        private System.Windows.Forms.Label lblQ3Time;
    }
}