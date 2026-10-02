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
            label1 = new Label();
            txtRoomNumber = new TextBox();
            label2 = new Label();
            txtRoomRate = new TextBox();
            label3 = new Label();
            label4 = new Label();
            cmbRoomStatus = new ComboBox();
            btnAddRoom = new Button();
            btnEditRoom = new Button();
            btnViewRoom = new Button();
            btnDeactivateRoom = new Button();
            cmbRoomType = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(126, 6);
            label1.Name = "label1";
            label1.Size = new Size(117, 23);
            label1.TabIndex = 0;
            label1.Text = "Room Number:";
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Location = new Point(5, 32);
            txtRoomNumber.Multiline = true;
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(385, 33);
            txtRoomNumber.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(139, 68);
            label2.Name = "label2";
            label2.Size = new Size(94, 23);
            label2.TabIndex = 2;
            label2.Text = "Room Type:";
            // 
            // txtRoomRate
            // 
            txtRoomRate.Location = new Point(5, 147);
            txtRoomRate.Multiline = true;
            txtRoomRate.Name = "txtRoomRate";
            txtRoomRate.Size = new Size(385, 33);
            txtRoomRate.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(139, 125);
            label3.Name = "label3";
            label3.Size = new Size(91, 23);
            label3.TabIndex = 4;
            label3.Text = "Room Rate:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(134, 182);
            label4.Name = "label4";
            label4.Size = new Size(104, 23);
            label4.TabIndex = 6;
            label4.Text = "Room Status:";
            // 
            // cmbRoomStatus
            // 
            cmbRoomStatus.FormattingEnabled = true;
            cmbRoomStatus.Location = new Point(5, 208);
            cmbRoomStatus.Name = "cmbRoomStatus";
            cmbRoomStatus.Size = new Size(385, 23);
            cmbRoomStatus.TabIndex = 8;
            // 
            // btnAddRoom
            // 
            btnAddRoom.BackColor = Color.Khaki;
            btnAddRoom.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddRoom.Location = new Point(12, 249);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(171, 41);
            btnAddRoom.TabIndex = 9;
            btnAddRoom.Text = "Add Room";
            btnAddRoom.UseVisualStyleBackColor = false;
            // 
            // btnEditRoom
            // 
            btnEditRoom.BackColor = Color.Khaki;
            btnEditRoom.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditRoom.Location = new Point(209, 249);
            btnEditRoom.Name = "btnEditRoom";
            btnEditRoom.Size = new Size(177, 41);
            btnEditRoom.TabIndex = 10;
            btnEditRoom.Text = "Edit Room";
            btnEditRoom.UseVisualStyleBackColor = false;
            // 
            // btnViewRoom
            // 
            btnViewRoom.BackColor = Color.Khaki;
            btnViewRoom.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewRoom.Location = new Point(12, 296);
            btnViewRoom.Name = "btnViewRoom";
            btnViewRoom.Size = new Size(171, 41);
            btnViewRoom.TabIndex = 11;
            btnViewRoom.Text = "View Room";
            btnViewRoom.UseVisualStyleBackColor = false;
            // 
            // btnDeactivateRoom
            // 
            btnDeactivateRoom.BackColor = Color.Khaki;
            btnDeactivateRoom.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeactivateRoom.Location = new Point(209, 296);
            btnDeactivateRoom.Name = "btnDeactivateRoom";
            btnDeactivateRoom.Size = new Size(177, 41);
            btnDeactivateRoom.TabIndex = 12;
            btnDeactivateRoom.Text = "Deactivate Room";
            btnDeactivateRoom.UseVisualStyleBackColor = false;
            // 
            // cmbRoomType
            // 
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Location = new Point(5, 94);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(385, 23);
            cmbRoomType.TabIndex = 14;
            // 
            // DesignRoomMaintenanceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 355);
            Controls.Add(cmbRoomType);
            Controls.Add(btnDeactivateRoom);
            Controls.Add(btnViewRoom);
            Controls.Add(btnEditRoom);
            Controls.Add(btnAddRoom);
            Controls.Add(cmbRoomStatus);
            Controls.Add(label4);
            Controls.Add(txtRoomRate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtRoomNumber);
            Controls.Add(label1);
            Name = "DesignRoomMaintenanceForm";
            Text = "DesignRoomMaintenanceForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtRoomNumber;
        private Label label2;
        private TextBox txtRoomRate;
        private Label label3;
        private Label label4;
        private ComboBox cmbRoomStatus;
        private Button btnAddRoom;
        private Button btnEditRoom;
        private Button btnViewRoom;
        private Button btnDeactivateRoom;
        private ComboBox cmbRoomType;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}