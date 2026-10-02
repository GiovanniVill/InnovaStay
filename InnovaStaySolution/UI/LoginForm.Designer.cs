namespace UI
{
    partial class LoginForm
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnLogin = new Button();
            cmbRole = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 19);
            label1.Name = "label1";
            label1.Size = new Size(157, 47);
            label1.TabIndex = 0;
            label1.Text = "Welcome!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(123, 30);
            label2.TabIndex = 1;
            label2.Text = "User's Role:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 156);
            label3.Name = "label3";
            label3.Size = new Size(113, 30);
            label3.TabIndex = 3;
            label3.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 237);
            label4.Name = "label4";
            label4.Size = new Size(109, 30);
            label4.TabIndex = 5;
            label4.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.Khaki;
            txtUsername.Location = new Point(12, 189);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(251, 31);
            txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Khaki;
            txtPassword.Location = new Point(12, 270);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(251, 31);
            txtPassword.TabIndex = 7;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(71, 304);
            label5.Name = "label5";
            label5.Size = new Size(135, 23);
            label5.TabIndex = 8;
            label5.Text = "Forgot Password?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Heading", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(52, 327);
            label6.Name = "label6";
            label6.Size = new Size(179, 19);
            label6.TabIndex = 9;
            label6.Text = "Empty fields are not allowed.";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Khaki;
            btnLogin.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(12, 362);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(251, 45);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // cmbRole
            // 
            cmbRole.BackColor = Color.Khaki;
            cmbRole.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Admin", "Frontdesk" });
            cmbRole.Location = new Point(12, 122);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(251, 29);
            cmbRole.TabIndex = 11;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 441);
            Controls.Add(cmbRole);
            Controls.Add(btnLogin);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label5;
        private Label label6;
        private Button btnLogin;
        private ComboBox cmbRole;
    }
}