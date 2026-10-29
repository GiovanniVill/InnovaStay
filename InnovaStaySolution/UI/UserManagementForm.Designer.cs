namespace UI
{
    partial class UserManagementForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtUserId = new MaskedTextBox();
            txtUsername = new MaskedTextBox();
            txtPassword = new MaskedTextBox();
            txtFullName = new MaskedTextBox();
            cmbRole = new ComboBox();
            cmbStatus = new ComboBox();
            btnAddUser = new Button();
            btnUpdateUser = new Button();
            btnDeleteUser = new Button();
            btnClearUser = new Button();
            dgvUsers = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(168, 65);
            txtUserId.Name = "txtUserId";
            txtUserId.ReadOnly = true;
            txtUserId.Size = new Size(125, 27);
            txtUserId.TabIndex = 0;
            txtUserId.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(168, 136);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(125, 27);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(168, 204);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 2;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(168, 274);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(125, 27);
            txtFullName.TabIndex = 3;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Admin", "Front Desk" });
            cmbRole.Location = new Point(168, 349);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(125, 28);
            cmbRole.TabIndex = 4;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Active", "Inactive" });
            cmbStatus.Location = new Point(168, 419);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(125, 28);
            cmbStatus.TabIndex = 5;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(87, 535);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(127, 47);
            btnAddUser.TabIndex = 6;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.Location = new Point(231, 535);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(125, 47);
            btnUpdateUser.TabIndex = 7;
            btnUpdateUser.Text = "Update";
            btnUpdateUser.UseVisualStyleBackColor = true;
            btnUpdateUser.Click += btnUpdateUser_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(88, 599);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(126, 43);
            btnDeleteUser.TabIndex = 8;
            btnDeleteUser.Text = "Delete";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnClearUser
            // 
            btnClearUser.Location = new Point(231, 599);
            btnClearUser.Name = "btnClearUser";
            btnClearUser.Size = new Size(125, 43);
            btnClearUser.TabIndex = 9;
            btnClearUser.Text = "Clear";
            btnClearUser.UseVisualStyleBackColor = true;
            btnClearUser.Click += btnClearUser_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(417, 49);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(929, 772);
            dgvUsers.TabIndex = 10;
            dgvUsers.CellClick += dgvUsers_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 65);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 11;
            label2.Text = "User ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 143);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 12;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 211);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 13;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 277);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 14;
            label5.Text = "Full Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(97, 357);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 15;
            label6.Text = "Role";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(87, 427);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 16;
            label7.Text = "Status";
            // 
            // UserManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(1924, 1055);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvUsers);
            Controls.Add(btnClearUser);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnUpdateUser);
            Controls.Add(btnAddUser);
            Controls.Add(cmbStatus);
            Controls.Add(cmbRole);
            Controls.Add(txtFullName);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtUserId);
            Name = "UserManagementForm";
            Text = "UserManagementForm";
            Load += UserManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox txtUserId;
        private MaskedTextBox txtUsername;
        private MaskedTextBox txtPassword;
        private MaskedTextBox txtFullName;
        private ComboBox cmbRole;
        private ComboBox cmbStatus;
        private Button btnAddUser;
        private Button btnUpdateUser;
        private Button btnDeleteUser;
        private Button btnClearUser;
        private DataGridView dgvUsers;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}