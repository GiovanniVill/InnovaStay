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
            this.lblRoomStatus = new Label();
            this.lblRoomRate = new Label();
            this.lblRoomType = new Label();
            lblRoomNumber = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            this.label5 = new Label();
            SuspendLayout();
            // 
            // lblRoomStatus
            // 
            this.lblRoomStatus.AutoSize = true;
            this.lblRoomStatus.Location = new Point(122, 291);
            this.lblRoomStatus.Name = "lblRoomStatus";
            this.lblRoomStatus.Size = new Size(19, 15);
            this.lblRoomStatus.TabIndex = 15;
            this.lblRoomStatus.Text = "ㅤ";
            // 
            // lblRoomRate
            // 
            this.lblRoomRate.AutoSize = true;
            this.lblRoomRate.Location = new Point(109, 217);
            this.lblRoomRate.Name = "lblRoomRate";
            this.lblRoomRate.Size = new Size(19, 15);
            this.lblRoomRate.TabIndex = 14;
            this.lblRoomRate.Text = "ㅤ";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new Point(112, 143);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new Size(19, 15);
            this.lblRoomType.TabIndex = 13;
            this.lblRoomType.Text = "ㅤ";
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
            this.label5.AutoSize = true;
            this.label5.BackColor = Color.Transparent;
            this.label5.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label5.Location = new Point(67, 9);
            this.label5.Name = "label5";
            this.label5.Size = new Size(213, 35);
            this.label5.TabIndex = 16;
            this.label5.Text = "Room Information";
            // 
            // RoomInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 363);
            Controls.Add(this.label5);
            Controls.Add(this.lblRoomStatus);
            Controls.Add(this.lblRoomRate);
            Controls.Add(this.lblRoomType);
            Controls.Add(lblRoomNumber);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RoomInfo";
            Text = "RoomInfo";
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
    }
}