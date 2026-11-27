namespace UI
{
    partial class Reciept
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            lblIssuedDate = new Label();
            lblBillingAddress = new Label();
            lblIssuedTo = new Label();
            label5 = new Label();
            panel2 = new Panel();
            label23 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblHotelName = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label13 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label14 = new Label();
            lblPeriod = new Label();
            lblRoomType = new Label();
            lblNumberOfRooms = new Label();
            lblNumberOfExtraBeds = new Label();
            lblTotalRoomCharges = new Label();
            lblTotalExtraBedCharges = new Label();
            lblGrandTotal = new Label();
            lblTotalChargeToCreditCard = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(109, 9);
            label1.Name = "label1";
            label1.Size = new Size(293, 53);
            label1.TabIndex = 0;
            label1.Text = "HOTEL INVOICE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 7);
            label2.Name = "label2";
            label2.Size = new Size(96, 23);
            label2.TabIndex = 1;
            label2.Text = "ISSUED TO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 30);
            label3.Name = "label3";
            label3.Size = new Size(151, 23);
            label3.TabIndex = 2;
            label3.Text = "BILLING ADDRESS:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 53);
            label4.Name = "label4";
            label4.Size = new Size(115, 23);
            label4.TabIndex = 3;
            label4.Text = "ISSUED DATE:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblIssuedDate);
            panel1.Controls.Add(lblBillingAddress);
            panel1.Controls.Add(lblIssuedTo);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(26, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(469, 88);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // lblIssuedDate
            // 
            lblIssuedDate.AutoSize = true;
            lblIssuedDate.BackColor = Color.Transparent;
            lblIssuedDate.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIssuedDate.Location = new Point(124, 53);
            lblIssuedDate.Name = "lblIssuedDate";
            lblIssuedDate.Size = new Size(25, 21);
            lblIssuedDate.TabIndex = 11;
            lblIssuedDate.Text = "ㅤ";
            // 
            // lblBillingAddress
            // 
            lblBillingAddress.AutoSize = true;
            lblBillingAddress.BackColor = Color.Transparent;
            lblBillingAddress.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBillingAddress.Location = new Point(160, 29);
            lblBillingAddress.Name = "lblBillingAddress";
            lblBillingAddress.Size = new Size(25, 21);
            lblBillingAddress.TabIndex = 10;
            lblBillingAddress.Text = "ㅤ";
            // 
            // lblIssuedTo
            // 
            lblIssuedTo.AutoSize = true;
            lblIssuedTo.BackColor = Color.Transparent;
            lblIssuedTo.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIssuedTo.Location = new Point(105, 9);
            lblIssuedTo.Name = "lblIssuedTo";
            lblIssuedTo.Size = new Size(25, 21);
            lblIssuedTo.TabIndex = 9;
            lblIssuedTo.Text = "ㅤ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 3);
            label5.Name = "label5";
            label5.Size = new Size(92, 23);
            label5.TabIndex = 4;
            label5.Text = "Description";
            label5.Click += label5_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label23);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(26, 195);
            panel2.Name = "panel2";
            panel2.Size = new Size(469, 31);
            panel2.TabIndex = 5;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.Location = new Point(380, 3);
            label23.Name = "label23";
            label23.Size = new Size(66, 23);
            label23.TabIndex = 5;
            label23.Text = "Amount";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.7583542F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.2416458F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 84F));
            tableLayoutPanel1.Controls.Add(lblHotelName, 1, 0);
            tableLayoutPanel1.Controls.Add(label6, 0, 0);
            tableLayoutPanel1.Controls.Add(label7, 0, 1);
            tableLayoutPanel1.Controls.Add(label8, 0, 2);
            tableLayoutPanel1.Controls.Add(label9, 0, 3);
            tableLayoutPanel1.Controls.Add(label13, 1, 8);
            tableLayoutPanel1.Controls.Add(label10, 0, 4);
            tableLayoutPanel1.Controls.Add(label11, 0, 5);
            tableLayoutPanel1.Controls.Add(label12, 0, 6);
            tableLayoutPanel1.Controls.Add(label14, 1, 7);
            tableLayoutPanel1.Controls.Add(lblPeriod, 1, 1);
            tableLayoutPanel1.Controls.Add(lblRoomType, 1, 2);
            tableLayoutPanel1.Controls.Add(lblNumberOfRooms, 1, 3);
            tableLayoutPanel1.Controls.Add(lblNumberOfExtraBeds, 1, 4);
            tableLayoutPanel1.Controls.Add(lblTotalRoomCharges, 2, 5);
            tableLayoutPanel1.Controls.Add(lblTotalExtraBedCharges, 2, 6);
            tableLayoutPanel1.Controls.Add(lblGrandTotal, 2, 7);
            tableLayoutPanel1.Controls.Add(lblTotalChargeToCreditCard, 2, 8);
            tableLayoutPanel1.Location = new Point(26, 232);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.6923065F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52.3076935F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(469, 301);
            tableLayoutPanel1.TabIndex = 13;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // lblHotelName
            // 
            lblHotelName.AutoSize = true;
            lblHotelName.BackColor = Color.Transparent;
            lblHotelName.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHotelName.Location = new Point(179, 2);
            lblHotelName.Name = "lblHotelName";
            lblHotelName.Size = new Size(25, 21);
            lblHotelName.TabIndex = 9;
            lblHotelName.Text = "ㅤ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(5, 2);
            label6.Name = "label6";
            label6.Size = new Size(83, 21);
            label6.TabIndex = 0;
            label6.Text = "Hotel Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(5, 31);
            label7.Name = "label7";
            label7.Size = new Size(50, 21);
            label7.TabIndex = 1;
            label7.Text = "Period";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(5, 62);
            label8.Name = "label8";
            label8.Size = new Size(80, 21);
            label8.TabIndex = 2;
            label8.Text = "Room Type";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(5, 95);
            label9.Name = "label9";
            label9.Size = new Size(92, 21);
            label9.TabIndex = 3;
            label9.Text = "No. of Rooms";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(179, 258);
            label13.Name = "label13";
            label13.Size = new Size(172, 41);
            label13.TabIndex = 7;
            label13.Text = "Total Charge To Credit Card";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(5, 127);
            label10.Name = "label10";
            label10.Size = new Size(119, 21);
            label10.TabIndex = 4;
            label10.Text = "No. of Extra Beds";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(5, 159);
            label11.Name = "label11";
            label11.Size = new Size(134, 21);
            label11.TabIndex = 5;
            label11.Text = "Total Room Charges";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(5, 191);
            label12.Name = "label12";
            label12.Size = new Size(161, 21);
            label12.TabIndex = 6;
            label12.Text = "Total Extra Bed Charges";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(179, 224);
            label14.Name = "label14";
            label14.Size = new Size(116, 23);
            label14.TabIndex = 8;
            label14.Text = "GRAND TOTAL";
            // 
            // lblPeriod
            // 
            lblPeriod.AutoSize = true;
            lblPeriod.BackColor = Color.Transparent;
            lblPeriod.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPeriod.Location = new Point(179, 31);
            lblPeriod.Name = "lblPeriod";
            lblPeriod.Size = new Size(25, 21);
            lblPeriod.TabIndex = 10;
            lblPeriod.Text = "ㅤ";
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.BackColor = Color.Transparent;
            lblRoomType.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoomType.Location = new Point(179, 62);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(25, 21);
            lblRoomType.TabIndex = 11;
            lblRoomType.Text = "ㅤ";
            // 
            // lblNumberOfRooms
            // 
            lblNumberOfRooms.AutoSize = true;
            lblNumberOfRooms.BackColor = Color.Transparent;
            lblNumberOfRooms.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumberOfRooms.Location = new Point(179, 95);
            lblNumberOfRooms.Name = "lblNumberOfRooms";
            lblNumberOfRooms.Size = new Size(25, 21);
            lblNumberOfRooms.TabIndex = 12;
            lblNumberOfRooms.Text = "ㅤ";
            // 
            // lblNumberOfExtraBeds
            // 
            lblNumberOfExtraBeds.AutoSize = true;
            lblNumberOfExtraBeds.BackColor = Color.Transparent;
            lblNumberOfExtraBeds.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumberOfExtraBeds.Location = new Point(179, 127);
            lblNumberOfExtraBeds.Name = "lblNumberOfExtraBeds";
            lblNumberOfExtraBeds.Size = new Size(25, 21);
            lblNumberOfExtraBeds.TabIndex = 13;
            lblNumberOfExtraBeds.Text = "ㅤ";
            // 
            // lblTotalRoomCharges
            // 
            lblTotalRoomCharges.AutoSize = true;
            lblTotalRoomCharges.BackColor = Color.Transparent;
            lblTotalRoomCharges.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalRoomCharges.Location = new Point(385, 159);
            lblTotalRoomCharges.Name = "lblTotalRoomCharges";
            lblTotalRoomCharges.Size = new Size(25, 21);
            lblTotalRoomCharges.TabIndex = 14;
            lblTotalRoomCharges.Text = "ㅤ";
            // 
            // lblTotalExtraBedCharges
            // 
            lblTotalExtraBedCharges.AutoSize = true;
            lblTotalExtraBedCharges.BackColor = Color.Transparent;
            lblTotalExtraBedCharges.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalExtraBedCharges.Location = new Point(385, 191);
            lblTotalExtraBedCharges.Name = "lblTotalExtraBedCharges";
            lblTotalExtraBedCharges.Size = new Size(25, 21);
            lblTotalExtraBedCharges.TabIndex = 15;
            lblTotalExtraBedCharges.Text = "ㅤ";
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.BackColor = Color.Transparent;
            lblGrandTotal.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrandTotal.Location = new Point(385, 224);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(25, 21);
            lblGrandTotal.TabIndex = 16;
            lblGrandTotal.Text = "ㅤ";
            // 
            // lblTotalChargeToCreditCard
            // 
            lblTotalChargeToCreditCard.AutoSize = true;
            lblTotalChargeToCreditCard.BackColor = Color.Transparent;
            lblTotalChargeToCreditCard.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalChargeToCreditCard.Location = new Point(385, 258);
            lblTotalChargeToCreditCard.Name = "lblTotalChargeToCreditCard";
            lblTotalChargeToCreditCard.Size = new Size(25, 21);
            lblTotalChargeToCreditCard.TabIndex = 17;
            lblTotalChargeToCreditCard.Text = "ㅤ";
            // 
            // Reciept
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 636);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Reciept";
            Text = "Reciept";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Label label5;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label13;
        private Label label11;
        private Label label12;
        private Label label14;
        private Label lblIssuedDate;
        private Label lblBillingAddress;
        private Label lblIssuedTo;
        private Label label23;
        private Label lblHotelName;
        private Label lblPeriod;
        private Label lblRoomType;
        private Label lblNumberOfRooms;
        private Label lblNumberOfExtraBeds;
        private Label lblTotalRoomCharges;
        private Label lblTotalExtraBedCharges;
        private Label lblGrandTotal;
        private Label lblTotalChargeToCreditCard;
    }
}