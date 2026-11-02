namespace UI
{
    partial class RoomInfo
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
            lblRoomStatus = new Label();
            lblRoomRate = new Label();
            lblRoomType = new Label();
            lblRoomNumber = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            lblRoomNo = new Label();
            lblType = new Label();
            lblRate = new Label();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // lblRoomStatus
            // 
            lblRoomStatus.AutoSize = true;
            lblRoomStatus.Location = new Point(122, 291);
            lblRoomStatus.Name = "lblRoomStatus";
            lblRoomStatus.Size = new Size(19, 15);
            lblRoomStatus.TabIndex = 15;
            lblRoomStatus.Text = "ㅤ";
            // 
            // lblRoomRate
            // 
            lblRoomRate.AutoSize = true;
            lblRoomRate.Location = new Point(109, 217);
            lblRoomRate.Name = "lblRoomRate";
            lblRoomRate.Size = new Size(19, 15);
            lblRoomRate.TabIndex = 14;
            lblRoomRate.Text = "ㅤ";
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Location = new Point(112, 143);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(19, 15);
            lblRoomType.TabIndex = 13;
            lblRoomType.Text = "ㅤ";
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.Location = new Point(134, 71);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new Size(19, 15);
            lblRoomNumber.TabIndex = 12;
            lblRoomNumber.Text = "ㅤ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 283);
            label4.Name = "label4";
            label4.Size = new Size(104, 23);
            label4.TabIndex = 11;
            label4.Text = "Room Status:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 211);
            label3.Name = "label3";
            label3.Size = new Size(91, 23);
            label3.TabIndex = 10;
            label3.Text = "Room Rate:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 135);
            label2.Name = "label2";
            label2.Size = new Size(94, 23);
            label2.TabIndex = 9;
            label2.Text = "Room Type:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 65);
            label1.Name = "label1";
            label1.Size = new Size(117, 23);
            label1.TabIndex = 8;
            label1.Text = "Room Number:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(67, 9);
            label5.Name = "label5";
            label5.Size = new Size(213, 35);
            label5.TabIndex = 16;
            label5.Text = "Room Information";
            // 
            // lblRoomNo
            // 
            lblRoomNo.AutoSize = true;
            lblRoomNo.BackColor = Color.Transparent;
            lblRoomNo.Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoomNo.Location = new Point(163, 65);
            lblRoomNo.Name = "lblRoomNo";
            lblRoomNo.Size = new Size(34, 23);
            lblRoomNo.TabIndex = 17;
            lblRoomNo.Text = "----";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblType.Location = new Point(163, 135);
            lblType.Name = "lblType";
            lblType.Size = new Size(34, 23);
            lblType.TabIndex = 18;
            lblType.Text = "----";
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRate.Location = new Point(163, 217);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(34, 23);
            lblRate.TabIndex = 19;
            lblRate.Text = "----";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(163, 283);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(34, 23);
            lblStatus.TabIndex = 20;
            lblStatus.Text = "----";
            // 
            // RoomInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 363);
            Controls.Add(lblStatus);
            Controls.Add(lblRate);
            Controls.Add(lblType);
            Controls.Add(lblRoomNo);
            Controls.Add(label5);
            Controls.Add(lblRoomStatus);
            Controls.Add(lblRoomRate);
            Controls.Add(lblRoomType);
            Controls.Add(lblRoomNumber);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RoomInfo";
            Text = "RoomInfo";
            Load += RoomInfo_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label lblRoomNumber;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblRoomStatus;
        private Label lblRoomType;
        private Label lblRoomRate;
        private Label label5;
        private Label lblRoomNo;
        private Label lblType;
        private Label lblRate;
        private Label lblStatus;
    }
}