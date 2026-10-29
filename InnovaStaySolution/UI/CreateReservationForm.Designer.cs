namespace UI
{
    partial class CreateReservationForm
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
            dtpCheckIn = new DateTimePicker();
            dtpCheckOut = new DateTimePicker();
            cmbGuest = new ComboBox();
            cmbRoom = new ComboBox();
            btnConfirmReservation = new Button();
            btnCancel = new Button();
            lblTotalAmount = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 203);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Calculated Total:";
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.Location = new Point(128, 111);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(200, 23);
            dtpCheckIn.TabIndex = 3;
            dtpCheckIn.ValueChanged += dtpCheckIn_ValueChanged;
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.Location = new Point(128, 159);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.Size = new Size(200, 23);
            dtpCheckOut.TabIndex = 4;
            dtpCheckOut.ValueChanged += dtpCheckOut_ValueChanged;
            // 
            // cmbGuest
            // 
            cmbGuest.FormattingEnabled = true;
            cmbGuest.Location = new Point(128, 20);
            cmbGuest.Name = "cmbGuest";
            cmbGuest.Size = new Size(121, 23);
            cmbGuest.TabIndex = 5;
            // 
            // cmbRoom
            // 
            cmbRoom.FormattingEnabled = true;
            cmbRoom.Location = new Point(128, 71);
            cmbRoom.Name = "cmbRoom";
            cmbRoom.Size = new Size(121, 23);
            cmbRoom.TabIndex = 6;
            cmbRoom.SelectedIndexChanged += cmbRoom_SelectedIndexChanged;
            // 
            // btnConfirmReservation
            // 
            btnConfirmReservation.Location = new Point(128, 235);
            btnConfirmReservation.Name = "btnConfirmReservation";
            btnConfirmReservation.Size = new Size(75, 23);
            btnConfirmReservation.TabIndex = 7;
            btnConfirmReservation.Text = "Reserve Room";
            btnConfirmReservation.UseVisualStyleBackColor = true;
            btnConfirmReservation.Click += btnConfirmReservation_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(29, 235);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Location = new Point(140, 203);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(38, 15);
            lblTotalAmount.TabIndex = 9;
            lblTotalAmount.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 28);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 10;
            label3.Text = "Guest Selection:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 79);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 11;
            label4.Text = "Room Selection:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 117);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 12;
            label5.Text = "Check-In Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 165);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 13;
            label6.Text = "Check-Out Date:";
            // 
            // CreateReservationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblTotalAmount);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirmReservation);
            Controls.Add(cmbRoom);
            Controls.Add(cmbGuest);
            Controls.Add(dtpCheckOut);
            Controls.Add(dtpCheckIn);
            Controls.Add(label1);
            Name = "CreateReservationForm";
            Text = "Front Desk - Reservation";
            Load += CreateReservationForm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpCheckIn;
        private DateTimePicker dtpCheckOut;
        private ComboBox cmbGuest;
        private ComboBox cmbRoom;
        private Button btnConfirmReservation;
        private Button btnCancel;
        private Label lblTotalAmount;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}