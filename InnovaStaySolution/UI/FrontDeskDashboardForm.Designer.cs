namespace UI
{
    partial class FrontDeskDashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCheck = new Button();
            btnOut = new Button();
            btnCreateRes = new Button();
            btnBP = new Button();
            label2 = new Label();
            btnGuestManagement = new Button();
            panel1 = new Panel();
            btnDashboard = new Button();
            btnLogout = new Button();
            panelMainContent = new Panel();
            dgvRecentPayments = new DataGridView();
            panel3 = new Panel();
            label9 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            lblTodayRevenue = new Label();
            pnlRooms = new Panel();
            label4 = new Label();
            lblAvailableRooms = new Label();
            pnlReservations = new Panel();
            lblActiveReservations = new Label();
            label5 = new Label();
            pnlCheckout = new Panel();
            label3 = new Label();
            lblCheckoutCount = new Label();
            pnlCheckIn = new Panel();
            label1 = new Label();
            lblCheckInCount = new Label();
            panel1.SuspendLayout();
            panelMainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentPayments).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            pnlRooms.SuspendLayout();
            pnlReservations.SuspendLayout();
            pnlCheckout.SuspendLayout();
            pnlCheckIn.SuspendLayout();
            SuspendLayout();
            // 
            // btnCheck
            // 
            btnCheck.BackColor = Color.FromArgb(22, 163, 74);
            btnCheck.Cursor = Cursors.Hand;
            btnCheck.FlatStyle = FlatStyle.Flat;
            btnCheck.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheck.ForeColor = Color.White;
            btnCheck.Location = new Point(16, 566);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(200, 40);
            btnCheck.TabIndex = 5;
            btnCheck.Text = "Check-In";
            btnCheck.UseVisualStyleBackColor = false;
            // 
            // btnOut
            // 
            btnOut.BackColor = Color.FromArgb(71, 85, 105);
            btnOut.FlatStyle = FlatStyle.Flat;
            btnOut.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOut.ForeColor = Color.White;
            btnOut.Location = new Point(16, 626);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(200, 40);
            btnOut.TabIndex = 6;
            btnOut.Text = "Check-Out";
            btnOut.UseVisualStyleBackColor = false;
            btnOut.Click += btnOut_Click;
            // 
            // btnCreateRes
            // 
            btnCreateRes.BackColor = Color.FromArgb(30, 41, 59);
            btnCreateRes.Cursor = Cursors.Hand;
            btnCreateRes.FlatStyle = FlatStyle.Flat;
            btnCreateRes.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnCreateRes.ForeColor = Color.White;
            btnCreateRes.Location = new Point(16, 119);
            btnCreateRes.Name = "btnCreateRes";
            btnCreateRes.Size = new Size(200, 40);
            btnCreateRes.TabIndex = 9;
            btnCreateRes.Text = "Create Reservation";
            btnCreateRes.UseVisualStyleBackColor = false;
            btnCreateRes.Click += btnCreateRes_Click;
            // 
            // btnBP
            // 
            btnBP.BackColor = Color.FromArgb(30, 41, 59);
            btnBP.Cursor = Cursors.Hand;
            btnBP.FlatStyle = FlatStyle.Flat;
            btnBP.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnBP.ForeColor = Color.White;
            btnBP.Location = new Point(16, 190);
            btnBP.Name = "btnBP";
            btnBP.Size = new Size(200, 40);
            btnBP.TabIndex = 10;
            btnBP.Text = "Billing/Payment";
            btnBP.UseVisualStyleBackColor = false;
            btnBP.Click += btnBP_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(30, 41, 59);
            label2.Location = new Point(246, 26);
            label2.Name = "label2";
            label2.Size = new Size(137, 32);
            label2.TabIndex = 11;
            label2.Text = "Front Desk";
            // 
            // btnGuestManagement
            // 
            btnGuestManagement.BackColor = Color.FromArgb(30, 41, 59);
            btnGuestManagement.Cursor = Cursors.Hand;
            btnGuestManagement.FlatStyle = FlatStyle.Flat;
            btnGuestManagement.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnGuestManagement.ForeColor = Color.White;
            btnGuestManagement.Location = new Point(16, 273);
            btnGuestManagement.Name = "btnGuestManagement";
            btnGuestManagement.Size = new Size(200, 40);
            btnGuestManagement.TabIndex = 12;
            btnGuestManagement.Text = "Guest Management";
            btnGuestManagement.UseVisualStyleBackColor = false;
            btnGuestManagement.Click += btnGuestManagement_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 23, 42);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnGuestManagement);
            panel1.Controls.Add(btnCreateRes);
            panel1.Controls.Add(btnOut);
            panel1.Controls.Add(btnBP);
            panel1.Controls.Add(btnCheck);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 784);
            panel1.TabIndex = 13;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(30, 41, 59);
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(16, 40);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(200, 40);
            btnDashboard.TabIndex = 14;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(239, 68, 68);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(16, 686);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(200, 40);
            btnLogout.TabIndex = 13;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panelMainContent
            // 
            panelMainContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMainContent.BorderStyle = BorderStyle.FixedSingle;
            panelMainContent.Controls.Add(dgvRecentPayments);
            panelMainContent.Controls.Add(panel3);
            panelMainContent.Controls.Add(panel2);
            panelMainContent.Controls.Add(pnlRooms);
            panelMainContent.Controls.Add(pnlReservations);
            panelMainContent.Controls.Add(pnlCheckout);
            panelMainContent.Controls.Add(pnlCheckIn);
            panelMainContent.Location = new Point(246, 78);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Size = new Size(898, 694);
            panelMainContent.TabIndex = 14;
            // 
            // dgvRecentPayments
            // 
            dgvRecentPayments.AllowUserToAddRows = false;
            dgvRecentPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentPayments.Location = new Point(20, 230);
            dgvRecentPayments.Name = "dgvRecentPayments";
            dgvRecentPayments.ReadOnly = true;
            dgvRecentPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentPayments.Size = new Size(850, 280);
            dgvRecentPayments.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(452, 134);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 80);
            panel3.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.WindowFrame;
            label9.Location = new Point(40, 10);
            label9.Name = "label9";
            label9.Size = new Size(95, 15);
            label9.TabIndex = 13;
            label9.Text = "Available Rooms";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(74, 35);
            label7.Name = "label7";
            label7.Size = new Size(34, 40);
            label7.TabIndex = 12;
            label7.Text = "0";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(lblTodayRevenue);
            panel2.Location = new Point(20, 134);
            panel2.Name = "panel2";
            panel2.Size = new Size(416, 80);
            panel2.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.WindowFrame;
            label8.Location = new Point(16, 10);
            label8.Name = "label8";
            label8.Size = new Size(95, 15);
            label8.TabIndex = 13;
            label8.Text = "Today's Revenue";
            // 
            // lblTodayRevenue
            // 
            lblTodayRevenue.AutoSize = true;
            lblTodayRevenue.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTodayRevenue.ForeColor = Color.Black;
            lblTodayRevenue.Location = new Point(140, 35);
            lblTodayRevenue.Name = "lblTodayRevenue";
            lblTodayRevenue.Size = new Size(95, 40);
            lblTodayRevenue.TabIndex = 12;
            lblTodayRevenue.Text = "₱0.00";
            // 
            // pnlRooms
            // 
            pnlRooms.BackColor = Color.White;
            pnlRooms.BorderStyle = BorderStyle.FixedSingle;
            pnlRooms.Controls.Add(label4);
            pnlRooms.Controls.Add(lblAvailableRooms);
            pnlRooms.Location = new Point(452, 22);
            pnlRooms.Margin = new Padding(8);
            pnlRooms.Name = "pnlRooms";
            pnlRooms.Padding = new Padding(10);
            pnlRooms.Size = new Size(200, 100);
            pnlRooms.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.WindowFrame;
            label4.Location = new Point(40, 10);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 2;
            label4.Text = "Available Rooms";
            // 
            // lblAvailableRooms
            // 
            lblAvailableRooms.AutoSize = true;
            lblAvailableRooms.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvailableRooms.ForeColor = Color.Black;
            lblAvailableRooms.Location = new Point(74, 35);
            lblAvailableRooms.Name = "lblAvailableRooms";
            lblAvailableRooms.Size = new Size(34, 40);
            lblAvailableRooms.TabIndex = 10;
            lblAvailableRooms.Text = "0";
            // 
            // pnlReservations
            // 
            pnlReservations.BackColor = Color.White;
            pnlReservations.BorderStyle = BorderStyle.FixedSingle;
            pnlReservations.Controls.Add(lblActiveReservations);
            pnlReservations.Controls.Add(label5);
            pnlReservations.Location = new Point(668, 22);
            pnlReservations.Margin = new Padding(8);
            pnlReservations.Name = "pnlReservations";
            pnlReservations.Padding = new Padding(10);
            pnlReservations.Size = new Size(200, 100);
            pnlReservations.TabIndex = 6;
            // 
            // lblActiveReservations
            // 
            lblActiveReservations.AutoSize = true;
            lblActiveReservations.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActiveReservations.ForeColor = Color.Black;
            lblActiveReservations.Location = new Point(77, 35);
            lblActiveReservations.Name = "lblActiveReservations";
            lblActiveReservations.Size = new Size(34, 40);
            lblActiveReservations.TabIndex = 11;
            lblActiveReservations.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.WindowFrame;
            label5.Location = new Point(42, 10);
            label5.Name = "label5";
            label5.Size = new Size(109, 15);
            label5.TabIndex = 3;
            label5.Text = "Active Reservations";
            // 
            // pnlCheckout
            // 
            pnlCheckout.BackColor = Color.White;
            pnlCheckout.BorderStyle = BorderStyle.FixedSingle;
            pnlCheckout.Controls.Add(label3);
            pnlCheckout.Controls.Add(lblCheckoutCount);
            pnlCheckout.Location = new Point(236, 22);
            pnlCheckout.Margin = new Padding(8);
            pnlCheckout.Name = "pnlCheckout";
            pnlCheckout.Padding = new Padding(10);
            pnlCheckout.Size = new Size(200, 100);
            pnlCheckout.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.WindowFrame;
            label3.Location = new Point(42, 10);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 1;
            label3.Text = "Today's Checkout";
            // 
            // lblCheckoutCount
            // 
            lblCheckoutCount.AutoSize = true;
            lblCheckoutCount.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCheckoutCount.ForeColor = Color.Black;
            lblCheckoutCount.Location = new Point(72, 35);
            lblCheckoutCount.Name = "lblCheckoutCount";
            lblCheckoutCount.Size = new Size(34, 40);
            lblCheckoutCount.TabIndex = 9;
            lblCheckoutCount.Text = "0";
            // 
            // pnlCheckIn
            // 
            pnlCheckIn.BackColor = Color.White;
            pnlCheckIn.BorderStyle = BorderStyle.FixedSingle;
            pnlCheckIn.Controls.Add(label1);
            pnlCheckIn.Controls.Add(lblCheckInCount);
            pnlCheckIn.Location = new Point(20, 22);
            pnlCheckIn.Margin = new Padding(8);
            pnlCheckIn.Name = "pnlCheckIn";
            pnlCheckIn.Padding = new Padding(10);
            pnlCheckIn.Size = new Size(200, 100);
            pnlCheckIn.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(38, 10);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Today's Check-in";
            // 
            // lblCheckInCount
            // 
            lblCheckInCount.AutoSize = true;
            lblCheckInCount.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCheckInCount.ForeColor = Color.Black;
            lblCheckInCount.Location = new Point(66, 35);
            lblCheckInCount.Name = "lblCheckInCount";
            lblCheckInCount.Size = new Size(34, 40);
            lblCheckInCount.TabIndex = 8;
            lblCheckInCount.Text = "0";
            // 
            // FrontDeskDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1156, 784);
            Controls.Add(panelMainContent);
            Controls.Add(panel1);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FrontDeskDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard - Front desk";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panelMainContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRecentPayments).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlRooms.ResumeLayout(false);
            pnlRooms.PerformLayout();
            pnlReservations.ResumeLayout(false);
            pnlReservations.PerformLayout();
            pnlCheckout.ResumeLayout(false);
            pnlCheckout.PerformLayout();
            pnlCheckIn.ResumeLayout(false);
            pnlCheckIn.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCheck;
        private Button btnOut;
        private Button btnCreateRes;
        private Button btnBP;
        private Label label2;
        private Button btnGuestManagement;
        private Panel panel1;
        private Button btnLogout;
        private Button btnDashboard;
        private Panel panelMainContent;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Panel pnlCheckIn;
        private Panel pnlRooms;
        private Panel pnlReservations;
        private Panel pnlCheckout;
        private Label lblActiveReservations;
        private Label lblAvailableRooms;
        private Label lblCheckoutCount;
        private Label lblCheckInCount;
        private Panel panel3;
        private Panel panel2;
        private Label label9;
        private Label label7;
        private Label label8;
        private Label lblTodayRevenue;
        private DataGridView dgvRecentPayments;
    }
}