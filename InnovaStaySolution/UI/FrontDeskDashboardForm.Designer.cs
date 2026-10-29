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
            label1 = new Label();
            btnLogout = new Button();
            panelMainContent = new Panel();
<<<<<<< HEAD
            label3 = new Label();
            panel1.SuspendLayout();
=======
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
>>>>>>> main
            SuspendLayout();
            // 
            // btnCheck
            // 
            btnCheck.BackColor = Color.FromArgb(0, 192, 0);
            btnCheck.Cursor = Cursors.Hand;
            btnCheck.FlatStyle = FlatStyle.Flat;
            btnCheck.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheck.ForeColor = Color.White;
            btnCheck.Location = new Point(24, 562);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(200, 40);
            btnCheck.TabIndex = 5;
            btnCheck.Text = "Check-In";
            btnCheck.UseVisualStyleBackColor = false;
            // 
            // btnOut
            // 
            btnOut.BackColor = Color.Navy;
            btnOut.FlatStyle = FlatStyle.Flat;
            btnOut.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOut.ForeColor = Color.White;
            btnOut.Location = new Point(24, 608);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(200, 40);
            btnOut.TabIndex = 6;
            btnOut.Text = "Check-Out";
            btnOut.UseVisualStyleBackColor = false;
            btnOut.Click += btnOut_Click;
            // 
            // btnCreateRes
            // 
            btnCreateRes.BackColor = Color.DarkKhaki;
            btnCreateRes.Cursor = Cursors.Hand;
            btnCreateRes.FlatStyle = FlatStyle.Flat;
            btnCreateRes.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnCreateRes.ForeColor = Color.White;
            btnCreateRes.Location = new Point(24, 220);
            btnCreateRes.Name = "btnCreateRes";
            btnCreateRes.Size = new Size(200, 56);
            btnCreateRes.TabIndex = 9;
            btnCreateRes.Text = "Create Reservation";
            btnCreateRes.UseVisualStyleBackColor = false;
            btnCreateRes.Click += btnCreateRes_Click;
            // 
            // btnBP
            // 
            btnBP.BackColor = Color.DarkKhaki;
            btnBP.Cursor = Cursors.Hand;
            btnBP.FlatStyle = FlatStyle.Flat;
            btnBP.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnBP.ForeColor = Color.White;
            btnBP.Location = new Point(24, 296);
            btnBP.Name = "btnBP";
            btnBP.Size = new Size(200, 56);
            btnBP.TabIndex = 10;
            btnBP.Text = "Billing/Payment";
            btnBP.UseVisualStyleBackColor = false;
            btnBP.Click += btnBP_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Olive;
            label2.Location = new Point(16, 27);
            label2.Name = "label2";
            label2.Size = new Size(208, 41);
            label2.TabIndex = 11;
            label2.Text = "INNOVASTAY";
            // 
            // btnGuestManagement
            // 
            btnGuestManagement.BackColor = Color.DarkKhaki;
            btnGuestManagement.Cursor = Cursors.Hand;
            btnGuestManagement.FlatStyle = FlatStyle.Flat;
            btnGuestManagement.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnGuestManagement.ForeColor = Color.White;
            btnGuestManagement.Location = new Point(24, 373);
            btnGuestManagement.Name = "btnGuestManagement";
            btnGuestManagement.Size = new Size(200, 56);
            btnGuestManagement.TabIndex = 12;
            btnGuestManagement.Text = "Guest Management";
            btnGuestManagement.UseVisualStyleBackColor = false;
            btnGuestManagement.Click += btnGuestManagement_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(label2);
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
            btnDashboard.BackColor = Color.DarkKhaki;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.Beige;
            btnDashboard.Location = new Point(24, 146);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(12, 0, 0, 0);
            btnDashboard.Size = new Size(200, 56);
            btnDashboard.TabIndex = 16;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(36, 68);
            label1.Name = "label1";
            label1.Size = new Size(157, 19);
            label1.TabIndex = 15;
            label1.Text = "FRONTDESK CONSOLE";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(239, 68, 68);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(24, 702);
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
            panelMainContent.BackColor = Color.White;
            panelMainContent.BorderStyle = BorderStyle.FixedSingle;
            panelMainContent.Location = new Point(268, 146);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Size = new Size(907, 596);
            panelMainContent.TabIndex = 14;
            // 
<<<<<<< HEAD
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Olive;
            label3.Location = new Point(258, 27);
            label3.Name = "label3";
            label3.Size = new Size(276, 41);
            label3.TabIndex = 15;
            label3.Text = "FRONTDESK USER";
=======
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
>>>>>>> main
            // 
            // FrontDeskDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1187, 784);
            Controls.Add(label3);
            Controls.Add(panelMainContent);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FrontDeskDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard - Front desk";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
<<<<<<< HEAD
            panel1.PerformLayout();
=======
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
>>>>>>> main
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
        private Panel panelMainContent;
        private Label label1;
        private Label label3;
        private Button btnDashboard;
    }
}