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
            label5 = new Label();
            label6 = new Label();
            btnLogin = new Button();
            cmbRole = new ComboBox();
            btnShow = new Button();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(67, 25);
            label1.Name = "label1";
            label1.Size = new Size(196, 58);
            label1.TabIndex = 0;
            label1.Text = "Welcome!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 104);
            label2.Name = "label2";
            label2.Size = new Size(160, 39);
            label2.TabIndex = 1;
            label2.Text = "User's Role:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 208);
            label3.Name = "label3";
            label3.Size = new Size(148, 39);
            label3.TabIndex = 3;
            label3.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(14, 316);
            label4.Name = "label4";
            label4.Size = new Size(140, 39);
            label4.TabIndex = 5;
            label4.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.Khaki;
            txtUsername.Location = new Point(14, 252);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(286, 40);
            txtUsername.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(81, 405);
            label5.Name = "label5";
            label5.Size = new Size(172, 29);
            label5.TabIndex = 8;
            label5.Text = "Forgot Password?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Heading", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(59, 436);
            label6.Name = "label6";
            label6.Size = new Size(229, 24);
            label6.TabIndex = 9;
            label6.Text = "Empty fields are not allowed.";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Khaki;
            btnLogin.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(14, 483);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(287, 60);
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
            cmbRole.Items.AddRange(new object[] { "Admin", "Front Desk" });
            cmbRole.Location = new Point(14, 163);
            cmbRole.Margin = new Padding(3, 4, 3, 4);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(286, 36);
            cmbRole.TabIndex = 11;
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.Khaki;
            btnShow.Font = new Font("Sitka Heading", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShow.Location = new Point(306, 364);
            btnShow.Margin = new Padding(3, 4, 3, 4);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(42, 36);
            btnShow.TabIndex = 12;
            btnShow.Text = "()";
            btnShow.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Khaki;
            txtPassword.Location = new Point(15, 359);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(286, 40);
            txtPassword.TabIndex = 13;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 588);
            Controls.Add(txtPassword);
            Controls.Add(btnShow);
            Controls.Add(cmbRole);
            Controls.Add(btnLogin);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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
        private Label label5;
        private Label label6;
        private Button btnLogin;
        private ComboBox cmbRole;
        private Button btnShow;
        private TextBox txtPassword;
    }
}