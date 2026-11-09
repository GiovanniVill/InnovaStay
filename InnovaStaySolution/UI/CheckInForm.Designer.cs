namespace UI
{
    partial class CheckInForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            lblTitle = new System.Windows.Forms.Label();
            dgvCheckIn = new System.Windows.Forms.DataGridView();
            colResId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colGuest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colRoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnConfirmCheckIn = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvCheckIn).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(20, 26, 40);
            lblTitle.Location = new System.Drawing.Point(25, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(248, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Process Guest Check-In";
            // 
            // dgvCheckIn
            // 
            dgvCheckIn.AllowUserToAddRows = false;
            dgvCheckIn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvCheckIn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvCheckIn.BackgroundColor = System.Drawing.Color.White;
            dgvCheckIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(20, 26, 40);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvCheckIn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCheckIn.ColumnHeadersHeight = 36;
            dgvCheckIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colResId, colGuest, colRoom, colType, colCheckIn, colCheckOut, colTotal, colStatus, colRoomId });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvCheckIn.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCheckIn.EnableHeadersVisualStyles = false;
            dgvCheckIn.Location = new System.Drawing.Point(25, 70);
            dgvCheckIn.MultiSelect = false;
            dgvCheckIn.Name = "dgvCheckIn";
            dgvCheckIn.ReadOnly = true;
            dgvCheckIn.RowHeadersVisible = false;
            dgvCheckIn.RowTemplate.Height = 32;
            dgvCheckIn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCheckIn.Size = new System.Drawing.Size(1035, 480);
            dgvCheckIn.TabIndex = 1;
            // 
            // colResId
            // 
            colResId.FillWeight = 50F;
            colResId.HeaderText = "Res #";
            colResId.Name = "colResId";
            colResId.ReadOnly = true;
            // 
            // colGuest
            // 
            colGuest.FillWeight = 130F;
            colGuest.HeaderText = "Guest Name";
            colGuest.Name = "colGuest";
            colGuest.ReadOnly = true;
            // 
            // colRoom
            // 
            colRoom.FillWeight = 60F;
            colRoom.HeaderText = "Room #";
            colRoom.Name = "colRoom";
            colRoom.ReadOnly = true;
            // 
            // colType
            // 
            colType.FillWeight = 80F;
            colType.HeaderText = "Room Type";
            colType.Name = "colType";
            colType.ReadOnly = true;
            // 
            // colCheckIn
            // 
            colCheckIn.FillWeight = 85F;
            colCheckIn.HeaderText = "Check-In Date";
            colCheckIn.Name = "colCheckIn";
            colCheckIn.ReadOnly = true;
            // 
            // colCheckOut
            // 
            colCheckOut.FillWeight = 85F;
            colCheckOut.HeaderText = "Check-Out Date";
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
            // colRoomId
            // 
            colRoomId.HeaderText = "RoomId";
            colRoomId.Name = "colRoomId";
            colRoomId.ReadOnly = true;
            colRoomId.Visible = false;
            // 
            // btnConfirmCheckIn
            // 
            btnConfirmCheckIn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnConfirmCheckIn.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            btnConfirmCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            btnConfirmCheckIn.FlatAppearance.BorderSize = 0;
            btnConfirmCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConfirmCheckIn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnConfirmCheckIn.ForeColor = System.Drawing.Color.White;
            btnConfirmCheckIn.Location = new System.Drawing.Point(780, 565);
            btnConfirmCheckIn.Name = "btnConfirmCheckIn";
            btnConfirmCheckIn.Size = new System.Drawing.Size(160, 36);
            btnConfirmCheckIn.TabIndex = 2;
            btnConfirmCheckIn.Text = "Confirm Check-In";
            btnConfirmCheckIn.UseVisualStyleBackColor = false;
            btnConfirmCheckIn.Click += btnConfirmCheckIn_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnClose.BackColor = System.Drawing.Color.White;
            btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnClose.ForeColor = System.Drawing.Color.FromArgb(20, 26, 40);
            btnClose.Location = new System.Drawing.Point(950, 565);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(110, 36);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // CheckInForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1100, 650);
            Controls.Add(btnClose);
            Controls.Add(btnConfirmCheckIn);
            Controls.Add(dgvCheckIn);
            Controls.Add(lblTitle);
            Name = "CheckInForm";
            Text = "Process Check-In";
            Load += CheckInForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCheckIn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGuest;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomId;
        private System.Windows.Forms.Button btnConfirmCheckIn;
        private System.Windows.Forms.Button btnClose;
    }
}