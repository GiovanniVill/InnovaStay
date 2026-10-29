namespace UI
{
    partial class AdminDashboardForm
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            btnRM = new Button();
            btnUM = new Button();
            panel1 = new Panel();
            btnLogOut = new Button();
            btnDashboard = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            pnlDashboard = new Panel();
            dgvCurrentActivity = new DataGridView();
            panelMainContent = new Panel();
            lblCurrentActivity = new Label();
            panel5 = new Panel();
            lblReservations = new Label();
            label6 = new Label();
            panel3 = new Panel();
            lblTotalRooms = new Label();
            lblTotal = new Label();
            panel4 = new Panel();
            lblOccupied = new Label();
            label5 = new Label();
            panel6 = new Panel();
            lblAvailable = new Label();
            lblAvail = new Label();
            pnlUserManagement = new Panel();
            panel1.SuspendLayout();
            pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCurrentActivity).BeginInit();
            panelMainContent.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // btnRM
            // 
            btnRM.BackColor = Color.DarkKhaki;
            btnRM.Cursor = Cursors.Hand;
            btnRM.FlatStyle = FlatStyle.Flat;
            btnRM.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRM.ForeColor = Color.Beige;
            btnRM.Location = new Point(20, 206);
            btnRM.Name = "btnRM";
            btnRM.Padding = new Padding(12, 0, 0, 0);
            btnRM.Size = new Size(200, 56);
            btnRM.TabIndex = 6;
            btnRM.Text = "Room Maintenance";
            btnRM.TextAlign = ContentAlignment.MiddleLeft;
            btnRM.UseVisualStyleBackColor = false;
            btnRM.Click += btnRM_Click;
            // 
            // btnUM
            // 
            btnUM.BackColor = Color.DarkKhaki;
            btnUM.Cursor = Cursors.Hand;
            btnUM.FlatStyle = FlatStyle.Flat;
            btnUM.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUM.ForeColor = Color.Beige;
            btnUM.Location = new Point(20, 282);
            btnUM.Name = "btnUM";
            btnUM.Padding = new Padding(12, 0, 0, 0);
            btnUM.Size = new Size(200, 56);
            btnUM.TabIndex = 7;
            btnUM.Text = "User Management";
            btnUM.TextAlign = ContentAlignment.MiddleLeft;
            btnUM.UseVisualStyleBackColor = false;
            btnUM.Click += btnUM_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnUM);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnRM);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 998);
            panel1.TabIndex = 8;
            // 
            // btnLogOut
            // 
            btnLogOut.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogOut.BackColor = Color.FromArgb(239, 68, 68);
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(20, 885);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(200, 40);
            btnLogOut.TabIndex = 8;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.DarkKhaki;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.Beige;
            btnDashboard.Location = new Point(20, 131);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(12, 0, 0, 0);
            btnDashboard.Size = new Size(200, 56);
            btnDashboard.TabIndex = 9;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(48, 60);
            label2.Name = "label2";
            label2.Size = new Size(124, 19);
            label2.TabIndex = 1;
            label2.Text = "ADMIN CONSOLE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Olive;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(208, 41);
            label1.TabIndex = 0;
            label1.Text = "INNOVASTAY";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Olive;
            label3.Location = new Point(250, 19);
            label3.Name = "label3";
            label3.Size = new Size(207, 41);
            label3.TabIndex = 9;
            label3.Text = "ADMIN USER";
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(dgvCurrentActivity);
            pnlDashboard.Controls.Add(panelMainContent);
            pnlDashboard.Controls.Add(panel5);
            pnlDashboard.Controls.Add(panel3);
            pnlDashboard.Controls.Add(panel4);
            pnlDashboard.Controls.Add(panel6);
            pnlDashboard.Location = new Point(247, 63);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(891, 920);
            pnlDashboard.TabIndex = 10;
            // 
            // dgvCurrentActivity
            // 
            dgvCurrentActivity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCurrentActivity.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCurrentActivity.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCurrentActivity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCurrentActivity.ColumnHeadersHeight = 35;
            dgvCurrentActivity.EnableHeadersVisualStyles = false;
            dgvCurrentActivity.Location = new Point(3, 164);
            dgvCurrentActivity.Name = "dgvCurrentActivity";
            dgvCurrentActivity.RowHeadersVisible = false;
            dgvCurrentActivity.RowHeadersWidth = 51;
            dgvCurrentActivity.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCurrentActivity.Size = new Size(879, 744);
            dgvCurrentActivity.TabIndex = 16;
            // 
            // panelMainContent
            // 
            panelMainContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMainContent.BackColor = Color.Silver;
            panelMainContent.BorderStyle = BorderStyle.FixedSingle;
            panelMainContent.Controls.Add(lblCurrentActivity);
            panelMainContent.Location = new Point(3, 132);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Size = new Size(879, 697);
            panelMainContent.TabIndex = 21;
            // 
            // lblCurrentActivity
            // 
            lblCurrentActivity.AutoSize = true;
            lblCurrentActivity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentActivity.ForeColor = Color.Black;
            lblCurrentActivity.Location = new Point(14, 0);
            lblCurrentActivity.Name = "lblCurrentActivity";
            lblCurrentActivity.Size = new Size(163, 28);
            lblCurrentActivity.TabIndex = 0;
            lblCurrentActivity.Text = "Current Activity";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Silver;
            panel5.Controls.Add(lblReservations);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(693, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(189, 97);
            panel5.TabIndex = 20;
            // 
            // lblReservations
            // 
            lblReservations.AutoSize = true;
            lblReservations.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReservations.ForeColor = Color.FromArgb(30, 41, 59);
            lblReservations.Location = new Point(18, 38);
            lblReservations.Name = "lblReservations";
            lblReservations.Size = new Size(40, 46);
            lblReservations.TabIndex = 4;
            lblReservations.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(18, 17);
            label6.Name = "label6";
            label6.Size = new Size(89, 19);
            label6.TabIndex = 4;
            label6.Text = "Reservations";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(lblTotalRooms);
            panel3.Controls.Add(lblTotal);
            panel3.Location = new Point(3, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(189, 97);
            panel3.TabIndex = 17;
            // 
            // lblTotalRooms
            // 
            lblTotalRooms.AutoSize = true;
            lblTotalRooms.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalRooms.ForeColor = Color.FromArgb(30, 41, 59);
            lblTotalRooms.Location = new Point(15, 38);
            lblTotalRooms.Name = "lblTotalRooms";
            lblTotalRooms.Size = new Size(40, 46);
            lblTotalRooms.TabIndex = 0;
            lblTotalRooms.Text = "0";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.Black;
            lblTotal.Location = new Point(15, 15);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(87, 19);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Total Rooms";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Controls.Add(lblOccupied);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(463, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(189, 97);
            panel4.TabIndex = 19;
            // 
            // lblOccupied
            // 
            lblOccupied.AutoSize = true;
            lblOccupied.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOccupied.ForeColor = Color.FromArgb(30, 41, 59);
            lblOccupied.Location = new Point(14, 38);
            lblOccupied.Name = "lblOccupied";
            lblOccupied.Size = new Size(40, 46);
            lblOccupied.TabIndex = 2;
            lblOccupied.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(14, 17);
            label5.Name = "label5";
            label5.Size = new Size(69, 19);
            label5.TabIndex = 3;
            label5.Text = "Occupied";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Silver;
            panel6.Controls.Add(lblAvailable);
            panel6.Controls.Add(lblAvail);
            panel6.Location = new Point(233, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(189, 97);
            panel6.TabIndex = 18;
            // 
            // lblAvailable
            // 
            lblAvailable.AutoSize = true;
            lblAvailable.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvailable.ForeColor = Color.FromArgb(30, 41, 59);
            lblAvailable.Location = new Point(13, 38);
            lblAvailable.Name = "lblAvailable";
            lblAvailable.Size = new Size(40, 46);
            lblAvailable.TabIndex = 2;
            lblAvailable.Text = "0";
            // 
            // lblAvail
            // 
            lblAvail.AutoSize = true;
            lblAvail.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblAvail.ForeColor = Color.Black;
            lblAvail.Location = new Point(13, 15);
            lblAvail.Name = "lblAvail";
            lblAvail.Size = new Size(66, 19);
            lblAvail.TabIndex = 2;
            lblAvail.Text = "Available";
            // 
            // pnlUserManagement
            // 
            pnlUserManagement.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlUserManagement.Location = new Point(247, 63);
            pnlUserManagement.Name = "pnlUserManagement";
            pnlUserManagement.Size = new Size(891, 920);
            pnlUserManagement.TabIndex = 23;
            pnlUserManagement.Visible = false;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1150, 998);
            Controls.Add(pnlUserManagement);
            Controls.Add(pnlDashboard);
            Controls.Add(label3);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.CornflowerBlue;
            Name = "AdminDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InnovaStay - Admin Dashboard";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCurrentActivity).EndInit();
            panelMainContent.ResumeLayout(false);
            panelMainContent.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Button btnRM;
        private Button btnUM;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button btnLogOut;
        private Button btnDashboard;
        private Label label3;
        private Panel pnlDashboardHome;
        private DataGridView dgvCurrentActivity;
        private Panel panelMainContent;
        private Label lblCurrentActivity;
        private Panel panel5;
        private Label lblReservations;
        private Label label6;
        private Panel panel3;
        private Label lblTotalRooms;
        private Label lblTotal;
        private Panel panel4;
        private Label lblOccupied;
        private Label label5;
        private Panel panel6;
        private Label lblAvailable;
        private Label lblAvail;
        private FlowLayoutPanel pnlContentHost;
        private Panel pnlDashboard;
        private Panel pnlUserManagement;
    }
}