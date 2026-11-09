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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlSidebar = new Panel();
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
            pnlTimelineCard = new Panel();
            lblTimelineTitle = new Label();
            lblTimelineSub = new Label();
            pnlTimelineCanvas = new Panel();
            pnlOccupancyCard = new Panel();
            lblOccupancyTitle = new Label();
            pnlRingCanvas = new Panel();
            lblBookingsWeek = new Label();
            pnlBarCanvas = new Panel();
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
            pnlQueueCard = new Panel();
            lblQueueTitle = new Label();
            pnlQueueItem1 = new Panel();
            lblQ1Title = new Label();
            lblQ1Time = new Label();
            pnlQueueItem2 = new Panel();
            lblQ2Title = new Label();
            lblQ2Time = new Label();
            pnlQueueItem3 = new Panel();
            lblQ3Title = new Label();
            lblQ3Time = new Label();
            pnlSidebar.SuspendLayout();
            panelMainContent.SuspendLayout();
            pnlDashboardWorkspace.SuspendLayout();
            pnlTimelineCard.SuspendLayout();
            pnlOccupancyCard.SuspendLayout();
            pnlActivityCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActivity).BeginInit();
            pnlQueueCard.SuspendLayout();
            pnlQueueItem1.SuspendLayout();
            pnlQueueItem2.SuspendLayout();
            pnlQueueItem3.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(238, 236, 203);
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
            pnlDashboardWorkspace.Controls.Add(pnlTimelineCard);
            pnlDashboardWorkspace.Controls.Add(pnlOccupancyCard);
            pnlDashboardWorkspace.Controls.Add(pnlActivityCard);
            pnlDashboardWorkspace.Controls.Add(pnlQueueCard);
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
            // pnlTimelineCard
            // 
            pnlTimelineCard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlTimelineCard.BackColor = Color.White;
            pnlTimelineCard.BorderStyle = BorderStyle.FixedSingle;
            pnlTimelineCard.Controls.Add(lblTimelineTitle);
            pnlTimelineCard.Controls.Add(lblTimelineSub);
            pnlTimelineCard.Controls.Add(pnlTimelineCanvas);
            pnlTimelineCard.Location = new Point(24, 82);
            pnlTimelineCard.Name = "pnlTimelineCard";
            pnlTimelineCard.Size = new Size(730, 290);
            pnlTimelineCard.TabIndex = 2;
            // 
            // lblTimelineTitle
            // 
            lblTimelineTitle.AutoSize = true;
            lblTimelineTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTimelineTitle.ForeColor = Color.FromArgb(20, 26, 40);
            lblTimelineTitle.Location = new Point(14, 10);
            lblTimelineTitle.Name = "lblTimelineTitle";
            lblTimelineTitle.Size = new Size(168, 21);
            lblTimelineTitle.TabIndex = 0;
            lblTimelineTitle.Text = "Rooms & Reservations";
            // 
            // lblTimelineSub
            // 
            lblTimelineSub.AutoSize = true;
            lblTimelineSub.Font = new Font("Segoe UI", 8.5F);
            lblTimelineSub.ForeColor = Color.FromArgb(115, 122, 134);
            lblTimelineSub.Location = new Point(15, 34);
            lblTimelineSub.Name = "lblTimelineSub";
            lblTimelineSub.Size = new Size(211, 15);
            lblTimelineSub.TabIndex = 1;
            lblTimelineSub.Text = "Interactive Rooms Availability Timeline";
            // 
            // pnlTimelineCanvas
            // 
            pnlTimelineCanvas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlTimelineCanvas.BackColor = Color.FromArgb(250, 251, 253);
            pnlTimelineCanvas.Location = new Point(14, 58);
            pnlTimelineCanvas.Name = "pnlTimelineCanvas";
            pnlTimelineCanvas.Size = new Size(700, 218);
            pnlTimelineCanvas.TabIndex = 2;
            // 
            // pnlOccupancyCard
            // 
            pnlOccupancyCard.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlOccupancyCard.BackColor = Color.White;
            pnlOccupancyCard.BorderStyle = BorderStyle.FixedSingle;
            pnlOccupancyCard.Controls.Add(lblOccupancyTitle);
            pnlOccupancyCard.Controls.Add(pnlRingCanvas);
            pnlOccupancyCard.Controls.Add(lblBookingsWeek);
            pnlOccupancyCard.Controls.Add(pnlBarCanvas);
            pnlOccupancyCard.Location = new Point(768, 82);
            pnlOccupancyCard.Name = "pnlOccupancyCard";
            pnlOccupancyCard.Size = new Size(292, 290);
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
            pnlRingCanvas.Size = new Size(262, 95);
            pnlRingCanvas.TabIndex = 1;
            // 
            // lblBookingsWeek
            // 
            lblBookingsWeek.AutoSize = true;
            lblBookingsWeek.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBookingsWeek.ForeColor = Color.FromArgb(115, 122, 134);
            lblBookingsWeek.Location = new Point(14, 142);
            lblBookingsWeek.Name = "lblBookingsWeek";
            lblBookingsWeek.Size = new Size(115, 15);
            lblBookingsWeek.TabIndex = 2;
            lblBookingsWeek.Text = "Bookings this week";
            // 
            // pnlBarCanvas
            // 
            pnlBarCanvas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlBarCanvas.BackColor = Color.White;
            pnlBarCanvas.Location = new Point(14, 165);
            pnlBarCanvas.Name = "pnlBarCanvas";
            pnlBarCanvas.Size = new Size(262, 110);
            pnlBarCanvas.TabIndex = 3;
            // 
            // pnlActivityCard
            // 
            pnlActivityCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlActivityCard.BackColor = Color.White;
            pnlActivityCard.BorderStyle = BorderStyle.FixedSingle;
            pnlActivityCard.Controls.Add(lblActivityTitle);
            pnlActivityCard.Controls.Add(dgvActivity);
            pnlActivityCard.Location = new Point(24, 386);
            pnlActivityCard.Name = "pnlActivityCard";
            pnlActivityCard.Size = new Size(730, 368);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(20, 26, 40);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(20, 26, 40);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvActivity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvActivity.ColumnHeadersHeight = 36;
            dgvActivity.Columns.AddRange(new DataGridViewColumn[] { colGuestId, colGuestName, colRoom, colCheckIn, colCheckOut, colTotal, colStatus });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(28, 34, 46);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(226, 222, 190);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(20, 26, 40);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvActivity.DefaultCellStyle = dataGridViewCellStyle2;
            dgvActivity.EnableHeadersVisualStyles = false;
            dgvActivity.GridColor = Color.FromArgb(240, 242, 245);
            dgvActivity.Location = new Point(14, 44);
            dgvActivity.MultiSelect = false;
            dgvActivity.Name = "dgvActivity";
            dgvActivity.ReadOnly = true;
            dgvActivity.RowHeadersVisible = false;
            dgvActivity.RowTemplate.Height = 38;
            dgvActivity.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvActivity.Size = new Size(700, 308);
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
            // pnlQueueCard
            // 
            pnlQueueCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pnlQueueCard.BackColor = Color.White;
            pnlQueueCard.BorderStyle = BorderStyle.FixedSingle;
            pnlQueueCard.Controls.Add(lblQueueTitle);
            pnlQueueCard.Controls.Add(pnlQueueItem1);
            pnlQueueCard.Controls.Add(pnlQueueItem2);
            pnlQueueCard.Controls.Add(pnlQueueItem3);
            pnlQueueCard.Location = new Point(768, 386);
            pnlQueueCard.Name = "pnlQueueCard";
            pnlQueueCard.Size = new Size(292, 368);
            pnlQueueCard.TabIndex = 5;
            // 
            // lblQueueTitle
            // 
            lblQueueTitle.AutoSize = true;
            lblQueueTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblQueueTitle.ForeColor = Color.FromArgb(20, 26, 40);
            lblQueueTitle.Location = new Point(14, 12);
            lblQueueTitle.Name = "lblQueueTitle";
            lblQueueTitle.Size = new Size(114, 21);
            lblQueueTitle.TabIndex = 0;
            lblQueueTitle.Text = "Action Queue";
            // 
            // pnlQueueItem1
            // 
            pnlQueueItem1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlQueueItem1.BackColor = Color.FromArgb(248, 249, 251);
            pnlQueueItem1.BorderStyle = BorderStyle.FixedSingle;
            pnlQueueItem1.Controls.Add(lblQ1Title);
            pnlQueueItem1.Controls.Add(lblQ1Time);
            pnlQueueItem1.Location = new Point(14, 46);
            pnlQueueItem1.Name = "pnlQueueItem1";
            pnlQueueItem1.Size = new Size(262, 60);
            pnlQueueItem1.TabIndex = 1;
            // 
            // lblQ1Title
            // 
            lblQ1Title.AutoSize = true;
            lblQ1Title.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblQ1Title.ForeColor = Color.FromArgb(20, 26, 40);
            lblQ1Title.Location = new Point(10, 10);
            lblQ1Title.Name = "lblQ1Title";
            lblQ1Title.Size = new Size(125, 17);
            lblQ1Title.TabIndex = 0;
            lblQ1Title.Text = "Turnover room 103";
            // 
            // lblQ1Time
            // 
            lblQ1Time.AutoSize = true;
            lblQ1Time.Font = new Font("Segoe UI", 8F);
            lblQ1Time.ForeColor = Color.FromArgb(115, 122, 134);
            lblQ1Time.Location = new Point(10, 32);
            lblQ1Time.Name = "lblQ1Time";
            lblQ1Time.Size = new Size(172, 13);
            lblQ1Time.TabIndex = 1;
            lblQ1Time.Text = "Cleaning required • 2 hours ago";
            // 
            // pnlQueueItem2
            // 
            pnlQueueItem2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlQueueItem2.BackColor = Color.FromArgb(248, 249, 251);
            pnlQueueItem2.BorderStyle = BorderStyle.FixedSingle;
            pnlQueueItem2.Controls.Add(lblQ2Title);
            pnlQueueItem2.Controls.Add(lblQ2Time);
            pnlQueueItem2.Location = new Point(14, 116);
            pnlQueueItem2.Name = "pnlQueueItem2";
            pnlQueueItem2.Size = new Size(262, 60);
            pnlQueueItem2.TabIndex = 2;
            // 
            // lblQ2Title
            // 
            lblQ2Title.AutoSize = true;
            lblQ2Title.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblQ2Title.ForeColor = Color.FromArgb(20, 26, 40);
            lblQ2Title.Location = new Point(10, 10);
            lblQ2Title.Name = "lblQ2Title";
            lblQ2Title.Size = new Size(141, 17);
            lblQ2Title.TabIndex = 0;
            lblQ2Title.Text = "Processing Check-Out";
            // 
            // lblQ2Time
            // 
            lblQ2Time.AutoSize = true;
            lblQ2Time.Font = new Font("Segoe UI", 8F);
            lblQ2Time.ForeColor = Color.FromArgb(115, 122, 134);
            lblQ2Time.Location = new Point(10, 32);
            lblQ2Time.Name = "lblQ2Time";
            lblQ2Time.Size = new Size(181, 13);
            lblQ2Time.TabIndex = 1;
            lblQ2Time.Text = "Check-Out pending • 5 hours ago";
            // 
            // pnlQueueItem3
            // 
            pnlQueueItem3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlQueueItem3.BackColor = Color.FromArgb(248, 249, 251);
            pnlQueueItem3.BorderStyle = BorderStyle.FixedSingle;
            pnlQueueItem3.Controls.Add(lblQ3Title);
            pnlQueueItem3.Controls.Add(lblQ3Time);
            pnlQueueItem3.Location = new Point(14, 186);
            pnlQueueItem3.Name = "pnlQueueItem3";
            pnlQueueItem3.Size = new Size(262, 60);
            pnlQueueItem3.TabIndex = 3;
            // 
            // lblQ3Title
            // 
            lblQ3Title.AutoSize = true;
            lblQ3Title.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblQ3Title.ForeColor = Color.FromArgb(20, 26, 40);
            lblQ3Title.Location = new Point(10, 10);
            lblQ3Title.Name = "lblQ3Title";
            lblQ3Title.Size = new Size(162, 17);
            lblQ3Title.TabIndex = 0;
            lblQ3Title.Text = "Keycard Reset: Room 105";
            // 
            // lblQ3Time
            // 
            lblQ3Time.AutoSize = true;
            lblQ3Time.Font = new Font("Segoe UI", 8F);
            lblQ3Time.ForeColor = Color.FromArgb(115, 122, 134);
            lblQ3Time.Location = new Point(10, 32);
            lblQ3Time.Name = "lblQ3Time";
            lblQ3Time.Size = new Size(180, 13);
            lblQ3Time.TabIndex = 1;
            lblQ3Time.Text = "Front Desk Request • 7 hours ago";
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
            pnlTimelineCard.ResumeLayout(false);
            pnlTimelineCard.PerformLayout();
            pnlOccupancyCard.ResumeLayout(false);
            pnlOccupancyCard.PerformLayout();
            pnlActivityCard.ResumeLayout(false);
            pnlActivityCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActivity).EndInit();
            pnlQueueCard.ResumeLayout(false);
            pnlQueueCard.PerformLayout();
            pnlQueueItem1.ResumeLayout(false);
            pnlQueueItem1.PerformLayout();
            pnlQueueItem2.ResumeLayout(false);
            pnlQueueItem2.PerformLayout();
            pnlQueueItem3.ResumeLayout(false);
            pnlQueueItem3.PerformLayout();
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