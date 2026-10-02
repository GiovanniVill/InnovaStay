namespace UI
{
    partial class GuestManagementForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtGuestID = new TextBox();
            label3 = new Label();
            txtFullName = new TextBox();
            txtContact = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            txtAddress = new TextBox();
            btnSearchGuest = new Button();
            btnAddGuest = new Button();
            btnEditGuest = new Button();
            btnViewGuest = new Button();
            dgvGuest = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvGuest).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(181, 9);
            label1.Name = "label1";
            label1.Size = new Size(291, 47);
            label1.TabIndex = 0;
            label1.Text = "Guest Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 56);
            label2.Name = "label2";
            label2.Size = new Size(99, 30);
            label2.TabIndex = 1;
            label2.Text = "Guest ID:";
            // 
            // txtGuestID
            // 
            txtGuestID.Location = new Point(29, 89);
            txtGuestID.Multiline = true;
            txtGuestID.Name = "txtGuestID";
            txtGuestID.Size = new Size(289, 39);
            txtGuestID.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(324, 56);
            label3.Name = "label3";
            label3.Size = new Size(115, 30);
            label3.TabIndex = 3;
            label3.Text = "Full Name:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(324, 89);
            txtFullName.Multiline = true;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(289, 39);
            txtFullName.TabIndex = 4;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(29, 164);
            txtContact.Multiline = true;
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(289, 39);
            txtContact.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 131);
            label4.Name = "label4";
            label4.Size = new Size(91, 30);
            label4.TabIndex = 6;
            label4.Text = "Contact:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(324, 131);
            label5.Name = "label5";
            label5.Size = new Size(74, 30);
            label5.TabIndex = 7;
            label5.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(324, 164);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(289, 39);
            txtEmail.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(29, 206);
            label6.Name = "label6";
            label6.Size = new Size(94, 30);
            label6.TabIndex = 9;
            label6.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(31, 239);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(289, 39);
            txtAddress.TabIndex = 12;
            // 
            // btnSearchGuest
            // 
            btnSearchGuest.BackColor = Color.Khaki;
            btnSearchGuest.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchGuest.ForeColor = Color.Black;
            btnSearchGuest.Location = new Point(326, 226);
            btnSearchGuest.Name = "btnSearchGuest";
            btnSearchGuest.Size = new Size(146, 39);
            btnSearchGuest.TabIndex = 13;
            btnSearchGuest.Text = "Search Guest";
            btnSearchGuest.UseVisualStyleBackColor = false;
            btnSearchGuest.Click += btnSearchGuest_Click;
            // 
            // btnAddGuest
            // 
            btnAddGuest.BackColor = Color.Khaki;
            btnAddGuest.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddGuest.Location = new Point(476, 226);
            btnAddGuest.Name = "btnAddGuest";
            btnAddGuest.Size = new Size(137, 39);
            btnAddGuest.TabIndex = 14;
            btnAddGuest.Text = "Add Guest";
            btnAddGuest.UseVisualStyleBackColor = false;
            btnAddGuest.Click += btnAddGuest_Click;
            // 
            // btnEditGuest
            // 
            btnEditGuest.BackColor = Color.Khaki;
            btnEditGuest.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditGuest.Location = new Point(324, 271);
            btnEditGuest.Name = "btnEditGuest";
            btnEditGuest.Size = new Size(146, 38);
            btnEditGuest.TabIndex = 15;
            btnEditGuest.Text = "Edit Guest";
            btnEditGuest.UseVisualStyleBackColor = false;
            btnEditGuest.Click += btnEditGuest_Click;
            // 
            // btnViewGuest
            // 
            btnViewGuest.BackColor = Color.Khaki;
            btnViewGuest.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewGuest.Location = new Point(476, 271);
            btnViewGuest.Name = "btnViewGuest";
            btnViewGuest.Size = new Size(137, 38);
            btnViewGuest.TabIndex = 16;
            btnViewGuest.Text = "View Guest";
            btnViewGuest.UseVisualStyleBackColor = false;
            btnViewGuest.Click += btnViewGuest_Click;
            // 
            // dgvGuest
            // 
            dgvGuest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGuest.BackgroundColor = Color.White;
            dgvGuest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGuest.Location = new Point(619, 86);
            dgvGuest.MultiSelect = false;
            dgvGuest.Name = "dgvGuest";
            dgvGuest.ReadOnly = true;
            dgvGuest.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGuest.Size = new Size(467, 223);
            dgvGuest.TabIndex = 17;
            // 
            // GuestManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1098, 342);
            Controls.Add(dgvGuest);
            Controls.Add(btnViewGuest);
            Controls.Add(btnEditGuest);
            Controls.Add(btnAddGuest);
            Controls.Add(btnSearchGuest);
            Controls.Add(txtAddress);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtContact);
            Controls.Add(txtFullName);
            Controls.Add(label3);
            Controls.Add(txtGuestID);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "GuestManagementForm";
            Text = "GuestManagementForm";
            Load += GuestManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGuest).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtGuestID;
        private Label label3;
        private TextBox txtFullName;
        private TextBox txtContact;
        private Label label4;
        private Label label5;
        private TextBox txtEmail;
        private Label label6;
        private TextBox txtAddress;
        private Button btnSearchGuest;
        private Button btnAddGuest;
        private Button btnEditGuest;
        private Button btnViewGuest;
        private DataGridView dgvGuest;
    }
}
