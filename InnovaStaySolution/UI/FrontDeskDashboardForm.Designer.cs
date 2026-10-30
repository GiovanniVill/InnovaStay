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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            label3 = new Label();
            panel5 = new Panel();
            lblAvailableRooms = new Label();
            label6 = new Label();
            panel3 = new Panel();
            lblCheckInCount = new Label();
            lblTotal = new Label();
            panel4 = new Panel();
            lblOccupiedCount = new Label();
            label5 = new Label();
            panel6 = new Panel();
            lblCheckOutCount = new Label();
            lblAvail = new Label();
            lblCurrentActivity = new Label();
            dgvFrontDeskSchedule = new DataGridView();
            panelMainContent = new Panel();
            pnlFrontDeskActivity = new Panel();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFrontDeskSchedule).BeginInit();
            panelMainContent.SuspendLayout();
            pnlFrontDeskActivity.SuspendLayout();
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
            panel1.Size = new Size(247, 1055);
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
            // 
            // panel5
            // 
            panel5.BackColor = Color.Silver;
            panel5.Controls.Add(lblAvailableRooms);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(698, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(189, 97);
            panel5.TabIndex = 26;
            // 
            // lblAvailableRooms
            // 
            lblAvailableRooms.AutoSize = true;
            lblAvailableRooms.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvailableRooms.ForeColor = Color.FromArgb(30, 41, 59);
            lblAvailableRooms.Location = new Point(18, 38);
            lblAvailableRooms.Name = "lblAvailableRooms";
            lblAvailableRooms.Size = new Size(40, 46);
            lblAvailableRooms.TabIndex = 4;
            lblAvailableRooms.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(18, 17);
            label6.Name = "label6";
            label6.Size = new Size(113, 19);
            label6.TabIndex = 4;
            label6.Text = "Available Rooms";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(lblCheckInCount);
            panel3.Controls.Add(lblTotal);
            panel3.Location = new Point(4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(189, 97);
            panel3.TabIndex = 23;
            // 
            // lblCheckInCount
            // 
            lblCheckInCount.AutoSize = true;
            lblCheckInCount.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCheckInCount.ForeColor = Color.FromArgb(30, 41, 59);
            lblCheckInCount.Location = new Point(15, 38);
            lblCheckInCount.Name = "lblCheckInCount";
            lblCheckInCount.Size = new Size(40, 46);
            lblCheckInCount.TabIndex = 0;
            lblCheckInCount.Text = "0";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.Black;
            lblTotal.Location = new Point(15, 15);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(106, 19);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Today's Arrivals";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Controls.Add(lblOccupiedCount);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(470, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(189, 97);
            panel4.TabIndex = 25;
            // 
            // lblOccupiedCount
            // 
            lblOccupiedCount.AutoSize = true;
            lblOccupiedCount.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOccupiedCount.ForeColor = Color.FromArgb(30, 41, 59);
            lblOccupiedCount.Location = new Point(14, 38);
            lblOccupiedCount.Name = "lblOccupiedCount";
            lblOccupiedCount.Size = new Size(40, 46);
            lblOccupiedCount.TabIndex = 2;
            lblOccupiedCount.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(14, 17);
            label5.Name = "label5";
            label5.Size = new Size(116, 19);
            label5.TabIndex = 3;
            label5.Text = "Occupied Rooms";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Silver;
            panel6.Controls.Add(lblCheckOutCount);
            panel6.Controls.Add(lblAvail);
            panel6.Location = new Point(236, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(189, 97);
            panel6.TabIndex = 24;
            // 
            // lblCheckOutCount
            // 
            lblCheckOutCount.AutoSize = true;
            lblCheckOutCount.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCheckOutCount.ForeColor = Color.FromArgb(30, 41, 59);
            lblCheckOutCount.Location = new Point(13, 38);
            lblCheckOutCount.Name = "lblCheckOutCount";
            lblCheckOutCount.Size = new Size(40, 46);
            lblCheckOutCount.TabIndex = 2;
            lblCheckOutCount.Text = "0";
            // 
            // lblAvail
            // 
            lblAvail.AutoSize = true;
            lblAvail.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblAvail.ForeColor = Color.Black;
            lblAvail.Location = new Point(13, 15);
            lblAvail.Name = "lblAvail";
            lblAvail.Size = new Size(127, 19);
            lblAvail.TabIndex = 2;
            lblAvail.Text = "Today's Departures";
            // 
            // lblCurrentActivity
            // 
            lblCurrentActivity.AutoSize = true;
            lblCurrentActivity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentActivity.ForeColor = Color.Black;
            lblCurrentActivity.Location = new Point(14, 0);
            lblCurrentActivity.Name = "lblCurrentActivity";
            lblCurrentActivity.Size = new Size(377, 28);
            lblCurrentActivity.TabIndex = 0;
            lblCurrentActivity.Text = "Today's Schedule And In-House Guests";
            // 
            // dgvFrontDeskSchedule
            // 
            dgvFrontDeskSchedule.AllowUserToAddRows = false;
            dgvFrontDeskSchedule.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvFrontDeskSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFrontDeskSchedule.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvFrontDeskSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvFrontDeskSchedule.ColumnHeadersHeight = 35;
            dgvFrontDeskSchedule.EnableHeadersVisualStyles = false;
            dgvFrontDeskSchedule.Location = new Point(258, 230);
            dgvFrontDeskSchedule.MultiSelect = false;
            dgvFrontDeskSchedule.Name = "dgvFrontDeskSchedule";
            dgvFrontDeskSchedule.ReadOnly = true;
            dgvFrontDeskSchedule.RowHeadersVisible = false;
            dgvFrontDeskSchedule.RowHeadersWidth = 51;
            dgvFrontDeskSchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFrontDeskSchedule.Size = new Size(804, 744);
            dgvFrontDeskSchedule.TabIndex = 22;
            // 
            // panelMainContent
            // 
            panelMainContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMainContent.BackColor = Color.Silver;
            panelMainContent.BorderStyle = BorderStyle.FixedSingle;
            panelMainContent.Controls.Add(lblCurrentActivity);
            panelMainContent.Location = new Point(258, 198);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Size = new Size(804, 697);
            panelMainContent.TabIndex = 27;
            // 
            // pnlFrontDeskActivity
            // 
            pnlFrontDeskActivity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlFrontDeskActivity.BorderStyle = BorderStyle.FixedSingle;
            pnlFrontDeskActivity.Controls.Add(panel3);
            pnlFrontDeskActivity.Controls.Add(panel5);
            pnlFrontDeskActivity.Controls.Add(panel6);
            pnlFrontDeskActivity.Controls.Add(panel4);
            pnlFrontDeskActivity.Location = new Point(253, 68);
            pnlFrontDeskActivity.Name = "pnlFrontDeskActivity";
            pnlFrontDeskActivity.Size = new Size(817, 914);
            pnlFrontDeskActivity.TabIndex = 10;
            // 
            // FrontDeskDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1840, 1055);
            Controls.Add(dgvFrontDeskSchedule);
            Controls.Add(panelMainContent);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(pnlFrontDeskActivity);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FrontDeskDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard - Front desk";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFrontDeskSchedule).EndInit();
            panelMainContent.ResumeLayout(false);
            panelMainContent.PerformLayout();
            pnlFrontDeskActivity.ResumeLayout(false);
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
        private Label label1;
        private Label label3;
        private Button btnDashboard;
        private Panel panel5;
        private Label lblAvailableRooms;
        private Label label6;
        private Panel panel3;
        private Label lblCheckInCount;
        private Label lblTotal;
        private Panel panel4;
        private Label lblOccupiedCount;
        private Label label5;
        private Panel panel6;
        private Label lblCheckOutCount;
        private Label lblAvail;
        private Label lblCurrentActivity;
        private DataGridView dgvFrontDeskSchedule;
        private Panel panelMainContent;
        private Panel pnlFrontDeskActivity;
    }
}