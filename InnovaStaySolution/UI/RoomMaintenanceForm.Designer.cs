namespace UI
{
    partial class RoomMaintenanceForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtRoomRate = new TextBox();
            txtRoomNumber = new MaskedTextBox();
            cmbRoomType = new ComboBox();
            cmbRoomStatus = new ComboBox();
            cmbRate = new ComboBox();
            btnAddRoom = new Button();
            btnEditRoom = new Button();
            btnViewRoom = new Button();
            btnClear = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pnlInputCard = new Panel();
            pnlGridCard = new Panel();
            dgvRooms = new DataGridView();
            pnlInputCard.SuspendLayout();
            pnlGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(71, 85, 105);
            label1.Location = new Point(12, 61);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 0;
            label1.Text = "Room Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(71, 85, 105);
            label2.Location = new Point(12, 110);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 2;
            label2.Text = "Room Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(71, 85, 105);
            label3.Location = new Point(12, 165);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 4;
            label3.Text = "Room Rate:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(71, 85, 105);
            label4.Location = new Point(12, 224);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 6;
            label4.Text = "Room Status:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(15, 23, 42);
            label5.Location = new Point(15, 15);
            label5.Name = "label5";
            label5.Size = new Size(204, 28);
            label5.TabIndex = 0;
            label5.Text = "Room Inventory List";
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Location = new Point(128, 62);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(187, 27);
            txtRoomNumber.TabIndex = 1;
            // 
            // txtRoomRate
            // 
            txtRoomRate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoomRate.Location = new Point(12, 188);
            txtRoomRate.Multiline = true;
            txtRoomRate.Name = "txtRoomRate";
            txtRoomRate.Size = new Size(303, 33);
            txtRoomRate.TabIndex = 5;
            // 
            // cmbRoomType
            // 
            cmbRoomType.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Items.AddRange(new object[] { "Single", "Deluxe", "Suite" });
            cmbRoomType.Location = new Point(12, 133);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(303, 29);
            cmbRoomType.TabIndex = 3;
            // 
            // cmbRoomStatus
            // 
            cmbRoomStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRoomStatus.FormattingEnabled = true;
            cmbRoomStatus.Location = new Point(12, 247);
            cmbRoomStatus.Name = "cmbRoomStatus";
            cmbRoomStatus.Size = new Size(303, 29);
            cmbRoomStatus.TabIndex = 7;
            // 
            // cmbRate
            // 
            cmbRate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRate.FormattingEnabled = true;
            cmbRate.Items.AddRange(new object[] { "P1.500", "P2.500", "P3.500" });
            cmbRate.Location = new Point(12, 119);
            cmbRate.Name = "cmbRate";
            cmbRate.Size = new Size(303, 25);
            cmbRate.TabIndex = 4;
            cmbRate.SelectedIndexChanged += cmbRate_SelectedIndexChanged;
            // 
            // btnAddRoom
            // 
            btnAddRoom.BackColor = Color.DarkKhaki;
            btnAddRoom.FlatStyle = FlatStyle.Flat;
            btnAddRoom.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddRoom.ForeColor = Color.White;
            btnAddRoom.Location = new Point(12, 311);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(126, 41);
            btnAddRoom.TabIndex = 8;
            btnAddRoom.Text = "Add Room";
            btnAddRoom.UseVisualStyleBackColor = false;
            btnAddRoom.Click += btnAddRoom_Click_1;
            // 
            // btnEditRoom
            // 
            btnEditRoom.BackColor = Color.DarkKhaki;
            btnEditRoom.FlatStyle = FlatStyle.Flat;
            btnEditRoom.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditRoom.ForeColor = Color.White;
            btnEditRoom.Location = new Point(187, 311);
            btnEditRoom.Name = "btnEditRoom";
            btnEditRoom.Size = new Size(128, 41);
            btnEditRoom.TabIndex = 9;
            btnEditRoom.Text = "Edit Room";
            btnEditRoom.UseVisualStyleBackColor = false;
            btnEditRoom.Click += btnEditRoom_Click_1;
            // 
            // btnViewRoom
            // 
            btnViewRoom.BackColor = Color.DarkKhaki;
            btnViewRoom.FlatStyle = FlatStyle.Flat;
            btnViewRoom.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewRoom.ForeColor = Color.White;
            btnViewRoom.Location = new Point(12, 382);
            btnViewRoom.Name = "btnViewRoom";
            btnViewRoom.Size = new Size(126, 41);
            btnViewRoom.TabIndex = 10;
            btnViewRoom.Text = "View Room";
            btnViewRoom.UseVisualStyleBackColor = false;
            btnViewRoom.Click += btnViewRoom_Click_1;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(239, 68, 68);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(187, 382);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(128, 41);
            btnClear.TabIndex = 11;
            btnClear.Text = "Deactivate Room";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnDeactivateRoom_Click_1;
            // 
            // pnlInputCard
            // 
            pnlInputCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlInputCard.BackColor = Color.Beige;
            pnlInputCard.BorderStyle = BorderStyle.FixedSingle;
            pnlInputCard.Controls.Add(label1);
            pnlInputCard.Controls.Add(txtRoomNumber);
            pnlInputCard.Controls.Add(label2);
            pnlInputCard.Controls.Add(cmbRoomType);
            pnlInputCard.Controls.Add(label3);
            pnlInputCard.Controls.Add(txtRoomRate);
            pnlInputCard.Controls.Add(label4);
            pnlInputCard.Controls.Add(cmbRoomStatus);
            pnlInputCard.Controls.Add(btnAddRoom);
            pnlInputCard.Controls.Add(btnEditRoom);
            pnlInputCard.Controls.Add(btnViewRoom);
            pnlInputCard.Controls.Add(btnClear);
            pnlInputCard.Location = new Point(15, 15);
            pnlInputCard.Name = "pnlInputCard";
            pnlInputCard.Size = new Size(458, 818);
            pnlInputCard.TabIndex = 12;
            // 
            // pnlGridCard
            // 
            pnlGridCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlGridCard.BackColor = Color.Silver;
            pnlGridCard.BorderStyle = BorderStyle.FixedSingle;
            pnlGridCard.Controls.Add(dgvRooms);
            pnlGridCard.Controls.Add(label5);
            pnlGridCard.Location = new Point(360, 15);
            pnlGridCard.Name = "pnlGridCard";
            pnlGridCard.Size = new Size(756, 818);
            pnlGridCard.TabIndex = 13;
            // 
            // dgvRooms
            // 
            dgvRooms.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRooms.BackgroundColor = Color.White;
            dgvRooms.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRooms.ColumnHeadersHeight = 38;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 231, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRooms.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRooms.EnableHeadersVisualStyles = false;
            dgvRooms.Location = new Point(3, 61);
            dgvRooms.Name = "dgvRooms";
            dgvRooms.RowHeadersWidth = 51;
            dgvRooms.RowTemplate.Height = 30;
            dgvRooms.Size = new Size(748, 592);
            dgvRooms.TabIndex = 1;
            // 
            // RoomMaintenanceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1128, 858);
            Controls.Add(pnlGridCard);
            Controls.Add(pnlInputCard);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            MinimizeBox = false;
            Name = "RoomMaintenanceForm";
            Text = "Admin - Room Maintenance";
            Load += DesignRoomMaintenanceForm_Load_1;
            pnlInputCard.ResumeLayout(false);
            pnlInputCard.PerformLayout();
            pnlGridCard.ResumeLayout(false);
            pnlGridCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtRoomRate;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbRoomStatus;
        private Button btnAddRoom;
        private Button btnEditRoom;
        private Button btnViewRoom;
        private Button btnClear;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel pnlInputCard;
        private Panel pnlGridCard;
        private DataGridView dgvRooms;
        private MaskedTextBox txtRoomNumber;
        private ComboBox cmbRoomType;
        private ComboBox cmbRate;
    }
}