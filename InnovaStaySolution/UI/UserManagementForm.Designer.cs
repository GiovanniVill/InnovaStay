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
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(78, 36);
            txtUserId.Margin = new Padding(3, 2, 3, 2);
            txtUserId.Name = "txtUserId";
            txtUserId.ReadOnly = true;
            txtUserId.Size = new Size(201, 23);
            txtUserId.TabIndex = 0;
            txtUserId.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(78, 79);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(201, 23);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(78, 118);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(201, 23);
            txtPassword.TabIndex = 2;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(78, 160);
            txtFullName.Margin = new Padding(3, 2, 3, 2);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(201, 23);
            txtFullName.TabIndex = 3;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Admin", "Front Desk" });
            cmbRole.Location = new Point(78, 195);
            cmbRole.Margin = new Padding(3, 2, 3, 2);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(201, 23);
            cmbRole.TabIndex = 4;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Active", "Inactive" });
            cmbStatus.Location = new Point(78, 232);
            cmbStatus.Margin = new Padding(3, 2, 3, 2);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(201, 23);
            cmbStatus.TabIndex = 5;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(168, 268);
            btnAddUser.Margin = new Padding(3, 2, 3, 2);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(111, 35);
            btnAddUser.TabIndex = 6;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.Location = new Point(170, 324);
            btnUpdateUser.Margin = new Padding(3, 2, 3, 2);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(109, 35);
            btnUpdateUser.TabIndex = 7;
            btnUpdateUser.Text = "Update";
            btnUpdateUser.UseVisualStyleBackColor = true;
            btnUpdateUser.Click += btnUpdateUser_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(168, 379);
            btnDeleteUser.Margin = new Padding(3, 2, 3, 2);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(110, 32);
            btnDeleteUser.TabIndex = 8;
            btnDeleteUser.Text = "Delete";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnClearUser
            // 
            btnClearUser.Location = new Point(168, 433);
            btnClearUser.Margin = new Padding(3, 2, 3, 2);
            btnClearUser.Name = "btnClearUser";
            btnClearUser.Size = new Size(109, 32);
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
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.Location = new Point(0, 0);
            dgvUsers.Margin = new Padding(0);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(1277, 666);
            dgvUsers.TabIndex = 10;
            dgvUsers.CellClick += dgvUsers_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 44);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 11;
            label2.Text = "User ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 82);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 12;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 118);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 13;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 160);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 14;
            label5.Text = "Full Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 198);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 15;
            label6.Text = "Role";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 235);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 16;
            label7.Text = "Status";
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnClearUser);
            panel1.Controls.Add(txtUserId);
            panel1.Controls.Add(btnDeleteUser);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnUpdateUser);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnAddUser);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cmbStatus);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(cmbRole);
            panel1.Controls.Add(txtFullName);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(16, 20, 16, 20);
            panel1.Size = new Size(300, 666);
            panel1.TabIndex = 17;
            // 
            // UserManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(1277, 666);
            Controls.Add(panel1);
            Controls.Add(dgvUsers);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserManagementForm";
            Text = "UserManagementForm";
            Load += UserManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private Panel panel1;
    }
}