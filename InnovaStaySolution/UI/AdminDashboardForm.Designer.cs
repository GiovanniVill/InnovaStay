namespace UI
{
    partial class AdminDashboardForm
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
            btnRoomMaintenance = new Button();
            btnUserManagement = new Button();
            btnLogOut = new Button();
            pnlContentHost = new Panel();
            pnlMainDashboard = new Panel();
            lblHeaderTitle = new Label();
            lblHeaderSub = new Label();
            pnlCardRooms = new Panel();
            lblCardRoomsSub = new Label();
            lblCardRoomsVal = new Label();
            lblCardRoomsTitle = new Label();
            pnlCardUsers = new Panel();
            lblCardUsersSub = new Label();
            lblCardUsersVal = new Label();
            lblCardUsersTitle = new Label();
            pnlCardRev = new Panel();
            lblCardRevSub = new Label();
            lblCardRevVal = new Label();
            lblCardRevTitle = new Label();
            pnlCardDb = new Panel();
            lblCardDbSub = new Label();
            lblCardDbVal = new Label();
            lblCardDbTitle = new Label();
            pnlGridCard = new Panel();
            lblGridTitle = new Label();
            dgvAdminUsers = new DataGridView();
            colUserId = new DataGridViewTextBoxColumn();
            colUsername = new DataGridViewTextBoxColumn();
            colRole = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colCreatedAt = new DataGridViewTextBoxColumn();
            pnlRightCard1 = new Panel();
            lblLog3 = new Label();
            lblLog2 = new Label();
            lblLog1 = new Label();
            lblLogsHeader = new Label();
            lblSessionFrontDeskStatus = new Label();
            lblSessionFrontDesk = new Label();
            lblSessionAdminStatus = new Label();
            lblSessionAdmin = new Label();
            lblActiveSessionTitle = new Label();
            pnlRightCard2 = new Panel();
            lblSuiteCount = new Label();
            lblSuiteName = new Label();
            lblDoubleCount = new Label();
            lblDoubleName = new Label();
            lblSingleCount = new Label();
            lblSingleName = new Label();
            lblBreakdownTitle = new Label();
            pnlSidebar.SuspendLayout();
            pnlContentHost.SuspendLayout();
            pnlMainDashboard.SuspendLayout();
            pnlCardRooms.SuspendLayout();
            pnlCardUsers.SuspendLayout();
            pnlCardRev.SuspendLayout();
            pnlCardDb.SuspendLayout();
            pnlGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdminUsers).BeginInit();
            pnlRightCard1.SuspendLayout();
            pnlRightCard2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(238, 236, 203);
            pnlSidebar.Controls.Add(lblBrandSubtitle);
            pnlSidebar.Controls.Add(lblBrand);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(btnRoomMaintenance);
            pnlSidebar.Controls.Add(btnUserManagement);
            pnlSidebar.Controls.Add(btnLogOut);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(220, 720);
            pnlSidebar.TabIndex = 0;
            // 
            // lblBrandSubtitle
            // 
            lblBrandSubtitle.AutoSize = true;
            lblBrandSubtitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblBrandSubtitle.ForeColor = Color.FromArgb(145, 134, 75);
            lblBrandSubtitle.Location = new Point(22, 60);
            lblBrandSubtitle.Name = "lblBrandSubtitle";
            lblBrandSubtitle.Size = new Size(99, 13);
            lblBrandSubtitle.TabIndex = 5;
            lblBrandSubtitle.Text = "ADMIN CONSOLE";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblBrand.ForeColor = Color.FromArgb(145, 134, 75);
            lblBrand.Location = new Point(20, 28);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(149, 30);
            lblBrand.TabIndex = 4;
            lblBrand.Text = "INNOVASTAY";
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(184, 172, 102);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(18, 110);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(184, 42);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnRoomMaintenance
            // 
            btnRoomMaintenance.BackColor = Color.FromArgb(184, 172, 102);
            btnRoomMaintenance.FlatAppearance.BorderSize = 0;
            btnRoomMaintenance.FlatStyle = FlatStyle.Flat;
            btnRoomMaintenance.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnRoomMaintenance.ForeColor = Color.White;
            btnRoomMaintenance.Location = new Point(18, 162);
            btnRoomMaintenance.Name = "btnRoomMaintenance";
            btnRoomMaintenance.Size = new Size(184, 42);
            btnRoomMaintenance.TabIndex = 1;
            btnRoomMaintenance.Text = "Room Maintenance";
            btnRoomMaintenance.UseVisualStyleBackColor = false;
            btnRoomMaintenance.Click += btnRoomMaintenance_Click;
            // 
            // btnUserManagement
            // 
            btnUserManagement.BackColor = Color.FromArgb(184, 172, 102);
            btnUserManagement.FlatAppearance.BorderSize = 0;
            btnUserManagement.FlatStyle = FlatStyle.Flat;
            btnUserManagement.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnUserManagement.ForeColor = Color.White;
            btnUserManagement.Location = new Point(18, 214);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Size = new Size(184, 42);
            btnUserManagement.TabIndex = 2;
            btnUserManagement.Text = "User Management";
            btnUserManagement.UseVisualStyleBackColor = false;
            btnUserManagement.Click += btnUserManagement_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogOut.BackColor = Color.FromArgb(220, 53, 69);
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(18, 654);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(184, 42);
            btnLogOut.TabIndex = 3;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // pnlContentHost
            // 
            pnlContentHost.BackColor = Color.FromArgb(244, 245, 247);
            pnlContentHost.Controls.Add(pnlMainDashboard);
            pnlContentHost.Dock = DockStyle.Fill;
            pnlContentHost.Location = new Point(220, 0);
            pnlContentHost.Name = "pnlContentHost";
            pnlContentHost.Size = new Size(1064, 720);
            pnlContentHost.TabIndex = 1;
            // 
            // pnlMainDashboard
            // 
            pnlMainDashboard.BackColor = Color.FromArgb(244, 245, 247);
            pnlMainDashboard.Controls.Add(lblHeaderTitle);
            pnlMainDashboard.Controls.Add(lblHeaderSub);
            pnlMainDashboard.Controls.Add(pnlCardRooms);
            pnlMainDashboard.Controls.Add(pnlCardUsers);
            pnlMainDashboard.Controls.Add(pnlCardRev);
            pnlMainDashboard.Controls.Add(pnlCardDb);
            pnlMainDashboard.Controls.Add(pnlGridCard);
            pnlMainDashboard.Controls.Add(pnlRightCard1);
            pnlMainDashboard.Controls.Add(pnlRightCard2);
            pnlMainDashboard.Dock = DockStyle.Fill;
            pnlMainDashboard.Location = new Point(0, 0);
            pnlMainDashboard.Name = "pnlMainDashboard";
            pnlMainDashboard.Padding = new Padding(24);
            pnlMainDashboard.Size = new Size(1064, 720);
            pnlMainDashboard.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(20, 26, 40);
            lblHeaderTitle.Location = new Point(24, 18);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(250, 37);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "Admin Workspace";
            // 
            // lblHeaderSub
            // 
            lblHeaderSub.AutoSize = true;
            lblHeaderSub.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHeaderSub.ForeColor = Color.FromArgb(145, 134, 75);
            lblHeaderSub.Location = new Point(26, 56);
            lblHeaderSub.Name = "lblHeaderSub";
            lblHeaderSub.Size = new Size(221, 19);
            lblHeaderSub.TabIndex = 1;
            lblHeaderSub.Text = "System Overview & Performance";
            // 
            // pnlCardRooms
            // 
            pnlCardRooms.BackColor = Color.White;
            pnlCardRooms.BorderStyle = BorderStyle.FixedSingle;
            pnlCardRooms.Controls.Add(lblCardRoomsSub);
            pnlCardRooms.Controls.Add(lblCardRoomsVal);
            pnlCardRooms.Controls.Add(lblCardRoomsTitle);
            pnlCardRooms.Location = new Point(24, 88);
            pnlCardRooms.Name = "pnlCardRooms";
            pnlCardRooms.Size = new Size(240, 95);
            pnlCardRooms.TabIndex = 2;
            // 
            // lblCardRoomsSub
            // 
            lblCardRoomsSub.AutoSize = true;
            lblCardRoomsSub.Font = new Font("Segoe UI", 8F);
            lblCardRoomsSub.ForeColor = Color.FromArgb(115, 122, 134);
            lblCardRoomsSub.Location = new Point(12, 64);
            lblCardRoomsSub.Name = "lblCardRoomsSub";
            lblCardRoomsSub.Size = new Size(19, 13);
            lblCardRoomsSub.TabIndex = 2;
            lblCardRoomsSub.Text = "---";
            // 
            // lblCardRoomsVal
            // 
            lblCardRoomsVal.AutoSize = true;
            lblCardRoomsVal.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblCardRoomsVal.ForeColor = Color.FromArgb(20, 26, 40);
            lblCardRoomsVal.Location = new Point(10, 30);
            lblCardRoomsVal.Name = "lblCardRoomsVal";
            lblCardRoomsVal.Size = new Size(36, 28);
            lblCardRoomsVal.TabIndex = 1;
            lblCardRoomsVal.Text = "---";
            // 
            // lblCardRoomsTitle
            // 
            lblCardRoomsTitle.AutoSize = true;
            lblCardRoomsTitle.Font = new Font("Segoe UI", 8.5F);
            lblCardRoomsTitle.ForeColor = Color.FromArgb(115, 122, 134);
            lblCardRoomsTitle.Location = new Point(12, 10);
            lblCardRoomsTitle.Name = "lblCardRoomsTitle";
            lblCardRoomsTitle.Size = new Size(72, 15);
            lblCardRoomsTitle.TabIndex = 0;
            lblCardRoomsTitle.Text = "Total Rooms";
            // 
            // pnlCardUsers
            // 
            pnlCardUsers.BackColor = Color.White;
            pnlCardUsers.BorderStyle = BorderStyle.FixedSingle;
            pnlCardUsers.Controls.Add(lblCardUsersSub);
            pnlCardUsers.Controls.Add(lblCardUsersVal);
            pnlCardUsers.Controls.Add(lblCardUsersTitle);
            pnlCardUsers.Location = new Point(276, 88);
            pnlCardUsers.Name = "pnlCardUsers";
            pnlCardUsers.Size = new Size(240, 95);
            pnlCardUsers.TabIndex = 3;
            // 
            // lblCardUsersSub
            // 
            lblCardUsersSub.AutoSize = true;
            lblCardUsersSub.Font = new Font("Segoe UI", 8F);
            lblCardUsersSub.ForeColor = Color.FromArgb(115, 122, 134);
            lblCardUsersSub.Location = new Point(12, 64);
            lblCardUsersSub.Name = "lblCardUsersSub";
            lblCardUsersSub.Size = new Size(19, 13);
            lblCardUsersSub.TabIndex = 2;
            lblCardUsersSub.Text = "---";
            // 
            // lblCardUsersVal
            // 
            lblCardUsersVal.AutoSize = true;
            lblCardUsersVal.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblCardUsersVal.ForeColor = Color.FromArgb(20, 26, 40);
            lblCardUsersVal.Location = new Point(10, 30);
            lblCardUsersVal.Name = "lblCardUsersVal";
            lblCardUsersVal.Size = new Size(36, 28);
            lblCardUsersVal.TabIndex = 1;
            lblCardUsersVal.Text = "---";
            // 
            // lblCardUsersTitle
            // 
            lblCardUsersTitle.AutoSize = true;
            lblCardUsersTitle.Font = new Font("Segoe UI", 8.5F);
            lblCardUsersTitle.ForeColor = Color.FromArgb(115, 122, 134);
            lblCardUsersTitle.Location = new Point(12, 10);
            lblCardUsersTitle.Name = "lblCardUsersTitle";
            lblCardUsersTitle.Size = new Size(98, 15);
            lblCardUsersTitle.TabIndex = 0;
            lblCardUsersTitle.Text = "Total Users / Staff";
            // 
            // pnlCardRev
            // 
            pnlCardRev.BackColor = Color.White;
            pnlCardRev.BorderStyle = BorderStyle.FixedSingle;
            pnlCardRev.Controls.Add(lblCardRevSub);
            pnlCardRev.Controls.Add(lblCardRevVal);
            pnlCardRev.Controls.Add(lblCardRevTitle);
            pnlCardRev.Location = new Point(528, 88);
            pnlCardRev.Name = "pnlCardRev";
            pnlCardRev.Size = new Size(240, 95);
            pnlCardRev.TabIndex = 4;
            // 
            // lblCardRevSub
            // 
            lblCardRevSub.AutoSize = true;
            lblCardRevSub.Font = new Font("Segoe UI", 8F);
            lblCardRevSub.ForeColor = Color.FromArgb(115, 122, 134);
            lblCardRevSub.Location = new Point(12, 64);
            lblCardRevSub.Name = "lblCardRevSub";
            lblCardRevSub.Size = new Size(19, 13);
            lblCardRevSub.TabIndex = 2;
            lblCardRevSub.Text = "---";
            // 
            // lblCardRevVal
            // 
            lblCardRevVal.AutoSize = true;
            lblCardRevVal.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblCardRevVal.ForeColor = Color.FromArgb(20, 26, 40);
            lblCardRevVal.Location = new Point(10, 30);
            lblCardRevVal.Name = "lblCardRevVal";
            lblCardRevVal.Size = new Size(36, 28);
            lblCardRevVal.TabIndex = 1;
            lblCardRevVal.Text = "---";
            // 
            // lblCardRevTitle
            // 
            lblCardRevTitle.AutoSize = true;
            lblCardRevTitle.Font = new Font("Segoe UI", 8.5F);
            lblCardRevTitle.ForeColor = Color.FromArgb(115, 122, 134);
            lblCardRevTitle.Location = new Point(12, 10);
            lblCardRevTitle.Name = "lblCardRevTitle";
            lblCardRevTitle.Size = new Size(143, 15);
            lblCardRevTitle.TabIndex = 0;
            lblCardRevTitle.Text = "System Revenue Potential";
            // 
            // pnlCardDb
            // 
            pnlCardDb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlCardDb.BackColor = Color.White;
            pnlCardDb.BorderStyle = BorderStyle.FixedSingle;
            pnlCardDb.Controls.Add(lblCardDbSub);
            pnlCardDb.Controls.Add(lblCardDbVal);
            pnlCardDb.Controls.Add(lblCardDbTitle);
            pnlCardDb.Location = new Point(780, 88);
            pnlCardDb.Name = "pnlCardDb";
            pnlCardDb.Size = new Size(260, 95);
            pnlCardDb.TabIndex = 5;
            // 
            // lblCardDbSub
            // 
            lblCardDbSub.AutoSize = true;
            lblCardDbSub.Font = new Font("Segoe UI", 8F);
            lblCardDbSub.ForeColor = Color.FromArgb(115, 122, 134);
            lblCardDbSub.Location = new Point(12, 64);
            lblCardDbSub.Name = "lblCardDbSub";
            lblCardDbSub.Size = new Size(155, 13);
            lblCardDbSub.TabIndex = 2;
            lblCardDbSub.Text = "MSSQLLocalDB InnovaStayDB";
            // 
            // lblCardDbVal
            // 
            lblCardDbVal.AutoSize = true;
            lblCardDbVal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCardDbVal.ForeColor = Color.FromArgb(46, 125, 50);
            lblCardDbVal.Location = new Point(10, 34);
            lblCardDbVal.Name = "lblCardDbVal";
            lblCardDbVal.Size = new Size(28, 21);
            lblCardDbVal.TabIndex = 1;
            lblCardDbVal.Text = "---";
            // 
            // lblCardDbTitle
            // 
            lblCardDbTitle.AutoSize = true;
            lblCardDbTitle.Font = new Font("Segoe UI", 8.5F);
            lblCardDbTitle.ForeColor = Color.FromArgb(115, 122, 134);
            lblCardDbTitle.Location = new Point(12, 10);
            lblCardDbTitle.Name = "lblCardDbTitle";
            lblCardDbTitle.Size = new Size(90, 15);
            lblCardDbTitle.TabIndex = 0;
            lblCardDbTitle.Text = "Database Status";
            // 
            // pnlGridCard
            // 
            pnlGridCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlGridCard.BackColor = Color.White;
            pnlGridCard.BorderStyle = BorderStyle.FixedSingle;
            pnlGridCard.Controls.Add(lblGridTitle);
            pnlGridCard.Controls.Add(dgvAdminUsers);
            pnlGridCard.Location = new Point(24, 200);
            pnlGridCard.Name = "pnlGridCard";
            pnlGridCard.Size = new Size(744, 496);
            pnlGridCard.TabIndex = 6;
            // 
            // lblGridTitle
            // 
            lblGridTitle.AutoSize = true;
            lblGridTitle.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            lblGridTitle.ForeColor = Color.FromArgb(20, 26, 40);
            lblGridTitle.Location = new Point(16, 14);
            lblGridTitle.Name = "lblGridTitle";
            lblGridTitle.Size = new Size(372, 21);
            lblGridTitle.TabIndex = 0;
            lblGridTitle.Text = "User / Staff Accounts (InnovaStayDB.dbo.Users)";
            // 
            // dgvAdminUsers
            // 
            dgvAdminUsers.AllowUserToAddRows = false;
            dgvAdminUsers.AllowUserToDeleteRows = false;
            dgvAdminUsers.AllowUserToResizeRows = false;
            dgvAdminUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAdminUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAdminUsers.BackgroundColor = Color.White;
            dgvAdminUsers.BorderStyle = BorderStyle.None;
            dgvAdminUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAdminUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(20, 26, 40);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(20, 26, 40);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAdminUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAdminUsers.ColumnHeadersHeight = 36;
            dgvAdminUsers.Columns.AddRange(new DataGridViewColumn[] { colUserId, colUsername, colRole, colStatus, colCreatedAt });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(28, 34, 46);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(226, 222, 190);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(20, 26, 40);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAdminUsers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAdminUsers.EnableHeadersVisualStyles = false;
            dgvAdminUsers.GridColor = Color.FromArgb(240, 242, 245);
            dgvAdminUsers.Location = new Point(16, 46);
            dgvAdminUsers.MultiSelect = false;
            dgvAdminUsers.Name = "dgvAdminUsers";
            dgvAdminUsers.ReadOnly = true;
            dgvAdminUsers.RowHeadersVisible = false;
            dgvAdminUsers.RowTemplate.Height = 40;
            dgvAdminUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdminUsers.Size = new Size(712, 434);
            dgvAdminUsers.TabIndex = 1;
            // 
            // colUserId
            // 
            colUserId.FillWeight = 50F;
            colUserId.HeaderText = "User ID";
            colUserId.Name = "colUserId";
            colUserId.ReadOnly = true;
            // 
            // colUsername
            // 
            colUsername.FillWeight = 85F;
            colUsername.HeaderText = "Username";
            colUsername.Name = "colUsername";
            colUsername.ReadOnly = true;
            // 
            // colRole
            // 
            colRole.FillWeight = 80F;
            colRole.HeaderText = "Role";
            colRole.Name = "colRole";
            colRole.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.FillWeight = 65F;
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // colCreatedAt
            // 
            colCreatedAt.FillWeight = 110F;
            colCreatedAt.HeaderText = "Created At";
            colCreatedAt.Name = "colCreatedAt";
            colCreatedAt.ReadOnly = true;
            // 
            // pnlRightCard1
            // 
            pnlRightCard1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlRightCard1.BackColor = Color.White;
            pnlRightCard1.BorderStyle = BorderStyle.FixedSingle;
            pnlRightCard1.Controls.Add(lblLog3);
            pnlRightCard1.Controls.Add(lblLog2);
            pnlRightCard1.Controls.Add(lblLog1);
            pnlRightCard1.Controls.Add(lblLogsHeader);
            pnlRightCard1.Controls.Add(lblSessionFrontDeskStatus);
            pnlRightCard1.Controls.Add(lblSessionFrontDesk);
            pnlRightCard1.Controls.Add(lblSessionAdminStatus);
            pnlRightCard1.Controls.Add(lblSessionAdmin);
            pnlRightCard1.Controls.Add(lblActiveSessionTitle);
            pnlRightCard1.Location = new Point(780, 200);
            pnlRightCard1.Name = "pnlRightCard1";
            pnlRightCard1.Size = new Size(260, 280);
            pnlRightCard1.TabIndex = 7;
            // 
            // lblLog3
            // 
            lblLog3.AutoSize = true;
            lblLog3.Font = new Font("Segoe UI", 8F);
            lblLog3.ForeColor = Color.FromArgb(115, 122, 134);
            lblLog3.Location = new Point(14, 230);
            lblLog3.Name = "lblLog3";
            lblLog3.Size = new Size(220, 13);
            lblLog3.TabIndex = 8;
            lblLog3.Text = "• dbo.tbl_Rooms state synchronized - Live";
            // 
            // lblLog2
            // 
            lblLog2.AutoSize = true;
            lblLog2.Font = new Font("Segoe UI", 8F);
            lblLog2.ForeColor = Color.FromArgb(115, 122, 134);
            lblLog2.Location = new Point(14, 206);
            lblLog2.Name = "lblLog2";
            lblLog2.Size = new Size(247, 13);
            lblLog2.TabIndex = 7;
            lblLog2.Text = "• spGetAllUsersWithProfiles queried - Just now";
            // 
            // lblLog1
            // 
            lblLog1.AutoSize = true;
            lblLog1.Font = new Font("Segoe UI", 8F);
            lblLog1.ForeColor = Color.FromArgb(115, 122, 134);
            lblLog1.Location = new Point(14, 182);
            lblLog1.Name = "lblLog1";
            lblLog1.Size = new Size(174, 13);
            lblLog1.TabIndex = 6;
            lblLog1.Text = "• sp_Room_CRUD executed - Live";
            // 
            // lblLogsHeader
            // 
            lblLogsHeader.AutoSize = true;
            lblLogsHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLogsHeader.ForeColor = Color.FromArgb(20, 26, 40);
            lblLogsHeader.Location = new Point(14, 150);
            lblLogsHeader.Name = "lblLogsHeader";
            lblLogsHeader.Size = new Size(161, 19);
            lblLogsHeader.TabIndex = 5;
            lblLogsHeader.Text = "Database Activity Logs";
            // 
            // lblSessionFrontDeskStatus
            // 
            lblSessionFrontDeskStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSessionFrontDeskStatus.AutoSize = true;
            lblSessionFrontDeskStatus.Font = new Font("Segoe UI", 8.5F);
            lblSessionFrontDeskStatus.ForeColor = Color.FromArgb(115, 122, 134);
            lblSessionFrontDeskStatus.Location = new Point(145, 82);
            lblSessionFrontDeskStatus.Name = "lblSessionFrontDeskStatus";
            lblSessionFrontDeskStatus.Size = new Size(22, 15);
            lblSessionFrontDeskStatus.TabIndex = 4;
            lblSessionFrontDeskStatus.Text = "---";
            // 
            // lblSessionFrontDesk
            // 
            lblSessionFrontDesk.AutoSize = true;
            lblSessionFrontDesk.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSessionFrontDesk.ForeColor = Color.FromArgb(20, 26, 40);
            lblSessionFrontDesk.Location = new Point(14, 80);
            lblSessionFrontDesk.Name = "lblSessionFrontDesk";
            lblSessionFrontDesk.Size = new Size(67, 17);
            lblSessionFrontDesk.TabIndex = 3;
            lblSessionFrontDesk.Text = "frontdesk";
            // 
            // lblSessionAdminStatus
            // 
            lblSessionAdminStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSessionAdminStatus.AutoSize = true;
            lblSessionAdminStatus.Font = new Font("Segoe UI", 8.5F);
            lblSessionAdminStatus.ForeColor = Color.FromArgb(46, 125, 50);
            lblSessionAdminStatus.Location = new Point(135, 48);
            lblSessionAdminStatus.Name = "lblSessionAdminStatus";
            lblSessionAdminStatus.Size = new Size(22, 15);
            lblSessionAdminStatus.TabIndex = 2;
            lblSessionAdminStatus.Text = "---";
            // 
            // lblSessionAdmin
            // 
            lblSessionAdmin.AutoSize = true;
            lblSessionAdmin.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSessionAdmin.ForeColor = Color.FromArgb(20, 26, 40);
            lblSessionAdmin.Location = new Point(14, 46);
            lblSessionAdmin.Name = "lblSessionAdmin";
            lblSessionAdmin.Size = new Size(47, 17);
            lblSessionAdmin.TabIndex = 1;
            lblSessionAdmin.Text = "admin";
            // 
            // lblActiveSessionTitle
            // 
            lblActiveSessionTitle.AutoSize = true;
            lblActiveSessionTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblActiveSessionTitle.ForeColor = Color.FromArgb(20, 26, 40);
            lblActiveSessionTitle.Location = new Point(14, 12);
            lblActiveSessionTitle.Name = "lblActiveSessionTitle";
            lblActiveSessionTitle.Size = new Size(182, 20);
            lblActiveSessionTitle.TabIndex = 0;
            lblActiveSessionTitle.Text = "Active Session & Accounts";
            // 
            // pnlRightCard2
            // 
            pnlRightCard2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pnlRightCard2.BackColor = Color.White;
            pnlRightCard2.BorderStyle = BorderStyle.FixedSingle;
            pnlRightCard2.Controls.Add(lblSuiteCount);
            pnlRightCard2.Controls.Add(lblSuiteName);
            pnlRightCard2.Controls.Add(lblDoubleCount);
            pnlRightCard2.Controls.Add(lblDoubleName);
            pnlRightCard2.Controls.Add(lblSingleCount);
            pnlRightCard2.Controls.Add(lblSingleName);
            pnlRightCard2.Controls.Add(lblBreakdownTitle);
            pnlRightCard2.Location = new Point(780, 496);
            pnlRightCard2.Name = "pnlRightCard2";
            pnlRightCard2.Size = new Size(260, 200);
            pnlRightCard2.TabIndex = 8;
            // 
            // lblSuiteCount
            // 
            lblSuiteCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSuiteCount.AutoSize = true;
            lblSuiteCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSuiteCount.ForeColor = Color.FromArgb(145, 134, 75);
            lblSuiteCount.Location = new Point(185, 102);
            lblSuiteCount.Name = "lblSuiteCount";
            lblSuiteCount.Size = new Size(22, 15);
            lblSuiteCount.TabIndex = 6;
            lblSuiteCount.Text = "---";
            // 
            // lblSuiteName
            // 
            lblSuiteName.AutoSize = true;
            lblSuiteName.Font = new Font("Segoe UI", 9F);
            lblSuiteName.ForeColor = Color.FromArgb(28, 34, 46);
            lblSuiteName.Location = new Point(14, 102);
            lblSuiteName.Name = "lblSuiteName";
            lblSuiteName.Size = new Size(38, 15);
            lblSuiteName.TabIndex = 5;
            lblSuiteName.Text = "Suites";
            // 
            // lblDoubleCount
            // 
            lblDoubleCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDoubleCount.AutoSize = true;
            lblDoubleCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDoubleCount.ForeColor = Color.FromArgb(145, 134, 75);
            lblDoubleCount.Location = new Point(185, 74);
            lblDoubleCount.Name = "lblDoubleCount";
            lblDoubleCount.Size = new Size(22, 15);
            lblDoubleCount.TabIndex = 4;
            lblDoubleCount.Text = "---";
            // 
            // lblDoubleName
            // 
            lblDoubleName.AutoSize = true;
            lblDoubleName.Font = new Font("Segoe UI", 9F);
            lblDoubleName.ForeColor = Color.FromArgb(28, 34, 46);
            lblDoubleName.Location = new Point(14, 74);
            lblDoubleName.Name = "lblDoubleName";
            lblDoubleName.Size = new Size(85, 15);
            lblDoubleName.TabIndex = 3;
            lblDoubleName.Text = "Double Rooms";
            // 
            // lblSingleCount
            // 
            lblSingleCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSingleCount.AutoSize = true;
            lblSingleCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSingleCount.ForeColor = Color.FromArgb(145, 134, 75);
            lblSingleCount.Location = new Point(185, 46);
            lblSingleCount.Name = "lblSingleCount";
            lblSingleCount.Size = new Size(22, 15);
            lblSingleCount.TabIndex = 2;
            lblSingleCount.Text = "---";
            // 
            // lblSingleName
            // 
            lblSingleName.AutoSize = true;
            lblSingleName.Font = new Font("Segoe UI", 9F);
            lblSingleName.ForeColor = Color.FromArgb(28, 34, 46);
            lblSingleName.Location = new Point(14, 46);
            lblSingleName.Name = "lblSingleName";
            lblSingleName.Size = new Size(79, 15);
            lblSingleName.TabIndex = 1;
            lblSingleName.Text = "Single Rooms";
            // 
            // lblBreakdownTitle
            // 
            lblBreakdownTitle.AutoSize = true;
            lblBreakdownTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblBreakdownTitle.ForeColor = Color.FromArgb(20, 26, 40);
            lblBreakdownTitle.Location = new Point(14, 12);
            lblBreakdownTitle.Name = "lblBreakdownTitle";
            lblBreakdownTitle.Size = new Size(177, 20);
            lblBreakdownTitle.TabIndex = 0;
            lblBreakdownTitle.Text = "Room Quick Breakdown";
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 245, 247);
            ClientSize = new Size(1284, 720);
            Controls.Add(pnlContentHost);
            Controls.Add(pnlSidebar);
            Name = "AdminDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InnovaStay - Admin Dashboard";
            Load += AdminDashboardForm_Load;
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlContentHost.ResumeLayout(false);
            pnlMainDashboard.ResumeLayout(false);
            pnlMainDashboard.PerformLayout();
            pnlCardRooms.ResumeLayout(false);
            pnlCardRooms.PerformLayout();
            pnlCardUsers.ResumeLayout(false);
            pnlCardUsers.PerformLayout();
            pnlCardRev.ResumeLayout(false);
            pnlCardRev.PerformLayout();
            pnlCardDb.ResumeLayout(false);
            pnlCardDb.PerformLayout();
            pnlGridCard.ResumeLayout(false);
            pnlGridCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdminUsers).EndInit();
            pnlRightCard1.ResumeLayout(false);
            pnlRightCard1.PerformLayout();
            pnlRightCard2.ResumeLayout(false);
            pnlRightCard2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblBrandSubtitle;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnRoomMaintenance;
        private System.Windows.Forms.Button btnUserManagement;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel pnlContentHost;
        private System.Windows.Forms.Panel pnlMainDashboard;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSub;
        private System.Windows.Forms.Panel pnlCardRooms;
        private System.Windows.Forms.Label lblCardRoomsTitle;
        private System.Windows.Forms.Label lblCardRoomsVal;
        private System.Windows.Forms.Label lblCardRoomsSub;
        private System.Windows.Forms.Panel pnlCardUsers;
        private System.Windows.Forms.Label lblCardUsersTitle;
        private System.Windows.Forms.Label lblCardUsersVal;
        private System.Windows.Forms.Label lblCardUsersSub;
        private System.Windows.Forms.Panel pnlCardRev;
        private System.Windows.Forms.Label lblCardRevTitle;
        private System.Windows.Forms.Label lblCardRevVal;
        private System.Windows.Forms.Label lblCardRevSub;
        private System.Windows.Forms.Panel pnlCardDb;
        private System.Windows.Forms.Label lblCardDbTitle;
        private System.Windows.Forms.Label lblCardDbVal;
        private System.Windows.Forms.Label lblCardDbSub;
        private System.Windows.Forms.Panel pnlGridCard;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.DataGridView dgvAdminUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedAt;
        private System.Windows.Forms.Panel pnlRightCard1;
        private System.Windows.Forms.Label lblActiveSessionTitle;
        private System.Windows.Forms.Label lblSessionAdmin;
        private System.Windows.Forms.Label lblSessionAdminStatus;
        private System.Windows.Forms.Label lblSessionFrontDesk;
        private System.Windows.Forms.Label lblSessionFrontDeskStatus;
        private System.Windows.Forms.Label lblLogsHeader;
        private System.Windows.Forms.Label lblLog1;
        private System.Windows.Forms.Label lblLog2;
        private System.Windows.Forms.Label lblLog3;
        private System.Windows.Forms.Panel pnlRightCard2;
        private System.Windows.Forms.Label lblBreakdownTitle;
        private System.Windows.Forms.Label lblSingleName;
        private System.Windows.Forms.Label lblSingleCount;
        private System.Windows.Forms.Label lblDoubleName;
        private System.Windows.Forms.Label lblDoubleCount;
        private System.Windows.Forms.Label lblSuiteName;
        private System.Windows.Forms.Label lblSuiteCount;
    }
}