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
            label1.ForeColor = Color.Olive;
            label1.Location = new Point(30, 9);
            label1.Name = "label1";
            label1.Size = new Size(363, 58);
            label1.TabIndex = 0;
            label1.Text = "Guest Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 94);
            label2.Name = "label2";
            label2.Size = new Size(128, 39);
            label2.TabIndex = 1;
            label2.Text = "Guest ID:";
            // 
            // txtGuestID
            // 
            txtGuestID.Location = new Point(34, 137);
            txtGuestID.Margin = new Padding(3, 4, 3, 4);
            txtGuestID.Multiline = true;
            txtGuestID.Name = "txtGuestID";
            txtGuestID.Size = new Size(370, 51);
            txtGuestID.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 400);
            label3.Name = "label3";
            label3.Size = new Size(147, 39);
            label3.TabIndex = 3;
            label3.Text = "Full Name:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(34, 443);
            txtFullName.Margin = new Padding(3, 4, 3, 4);
            txtFullName.Multiline = true;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(370, 51);
            txtFullName.TabIndex = 4;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(34, 247);
            txtContact.Margin = new Padding(3, 4, 3, 4);
            txtContact.Multiline = true;
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(370, 51);
            txtContact.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(34, 204);
            label4.Name = "label4";
            label4.Size = new Size(118, 39);
            label4.TabIndex = 6;
            label4.Text = "Contact:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(34, 509);
            label5.Name = "label5";
            label5.Size = new Size(95, 39);
            label5.TabIndex = 7;
            label5.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(34, 552);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(370, 51);
            txtEmail.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(34, 302);
            label6.Name = "label6";
            label6.Size = new Size(122, 39);
            label6.TabIndex = 9;
            label6.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(34, 345);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(370, 51);
            txtAddress.TabIndex = 12;
            // 
            // btnSearchGuest
            // 
            btnSearchGuest.BackColor = Color.DarkKhaki;
            btnSearchGuest.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchGuest.ForeColor = Color.Beige;
            btnSearchGuest.Location = new Point(34, 732);
            btnSearchGuest.Margin = new Padding(3, 4, 3, 4);
            btnSearchGuest.Name = "btnSearchGuest";
            btnSearchGuest.Size = new Size(184, 52);
            btnSearchGuest.TabIndex = 13;
            btnSearchGuest.Text = "Search Guest";
            btnSearchGuest.UseVisualStyleBackColor = false;
            btnSearchGuest.Click += btnSearchGuest_Click;
            // 
            // btnAddGuest
            // 
            btnAddGuest.BackColor = Color.DarkKhaki;
            btnAddGuest.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddGuest.ForeColor = Color.Beige;
            btnAddGuest.Location = new Point(34, 674);
            btnAddGuest.Margin = new Padding(3, 4, 3, 4);
            btnAddGuest.Name = "btnAddGuest";
            btnAddGuest.Size = new Size(184, 52);
            btnAddGuest.TabIndex = 14;
            btnAddGuest.Text = "Add Guest";
            btnAddGuest.UseVisualStyleBackColor = false;
            btnAddGuest.Click += btnAddGuest_Click;
            // 
            // btnEditGuest
            // 
            btnEditGuest.BackColor = Color.DarkKhaki;
            btnEditGuest.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditGuest.ForeColor = Color.Beige;
            btnEditGuest.Location = new Point(220, 674);
            btnEditGuest.Margin = new Padding(3, 4, 3, 4);
            btnEditGuest.Name = "btnEditGuest";
            btnEditGuest.Size = new Size(184, 51);
            btnEditGuest.TabIndex = 15;
            btnEditGuest.Text = "Edit Guest";
            btnEditGuest.UseVisualStyleBackColor = false;
            btnEditGuest.Click += btnEditGuest_Click;
            // 
            // btnViewGuest
            // 
            btnViewGuest.BackColor = Color.DarkKhaki;
            btnViewGuest.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewGuest.ForeColor = Color.Beige;
            btnViewGuest.Location = new Point(220, 732);
            btnViewGuest.Margin = new Padding(3, 4, 3, 4);
            btnViewGuest.Name = "btnViewGuest";
            btnViewGuest.Size = new Size(184, 51);
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
            dgvGuest.Location = new Point(491, 136);
            dgvGuest.Margin = new Padding(3, 4, 3, 4);
            dgvGuest.MultiSelect = false;
            dgvGuest.Name = "dgvGuest";
            dgvGuest.ReadOnly = true;
            dgvGuest.RowHeadersWidth = 51;
            dgvGuest.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGuest.Size = new Size(862, 647);
            dgvGuest.TabIndex = 17;
            // 
            // GuestManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(1760, 870);
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
