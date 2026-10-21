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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            label3 = new Label();
            txtLname = new TextBox();
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
            txtMname = new TextBox();
            txtFname = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            panel1 = new Panel();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvGuest).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(15, 23, 42);
            label1.Location = new Point(30, 20);
            label1.Name = "label1";
            label1.Size = new Size(205, 30);
            label1.TabIndex = 0;
            label1.Text = "Guest Management";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(51, 65, 85);
            label3.Location = new Point(14, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 3;
            label3.Text = "Full Name:";
            // 
            // txtLname
            // 
            txtLname.BackColor = Color.White;
            txtLname.BorderStyle = BorderStyle.FixedSingle;
            txtLname.ForeColor = Color.FromArgb(15, 23, 42);
            txtLname.Location = new Point(14, 48);
            txtLname.Multiline = true;
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(123, 39);
            txtLname.TabIndex = 4;
            // 
            // txtContact
            // 
            txtContact.BackColor = Color.White;
            txtContact.BorderStyle = BorderStyle.FixedSingle;
            txtContact.ForeColor = Color.FromArgb(15, 23, 42);
            txtContact.Location = new Point(13, 298);
            txtContact.Multiline = true;
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(381, 39);
            txtContact.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(51, 65, 85);
            label4.Location = new Point(14, 280);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 6;
            label4.Text = "Contact:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(51, 65, 85);
            label5.Location = new Point(13, 198);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 7;
            label5.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.ForeColor = Color.FromArgb(15, 23, 42);
            txtEmail.Location = new Point(13, 216);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(381, 39);
            txtEmail.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(51, 65, 85);
            label6.Location = new Point(13, 99);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 9;
            label6.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.White;
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.ForeColor = Color.FromArgb(15, 23, 42);
            txtAddress.Location = new Point(13, 136);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(123, 39);
            txtAddress.TabIndex = 12;
            // 
            // btnSearchGuest
            // 
            btnSearchGuest.BackColor = Color.FromArgb(30, 41, 59);
            btnSearchGuest.FlatStyle = FlatStyle.Flat;
            btnSearchGuest.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchGuest.ForeColor = Color.White;
            btnSearchGuest.Location = new Point(252, 377);
            btnSearchGuest.Name = "btnSearchGuest";
            btnSearchGuest.Size = new Size(146, 38);
            btnSearchGuest.TabIndex = 13;
            btnSearchGuest.Text = "Search Guest";
            btnSearchGuest.UseVisualStyleBackColor = false;
            btnSearchGuest.Click += btnSearchGuest_Click;
            // 
            // btnAddGuest
            // 
            btnAddGuest.BackColor = Color.FromArgb(30, 41, 59);
            btnAddGuest.Cursor = Cursors.Hand;
            btnAddGuest.FlatStyle = FlatStyle.Flat;
            btnAddGuest.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddGuest.ForeColor = Color.White;
            btnAddGuest.Location = new Point(14, 470);
            btnAddGuest.Name = "btnAddGuest";
            btnAddGuest.Size = new Size(146, 38);
            btnAddGuest.TabIndex = 14;
            btnAddGuest.Text = "Add Guest";
            btnAddGuest.UseVisualStyleBackColor = false;
            btnAddGuest.Click += btnAddGuest_Click;
            // 
            // btnEditGuest
            // 
            btnEditGuest.BackColor = Color.FromArgb(30, 41, 59);
            btnEditGuest.Cursor = Cursors.Hand;
            btnEditGuest.FlatStyle = FlatStyle.Flat;
            btnEditGuest.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditGuest.ForeColor = Color.White;
            btnEditGuest.Location = new Point(14, 536);
            btnEditGuest.Name = "btnEditGuest";
            btnEditGuest.Size = new Size(146, 38);
            btnEditGuest.TabIndex = 15;
            btnEditGuest.Text = "Edit Guest";
            btnEditGuest.UseVisualStyleBackColor = false;
            btnEditGuest.Click += btnEditGuest_Click;
            // 
            // btnViewGuest
            // 
            btnViewGuest.BackColor = Color.FromArgb(30, 41, 59);
            btnViewGuest.Cursor = Cursors.Hand;
            btnViewGuest.FlatStyle = FlatStyle.Flat;
            btnViewGuest.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewGuest.ForeColor = Color.White;
            btnViewGuest.Location = new Point(252, 470);
            btnViewGuest.Name = "btnViewGuest";
            btnViewGuest.Size = new Size(147, 38);
            btnViewGuest.TabIndex = 16;
            btnViewGuest.Text = "View Guest";
            btnViewGuest.UseVisualStyleBackColor = false;
            btnViewGuest.Click += btnViewGuest_Click;
            // 
            // dgvGuest
            // 
            dgvGuest.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dgvGuest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGuest.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvGuest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvGuest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 231, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvGuest.DefaultCellStyle = dataGridViewCellStyle2;
            dgvGuest.EnableHeadersVisualStyles = false;
            dgvGuest.Location = new Point(471, 20);
            dgvGuest.MultiSelect = false;
            dgvGuest.Name = "dgvGuest";
            dgvGuest.ReadOnly = true;
            dgvGuest.RowHeadersVisible = false;
            dgvGuest.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGuest.Size = new Size(1006, 655);
            dgvGuest.TabIndex = 17;
            // 
            // txtMname
            // 
            txtMname.BackColor = Color.White;
            txtMname.BorderStyle = BorderStyle.FixedSingle;
            txtMname.ForeColor = Color.FromArgb(15, 23, 42);
            txtMname.Location = new Point(142, 48);
            txtMname.Multiline = true;
            txtMname.Name = "txtMname";
            txtMname.Size = new Size(123, 39);
            txtMname.TabIndex = 18;
            // 
            // txtFname
            // 
            txtFname.BackColor = Color.White;
            txtFname.BorderStyle = BorderStyle.FixedSingle;
            txtFname.ForeColor = Color.FromArgb(15, 23, 42);
            txtFname.Location = new Point(271, 48);
            txtFname.Multiline = true;
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(123, 39);
            txtFname.TabIndex = 19;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.FromArgb(15, 23, 42);
            textBox1.Location = new Point(142, 136);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(123, 39);
            textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.ForeColor = Color.FromArgb(15, 23, 42);
            textBox2.Location = new Point(271, 136);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(123, 39);
            textBox2.TabIndex = 21;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(14, 377);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(229, 23);
            textBox3.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(btnSearchGuest);
            panel1.Controls.Add(txtLname);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(btnViewGuest);
            panel1.Controls.Add(txtMname);
            panel1.Controls.Add(btnAddGuest);
            panel1.Controls.Add(btnEditGuest);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(txtFname);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtContact);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(label5);
            panel1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            panel1.ForeColor = Color.FromArgb(15, 23, 42);
            panel1.Location = new Point(20, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 655);
            panel1.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(51, 65, 85);
            label11.Location = new Point(298, 118);
            label11.Name = "label11";
            label11.Size = new Size(53, 15);
            label11.TabIndex = 27;
            label11.Text = "Province";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(51, 65, 85);
            label10.Location = new Point(172, 118);
            label10.Name = "label10";
            label10.Size = new Size(73, 15);
            label10.TabIndex = 26;
            label10.Text = "Municipality";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(51, 65, 85);
            label9.Location = new Point(37, 118);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 25;
            label9.Text = "Barangay";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(51, 65, 85);
            label8.Location = new Point(298, 29);
            label8.Name = "label8";
            label8.Size = new Size(77, 15);
            label8.TabIndex = 24;
            label8.Text = "Middle name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(51, 65, 85);
            label7.Location = new Point(172, 29);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 23;
            label7.Text = "First name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(51, 65, 85);
            label2.Location = new Point(37, 30);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 22;
            label2.Text = "Last name";
            // 
            // GuestManagementForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1489, 694);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(dgvGuest);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "GuestManagementForm";
            Text = "GuestManagementForm";
            Load += GuestManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGuest).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox txtLname;
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
        private TextBox txtMname;
        private TextBox txtFname;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Panel panel1;
        private Label label7;
        private Label label2;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
    }
}
