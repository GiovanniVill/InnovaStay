namespace UI
{
    partial class DesignRoomMaintenanceForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            txtRoomRate = new TextBox();
            label3 = new Label();
            btnAddRoom = new Button();
            btnEditRoom = new Button();
            btnViewRoom = new Button();
            btnClear = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pnlInputCard = new Panel();
            pnlGridCard = new Panel();
            dgvRooms = new DataGridView();
            label5 = new Label();
            cmbRoomType = new ComboBox();
            label2 = new Label();
            pnlInputCard.SuspendLayout();
            pnlGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            SuspendLayout();
            // 
            // txtRoomRate
            // 
            txtRoomRate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoomRate.Location = new Point(13, 118);
            txtRoomRate.Multiline = true;
            txtRoomRate.Name = "txtRoomRate";
            txtRoomRate.Size = new Size(303, 33);
            txtRoomRate.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(71, 85, 105);
            label3.Location = new Point(13, 90);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 4;
            label3.Text = "Room Rate:";
            // 
            // btnAddRoom
            // 
            btnAddRoom.BackColor = Color.FromArgb(37, 99, 235);
            btnAddRoom.FlatStyle = FlatStyle.Flat;
            btnAddRoom.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddRoom.ForeColor = Color.White;
            btnAddRoom.Location = new Point(12, 283);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(126, 41);
            btnAddRoom.TabIndex = 9;
            btnAddRoom.Text = "Add Room";
            btnAddRoom.UseVisualStyleBackColor = false;
            btnAddRoom.Click += btnAddRoom_Click_1;
            // 
            // btnEditRoom
            // 
            btnEditRoom.BackColor = Color.FromArgb(30, 41, 59);
            btnEditRoom.FlatStyle = FlatStyle.Flat;
            btnEditRoom.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditRoom.ForeColor = Color.White;
            btnEditRoom.Location = new Point(187, 283);
            btnEditRoom.Name = "btnEditRoom";
            btnEditRoom.Size = new Size(128, 41);
            btnEditRoom.TabIndex = 10;
            btnEditRoom.Text = "Edit Room";
            btnEditRoom.UseVisualStyleBackColor = false;
            btnEditRoom.Click += btnEditRoom_Click_1;
            // 
            // btnViewRoom
            // 
            btnViewRoom.BackColor = Color.FromArgb(71, 85, 105);
            btnViewRoom.FlatStyle = FlatStyle.Flat;
            btnViewRoom.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewRoom.ForeColor = Color.White;
            btnViewRoom.Location = new Point(12, 352);
            btnViewRoom.Name = "btnViewRoom";
            btnViewRoom.Size = new Size(126, 41);
            btnViewRoom.TabIndex = 11;
            btnViewRoom.Text = "View Room";
            btnViewRoom.UseVisualStyleBackColor = false;
            btnViewRoom.Click += btnViewRoom_Click_1;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(226, 232, 240);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.FromArgb(51, 65, 85);
            btnClear.Location = new Point(187, 352);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(128, 41);
            btnClear.TabIndex = 12;
            btnClear.Text = "Deactivate Room";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnDeactivateRoom_Click_1;
            // 
            // pnlInputCard
            // 
            pnlInputCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlInputCard.BackColor = Color.White;
            pnlInputCard.BorderStyle = BorderStyle.FixedSingle;
            pnlInputCard.Controls.Add(btnClear);
            pnlInputCard.Controls.Add(cmbRoomType);
            pnlInputCard.Controls.Add(btnViewRoom);
            pnlInputCard.Controls.Add(btnEditRoom);
            pnlInputCard.Controls.Add(label2);
            pnlInputCard.Controls.Add(btnAddRoom);
            pnlInputCard.Controls.Add(label3);
            pnlInputCard.Controls.Add(txtRoomRate);
            pnlInputCard.Location = new Point(15, 15);
            pnlInputCard.Name = "pnlInputCard";
            pnlInputCard.Size = new Size(330, 480);
            pnlInputCard.TabIndex = 14;
            // 
            // pnlGridCard
            // 
            pnlGridCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlGridCard.BackColor = Color.White;
            pnlGridCard.BorderStyle = BorderStyle.FixedSingle;
            pnlGridCard.Controls.Add(dgvRooms);
            pnlGridCard.Controls.Add(label5);
            pnlGridCard.Location = new Point(360, 15);
            pnlGridCard.Name = "pnlGridCard";
            pnlGridCard.Size = new Size(620, 480);
            pnlGridCard.TabIndex = 15;
            // 
            // dgvRooms
            // 
            dgvRooms.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRooms.BackgroundColor = Color.White;
            dgvRooms.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvRooms.ColumnHeadersHeight = 38;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(224, 231, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvRooms.DefaultCellStyle = dataGridViewCellStyle4;
            dgvRooms.EnableHeadersVisualStyles = false;
            dgvRooms.GridColor = Color.FromArgb(241, 245, 249);
            dgvRooms.Location = new Point(15, 50);
            dgvRooms.Name = "dgvRooms";
            dgvRooms.Size = new Size(590, 415);
            dgvRooms.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(15, 23, 42);
            label5.Location = new Point(15, 15);
            label5.Name = "label5";
            label5.Size = new Size(164, 21);
            label5.TabIndex = 0;
            label5.Text = "Room Inventory List";
            // 
            // cmbRoomType
            // 
            cmbRoomType.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Items.AddRange(new object[] { "Single", "Deluxe", "Suite" });
            cmbRoomType.Location = new Point(12, 50);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(303, 25);
            cmbRoomType.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(71, 85, 105);
            label2.Location = new Point(12, 20);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 2;
            label2.Text = "Room Type:";
            // 
            // DesignRoomMaintenanceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1000, 520);
            Controls.Add(pnlGridCard);
            Controls.Add(pnlInputCard);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DesignRoomMaintenanceForm";
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
        private TextBox txtRoomRate;
        private Label label3;
        private Button btnAddRoom;
        private Button btnEditRoom;
        private Button btnViewRoom;
        private Button btnClear;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel pnlInputCard;
        private Panel pnlGridCard;
        private DataGridView dgvRooms;
        private Label label5;
        private ComboBox cmbRoomType;
        private Label label2;
    }
}