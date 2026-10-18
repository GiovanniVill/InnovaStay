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
            lblTotal = new Label();
            lblAvail = new Label();
            btnRM = new Button();
            btnUM = new Button();
            panel1 = new Panel();
            btnDashboard = new Button();
            btnLogOut = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            lblTotalRooms = new Label();
            panel3 = new Panel();
            lblAvailable = new Label();
            panel4 = new Panel();
            lblOccupied = new Label();
            label5 = new Label();
            panel5 = new Panel();
            lblReservations = new Label();
            label6 = new Label();
            panelMainContent = new Panel();
            dgvCurrentActivity = new DataGridView();
            lblCurrentActivity = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panelMainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCurrentActivity).BeginInit();
            SuspendLayout();
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.FromArgb(100, 116, 139);
            lblTotal.Location = new Point(15, 15);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(71, 13);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Total Rooms";
            // 
            // lblAvail
            // 
            lblAvail.AutoSize = true;
            lblAvail.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblAvail.ForeColor = Color.FromArgb(100, 116, 139);
            lblAvail.Location = new Point(13, 15);
            lblAvail.Name = "lblAvail";
            lblAvail.Size = new Size(54, 13);
            lblAvail.TabIndex = 2;
            lblAvail.Text = "Available";
            // 
            // btnRM
            // 
            btnRM.BackColor = Color.FromArgb(30, 41, 59);
            btnRM.Cursor = Cursors.Hand;
            btnRM.FlatStyle = FlatStyle.Flat;
            btnRM.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRM.ForeColor = Color.White;
            btnRM.Location = new Point(20, 110);
            btnRM.Name = "btnRM";
            btnRM.Padding = new Padding(12, 0, 0, 0);
            btnRM.Size = new Size(180, 45);
            btnRM.TabIndex = 6;
            btnRM.Text = "Room Maintenance";
            btnRM.TextAlign = ContentAlignment.MiddleLeft;
            btnRM.UseVisualStyleBackColor = false;
            btnRM.Click += btnRM_Click;
            // 
            // btnUM
            // 
            btnUM.BackColor = Color.FromArgb(30, 41, 59);
            btnUM.Cursor = Cursors.Hand;
            btnUM.FlatStyle = FlatStyle.Flat;
            btnUM.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUM.ForeColor = Color.White;
            btnUM.Location = new Point(20, 189);
            btnUM.Name = "btnUM";
            btnUM.Padding = new Padding(12, 0, 0, 0);
            btnUM.Size = new Size(180, 45);
            btnUM.TabIndex = 7;
            btnUM.Text = "User Management";
            btnUM.TextAlign = ContentAlignment.MiddleLeft;
            btnUM.UseVisualStyleBackColor = false;
            btnUM.Click += btnUM_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 23, 42);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnUM);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnRM);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 751);
            panel1.TabIndex = 8;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(30, 41, 59);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(20, 271);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(12, 0, 0, 0);
            btnDashboard.Size = new Size(180, 45);
            btnDashboard.TabIndex = 9;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnLogOut
            // 
            btnLogOut.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogOut.BackColor = Color.FromArgb(239, 68, 68);
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(20, 700);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(180, 40);
            btnLogOut.TabIndex = 8;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(148, 163, 184);
            label2.Location = new Point(20, 52);
            label2.Name = "label2";
            label2.Size = new Size(94, 13);
            label2.TabIndex = 1;
            label2.Text = "ADMIN CONSOLE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 24);
            label1.Name = "label1";
            label1.Size = new Size(132, 25);
            label1.TabIndex = 0;
            label1.Text = "INNOVASTAY";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(30, 41, 59);
            label3.Location = new Point(250, 25);
            label3.Name = "label3";
            label3.Size = new Size(252, 32);
            label3.TabIndex = 9;
            label3.Text = "Dashboard Overview";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(100, 116, 139);
            label4.Location = new Point(250, 60);
            label4.Name = "label4";
            label4.Size = new Size(281, 15);
            label4.TabIndex = 10;
            label4.Text = "Live room status and property management metrics";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblTotalRooms);
            panel2.Controls.Add(lblTotal);
            panel2.Location = new Point(250, 110);
            panel2.Name = "panel2";
            panel2.Size = new Size(150, 90);
            panel2.TabIndex = 11;
            // 
            // lblTotalRooms
            // 
            lblTotalRooms.AutoSize = true;
            lblTotalRooms.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalRooms.ForeColor = Color.FromArgb(30, 41, 59);
            lblTotalRooms.Location = new Point(15, 38);
            lblTotalRooms.Name = "lblTotalRooms";
            lblTotalRooms.Size = new Size(33, 37);
            lblTotalRooms.TabIndex = 0;
            lblTotalRooms.Text = "0";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lblAvailable);
            panel3.Controls.Add(lblAvail);
            panel3.Location = new Point(419, 110);
            panel3.Name = "panel3";
            panel3.Size = new Size(150, 90);
            panel3.TabIndex = 12;
            // 
            // lblAvailable
            // 
            lblAvailable.AutoSize = true;
            lblAvailable.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvailable.ForeColor = Color.FromArgb(30, 41, 59);
            lblAvailable.Location = new Point(13, 38);
            lblAvailable.Name = "lblAvailable";
            lblAvailable.Size = new Size(33, 37);
            lblAvailable.TabIndex = 2;
            lblAvailable.Text = "0";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(lblOccupied);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(593, 110);
            panel4.Name = "panel4";
            panel4.Size = new Size(150, 90);
            panel4.TabIndex = 13;
            // 
            // lblOccupied
            // 
            lblOccupied.AutoSize = true;
            lblOccupied.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOccupied.ForeColor = Color.FromArgb(30, 41, 59);
            lblOccupied.Location = new Point(14, 38);
            lblOccupied.Name = "lblOccupied";
            lblOccupied.Size = new Size(33, 37);
            lblOccupied.TabIndex = 2;
            lblOccupied.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(100, 116, 139);
            label5.Location = new Point(14, 17);
            label5.Name = "label5";
            label5.Size = new Size(54, 13);
            label5.TabIndex = 3;
            label5.Text = "Occupied";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(lblReservations);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(772, 110);
            panel5.Name = "panel5";
            panel5.Size = new Size(150, 90);
            panel5.TabIndex = 14;
            // 
            // lblReservations
            // 
            lblReservations.AutoSize = true;
            lblReservations.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReservations.ForeColor = Color.FromArgb(30, 41, 59);
            lblReservations.Location = new Point(18, 38);
            lblReservations.Name = "lblReservations";
            lblReservations.Size = new Size(33, 37);
            lblReservations.TabIndex = 4;
            lblReservations.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(100, 116, 139);
            label6.Location = new Point(18, 17);
            label6.Name = "label6";
            label6.Size = new Size(72, 13);
            label6.TabIndex = 4;
            label6.Text = "Reservations";
            // 
            // panelMainContent
            // 
            panelMainContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMainContent.BackColor = Color.White;
            panelMainContent.BorderStyle = BorderStyle.FixedSingle;
            panelMainContent.Controls.Add(dgvCurrentActivity);
            panelMainContent.Controls.Add(lblCurrentActivity);
            panelMainContent.Location = new Point(250, 241);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Size = new Size(875, 477);
            panelMainContent.TabIndex = 15;
            // 
            // dgvCurrentActivity
            // 
            dgvCurrentActivity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCurrentActivity.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCurrentActivity.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCurrentActivity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCurrentActivity.ColumnHeadersHeight = 35;
            dgvCurrentActivity.EnableHeadersVisualStyles = false;
            dgvCurrentActivity.Location = new Point(20, 50);
            dgvCurrentActivity.Name = "dgvCurrentActivity";
            dgvCurrentActivity.RowHeadersVisible = false;
            dgvCurrentActivity.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCurrentActivity.Size = new Size(812, 376);
            dgvCurrentActivity.TabIndex = 1;
            // 
            // lblCurrentActivity
            // 
            lblCurrentActivity.AutoSize = true;
            lblCurrentActivity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentActivity.ForeColor = Color.FromArgb(30, 41, 59);
            lblCurrentActivity.Location = new Point(20, 15);
            lblCurrentActivity.Name = "lblCurrentActivity";
            lblCurrentActivity.Size = new Size(130, 21);
            lblCurrentActivity.TabIndex = 0;
            lblCurrentActivity.Text = "Current Activity";
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1150, 751);
            Controls.Add(panelMainContent);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "AdminDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InnovaStay - Admin Dashboard";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panelMainContent.ResumeLayout(false);
            panelMainContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCurrentActivity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Label lblTotal;
        private Label lblAvail;
        private Button btnRM;
        private Button btnUM;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button btnLogOut;
        private Label label3;
        private Label label4;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label lblTotalRooms;
        private Label lblAvailable;
        private Label lblOccupied;
        private Label label5;
        private Label lblReservations;
        private Label label6;
        private Panel panelMainContent;
        private Button btnDashboard;
        private DataGridView dgvCurrentActivity;
        private Label lblCurrentActivity;
    }
}