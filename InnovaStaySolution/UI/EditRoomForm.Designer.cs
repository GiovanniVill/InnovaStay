namespace UI
{
    partial class EditRoomForm
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
            lblTitle = new Label();
            lblRoomIdLabel = new Label();
            lblRoomIdVal = new Label();
            lblRoomNumber = new Label();
            txtRoomNumber = new TextBox();
            lblRoomType = new Label();
            cmbRoomType = new ComboBox();
            lblPrice = new Label();
            txtPrice = new TextBox();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(20, 26, 40);
            lblTitle.Location = new Point(24, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(104, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Edit Room";
            // 
            // lblRoomIdLabel
            // 
            lblRoomIdLabel.AutoSize = true;
            lblRoomIdLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRoomIdLabel.ForeColor = Color.Gray;
            lblRoomIdLabel.Location = new Point(26, 65);
            lblRoomIdLabel.Name = "lblRoomIdLabel";
            lblRoomIdLabel.Size = new Size(59, 15);
            lblRoomIdLabel.TabIndex = 1;
            lblRoomIdLabel.Text = "Room ID:";
            // 
            // lblRoomIdVal
            // 
            lblRoomIdVal.AutoSize = true;
            lblRoomIdVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRoomIdVal.ForeColor = Color.FromArgb(20, 26, 40);
            lblRoomIdVal.Location = new Point(145, 65);
            lblRoomIdVal.Name = "lblRoomIdVal";
            lblRoomIdVal.Size = new Size(12, 15);
            lblRoomIdVal.TabIndex = 2;
            lblRoomIdVal.Text = "-";
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.Font = new Font("Segoe UI", 9F);
            lblRoomNumber.Location = new Point(26, 105);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new Size(89, 15);
            lblRoomNumber.TabIndex = 3;
            lblRoomNumber.Text = "Room Number:";
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Font = new Font("Segoe UI", 9.5F);
            txtRoomNumber.Location = new Point(145, 102);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(215, 24);
            txtRoomNumber.TabIndex = 4;
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Font = new Font("Segoe UI", 9F);
            lblRoomType.Location = new Point(26, 150);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(69, 15);
            lblRoomType.TabIndex = 5;
            lblRoomType.Text = "Room Type:";
            // 
            // cmbRoomType
            // 
            cmbRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoomType.Font = new Font("Segoe UI", 9.5F);
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Items.AddRange(new object[] { "Single", "Deluxe", "Suite" });
            cmbRoomType.Location = new Point(145, 147);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(215, 25);
            cmbRoomType.TabIndex = 6;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 9F);
            lblPrice.Location = new Point(26, 195);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(111, 15);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "Price / Night (PHP):";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 9.5F);
            txtPrice.Location = new Point(145, 192);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(215, 24);
            txtPrice.TabIndex = 8;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F);
            lblStatus.Location = new Point(26, 240);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "Status:";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 9.5F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Available", "Occupied", "Reserved", "Under Maintenance" });
            cmbStatus.Location = new Point(145, 237);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(215, 25);
            cmbStatus.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(46, 125, 50);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(145, 285);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(105, 36);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.5F);
            btnCancel.ForeColor = Color.FromArgb(20, 26, 40);
            btnCancel.Location = new Point(260, 285);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 36);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // EditRoomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(390, 345);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cmbStatus);
            Controls.Add(lblStatus);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(cmbRoomType);
            Controls.Add(lblRoomType);
            Controls.Add(txtRoomNumber);
            Controls.Add(lblRoomNumber);
            Controls.Add(lblRoomIdVal);
            Controls.Add(lblRoomIdLabel);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditRoomForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Room";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRoomIdLabel;
        private System.Windows.Forms.Label lblRoomIdVal;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}