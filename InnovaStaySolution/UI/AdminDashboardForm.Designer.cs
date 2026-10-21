namespace UI
{
    partial class AdminDashboardForm
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            lblSum = new Label();
            lblTotal = new Label();
            lblAvail = new Label();
            lblOccu = new Label();
            lblRes = new Label();
            lblQuick = new Label();
            btnRM = new Button();
            btnUM = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblSum
            // 
            lblSum.AutoSize = true;
            lblSum.Font = new Font("Sitka Heading", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSum.Location = new Point(24, 29);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(202, 49);
            lblSum.TabIndex = 0;
            lblSum.Text = "Summaries:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(24, 89);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(183, 43);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Total Rooms";
            // 
            // lblAvail
            // 
            lblAvail.AutoSize = true;
            lblAvail.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvail.Location = new Point(270, 89);
            lblAvail.Name = "lblAvail";
            lblAvail.Size = new Size(138, 43);
            lblAvail.TabIndex = 2;
            lblAvail.Text = "Available";
            // 
            // lblOccu
            // 
            lblOccu.AutoSize = true;
            lblOccu.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOccu.Location = new Point(485, 89);
            lblOccu.Name = "lblOccu";
            lblOccu.Size = new Size(139, 43);
            lblOccu.TabIndex = 3;
            lblOccu.Text = "Occupied";
            // 
            // lblRes
            // 
            lblRes.AutoSize = true;
            lblRes.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRes.Location = new Point(699, 89);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(189, 43);
            lblRes.TabIndex = 4;
            lblRes.Text = "Reservations";
            // 
            // lblQuick
            // 
            lblQuick.AutoSize = true;
            lblQuick.Font = new Font("Sitka Heading", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuick.Location = new Point(24, 355);
            lblQuick.Name = "lblQuick";
            lblQuick.Size = new Size(208, 49);
            lblQuick.TabIndex = 5;
            lblQuick.Text = "Quick Links:";
            // 
            // btnRM
            // 
            btnRM.BackColor = Color.Khaki;
            btnRM.Font = new Font("Sitka Heading", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRM.Location = new Point(102, 425);
            btnRM.Margin = new Padding(3, 4, 3, 4);
            btnRM.Name = "btnRM";
            btnRM.Size = new Size(351, 84);
            btnRM.TabIndex = 6;
            btnRM.Text = "Room Maintenance";
            btnRM.UseVisualStyleBackColor = false;
            // 
            // btnUM
            // 
            btnUM.BackColor = Color.Khaki;
            btnUM.Font = new Font("Sitka Heading", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUM.Location = new Point(473, 425);
            btnUM.Margin = new Padding(3, 4, 3, 4);
            btnUM.Name = "btnUM";
            btnUM.Size = new Size(350, 84);
            btnUM.TabIndex = 7;
            btnUM.Text = "User Management";
            btnUM.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Khaki;
            btnLogout.Font = new Font("Sitka Heading", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(359, 527);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(208, 60);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(914, 600);
            Controls.Add(btnLogout);
            Controls.Add(btnUM);
            Controls.Add(btnRM);
            Controls.Add(lblQuick);
            Controls.Add(lblRes);
            Controls.Add(lblOccu);
            Controls.Add(lblAvail);
            Controls.Add(lblTotal);
            Controls.Add(lblSum);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminDashboardForm";
            Text = "AdminDashboardForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Label lblSum;
        private Label lblTotal;
        private Label lblAvail;
        private Label lblOccu;
        private Label lblRes;
        private Label lblQuick;
        private Button btnRM;
        private Button btnUM;
        private Button btnLogout;
    }
}