namespace UI
{
    partial class GuestInfo
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
            label5 = new Label();
            label9 = new Label();
            label10 = new Label();
            lblFullName = new Label();
            lblAddress = new Label();
            lblEmail = new Label();
            lblContact = new Label();
            label7 = new Label();
            label2 = new Label();
            lblAge = new Label();
            label3 = new Label();
            lblDOB = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 60);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 0;
            label1.Text = "Full Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 104);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 4;
            label5.Text = "Address:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(14, 145);
            label9.Name = "label9";
            label9.Size = new Size(64, 25);
            label9.TabIndex = 8;
            label9.Text = "Email:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(12, 195);
            label10.Name = "label10";
            label10.Size = new Size(86, 25);
            label10.TabIndex = 9;
            label10.Text = "Contact:";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(226, 60);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(36, 25);
            lblFullName.TabIndex = 10;
            lblFullName.Text = "---";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(226, 104);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(36, 25);
            lblAddress.TabIndex = 11;
            lblAddress.Text = "---";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(226, 145);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 25);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "---";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContact.Location = new Point(226, 195);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(36, 25);
            lblContact.TabIndex = 13;
            lblContact.Text = "---";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(176, 25);
            label7.TabIndex = 14;
            label7.Text = "Guest Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 236);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 15;
            label2.Text = "Age:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(226, 236);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(36, 25);
            lblAge.TabIndex = 16;
            lblAge.Text = "---";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 279);
            label3.Name = "label3";
            label3.Size = new Size(131, 25);
            label3.TabIndex = 17;
            label3.Text = "Date of Birth:";
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDOB.Location = new Point(226, 279);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(36, 25);
            lblDOB.TabIndex = 18;
            lblDOB.Text = "---";
            // 
            // GuestInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 336);
            Controls.Add(lblDOB);
            Controls.Add(label3);
            Controls.Add(lblAge);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(lblContact);
            Controls.Add(lblEmail);
            Controls.Add(lblAddress);
            Controls.Add(lblFullName);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "GuestInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Front Desk - Guest Information";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label5;
        private Label label9;
        private Label label10;
        private Label lblFullName;
        private Label lblAddress;
        private Label lblEmail;
        private Label lblContact;
        private Label label7;
        private Label label2;
        private Label lblAge;
        private Label label3;
        private Label lblDOB;
    }
}