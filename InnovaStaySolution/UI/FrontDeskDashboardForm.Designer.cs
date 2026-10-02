namespace UI
{
    partial class FrontDeskDashboardForm
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
            btnCI = new Button();
            btnCO = new Button();
            btnAvailR = new Button();
            btnActiveR = new Button();
            label1 = new Label();
            btnCheck = new Button();
            btnOut = new Button();
            lblQuickActs = new Label();
            btnSearchAvail = new Button();
            btnCreateRes = new Button();
            btnBP = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnCI
            // 
            btnCI.BackColor = Color.Khaki;
            btnCI.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCI.Location = new Point(37, 68);
            btnCI.Name = "btnCI";
            btnCI.Size = new Size(203, 51);
            btnCI.TabIndex = 0;
            btnCI.Text = "Today's Check-in";
            btnCI.UseVisualStyleBackColor = false;
            // 
            // btnCO
            // 
            btnCO.BackColor = Color.Khaki;
            btnCO.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCO.Location = new Point(37, 135);
            btnCO.Name = "btnCO";
            btnCO.Size = new Size(203, 51);
            btnCO.TabIndex = 1;
            btnCO.Text = "Today's Check-out";
            btnCO.UseVisualStyleBackColor = false;
            // 
            // btnAvailR
            // 
            btnAvailR.BackColor = Color.Khaki;
            btnAvailR.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAvailR.Location = new Point(37, 204);
            btnAvailR.Name = "btnAvailR";
            btnAvailR.Size = new Size(203, 51);
            btnAvailR.TabIndex = 2;
            btnAvailR.Text = "Available Rooms";
            btnAvailR.UseVisualStyleBackColor = false;
            // 
            // btnActiveR
            // 
            btnActiveR.BackColor = Color.Khaki;
            btnActiveR.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActiveR.Location = new Point(37, 271);
            btnActiveR.Name = "btnActiveR";
            btnActiveR.Size = new Size(203, 51);
            btnActiveR.TabIndex = 3;
            btnActiveR.Text = "Active Reservations";
            btnActiveR.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 325);
            label1.Name = "label1";
            label1.Size = new Size(208, 17);
            label1.TabIndex = 4;
            label1.Text = "________________________________________";
            // 
            // btnCheck
            // 
            btnCheck.BackColor = Color.Khaki;
            btnCheck.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheck.Location = new Point(37, 361);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(112, 51);
            btnCheck.TabIndex = 5;
            btnCheck.Text = "Check-In";
            btnCheck.UseVisualStyleBackColor = false;
            // 
            // btnOut
            // 
            btnOut.BackColor = Color.Khaki;
            btnOut.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOut.Location = new Point(155, 361);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(119, 51);
            btnOut.TabIndex = 6;
            btnOut.Text = "Check-Out";
            btnOut.UseVisualStyleBackColor = false;
            // 
            // lblQuickActs
            // 
            lblQuickActs.AutoSize = true;
            lblQuickActs.Font = new Font("Sitka Heading", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuickActs.Location = new Point(357, 56);
            lblQuickActs.Name = "lblQuickActs";
            lblQuickActs.Size = new Size(190, 39);
            lblQuickActs.TabIndex = 7;
            lblQuickActs.Text = "Quick Actions:";
            // 
            // btnSearchAvail
            // 
            btnSearchAvail.BackColor = Color.Khaki;
            btnSearchAvail.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchAvail.Location = new Point(394, 110);
            btnSearchAvail.Name = "btnSearchAvail";
            btnSearchAvail.Size = new Size(203, 51);
            btnSearchAvail.TabIndex = 8;
            btnSearchAvail.Text = "Search Availability";
            btnSearchAvail.UseVisualStyleBackColor = false;
            // 
            // btnCreateRes
            // 
            btnCreateRes.BackColor = Color.Khaki;
            btnCreateRes.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateRes.Location = new Point(394, 183);
            btnCreateRes.Name = "btnCreateRes";
            btnCreateRes.Size = new Size(203, 51);
            btnCreateRes.TabIndex = 9;
            btnCreateRes.Text = "Create Reservation";
            btnCreateRes.UseVisualStyleBackColor = false;
            // 
            // btnBP
            // 
            btnBP.BackColor = Color.Khaki;
            btnBP.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBP.Location = new Point(394, 255);
            btnBP.Name = "btnBP";
            btnBP.Size = new Size(203, 51);
            btnBP.TabIndex = 10;
            btnBP.Text = "Billing/Payment";
            btnBP.UseVisualStyleBackColor = false;
            btnBP.Click += btnBP_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Heading", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(225, 9);
            label2.Name = "label2";
            label2.Size = new Size(176, 47);
            label2.TabIndex = 11;
            label2.Text = "Front Desk";
            // 
            // FrontDeskDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(640, 434);
            Controls.Add(label2);
            Controls.Add(btnBP);
            Controls.Add(btnCreateRes);
            Controls.Add(btnSearchAvail);
            Controls.Add(lblQuickActs);
            Controls.Add(btnOut);
            Controls.Add(btnCheck);
            Controls.Add(label1);
            Controls.Add(btnActiveR);
            Controls.Add(btnAvailR);
            Controls.Add(btnCO);
            Controls.Add(btnCI);
            Name = "FrontDeskDashboardForm";
            Text = "FrontDeskDashboardForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCI;
        private Button btnCO;
        private Button btnAvailR;
        private Button btnActiveR;
        private Label label1;
        private Button btnCheck;
        private Button btnOut;
        private Label lblQuickActs;
        private Button btnSearchAvail;
        private Button btnCreateRes;
        private Button btnBP;
        private Label label2;
    }
}