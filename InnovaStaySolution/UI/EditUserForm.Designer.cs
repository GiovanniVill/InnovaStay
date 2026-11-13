namespace UI
{
    partial class EditUserForm
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
            pnlHeader = new System.Windows.Forms.Panel();
            lblHeaderTitle = new System.Windows.Forms.Label();
            lblUserId = new System.Windows.Forms.Label();
            txtUserId = new System.Windows.Forms.TextBox();
            lblUsername = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            lblPassword = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            lblRole = new System.Windows.Forms.Label();
            cmbRole = new System.Windows.Forms.ComboBox();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = System.Drawing.Color.FromArgb(20, 26, 40);
            pnlHeader.Controls.Add(lblHeaderTitle);
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Location = new System.Drawing.Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new System.Drawing.Size(380, 50);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            lblHeaderTitle.Location = new System.Drawing.Point(20, 14);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new System.Drawing.Size(156, 21);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "Edit User Account";
            // 
            // lblUserId
            // 
            lblUserId.AutoSize = true;
            lblUserId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblUserId.ForeColor = System.Drawing.Color.FromArgb(20, 26, 40);
            lblUserId.Location = new System.Drawing.Point(24, 68);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new System.Drawing.Size(52, 15);
            lblUserId.TabIndex = 1;
            lblUserId.Text = "User ID:";
            // 
            // txtUserId
            // 
            txtUserId.BackColor = System.Drawing.Color.FromArgb(245, 245, 240);
            txtUserId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtUserId.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtUserId.Location = new System.Drawing.Point(24, 88);
            txtUserId.Name = "txtUserId";
            txtUserId.ReadOnly = true;
            txtUserId.Size = new System.Drawing.Size(330, 25);
            txtUserId.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblUsername.ForeColor = System.Drawing.Color.FromArgb(20, 26, 40);
            lblUsername.Location = new System.Drawing.Point(24, 126);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(68, 15);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtUsername.Location = new System.Drawing.Point(24, 146);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(330, 25);
            txtUsername.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblPassword.ForeColor = System.Drawing.Color.FromArgb(20, 26, 40);
            lblPassword.Location = new System.Drawing.Point(24, 184);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(175, 15);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "New Password (Optional):";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtPassword.Location = new System.Drawing.Point(24, 204);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Leave blank to keep current password";
            txtPassword.Size = new System.Drawing.Size(330, 25);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblRole.ForeColor = System.Drawing.Color.FromArgb(20, 26, 40);
            lblRole.Location = new System.Drawing.Point(24, 242);
            lblRole.Name = "lblRole";
            lblRole.Size = new System.Drawing.Size(35, 15);
            lblRole.TabIndex = 7;
            lblRole.Text = "Role:";
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmbRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Admin", "Front Desk" });
            cmbRole.Location = new System.Drawing.Point(24, 262);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new System.Drawing.Size(330, 25);
            cmbRole.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.FromArgb(184, 172, 102);
            btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(24, 314);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(158, 38);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.FromArgb(160, 165, 170);
            btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnCancel.ForeColor = System.Drawing.Color.White;
            btnCancel.Location = new System.Drawing.Point(196, 314);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(158, 38);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // EditUserForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(238, 236, 203);
            ClientSize = new System.Drawing.Size(380, 374);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cmbRole);
            Controls.Add(lblRole);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(txtUserId);
            Controls.Add(lblUserId);
            Controls.Add(pnlHeader);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditUserForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Edit User Account";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}